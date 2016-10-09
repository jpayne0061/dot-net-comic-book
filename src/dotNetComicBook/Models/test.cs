using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dotNetComicBook.Models
{
    public class test
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string[] Characters { get; set; }
        public string Publisher { get; set; }

        public string DisplayText
        {
            get
            {
                return Title + "(" + Publisher + ")";
            }
        }
    }
}