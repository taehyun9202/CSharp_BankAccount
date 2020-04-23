using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BankAccount.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace BankAccount.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context)
        {
            _context = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Eamil Already Exists");
                    return View("Index");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    _context.Users.Add(newUser);
                    _context.SaveChanges();
                    HttpContext.Session.SetInt32("userinSession", newUser.UserId);
                    return Redirect($"/account/{newUser.UserId}");
                }
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("login")]
        public IActionResult LoginHome()
        {
            return View("Login");
        }
        [HttpPost("login")]
        public IActionResult Login(LoginUser userIn)
        {
            if(ModelState.IsValid)
            {
                var userInDb = _context.Users.FirstOrDefault(u => u.Email == userIn.LoginEmail);
                if(userInDb == null){
                    ModelState.AddModelError("LoginEmail","Invalid Email Address");
                    return View("Login");
                }
                else
                {
                    var hash = new PasswordHasher<LoginUser>();
                    var result = hash.VerifyHashedPassword(userIn, userInDb.Password, userIn.LoginPassword);
                    if(result == 0)
                    {
                        ModelState.AddModelError("LoginPassword","Invalid Password");
                        return View("Login");
                    }
                    else
                    {
                        HttpContext.Session.SetInt32("userinSession", userInDb.UserId);
                        return Redirect($"/account/{userInDb.UserId}");
                    }
                }
            }
            else
            {
                return View("Login");
            }
        }

        [HttpGet("account/{ID}")]
        public IActionResult UserHome(int ID)
        {
            int? userID = HttpContext.Session.GetInt32("userinSession");
            if(userID == ID)
            {
                ViewBag.getUser = _context.Users.Include(u => u.Histories)
                                                .FirstOrDefault(u => u.UserId == ID);
                ViewBag.AllHistory = _context.Histories.FirstOrDefault(u => u.UserId == ID);
                User loggedin = _context.Users.Include(u => u.Histories)
                                              .FirstOrDefault(u => u.UserId == ID);
                return View("UserHome",loggedin);
            }
            else
            {
                return View("Login");
            }
        }

        // [HttpGet("account/{ID}")]
        // public IActionResult AddTransaction(int ID)
        // {
        //     int? userID = HttpContext.Session.GetInt32("userinSession");
        //     if(userID == ID)
        //     {
        //         // List<History> getAll = _context.Histories.Include(h => h.Owner).ToList();
        //         // _context.Histories.Add(newTransaction);
        //         // _context.SaveChanges();
        //         ViewBag.Loggedin = _context.Users.FirstOrDefault(u => u.UserId == ID);
        //         // User loggedin = _context.Users.FirstOrDefault(u => u.UserId == ID);
        //         return Redirect($"/account/{ID}");
        //     }
        //     else
        //     {
        //         return Redirect($"/account/{ID}");
        //     }
        // }
        [HttpPost("account/{ID}")]
        public IActionResult Transaction(int ID, History newTransaction)
        {
            int? userID = HttpContext.Session.GetInt32("userinSession");
            if(userID == ID)
            {
                
                // List<History> getAll = _context.Histories.Include(h => h.Owner).ToList();
                // _context.Histories.Add(newTransaction);
                // _context.SaveChanges();
                // ViewBag.Loggedin = _context.Users.FirstOrDefault(u => u.UserId == ID);
                // User loggedin = _context.Users.FirstOrDefault(u => u.UserId == ID);
                _context.Histories.Add(newTransaction);
                _context.SaveChanges();
                return Redirect($"/account/{ID}");
            }
            else
            {
                return Redirect($"/account/{ID}");
            }
        }
        [HttpPost("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("userinSession");
            HttpContext.Session.Clear();
            return Redirect("Index");
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
