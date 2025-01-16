using Amazon.S3.Model;
using AwsMassEmailSesApi.Contracts.Models;

namespace AwsMassEmailSesApi.Contracts.Services
{
    public interface IS3BucketService
    {
        Task<PutObjectResponse> PutObject(IFormFile file);
    }
}
