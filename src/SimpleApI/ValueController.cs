using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class ValueController : Controller
    {
        // GET: ValueController
        [Route("api/value")]
        [HttpGet]
        public ActionResult<string> getString()
        {
            return "Some result";
        }

    }
}
