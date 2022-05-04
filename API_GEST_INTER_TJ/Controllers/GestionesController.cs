using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GEST_INTER_TJ.Utils;
using GEST_INTER_TJ.Interfaces.IGestionTJ;

namespace GEST_INTER_TJ.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GestionesController : Controller
    {
        private readonly IGestionesTJ vGestiones;

        public GestionesController(IGestionesTJ gestiones)
        {
            vGestiones = gestiones;
        }


        [HttpPost]
        [Route("GrabaTramite")]
        public ActionResult<clsGrabaTramiteOut> GrabaTramite(clsGrabaTramiteIN pInput)
        {
            clsGrabaTramiteOut resultado = vGestiones.GrabaTramite(pInput);

            if (resultado.CodRespInterno != clsCodigoRespuesta.Exito)
            {
                return BadRequest(resultado);
            }
            return Ok(resultado);

        }

    }
}
