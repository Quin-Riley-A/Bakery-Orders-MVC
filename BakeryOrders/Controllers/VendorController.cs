using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace BakeryOrder.Controllers
{
  public class VendorController : Controller
  {

    [Route("/vendor/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
  }
}