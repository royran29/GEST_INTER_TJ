using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GEST_INTER_TJ.Utils;
using GEST_INTER_TJ.Interfaces.IGestionTJ;
using GEST_INTER_TJ.Interfaces;

namespace GEST_INTER_TJ.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CanalesController : Controller
    {
        private readonly IGestionesTJ vGestiones;

        public CanalesController(IGestionesTJ gestiones)
        {
            vGestiones = gestiones;
        }


        /// <summary>
        /// Permite obtener el Identificador Syscards de una tarjeta por medio de datos como empresa, 
        /// identificación del TH y los últimos 4 dígitos de la tarjeta.
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("RecuperaIDTC")]
        public ActionResult<clsRecuperaIdTCOUT> RecuperaIDTC(clsRecuperaIdTCIN pInput)
        {
            clsRecuperaIdTCOUT resultado = vGestiones.RecuperaIdTC(pInput);

            if (resultado.CodRespInterno != clsCodigoRespuesta.Exito)
            {
                return BadRequest(resultado);
            }

            return Ok(resultado);

        }

        /// <summary>
        /// Permite consultar las transacciones confirmadas y flotantes en un rango de fecha para 
        /// una tarjeta específica.Rango máximo de consulta 60 días
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ConsultaTransacciones")]
        public ActionResult<clsConsultaTransaccionesOUT> ConsultaTransacciones(clsConsultaTransaccionesIN pInput)
        {
            clsConsultaTransaccionesOUT resultado = vGestiones.ConsultaTransacciones(pInput);

            if (resultado.CodRespInterno != clsCodigoRespuesta.Exito)
            {
                return BadRequest(resultado);
            }

            return Ok(resultado);
        }


        /// <summary>
        /// Para actualización de datos de cuenta
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ActualizaDatos")]
        public ActionResult<clsActualizaDatosOUT> ActualizaDatos(clsActualizaDatosIN pInput)
        {
            clsActualizaDatosOUT resultado = vGestiones.ActualizaDatos(pInput);

            if (resultado.CodRespInterno != clsCodigoRespuesta.Exito)
            {
                return BadRequest(resultado);
            }

            return Ok(resultado);
        }


        /// <summary>
        /// Retiro de Efectivo con Tarjeta de Crédito
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("RetiroCanales")]
        public ActionResult<clsRetiroCanalesOUT> RetiroCanales(clsRetiroCanalesIN pInput)
        {
            clsRetiroCanalesOUT resultado = vGestiones.RetiroCanales(pInput);

            if (resultado.CodRespInterno != clsCodigoRespuesta.Exito)
            {
                return BadRequest(resultado);
            }

            return Ok(resultado);

        }


        /// <summary>
        /// Consulta de Saldos de Tarjeta de Crédito
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ConsultaSaldos")]
        public ActionResult<clsConsultaSaldosOUT> ConsultaSaldos(clsConsultaSaldosIN pInput)
        {
            clsConsultaSaldosOUT resultado = vGestiones.ConsultaSaldos(pInput);

            if (resultado.CodRespInterno != clsCodigoRespuesta.Exito)
            {
                return BadRequest(resultado);
            }

            return Ok(resultado);
        }


        /// <summary>
        /// Pago/Abono Tarjeta de Crédito 
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("PagoCanales")]
        public ActionResult<clsPagoCanalesOUT> PagoCanales(clsPagoCanalesIN pInput)
        {
            clsPagoCanalesOUT resultado = vGestiones.PagoCanales(pInput);

            if (resultado.CodRespInterno != clsCodigoRespuesta.Exito)
            {
                return BadRequest(resultado);
            }

            return Ok(resultado);
        }


        /// <summary>
        /// Consultar los Programas de Lealtad 
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ConsultaProgramas")]
        public ActionResult<clsConsultaProgramasOUT> ConsultaProgramas(clsConsultaProgramasIN pInput)
        {
            clsConsultaProgramasOUT resultado = vGestiones.ConsultaProgramas(pInput);

            if (resultado.CodRespInterno != clsCodigoRespuesta.Exito)
            {
                return BadRequest(resultado);
            }

            return Ok(resultado);
        }


        /// <summary>
        /// Rendencion de puntos
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("RedencionPuntos")]
        public ActionResult<clsRedencionOUT> RendencionPuntos(clsRedencionIN pInput)
        {
            clsRedencionOUT resultado = vGestiones.RedencionPuntos(pInput);

            if (resultado.CodRespInterno != clsCodigoRespuesta.Exito)
            {
                return BadRequest(resultado);
            }

            return Ok(resultado);
        }


        /// <summary>
        /// Actualizacion de tipo de camibio
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("TipoCambioActualiza")]
        public ActionResult<clsTipoCambioActualizaOUT> TipoCambioActualiza(clsTipoCambioActualizaIN pInput)
        {
            clsTipoCambioActualizaOUT resultado = vGestiones.TipoCambioActualiza(pInput);

            if (resultado.CodRespInterno != clsCodigoRespuesta.Exito)
            {
                return BadRequest(resultado);
            }

            return Ok(resultado);
        }
    }
}
