using System;
using System.Web.Http;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class ReciboController : ApiController
    {
        private InformacionReciboData informacionReciboData;

        public ReciboController()
        {
            informacionReciboData = new InformacionReciboData();
        }

        // GET api/recibo/5
        [HttpGet]
        [Route("api/recibo/{NoRecibo}")]
        public IHttpActionResult Get(int NoRecibo)
        {
            InformacionRecibo informacionRecibo = InformacionReciboData.Obtener(NoRecibo);

            if (informacionRecibo != null)
            {
                return Ok(informacionRecibo);
            }
            else
            {
                return NotFound();
            }
        }


    }
}
