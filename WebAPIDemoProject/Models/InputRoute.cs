using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIDemoProject.Models
{
    public class InputRoute
    {
        public string routename { get; set; }
        public List<Stop> stops { get; set; }
    }
}
