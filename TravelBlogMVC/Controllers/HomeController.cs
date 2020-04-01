using Microsoft.AspNetCore.Mvc;

namespace TravelBlogMVC.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}