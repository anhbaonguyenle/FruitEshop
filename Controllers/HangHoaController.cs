using Microsoft.AspNetCore.Mvc;

namespace FruitEshop.Controllers
{
    public class HangHoaController : Controller
    {
        public IActionResult Index(int? id)
        {
            return View();
        }
    }
}
