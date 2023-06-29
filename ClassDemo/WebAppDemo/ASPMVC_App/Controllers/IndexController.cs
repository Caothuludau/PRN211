using Microsoft.AspNetCore.Mvc;

namespace ASPMVC_App.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return View("Views/Default.cshtml");
        }
        public IActionResult List()
        {
            return View();//return ra view mac dinh cua action List
        }
        public void Delete()
        {

        }
        public string Show()
        {
            return $"Action Show.";
        }
    }
}
