using Microsoft.AspNetCore.Http;

namespace Atilim.Models
{
    public class ReferanceAdd
    {
        public string ReferanceName { get; set; }
        public string ReferanceNameEng { get; set; }
        public IFormFile ImagePath { get; set; }
    }
}
