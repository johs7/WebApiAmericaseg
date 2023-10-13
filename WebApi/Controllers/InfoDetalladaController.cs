using System;
using System.Web.Http;
using CapaEntidades;
using CapaDatos;

namespace WebApi.Controllers
{
    public class InfoDetalladaController : ApiController
    {

        [System.Web.Http.HttpGet]
        [Route("api/InfoDetallada/{NoRecibo}")]
        public IHttpActionResult Get(int NoRecibo)
        {
            InformacionReciboDetalle informacionRecibo = InformacionReciboDetalladaData.ObtenerInformacionReciboDetallada(NoRecibo);

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