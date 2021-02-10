using K207CoreFirst.Data;
using K207CoreFirst.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K207CoreFirst.Controllers
{
    public class MyUserController : Controller
    {
        private K207RegisterDB _db;

        public MyUserController(K207RegisterDB db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Users.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string Fullname,string Email,string phone,DateTime birthday )
        {
            User user = new User();
            user.name = Fullname;
            user.email = Email;
            user.phonenumber = phone;
            user.birthday = birthday;
            _db.Users.Add(user);
            _db.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int ID)
        {
            var user = _db.Users.Find(ID);
            _db.Users.Remove(user);
            _db.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Edit(int? ID)
        {
            return View(_db.Users.Find(ID));
        }
        [HttpPost]
        public IActionResult Edit(int ID, string Fullname, string Email, string phone, DateTime birthday)
        {
            User selecteduser = _db.Users.Find(ID);
            selecteduser.name=Fullname;
            selecteduser.email = Email;
            selecteduser.phonenumber = phone;
            selecteduser.birthday = birthday;
            _db.SaveChanges();
            return RedirectToAction("index");
        }

    }
}
