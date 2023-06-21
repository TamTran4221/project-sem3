using Microsoft.AspNetCore.Mvc;

namespace eproject_sem3.Areas.Admin.Controllers
{
    public class DashboardController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
