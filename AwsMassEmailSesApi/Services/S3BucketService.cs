using Amazon.S3;
using Amazon.S3.Model;
using AwsMassEmailSesApi.Contracts.Models;
using AwsMassEmailSesApi.Contracts.Services;
using System.Runtime.CompilerServices;

namespace AwsMassEmailSesApi.Services
{
    public class S3BucketService : IS3BucketService
    {
        private static IAmazonS3 client;
        public S3BucketService() {
            client = new AmazonS3Client(Amazon.RegionEndpoint.USEast2);
        }
        public async Task<PutObjectResponse> PutObject(IFormFile file)
        {
            try
            {
                PutObjectRequest request = new PutObjectRequest()
                {
                    BucketName = string.Empty,
                    Key = default,
                    ContentBody = string.Empty,
                    ContentType = "application/json",
                };
                request.Metadata.Add("x-amz-meta-title", "email csv");
                var response = await client.PutObjectAsync(request);      
                return response;
            }
            catch (AmazonS3Exception e)
            {
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
