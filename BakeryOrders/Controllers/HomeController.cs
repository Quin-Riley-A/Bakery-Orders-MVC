using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace BakeryOrder.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index() 
    {
      return View();
    }

    [Route("/Vendors")]
    public ActionResult Vendor() 
    {
      return View();
    }
  }
}