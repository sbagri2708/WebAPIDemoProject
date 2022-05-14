using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemoProject.Models;

namespace WebAPIDemoProject.Interface
{
    public interface IRouteManager
    {
        IList<OutputRoute> GetRoutes(IList<InputRoute> inputRoutes);
    }
}
