using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PCloud.Repository;
using PCloud.ViewModels;

namespace PCloud.Controllers
{
    public class DocumentController : Controller
    {
        //private ICloudDocumentsRepository documentsRepository;
        //public DocumentController(ICloudDocumentsRepository documentsRepository)
        //{
        //    this.documentsRepository = documentsRepository;
        //}

        [HttpGet]
        public IActionResult Index()
        {
            return View();
            //var documents = documentsRepository.GetAllCloudDocuments();

            //return View(documents);
        }


        public IActionResult Solutions()
        {
           
            return View();
            //var documents = documentsRepository.GetAllCloudDocuments("Solution Over Cloud");

            //return View(documents); 
        }

        public IActionResult ManageServices()
        {
            //var documents = documentsRepository.GetAllCloudDocuments("Managed Services");
           // ViewBag.User = HttpContext.Session.GetString("User");
            //return View(documents);
            return View();
        }

        public IActionResult Innovation()
        {
           
            return View();
            //var documents = documentsRepository.GetAllCloudDocuments("Cloud as an Innovation Platform");

            //return View(documents);
        }

        //[HttpGet]
        //public IActionResult DocumentViewer(string Id)
        //{
        //    Guid id = Guid.Parse(Id);

        //    var temp = documentsRepository.GetDocumentById(id);

        //    if (id != null)
        //    {
        //        ViewData["PDF"] = temp.Data;
        //    }

        //    DocumentViewerViewModel model = new DocumentViewerViewModel()
        //    {
        //        DocumentName = temp.DocumentName,
        //        DocumentDescription = temp.DocumentDescription,
        //        DocumentCatagery = temp.DocumentCatogery
        //    };
        //    return View(model);
        //}
    }
}