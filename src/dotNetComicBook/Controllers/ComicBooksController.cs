using dotNetComicBook.Models;
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
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider man",
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                IssueNumber = 700,
                Favorite = false,
                Artists = new Artist[]
                {
                    new Artist() {Name="Dan Slitt", Role="Script" },
                    new Artist() {Name="Humberto Ramos", Role="Pencils" },
                    new Artist() {Name="Victor Olazaba", Role="Inks" },
                    new Artist() {Name="Chris Eliopoulos", Role="Letters" },
                    new Artist() {Name="Edgar Delado", Role="Colors" }
                }
                

            };

            return View(comicBook);
        }
            
    }
        

  
}