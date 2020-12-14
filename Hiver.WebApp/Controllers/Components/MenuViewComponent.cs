using Hiver.Application.Common.Menu;
using Hiver.ViewModels.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiver.WebApp.Controllers.Components
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly IMenuService _menuService;

        public MenuViewComponent(IMenuService menuService)
        {
            _menuService = menuService;
        }

        public Task<IViewComponentResult> InvokeAsync(int? parentId)
        {
            var children =  GetMenu(parentId);

            return Task.FromResult((IViewComponentResult)View("_MenuPartial", children));
        }

        public IList<MenuViewModel> GetMenu(int? parentId)
        {
            var children = _menuService.GetChildrenMenu(parentId);

            if (!children.Result.Any())
            {
                return new List<MenuViewModel>();
            }

            var vmList = new List<MenuViewModel>();

            foreach (var item in children.Result)
            {
                var menu = _menuService.GetMenuItem(item.MenuId);

                var vm = new MenuViewModel();

                vm.MenuId = menu.Result.MenuId;
                vm.MenuName = menu.Result.MenuName;
                vm.MenuOrder = menu.Result.MenuOrder;
                vm.Description = menu.Result.Description;
                vm.IconClass = menu.Result.IconClass;
                vm.Url = menu.Result.Url;
                vm.IsVisible = menu.Result.IsVisible;

                vm.Children = GetMenu(menu.Result.MenuId);
                vmList.Add(vm);
            }
            return vmList;
        }
       

    }
}
