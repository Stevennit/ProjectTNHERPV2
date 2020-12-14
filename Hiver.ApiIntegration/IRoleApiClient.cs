using Hiver.ViewModels.Common;
using Hiver.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiver.ApiIntegration
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleVm>>> GetAll();


        Task<ApiResult<bool>> roleCheck(string nameUser);
    }
}