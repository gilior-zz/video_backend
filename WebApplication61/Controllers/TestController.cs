
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi.Template3.Controllers
{
    public class TestController : ApiController
    {

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok();

        }
    }
}
