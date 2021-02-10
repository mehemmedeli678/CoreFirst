using K207CoreFirst.Data;
using K207CoreFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace K207CoreFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private K207RegisterDB _db;

        public HomeController(ILogger<HomeController> logger,K207RegisterDB db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            #region baza yaratmaq!
            //SQL-siz databaza yaratmaq!

            //User us1 = new User();
            //us1.ID = 1;
            //us1.name = "Salmanov";
            //us1.birthday = DateTime.Now;
            //us1.phonenumber = "0559978755";
            //us1.email = "samir@gmail.com";

            //User us2 = new User();
            //us2.ID = 1;
            //us2.name = "Murad";
            //us2.birthday = DateTime.Now;
            //us2.phonenumber = "0709877353";
            //us2.email = "murad@gmail.com";

            //User us3 = new User();
            //us3.name = "Ilkin";
            //us3.birthday = DateTime.Now;
            //us3.phonenumber = "0709877353";
            //us3.email = "ilkin@gmail.com";

            //List<User> userlist = new List<User>();

            //userlist.Add(us1);
            //userlist.Add(us2);
            //userlist.Add(us3);

            #endregion

            return View(_db.Users.ToList());
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
