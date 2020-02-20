using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace PCloud.Controllers
{
    public class AdminController : Controller
    {
        public IConfiguration Configuration { get; }

        public AdminController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

       

        public IActionResult Index()
        {
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            return View();
        }

        public IActionResult UploadDocument()
        {
            return View();
        }

        public IActionResult ManageDocument()
        {
            return View();
        }
    }
}