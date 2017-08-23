using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Working.Models;

namespace Working.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            MyViewModel model = new MyViewModel();
            model = define(model);
            return View(model);
        }
        public ActionResult Tosya()
        {
            MyViewModel model = new MyViewModel();
            model = define(model);
            return View(model);

        }
        protected MyViewModel define(MyViewModel model)
        {

            List<Image> images = new List<Image>()
            {
                new Image
                {
                    Url = "/Contents/Images/image1.jpg",
                    Alt = "1070",
                    Name = "Kastamonu Castle"
                },
                new Image
                {
                    Url = "/Contents/Images/image2.jpg",
                    Alt = "1068",
                    Name = "Nasrullah Mosque"
                },
                new Image
                {
                    Url = "/Contents/Images/image3.jpg",
                    Alt = "1071",
                    Name = "Clock Tower"
                },
                new Image
                {
                    Url = "/Contents/Images/image4.jpg",
                    Alt = "1067",
                    Name = "Lovers Bridge"
                }
            };

            List<Town> towns = new List<Town>()
            {
                new Town
                {
                    Name = "Araç",
                    Population = 5000,
                    Url = "/Home/index"
                },
                new Town
                {
                    Name = "Azdavay",
                    Population = 3000,
                    Url = "/Home/index"
                },
                new Town
                {
                    Name = "Abana",
                    Population = 2500,
                    Url = "/Home/index"
                },
                new Town
                {
                    Name = "Bozkurt",
                    Population = 2000,
                    Url = "/Home/index"
                },
                new Town
                {
                    Name = "Cide",
                    Population = 5300,
                    Url = "/Home/index"
                },
                new Town
                {
                    Name = "Çatalzeytin",
                    Population = 1800,
                    Url = "/Home/index"
                },
                new Town
                {
                    Name = "Devrekani",
                    Population = 2200,
                    Url = "/Home/index"
                },
                new Town
                {
                    Name = "Doğanyurt",
                    Population = 1000,
                    Url = "/Home/index"
                },
                new Town
                {
                    Name = "Hanönü",
                    Population = 1100,
                    Url = "/Home/index"
                },
                new Town
                {
                    Name = "İhsangazi",
                    Population = 1800,
                    Url = "/Home/index"
                },
                new Town
                {
                    Name = "İnebolu",
                    Population = 6000,
                    Url = "/Home/index"
                },
                new Town
                {
                    Name = "Tosya",
                    Population = 25000,
                    Url = "/Home/tosya"
                }
            };
            model.SetImages(images);
            model.SetTowns(towns);
            return model;
        }
    }
}