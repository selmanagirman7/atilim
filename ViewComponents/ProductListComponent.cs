using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Atilim.ViewComponents
{
    public class ProductListComponent:ViewComponent
    {
        IProductService _productservice;
        public ProductListComponent(IProductService productService)
        {
            _productservice = productService;
        }
        

        ProductManager productManager = new ProductManager(new EfProductDal());
        public IViewComponentResult Invoke()
        {
            var result = _productservice.GetAll().OrderBy(x =>Guid.NewGuid()).Take(10);
            return View(result);

        }
    }
}
