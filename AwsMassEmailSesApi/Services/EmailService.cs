using Amazon.S3;
using Amazon.S3.Model;
using AwsMassEmailSesApi.Contracts.Models;
using AwsMassEmailSesApi.Contracts.Services;
using System.Text;

namespace AwsMassEmailSesApi.Services
{
    public class EmailService : IEmailService
    {
        public IFormFile GetById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<S3UploadResponse> UploadEmailCsv(IFormFile csvFile, string bucketName)
        {
            IAmazonS3 client = new AmazonS3Client();
            string csvFileName = csvFile.FileName;

            try
            {

                await client.UploadObjectFromStreamAsync(bucketName, csvFileName, csvFile.OpenReadStream(), new Dictionary<string, object>());
            }
            catch (Exception ex) 
            { 
                
            }

            return new S3UploadResponse();
        }
    }
}
