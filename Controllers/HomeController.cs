using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Tutor.Models;

namespace Tutor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private UserContext _context;
        public HomeController(UserContext context){
            _context = context;
        }

        [HttpPost]
        public IActionResult Register(ValidateUser user){
            if(ModelState.IsValid){
                PasswordHasher<ValidateUser> Hasher = new PasswordHasher<ValidateUser>();
                user.Password = Hasher.HashPassword(user, user.Password);
                User thisUser = new User{
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Password = user.Password
                };
                _context.Add(thisUser);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("UserId", thisUser.UserId);
                return RedirectToAction("Success", thisUser.UserId);
            }
            else{
                return View("Index");
            }
        }

        public IActionResult Login(string Email, string Password){
            var thisUser = _context.Users.Where(p => p.Email == Email).FirstOrDefault();
            if(thisUser != null && Password != null){
                var Hasher = new PasswordHasher<User>();
                if(0 != Hasher.VerifyHashedPassword(thisUser, thisUser.Password, Password)){
                    HttpContext.Session.SetInt32("UserId", thisUser.UserId);
                    return RedirectToAction("Success");
                }
            }
            ViewBag.error = "Email and Password do not match";
            return View("Index");
        }

        public IActionResult About(){
            return View("Login");
        }

        public IActionResult Contact(){
            return View("Register");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
