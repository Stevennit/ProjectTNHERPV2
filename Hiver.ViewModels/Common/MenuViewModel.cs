using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiver.ViewModels.Common
{
    public class MenuViewModel
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string Description { get; set; }
        public string IconClass { get; set; }
        public string Url { get; set; }
        public int MenuOrder { get; set; }
        public bool IsVisible { get; set; }

        public IList<MenuViewModel> Children { get; set; }
    }
}
