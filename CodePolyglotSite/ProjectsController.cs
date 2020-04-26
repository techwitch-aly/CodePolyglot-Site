using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodePolyglotSite.Pages;
using CodePolyglotSite.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CodePolyglotSite
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            ProjectListViewModel model = new ProjectListViewModel();
            model.Info = DateTime.Now.ToString();
            return View(model);
        }
    }
}