using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.Data.Entities
{
    public class AppRoleControllerGroup
    {
        public int Id { get; set; }

        public Guid IdRole { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Description { get; set; }
    }
}
