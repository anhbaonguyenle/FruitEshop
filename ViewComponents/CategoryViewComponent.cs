using FruitEshop.Data;
using FruitEshop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FruitEshop.ViewComponents
{

    public class CategoryViewComponent : ViewComponent
    {
        private readonly FruitEshopContext DB;
        public CategoryViewComponent(FruitEshopContext context) => DB = context;

        public IViewComponentResult Invoke()
        {
            var data = DB.Loais.Select(lo => new CategoryVM
            {
                MaLoai = lo.MaLoai,
                TenLoai = lo.TenLoai,
                Count = lo.HangHoas.Count,
            }).OrderBy(p => p.TenLoai);
            return View(data);
        }
    }
}
