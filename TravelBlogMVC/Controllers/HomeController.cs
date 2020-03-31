using Microsoft.AspNetCore.Mvc;

namespace TravelBlog.Controllers
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