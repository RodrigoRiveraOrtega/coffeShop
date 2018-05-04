using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CoffeeShop_Server.Controllers
{
    [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
    public class HomePageController : ApiController
    {
        public String GET() {
            return "Welcome to my Page";
        }
    }
}
