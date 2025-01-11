using Microsoft.AspNetCore.Mvc;

namespace AwsMassEmailSesApi.Controllers
{
    public class EmailsController : Controller
    {
        public IActionResult GetById(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost("upload")]
        public async Task<IActionResult> SendMassEmail(IFormFile emailCsvFile)
        {
            // takes in CSV and uploads to S3

            // validate that file is of type csv
            // check that input contains only valid email address
            // call service to upload csv to s3

            // response will be http response with any exceptions from s3 


            throw new NotImplementedException();
        }
    }
}
