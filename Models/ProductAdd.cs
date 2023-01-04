using Microsoft.AspNetCore.Http;

namespace Atilim.Models
{
    public class ProductAdd
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductNameEng { get; set; }
        public string ProductDescription { get; set; }
        public string ProductDescriptionEng { get; set; }
        public IFormFile ImgPath { get; set; }
        public string Metarial { get; set; }
        public string MetarialEng { get; set; }
        public string SeatAngle { get; set; }
        public string SeatAngleEng { get; set; }
        public string TotalWeight { get; set; }
        public string TotalWeightEng { get; set; }
        public string Dimensions { get; set; }
        public string DimensionsEng { get; set; }
        public string BoxSize { get; set; }
        public string BoxSizeEng { get; set; }
       
        public int CategoryId { get; set; }
        
        public IFormFile ImgPath1 { get; set; }
        public IFormFile ImgPath2 { get; set; }
        public IFormFile ImgPath3 { get; set; }
        public IFormFile ImgPath4 { get; set; }
        public IFormFile ImgPath5 { get; set; }
        public IFormFile ImgPath6 { get; set; }
        public IFormFile ImgPath7 { get; set; }
        public string ImgPath8 { get; set; }
        public string ImgPath9 { get; set; }
        public string ImgPath10 { get; set; }
        public string BoxSize1 { get; set; }
        public string BoxSize2 { get; set; }
        public string BoxSize3 { get; set; }
        public string BoxSize4 { get; set; }
        public string Height { get; set; }
        public string Height1 { get; set; }
        public string Height2 { get; set; }
        public string Height3 { get; set; }
        public string Height4 { get; set; }
        public string ThumbDesc { get; set; }
        public string ThumbDesc1 { get; set; }
        public string ThumbDesc2 { get; set; }
        public string ThumbDesc3 { get; set; }
        public string ThumbDesc4 { get; set; }
        public string ThumbDescEng { get; set;}
        public string ThumbDesc5 { get; set; }
        public string ThumbDesc6 { get; set; }
        public string ThumbDesc7 { get; set; }
        public string ThumbDesc8 { get; set; }
        public string ThumbDesc9 { get; set; }

    }
}
