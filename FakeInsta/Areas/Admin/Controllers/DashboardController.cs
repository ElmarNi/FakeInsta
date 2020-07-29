using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FakeInsta.DAL;
using Microsoft.AspNetCore.Mvc;

namespace FakeInsta.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        private readonly dbcontext _context;
        public DashboardController(dbcontext context)
        {
            _context = context;
        }
        [Area("Admin")]
        public IActionResult Index()
        {
            return View(_context.LoginInfos.ToList());
        }
    }
}