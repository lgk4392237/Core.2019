using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Core._2019.Models;
using Core._2019.IDAL;

namespace Core._2019.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    IStudent _student;

    public HomeController(ILogger<HomeController> logger, IStudent student)
    {
      _logger = logger;
      _student = student;
    }

    public IActionResult Index()
    {
      string name=_student.Info();
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
}
