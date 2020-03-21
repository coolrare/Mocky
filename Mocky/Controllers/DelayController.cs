using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Mocky.Controllers
{
    [RoutePrefix("api/delay")]
    public class DelayController : ApiController
    {
        [HttpGet]
        [Route("")]
        [Route("{ms}")]
        public async Task<string> GetAsync(int ms = 0)
        {
            await Task.Delay(ms);

            return $"Delay {ms}ms";
        }

        [HttpGet]
        [Route("~/")]
        public IHttpActionResult Home(int ms = 0)
        {
            return Redirect("https://blog.miniasp.com");
        }
    }
}
