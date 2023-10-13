using System;
using System.Web.Http;
using CapaEntidades;
using CapaDatos;

namespace WebApi.Controllers
{
    public class ReciboController : ApiController
    {
       
        public ReciboController()
        {
          
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
