using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCore2.Models;

namespace NetCore2.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LayMot()
        {
            var Model = new Product
            {
                Code = 2,
                ProductName = "SamSung",
                Invoid = 8000000,
                Discount = 0.5
            };
            return View(Model);
            
        }
        public IActionResult DanhSach()
        {
            List<Product> DanhSach = new List<Product>();
            Product tmp;
            var random = new Random();
            var soPhanTu = random.Next(1, 101);
            for(int i = 0; i< soPhanTu;i++)
                {
                tmp = new Product
                {
                    Code = i + 100,
                    ProductName = $"Iphone {random.Next()}",
                    Invoid = random.NextDouble() * 1000000,
                    Discount = random.NextDouble()
                };
                DanhSach.Add(tmp);
                }
            return View(DanhSach);
        }
        public IActionResult DemoHinhHoc()
        {
            return View();
        }
    }
}