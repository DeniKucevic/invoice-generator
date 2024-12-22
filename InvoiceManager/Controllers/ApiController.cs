using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using InvoiceManager.Models;

namespace InvoiceManager.Controllers;

public class ApiController : Controller
{
    private readonly ILogger<ApiController> _logger;

    public ApiController(ILogger<ApiController> logger)
    {
        _logger = logger;
    }

    // GET
    public JsonResult Index()
    {
        // how do we work with file system
        var data = new
        {
            Name = "John Doe",
            Age = 30,
            Profession = "Developer"
        };
        return Json(data);

    }
    [HttpPost]
    public String GetString()
    {
        return "string";
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
