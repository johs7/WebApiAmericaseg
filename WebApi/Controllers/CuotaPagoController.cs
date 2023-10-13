using System;
using System.Web.Http;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class CuotaPagoController : ApiController
    {
      
        [System.Web.Http.HttpGet]
        [Route("api/CuotaPago/{NoRecibo}")]
        public IHttpActionResult Get(int NoRecibo)
        {
             CuotaPagoInfo informacionPago =  CuotaPagoInfoData.Obtener(NoRecibo);

            if (informacionPago != null)
            {
                return Ok(informacionPago);
            }
            else
            {
                return NotFound();
            }
        }
    }
}