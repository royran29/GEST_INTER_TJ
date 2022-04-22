using Microsoft.AspNetCore.Mvc;
using GEST_INTER_TJ.Utils;
using GEST_INTER_TJ.Interfaces.IGestionTJ;

namespace GEST_INTER_TJ.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HSMController : Controller
    {
        private readonly IGestionesTJ vGestiones;

        public HSMController(IGestionesTJ gestiones)
        {
            vGestiones = gestiones;
        }


        /// <summary>
        /// Entrada para mantenimiento de clientes 
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GeneraPinPVV")]
        public ActionResult<clsGenPinPvvOut> GeneraPinPVV(clsGenPinPvvIn pInput)
        {
            clsGenPinPvvOut resultado = vGestiones.GenPinPVV(pInput);

            if (resultado.CodRespInterno != clsCodigoRespuesta.Exito)
            {
                return BadRequest(resultado);
            }

            return Ok(resultado);
        }

    }
}
