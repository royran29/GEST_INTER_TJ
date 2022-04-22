using Microsoft.AspNetCore.Mvc;
using GEST_INTER_TJ.Utils;
using GEST_INTER_TJ.Interfaces.IGestionTJ;

namespace GEST_INTER_TJ.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientesController : Controller
    {
        private readonly IGestionesTJ vGestiones;

        public ClientesController(IGestionesTJ gestiones)
        {
            vGestiones = gestiones;
        }


        /// <summary>
        /// Entrada para mantenimiento de clientes 
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GrabaClientes")]
        public ActionResult<clsGrabaClientesOut> GrabaClientes(clsGrabaClientesIn pInput)
        {
            clsGrabaClientesOut resultado = vGestiones.GrabaClientes(pInput);

            if (resultado.CodRespInterno != clsCodigoRespuesta.Exito)
            {
                return BadRequest(resultado);
            }

            return Ok(resultado);
        }



        /// <summary>
        /// Entrada para mantenimiento de direcciones 
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GrabaDirecciones")]
        public ActionResult<clsGrabaDireccionesOut> GrabaDirecciones(clsGrabaDireccionesIn pInput)
        {
            clsGrabaDireccionesOut resultado = vGestiones.GrabaDirecciones(pInput);

            if (resultado.CodRespInterno != clsCodigoRespuesta.Exito)
            {
                return BadRequest(resultado);
            }

            return Ok(resultado);
        }


        /// <summary>
        /// Entrada para mantenimiento de telefonos 
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GrabaTelefonos")]
        public ActionResult<clsGrabaTelefonosOut> GrabaTelefonos(clsGrabaTelefonosIn pInput)
        {
            clsGrabaTelefonosOut resultado = vGestiones.GrabaTelefonos(pInput);

            if (resultado.CodRespInterno != clsCodigoRespuesta.Exito)
            {
                return BadRequest(resultado);
            }

            return Ok(resultado);
        }

    }
}
