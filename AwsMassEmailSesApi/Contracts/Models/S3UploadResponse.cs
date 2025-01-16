namespace AwsMassEmailSesApi.Contracts.Models
{
    public class S3UploadResponse
    {
        bool Success { get; set; }

        IEnumerable<string> ErrorMessages { get; set; }
    }
}
