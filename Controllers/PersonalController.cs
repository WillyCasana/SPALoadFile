using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppWebApiHtml2.Controllers
{
    public class PersonalController : ApiController
    {
        public IHttpActionResult GetPersonal()
        {

            List<string> personalListado = new List<string>() { "Elon", "Steve", "Bill", "Jack Ma" };

            //return Ok(personalListado);
            return  Json(personalListado);
        }
    }
}
