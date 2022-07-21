using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Index();
        }

        public IActionResult Error()
        {
            return Error();
        }
    }
}
