using Hiver.Application.System.Roles;
using Hiver.ViewModels.Common;
using Hiver.ViewModels.System.Roles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Hiver.BackendApi.Auth
{
    public class AuthAttribute : ActionFilterAttribute
    {
        private readonly IRoleService _roleService;
        public AuthAttribute(IRoleService roleService)
        {
            _roleService = roleService;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Get name
            string nameUser = context.HttpContext.User.Claims.Where(c => c.Type == ClaimTypes.Name).Select(c => c.Value).FirstOrDefault();

            // Get Name Controller and Name Action 
            string nameController = (string)context.RouteData.Values["Controller"];
            string nameAction = (string)context.RouteData.Values["Action"];

            var request = new RoleCheckVm()
            {
                AppUser = nameUser,
                Controller = nameController,
                Action = nameAction
            };

            var res = _roleService.roleCheck(request);

            if (res.Result == true)
            {
                base.OnActionExecuting(context);
            }
            else
            {
                context.Result = new BadRequestObjectResult(new ApiErrorResult<string>("Bạn không có quyền truy cập"));
                return;
            }
                
        }
    }
}
