using Microsoft.AspNetCore.Mvc;

namespace expense_management_app.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
