using Hiver.Data.EF;
using Hiver.Data.Entities;
using Hiver.Utilities.Exceptions;
using Hiver.ViewModels.Common;
using Hiver.ViewModels.System.Roles;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.Application.System.Roles
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly HiverDbContext _context;


        public RoleService(RoleManager<AppRole> roleManager, HiverDbContext context)
        {
            _roleManager = roleManager;
            _context = context;
        }

        public async Task<List<RoleVm>> GetAll()
        {
            var roles = await _roleManager.Roles
                .Select(x => new RoleVm()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description
                }).ToListAsync();

            return roles;
        }

        public async Task<bool> roleCheck(RoleCheckVm request)
        {
            var rel = await _context.AppRoleControllers.SingleOrDefaultAsync(x => x.Controller == request.Controller &&
                x.Action == request.Action && x.AppUser == request.AppUser);

            if (rel == null)
            {
                return false;
            }

            return true;
        }

        
    }
}