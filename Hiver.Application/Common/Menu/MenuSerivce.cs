using Hiver.Data.EF;
using Hiver.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.Application.Common.Menu
{
    public class MenuSerivce : IMenuService
    {
        private readonly HiverDbContext _context;

        public MenuSerivce(HiverDbContext context)
        {
            _context = context;
        }

        public async Task<MenuResult> GetMenuItem(int Id)
        {
            var res = await _context.Menus.FirstOrDefaultAsync(x => x.MenuID == Id);

            var menu = new MenuResult()
            {
                MenuId = res.MenuID,
                MenuName = res.MenuName,
                Description = res.Description,
                IconClass = res.IconClass,
                IsVisible = res.IsVisible,
                MenuOrder = res.MenuOrder,
                ParentID = res.ParentID,
                Url = res.Url
            };

            return menu;
           
        }

        public async Task<List<MenuResult>> GetChildrenMenu(int? parentId)
        {
            return await _context.Menus.Where(x => x.ParentID == parentId)
                .Select( i => new MenuResult()
                    {
                        MenuId = i.MenuID,
                        MenuName = i.MenuName,
                        Description = i.Description,
                        IconClass = i.IconClass,
                        IsVisible = i.IsVisible,
                        MenuOrder = i.MenuOrder,
                        ParentID = i.ParentID,
                        Url = i.Url
                    }
                ).ToListAsync();
        }
    }
}
