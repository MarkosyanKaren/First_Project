using First_Project.BLL.Services;
using First_Project.DAL;
using First_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace First_Project.Controllers;

public class CustomerController : Controller
{
    private readonly ILogger<CustomerController> _logger;
    private ProjectDBContext _dbContext;
    private CustomerService _customerService;

    public CustomerController(ILogger<CustomerController> logger, ProjectDBContext projectDBContext, CustomerService customerService)
    {
        _logger = logger;
        _dbContext = projectDBContext;
        _customerService = customerService;
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
