using Microsoft.AspNetCore.Mvc;

namespace ASP_CRUD_and_git_practice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
