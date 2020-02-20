using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PCloud.Models;
using PCloud.Repository;

namespace PCloud.Controllers
{
    public class HomeController : Controller
    {
        public IConfiguration Configuration { get; }

        public AdminController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Login(UserModel userModel)
        {
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "Select * from dbo.User where UserName="+userModel.UserName +" and Password="+userModel.Password+"";
                SqlCommand command = new SqlCommand(sql, connection);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        UserModel User = new UserModel();
                        User.UserName = dataReader["UserName"].ToString();
                    }
                }
                connection.Close();
                //if ((userModel.UserName == "John" && userModel.Password == "password")  || (userModel.UserName == "User" && userModel.Password == "password"))
                //{
                //    HttpContext.Session.SetString("UserName", userModel.UserName);
                //    HttpContext.Session.SetString("Date", DateTime.Now.ToShortDateString());
                //}
            }
                return RedirectToAction("Home");
        }

        public IActionResult Home()
        {
            ViewBag.User = HttpContext.Session.GetString("UserName");
            ViewBag.Date = HttpContext.Session.GetString("Date");
            return View();
            //var documents = documentsRepository.GetAllCloudDocuments("Migration and MultiCloud");

            //return View(documents);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
