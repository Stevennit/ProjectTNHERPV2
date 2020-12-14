using Hiver.ViewModels.Common;
using Hiver.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.Application.System.Roles
{
    public interface IRoleService
    {
        Task<List<RoleVm>> GetAll();

        Task<bool> roleCheck(RoleCheckVm request);
    }
}