using Microsoft.AspNetCore.Mvc;

namespace _21_PS36400_NguyenLocThong_ASM.Areas.Admin.Controllers
{
    public class AdminTrangChuController : Controller
    {
        [Area("Admin")]
        [Route("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
