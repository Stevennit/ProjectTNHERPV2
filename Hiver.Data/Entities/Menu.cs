using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.Data.Entities
{
    public class Menu
    {
        public int MenuID { get; set; }
        public int? ParentID { get; set; }
        public string MenuName { get; set; }
        public string Description { get; set; }
        public string IconClass { get; set; }
        public string Url { get; set; }
        public int MenuOrder { get; set; }
        public bool IsVisible { get; set; }
    }
}
