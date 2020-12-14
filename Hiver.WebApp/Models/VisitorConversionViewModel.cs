using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiver.WebApp.Models
{
    public class VisitorConversionViewModel
    {
        public int Value { get; set; }
        public DateTime Date { get; set; }
        public string Channel { get; set; }
        public int Conversion { get; set; }
        public int Users { get; set; }
    }
}
