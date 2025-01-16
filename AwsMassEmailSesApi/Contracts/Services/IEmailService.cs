using AwsMassEmailSesApi.Contracts.Models;

namespace AwsMassEmailSesApi.Contracts.Services
{
    public interface IEmailService
    {
        IFormFile GetById(string id);
        Task<S3UploadResponse> UploadEmailCsv(IFormFile csvFile, string bucketName);

    }
}
