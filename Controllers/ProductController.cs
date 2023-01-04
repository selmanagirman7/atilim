using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using Atilim.Models;

namespace Atilim.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());



        public IActionResult Index()
        {
            var result = productManager.GetAll();
            return View(result);
        }
        public IActionResult EnIndex()
        {
            var result = productManager.GetAll();
            return View(result);
        }
        public IActionResult ProductDetail(int id)
        {
            var result = productManager.GetProductById(id);
            return View(result);
        }
        public IActionResult EnProductDetail(int id)
        {
            var result = productManager.GetProductById(id);
            return View(result);
        }
        public IActionResult GetCategories(int id)
        {
            var result = productManager.GetByCategory(id);

            return View(result);
        }
        public IActionResult EnGetCatagories(int id)
        {
            var result = productManager.GetByCategory(id);
            return View(result);
        }
        [HttpGet]
        public IActionResult ProductAdd()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult ProductAdd(ProductAdd productadd)
        //{
        //    ProductController p = new ProductController();
        //    if (productadd.ImgPath != null)
        //    {
        //        var extension = Path.GetExtension(productadd.ImgPath.FileName);
        //        var newguid = Guid.NewGuid() + extension;
        //        var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/assets/img/" + newguid);
        //        var stream = new FileStream(location, FileMode.Create);
        //        productadd.ImgPath.CopyTo(stream);
        //        p.ImgPath = newguid;



        //   }

        //    p.ProductName = productadd.ProductName;
        //    p.ProductNameEng = productadd.ProductNameEng;
        //    p.Metarial = productadd.Metarial;
        //    p.MetarialEng = productadd.MetarialEng;
        //    p.BoxSizeEng = productadd.BoxSizeEng;
        //    p.BoxSize = productadd.BoxSize;
        //    p.DimensionsEng = productadd.Dimensions;
        //    p.ProductDescription = productadd.ProductDescription;
        //    p.ProductDescriptionEng = productadd.ProductDescriptionEng;
        //    p.SeatAngle = productadd.SeatAngle;
        //    p.SeatAngleEng = productadd.SeatAngleEng;

        //    productManager.Add(p);
        //    return RedirectToAction("Index", "Product");

        }
    }
