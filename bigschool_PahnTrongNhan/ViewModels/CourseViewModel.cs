using bigschool_PahnTrongNhan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bigschool_PahnTrongNhan.ViewModels
{
    public class CourseViewModel
    {
        public string Place { set; get; }
        public string Date { set; get; }
        public string Time { set; get; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDate()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }

    }
}