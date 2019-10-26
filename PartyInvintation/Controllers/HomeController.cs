using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvintation.Models;

namespace PartyInvintation.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Forma()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Forma(ResponseModel responseModel)
        {
            if(ModelState.IsValid)
            {
                Repository.AddResponse(responseModel);
                return View("Thanks", responseModel);
            }

            return View();
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}
