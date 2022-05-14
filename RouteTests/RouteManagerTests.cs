using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPIDemoProject.Services;
using WebAPIDemoProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace RouteTests
{
    [TestClass]
    public class RouteManagerTests
    {
        RouteManager _routeManager;
        [TestInitialize]
        public void Init()
        {
            _routeManager = new RouteManager();
        }
        [TestMethod]
        public void GetRoutesPositiveTest()
        {
            IList<InputRoute> inputRoutes = new List<InputRoute>()
            {
                new InputRoute()
                {
                    routename="Route 1",
                    stops= new System.Collections.Generic.List<Stop>()
                    {
                        new Stop()
                        {
                            stopname= "Stop 1",
                            objects= new System.Collections.Generic.List<Object>() {
                                new Object()
                                {
                                    objecttype= "tank",
                                    objectname= "MT ACE UNIT 3H WATER TANK"

                                }
                            }
                        }
                    }
                }
            };

            OutputRoute outputRouteExpected = new OutputRoute()
            {
                routename = "Route 1",
                stopname = "Stop 1",
                objecttype = "tank",
                objectname = "MT ACE UNIT 3H WATER TANK"
            };

            IList<OutputRoute> outputRoutes = _routeManager.GetRoutes(inputRoutes);

            Assert.IsNotNull(outputRoutes);
            Assert.IsTrue(outputRoutes.Any(x => x.routename == outputRouteExpected.routename));
        }

        [TestMethod]
        public void GetRoutesNegativeTest()
        {
            IList<InputRoute> inputRoutes = new List<InputRoute>()
            {
                new InputRoute()
                {
                    routename="Route 1",
                    stops=null
                }
            };

            // Act
            try
            {
                _routeManager.GetRoutes(inputRoutes);
            }
            catch (System.NullReferenceException e)
            {
                // Assert
                StringAssert.Contains(e.Message, "Object reference not set to an instance of an object.");
            }

        }
    }
}
