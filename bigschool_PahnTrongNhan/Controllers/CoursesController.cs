using bigschool_PahnTrongNhan.Models;
using bigschool_PahnTrongNhan.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bigschool_PahnTrongNhan.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        [Authorize]
        public ActionResult Create()
        {
            var ViewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(ViewModel);
        }
    }
}