using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Middleware.Exceptions;
using Shop.BackApp.Repository.Interfaces;
using Shop.BackApp.Services.Interfaces;

namespace Shop.BackApp.Services;
public class FileDetailsService<T> : IFileDetailsService<T> where T : FileDetails, new()
{
    private readonly string NameFolderFiles = "Files";

    private readonly string NameFolderPictures = "Pictures";
    private readonly string NameFolderVideo = "Videos";

    private string PicturesPath = string.Empty;
    private string VideosPath = string.Empty;

    private readonly string[] _pictureExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
    private readonly string[] _videoExtensions = new[] { ".mp4", ".avi", ".mov", ".wmv", ".flv" };

    private readonly IConfiguration _configuration;
    private readonly IBaseRepository<FileDetails> _fileDetaisRepository;

    public FileDetailsService(IConfiguration configuration, IBaseRepository<FileDetails> fileDetaisRepository)
    {
        _configuration = configuration;
        _fileDetaisRepository = fileDetaisRepository;

        CheckAndCreateFolders();
    }

    public async Task<T?> AddAsync(IFormFile uploadedFile)
    {
        var fileDetails = await UploadFile(uploadedFile);

        return fileDetails;
    }

    #region Private Methods

    private void CheckAndCreateFolders()
    {
        var filesPath = Path.Combine( "..", "Data",  NameFolderFiles);
        CreateFolderIfNotExists(filesPath);

        var picturesPath = Path.Combine(filesPath, NameFolderPictures);
        CreateFolderIfNotExists(picturesPath);
        PicturesPath = picturesPath;

        var videoPath = Path.Combine(filesPath, NameFolderVideo);
        CreateFolderIfNotExists(videoPath);
        VideosPath = videoPath;
    }

    private void CreateFolderIfNotExists(string path)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
    }

    private string GetPathForFile(IFormFile uploadedFile, string fileName)
    {
        var extension = Path.GetExtension(uploadedFile.FileName).ToLower();

        var path = string.Empty;

        if (_pictureExtensions.Contains(extension))
        {
            path = PicturesPath;
        }
        else if (_videoExtensions.Contains(extension))
        {
            path = VideosPath;
        }
        else
        {
            throw new UnsupportedFileException("Unsupported file type.");
        }

        return Path.Combine(path, $"{fileName}{extension}");
    }

    private async Task<T> UploadFile(IFormFile uploadedFile)
    {

        var fileDetails = new T();

        var fileName = string.Concat(uploadedFile.FileName.Split('.')[0], "_", DateTime.UtcNow.Ticks.ToString());

        string path = GetPathForFile(uploadedFile, fileName);

        try
        {
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await uploadedFile.CopyToAsync(fileStream);
            }

            var domen = _configuration.GetSection("Domen").Value!;

            var fileDetaisPath = path.Replace("..\\Data", domen);

            fileDetails.Path = fileDetaisPath;
            fileDetails.Name = uploadedFile.FileName;
            fileDetails.Extension = Path.GetExtension(uploadedFile.FileName);

            return fileDetails;
        }
        catch (Exception ex)
        {
            throw new CustomException("Error upload file!");
        }
    }

    #endregion
}
