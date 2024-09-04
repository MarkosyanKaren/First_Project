using First_Project.BLL.Services;
using First_Project.DAL;
using First_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace First_Project.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<CustomerController> _logger;
    private ProjectDBContext _dbContext;
    private CustomerService _customerService;

    public HomeController(ILogger<CustomerController> logger)
    {
        _logger = logger;
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
