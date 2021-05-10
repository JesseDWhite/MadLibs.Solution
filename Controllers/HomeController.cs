using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult HomePage() { return View(); }
    [Route("/form")]
    public ActionResult Form() { return View(); }
    [Route("/form-aliens")]
    public ActionResult FormAliens() { return View(); }

    [Route("/madlib")]
    public ActionResult MadLibResult(string friendName, string actionVerb, string sizeAdjective, string speedAdjective, string throwableObject, string place)
    {
      MadLib newMadLib = new MadLib();
      newMadLib.FriendName = friendName;
      newMadLib.ActionVerb = actionVerb;
      newMadLib.SizeAdjective = sizeAdjective;
      newMadLib.SpeedAdjective = speedAdjective;
      newMadLib.ThrowableObject = throwableObject;
      newMadLib.Place = place;
      return View(newMadLib);
    }
    public ActionResult AlienResult(string friendName, string place, string smell, string headShape, string sensation, string vehicle, string soundAdjective)
    {
      MadLib newMadLib = new MadLib();
      newMadLib.FriendName = friendName;
      newMadLib.Place = place;
      newMadLib.Smell = smell;
      newMadLib.HeadShape = headShape;
      newMadLib.Sensation = sensation;
      newMadLib.Vehicle = vehicle;
      newMadLib.SoundsAdjective = soundAdjective;
      return View(newMadLib);
    }
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
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
}
