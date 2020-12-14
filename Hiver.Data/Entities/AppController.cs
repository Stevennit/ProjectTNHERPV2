using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.Data.Entities
{
    public class AppController
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Area { get; set; }
        public string Description { get; set; }
        public bool Licensed { get; set; }
    }
}
