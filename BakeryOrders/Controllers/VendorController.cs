using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace BakeryOrder.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]


    [HttpGet("/vendors/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
  }
}