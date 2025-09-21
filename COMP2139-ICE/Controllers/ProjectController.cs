using COMP2139_ICE.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP2139_ICE.Controllers;

public class ProjectController : Controller
{
    [HttpGet]
    public IActionResult Index()
    // GET
    {
        var projects = new List<Project>() 
        {
            new Project {ProjectId = 1, Name = "Project 1", Description = "First Project"}, 
        };
        return View(projects);
    } 
    [HttpGet]
    public IActionResult Create()
    // GET
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Project project)
    // GET
    {
        return RedirectToAction("index");
    }
    [HttpGet]
    public IActionResult Details(int id)
    // GET
    {
        var project = new List<Project>()
        {
            new Project {ProjectId = 1, Name = "Project 1", Description = "First Project"}, 
        };
        return View(project);
    }
}