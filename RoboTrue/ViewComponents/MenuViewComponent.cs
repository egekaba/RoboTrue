using Microsoft.AspNetCore.Mvc;
using RoboTrue.Business.Abstract;

namespace RoboTrue.Business.Controllers
{
    public class MenuViewComponent : ViewComponent
    {

        private readonly IMenuManager menuManager;

        public MenuViewComponent(IMenuManager menuManager)
        {

            this.menuManager = menuManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menuler = menuManager.GetAll(p => p.Role.Id == 2 || p.Role.Id == 1).Result.ToList();
            return View(menuler);
        }
    }
}
