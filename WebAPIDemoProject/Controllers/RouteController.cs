using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAPIDemoProject.Models;
using WebAPIDemoProject.Interface;
using System;



namespace WebAPIDemoProject.Controllers
{
    [ApiController]
    public class RouteController : ControllerBase
    {
        IRouteManager _routeManager;

        public RouteController(IRouteManager routeManager)
        {
            _routeManager = routeManager;
        }
        // POST: route

        [HttpPost]
        [Route("route")]
        public ActionResult<IEnumerable<OutputRoute>> Post([FromBody] IList<InputRoute> inputRoutes)
        {
            try
            {
                var outputRoutes = _routeManager.GetRoutes(inputRoutes);
                return Ok(outputRoutes);
            }
            catch (Exception)
            {
                return Conflict(new Exception("Incorrect input provided"));
            }

        }
    }
}
