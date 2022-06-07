using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers;

public class DepartmentsController : Controller
{
    private readonly ILogger<DepartmentsController> _logger;
    
    public DepartmentsController(ILogger<DepartmentsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Department> departments = new List<Department>();
        departments.Add(new Department { Id = 1, Name = "Electronics" });
        departments.Add(new Department { Id = 2, Name = "Fashion" });

        return View(departments);
    }
}
