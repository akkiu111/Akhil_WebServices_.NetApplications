using akWebApiimcs.DbContext;
using Newtonsoft.Json;
using System.Linq;
using System.Web.Http;

namespace akWebApiimcs.Controllers
{
    public class StateController : ApiController
    {
        [ActionName("MyXML")]
        [Route("api/State/myxml")]
        [Route("api/State/getstatesxml")]
        [HttpGet]
        public IHttpActionResult GetStatesXml()
        {
            StateDropdownEntity sdde = new StateDropdownEntity();
            return Ok(sdde.states.ToList());

        }

        [ActionName("MyJSON")]
        [Route("api/State/myjson")]
        [Route("api/State/getstatesjson")]
        [HttpGet]
        public string GetStatesJson()
        {
            StateDropdownEntity sdde = new StateDropdownEntity();
            return JsonConvert.SerializeObject(sdde.states.ToList());

        }


    }
}
