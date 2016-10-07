using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dotNetComicBook.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
            {
            if(DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            {
                return Redirect("/ComicBooks/Schmetail");
                //return new RedirectResult("/"); ---> this object replaced by method provided by Controller class
            }

            return Content("Hello from the Content action method!");
            //return new ContentResult()-----> this method replaced by short cut provided by controller class
            //{
            //    Content = "Hello from the Detail action!"
            //};
            
        }
        
        public ActionResult Schmetail()
        {
            return Content("you were redirected because its Friday");
        }     

    }
}