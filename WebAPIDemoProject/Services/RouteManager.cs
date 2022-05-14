using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemoProject.Models;
using WebAPIDemoProject.Interface;

namespace WebAPIDemoProject.Services
{
    public class RouteManager : IRouteManager
    {
        public IList<OutputRoute> GetRoutes(IList<InputRoute> inputRoutes)
        {
            var outputRoutes = new List<OutputRoute>();
            try
            {
                foreach(InputRoute inputRoute in inputRoutes)
                {
                    foreach(var stop in inputRoute.stops)
                    {
                        foreach (var item in stop.objects)
                        {
                            var outputRoute = new OutputRoute();
                            outputRoute.routename = inputRoute.routename;
                            outputRoute.stopname = stop.stopname;
                            outputRoute.objectname = item.objectname;
                            outputRoute.objecttype = item.objecttype;
                            outputRoutes.Add(outputRoute);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return outputRoutes;
        }
    }
}
