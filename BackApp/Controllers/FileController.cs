using Microsoft.AspNetCore.Mvc;
using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Middleware.Exceptions;
using Shop.BackApp.Models;
using Shop.BackApp.Services.Interfaces;

namespace Shop.BackApp.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class FileController
{
    private readonly string NameFolderFiles = "Files";

    private readonly string NameFolderPictures = "Pictures";
    private readonly string NameFolderVideo = "Videos";

    private string PicturesPath = string.Empty;
    private string VideosPath = string.Empty;

    private readonly string[] _pictureExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
    private readonly string[] _videoExtensions = new[] { ".mp4", ".avi", ".mov", ".wmv", ".flv" };

    IWebHostEnvironment _appEnvironment;
    IFileDetailsService _fileDetailseService;

    public FileController(IWebHostEnvironment appEnvironment, IFileDetailsService fileDetailseService)
    {
        _appEnvironment = appEnvironment;
        _fileDetailseService = fileDetailseService;
        CheckAndCreateFolders();
    }

    [HttpPost]
    public async Task<BaseResponseModel<FileDetails>> AddAlone(IFormFile uploadedFile)
    {
        var response = new BaseResponseModel<FileDetails>();

        #region Check Presence File

        if (uploadedFile == null)
        {
            response.SetFailResponse("File is empty.");

            return response;
        }

        #endregion

        var fileDetails = await UploadFile(uploadedFile);

        response.SetSuccessResponse(fileDetails);

        return response;

    }

    [HttpPost]
    public async Task<BaseResponseModel<List<FileDetails>>> AddMultiple(List<IFormFile> uploadedFiles)
    {
        var response = new BaseResponseModel<List<FileDetails>>();

        #region Check Presence File

        if (uploadedFiles.Count < 1)
        {
            response.SetFailResponse("File is empty.");

            return response;
        }

        #endregion

        var filesDetails = new List<FileDetails>();

        uploadedFiles.ForEach(async file =>
        {
            filesDetails.Add(await UploadFile(file));
        });

        response.SetSuccessResponse(filesDetails);

        return response;

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

    private string GetPathForFile (IFormFile uploadedFile, string id)
    {
        var extension = Path.GetExtension(uploadedFile.FileName).ToLower();

        var path = string.Empty;

        if (_pictureExtensions.Contains(extension))
        {
            path = PicturesPath;
        }
        else if(_videoExtensions.Contains(extension))
        {
            path = VideosPath;
        }
        else
        {
            throw new UnsupportedFileException("Unsupported file type.");
        }

        return Path.Combine(path, $"{id}{extension}");
    }

    private async Task<FileDetails> UploadFile(IFormFile uploadedFile)
    {
        var fileDetails = new FileDetails();

        string path = GetPathForFile(uploadedFile, fileDetails.Id.ToString());

        try
        {
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await uploadedFile.CopyToAsync(fileStream);
            }

            fileDetails.Path = path;
            fileDetails.Name = uploadedFile.FileName;
            fileDetails.Extension = Path.GetExtension(uploadedFile.FileName);

            ///await _fileDetailseService.AddAsync(fileDetails);

            return fileDetails;
        }
        catch (Exception ex)
        {
            throw new CustomException("Error upload file!");
        }
    }

    #endregion
}

