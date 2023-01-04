﻿using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Atilim.Controllers
{
    public class About : Controller
    {
        AboutManager aboutManager = new AboutManager( new EfAboutDal());
        public IActionResult Index()
        {
            var result = aboutManager.GetAll();
            return View(result);
        }
        public IActionResult EnIndex()
        {
            var result = aboutManager.GetAll();
            return View(result);
        }
    }
}
