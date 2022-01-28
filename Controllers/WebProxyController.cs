using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace web_hook_proxy.Controllers
{
    [ApiController]
    [Route("api/web_hook_proxy")]
    public class WebProxyController : ControllerBase
    {
        private const string LOCAL_IPADDRESS = "YOUR IP ADDRESS HERE";

        [HttpGet]
        [Route("{hookName}")]
        public ActionResult<string> Get(string hookName)
        {
            Console.WriteLine($"Hook {hookName} called");
            WebRequest request = WebRequest.Create($"http://{LOCAL_IPADDRESS}:8123/api/webhook/{hookName}");
            request.Method = "POST";
            WebResponse response = request.GetResponse();
            response.Close();

            return Ok($"Hook {hookName} called");
        }
    }
}
