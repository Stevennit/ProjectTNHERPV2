using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Hiver.ViewModels.System.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Hiver.WebApp.Controllers
{
    
    public class BaseController : Controller
    {

        public BaseController()
        {
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Get name
            string nameUser = context.HttpContext.User.Claims.Where(c => c.Type == ClaimTypes.Name).Select(c => c.Value).FirstOrDefault();

            if(!User.Identity.IsAuthenticated)
            {
                context.Result = new RedirectToActionResult("Index", "Login", null);
            }
            
            base.OnActionExecuting(context);
        }
    }
}