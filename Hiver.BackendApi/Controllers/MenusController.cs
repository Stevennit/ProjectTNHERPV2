using Hiver.Application.Common.Menu;
using Hiver.Application.System.Users;
using Hiver.ViewModels.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiver.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        private readonly IMenuService _menuService;

        public MenusController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet("GetChildrenMenus")]
        public async Task<IActionResult> GetChildrenMenu(int? parentId)
        {
            var res = await _menuService.GetChildrenMenu(parentId);

            return Ok(res);
        }

        [HttpGet("GetMenuItems")]
        public async Task<IActionResult> GetMenuItem(int Id)
        {
            var res = await _menuService.GetMenuItem(Id);

            return Ok(res);
        }
    }
}
