using Atilim.Models;
using Business.Concrete;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace Atilim.Controllers.Admin
{

        public class AdminController : Controller
        {
            AboutManager aboutManager = new AboutManager(new EfAboutDal());
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            ContactManager contactManager = new ContactManager(new EfContactDal());
            ProductManager productManager = new ProductManager(new EfProductDal());
            ReferanceManager referanceManager = new ReferanceManager(new EfReferanceDal());
            SliderManager sliderManager = new SliderManager(new EfSliderDal());
            public IActionResult AboutList()
            {
                var result = aboutManager.GetAll();
                return View(result);
            }

            [HttpGet]
            public IActionResult AboutAdd()
            {
                return View();
            }

            [HttpPost]
            public IActionResult AboutAdd(Entity.About about)
            {
                aboutManager.Add(about);

                return RedirectToAction("AboutList", "Admin");
            }

            [HttpGet]
            public IActionResult AboutUpdate()
            {
            return View();

            }


            [HttpPost]
            public IActionResult AboutUpdate(Entity.About about)
            {
            aboutManager.Update(about);
            return RedirectToAction("AboutList", "Admin");
            }


            public IActionResult AboutDelete(int id)
            {

                var result = aboutManager.Get(id);
                aboutManager.Delete(result);
                return RedirectToAction("AboutList", "Admin");
            }

            [HttpGet]
            public IActionResult AboutEdit(int id)
            {
                var result = aboutManager.Get(id);
                return View(result);
            }
            [HttpPost]
            public IActionResult AboutEdit(About about)
            {
                return View("AboutList", "Admin");
            }

            // Category 

            public IActionResult CategoryList()
            {
                var result = categoryManager.GetAll();
                return View(result);
            }

            [HttpGet]
            public IActionResult CategoryAdd()
            {
                return View();
            }



            [HttpPost]
            public IActionResult CategoryAdd(Category category)
            {
                categoryManager.Add(category);
                return RedirectToAction("CategoryList");

            }

            [HttpGet]
            public IActionResult CategoryUpdate()
            {
            return View();

            }


            [HttpPost]
            public IActionResult CategoryUpdate(Entity.Category category)
            {
            categoryManager.Update(category);
            return RedirectToAction("AboutList","Admin");
            }


            public IActionResult CategoryDelete(int id)
            {
                var result = categoryManager.Get(id);
                categoryManager.Delete(result);
                return View("CategoryList");
            }

            public IActionResult CategoryEdit()
            {
                return View();
            }


            //Contact 

            public IActionResult ContactList()
            {
                var result = contactManager.GetAll();
                return View(result);
            }

            [HttpGet]
            public IActionResult ContactAdd()
            {
                return View();
            }

            [HttpPost]
            public IActionResult ContactAdd(Contact contact)
            {
                //contactManager.Add(contact);
                return RedirectToAction("ContactList");
            }
            [HttpGet]
            public IActionResult ContactUpdate()
            {
             return View();

            }


            [HttpPost]
            public IActionResult ContactUpdate(Entity.Contact contact)
            {
            contactManager.Update(contact);
            return RedirectToAction("AboutList", "Admin");
            }
            public IActionResult ContactDelete(int id)
            {
                var result = contactManager.Get(id);
                contactManager.Delete(result);
                return RedirectToAction("ContactList");
            }
        public IActionResult ContactEdit(int id)
        {
            var result = contactManager.Get(id);
            return View(result);
        }


        public IActionResult ProductList()
            {
              var result = productManager.GetAll();
              return View(result);
            }

           [HttpGet]
           public IActionResult ProductAdd()
           {
            return View();
           }

           [HttpPost]
           public IActionResult ProductAdd(ProductAdd product)
           {
            Product p = new Product();
            if (product.ImgPath != null)
            {

                var extension = Path.GetExtension(product.ImgPath.FileName);
                var newguid = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/assets/img/shop/product" + newguid);
                var stream = new FileStream(location, FileMode.Create);
                product.ImgPath.CopyTo(stream);
                p.ImgPath = newguid;

            }

            p.ProductName = product.ProductName;
            p.ProductNameEng = product.ProductNameEng;
            p.Metarial = product.Metarial;
            p.Dimensions = product.Dimensions;
            p.BoxSize = product.BoxSize;
            p.MetarialEng = product.MetarialEng;
            p.BoxSizeEng = product.BoxSizeEng;
            p.DimensionsEng = product.DimensionsEng;
            p.SeatAngleEng = product.SeatAngleEng;
            p.TotalWeight = product.TotalWeight;
            p.TotalWeightEng = product.TotalWeightEng;
            p.SeatAngle = product.SeatAngle;
            p.SeatAngleEng = product.SeatAngleEng;
            p.CategoryId = product.CategoryId;




            productManager.Add(p);
            return RedirectToAction("Index", "Products");
        }
           [HttpGet]
           public IActionResult ProductUpdate()
           {
            return View();

           }


           [HttpPost]
           public IActionResult ProductUpdate(Entity.Product product)
           {
            productManager.Update(product);
            return RedirectToAction("ProductList", "Admin");
           }
           public IActionResult ProductDelete(int id)
           {
            var result = productManager.Get(id);
            productManager.Delete(result);
            return RedirectToAction("ProductList");
           }
        public IActionResult ProductEdit(int id)
        {
            var result = productManager.Get(id);
            return View(result);
        }

        public IActionResult SliderList()
        {
            var result = sliderManager.GetAll();
            return View(result);
        }

        [HttpGet]
        public IActionResult SliderAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SliderAdd(Entity.Slider slider)
        {
            sliderManager.Add(slider);

            return RedirectToAction("SliderList", "Admin");
        }

        [HttpGet]
        public IActionResult SliderUpdate()
        {
            return View();

        }


        [HttpPost]
        public IActionResult SliderUpdate(Entity.Slider slider)
        {
            sliderManager.Update(slider);
            return RedirectToAction("SliderList", "Admin");
        }


        public IActionResult SliderDelete(int id)
        {
            var result = sliderManager.Get(id);
            sliderManager.Selman(result);
            return RedirectToAction("SliderList");
        }

        [HttpGet]
        public IActionResult SliderEdit(int id)
        {
            var result = aboutManager.Get(id);
            return View(result);
        }


    }
    }

