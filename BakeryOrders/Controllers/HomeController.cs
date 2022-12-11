using Microsoft.AspNetCore.Mvc;

namespace BakeryOrder.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public string Root() {}

    [Route("/Vendor")]
    public string Vendor() {}
  }
}