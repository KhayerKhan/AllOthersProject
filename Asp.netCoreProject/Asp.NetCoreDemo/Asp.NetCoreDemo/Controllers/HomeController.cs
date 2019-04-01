using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Asp.NetCoreDemo.Models;
using Asp.NetCoreDemo.Code;

namespace Asp.NetCoreDemo.Controllers
{
    public class HomeController : Controller
    {
        //DataStore s = new DataStore();
        //DataStore2 s1 = new DataStore2();
        //DataUser user = new DataUser(s1);
        public HomeController()
        {



        }





        public IActionResult Index()
        {
            
                SQLServerData data = new SQLServerData();
                ViewBag.message = data.GetStudentsNames();
            
            
              
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
