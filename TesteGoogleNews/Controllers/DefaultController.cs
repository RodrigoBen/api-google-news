using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;

namespace TesteGoogleNews.Controllers
{
    public class DefaultController : Controller
    {
        
        // GET: Default
        public ActionResult Index()
        {
           
       
        return View();
        }
    }
}