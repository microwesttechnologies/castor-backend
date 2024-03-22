using Microsoft.AspNetCore.Http;

namespace Domain.Model.Entities
{
    public class UploadImage
    {
        public IFormFile fileImage {  get; set; }
    }
}
