using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.Data.Entities
{
    public class AppRoleController
    {
        public int Id { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string AppUser { get; set; }
        public string Description { get; set; }
    }
}
