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

    IWebHostEnvironment _appEnvironment;
    private readonly IBaseRepository<FileDetails> _fileDetaisRepository;

    public FileDetailsService(IWebHostEnvironment appEnvironment, IBaseRepository<FileDetails> fileDetaisRepository)
    {
        _appEnvironment = appEnvironment;
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
        var filesPath = Path.Combine(_appEnvironment.ContentRootPath, NameFolderFiles);
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

    private string GetPathForFile(IFormFile uploadedFile, string id)
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

        return Path.Combine(path, $"{id}{extension}");
    }

    private async Task<T> UploadFile(IFormFile uploadedFile)
    {
        var fileDetails = new T();

        var fileName = string.Concat(uploadedFile.FileName.Split('.')[0], "_", DateTime.UtcNow.Ticks.ToString(), uploadedFile.FileName.Split('.')[1]);

        string path = GetPathForFile(uploadedFile, fileName);

        try
        {
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await uploadedFile.CopyToAsync(fileStream);
            }

            fileDetails.Path = path;
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
