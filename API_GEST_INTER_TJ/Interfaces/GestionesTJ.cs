using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GEST_INTER_TJ.Interfaces.IGestionTJ;
using GEST_INTER_TJ.Utils;
using GEST_INTER_TJ.Datos;

namespace GEST_INTER_TJ.Interfaces
{
    public class GestionesTJ : IGestionesTJ
    {
   
        private readonly AccesoServicios vServicio;
        
        public GestionesTJ(AccesoServicios pServicio)
        {
            vServicio = pServicio;
        }

        /// <summary>
        /// Permite obtener el Identificador Syscards de una tarjeta por medio de datos como empresa, 
        /// identificación del TH y los últimos 4 dígitos de la tarjeta.
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        public clsRecuperaIdTCOUT RecuperaIdTC(clsRecuperaIdTCIN pInput)
        {
            clsRecuperaIdTCOUT vResultado = new clsRecuperaIdTCOUT();

            try
            {
                //Valida que los parametros no sean nulos
                if (!String.IsNullOrEmpty(pInput.Empresa.ToString())
                     && !String.IsNullOrEmpty(pInput.Identifica)
                     && !String.IsNullOrEmpty(pInput.TipoIdent)
                     && !String.IsNullOrEmpty(pInput.UltDigitos))
                {
                    vResultado = vServicio.RecuperaIDTCDAO(pInput);

                    return vResultado;
                }
                else
                {
                    vResultado.CodRespInterno = clsCodigoRespuesta.Error;
                    vResultado.Mensaje = clsMensajes.ValoresRequeridos;
                    return vResultado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Permite consultar las transacciones confirmadas y flotantes en un rango de fecha para una tarjeta específica.
        /// Rango máximo de consulta 60 días.
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        public clsConsultaTransaccionesOUT ConsultaTransacciones(clsConsultaTransaccionesIN pInput)
        {
            clsConsultaTransaccionesOUT vResultado = new clsConsultaTransaccionesOUT();

            try
            {
                //Valida que los parametros no sean nulos
                if (!String.IsNullOrEmpty(pInput.TarjetaID)
                    && !String.IsNullOrEmpty(pInput.Empresa.ToString())
                    && !String.IsNullOrEmpty(pInput.Entidad.ToString())
                    && !String.IsNullOrEmpty(pInput.FechaDesde)
                    && !String.IsNullOrEmpty(pInput.FechaHasta)
                    && !String.IsNullOrEmpty (pInput.Usuario)
                    )
                {
                    vResultado = vServicio.ConsultaTransaccionesDAO(pInput);
                    return vResultado;
                }
                else
                {
                    vResultado.CodRespInterno = clsCodigoRespuesta.Error;
                    vResultado.Mensaje = clsMensajes.ValoresRequeridos;
                    return vResultado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Interface de entrada para actualización de datos de cuenta 
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        public clsActualizaDatosOUT ActualizaDatos(clsActualizaDatosIN pInput)
        {
            clsActualizaDatosOUT vResultado = new clsActualizaDatosOUT();

            try
            {
                if (!String.IsNullOrEmpty(pInput.Usuario)
                    && !String.IsNullOrEmpty(pInput.Estacion)
                    && !String.IsNullOrEmpty(pInput.Oficina)
                    && !String.IsNullOrEmpty(pInput.Entidad.ToString())
                    && !String.IsNullOrEmpty (pInput.Empresa.ToString())
                    && !String.IsNullOrEmpty(pInput.CuentaCliente.ToString())
                    )
                {
                    vResultado = vServicio.ActualizaDatosDAO(pInput);
                    return vResultado;
                }
                else
                {
                    vResultado.CodRespInterno = clsCodigoRespuesta.Error;
                    vResultado.Mensaje = clsMensajes.ValoresRequeridos;
                    return vResultado;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        /// <summary>
        ///  Retiro de Efectivo con Tarjeta de Crédito
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public clsRetiroCanalesOUT RetiroCanales(clsRetiroCanalesIN pInput)
        {
            clsRetiroCanalesOUT vResultado = new clsRetiroCanalesOUT();

            try
            {
                if (!String.IsNullOrEmpty(pInput.Empresa.ToString())
                    && !String.IsNullOrEmpty(pInput.Dispositivo)
                    && !String.IsNullOrEmpty(pInput.Expira)
                    && !String.IsNullOrEmpty(pInput.GiroEst)
                    && !String.IsNullOrEmpty(pInput.FchSis)
                    && !String.IsNullOrEmpty(pInput.Monto.ToString())
                    && !String.IsNullOrEmpty(pInput.MerchantName)
                    && !String.IsNullOrEmpty(pInput.Ciudad)
                    && !String.IsNullOrEmpty(pInput.Reverso)
                    && !String.IsNullOrEmpty(pInput.CodSeguridad)
                    && !String.IsNullOrEmpty(pInput.Moneda)
                    && !String.IsNullOrEmpty(pInput.PosCondCode)
                    && !String.IsNullOrEmpty(pInput.OrigenTrn)
                    )
                {
                    vResultado = vServicio.RetiroCanalesDAO(pInput);
                    return vResultado;
                }
                else
                {
                    vResultado.CodRespInterno = clsCodigoRespuesta.Error;
                    vResultado.Mensaje = clsMensajes.ValoresRequeridos;
                    return vResultado;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        /// <summary>
        /// Consulta de Saldos de Tarjeta de Crédito 
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        public clsConsultaSaldosOUT ConsultaSaldos(clsConsultaSaldosIN pInput)
        {
            clsConsultaSaldosOUT vResultado = new clsConsultaSaldosOUT();

            try
            {
                if (!String.IsNullOrEmpty(pInput.Moneda)
                    && !String.IsNullOrEmpty(pInput.Empresa.ToString())
                    && !String.IsNullOrEmpty(pInput.Usuario)
                    && !String.IsNullOrEmpty(pInput.FechaTrn.ToString())
                    && !String.IsNullOrEmpty(pInput.HoraTrn)
                    )
                {
                    vResultado = vServicio.ConsultaSaldosDAO(pInput);
                    return vResultado;
                }
                else
                {
                    vResultado.CodRespInterno = clsCodigoRespuesta.Error;
                    vResultado.Mensaje = clsMensajes.ValoresRequeridos;
                    return vResultado;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        /// <summary>
        /// Pago/Abono Tarjeta de Crédito 
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        public clsPagoCanalesOUT PagoCanales(clsPagoCanalesIN pInput)
        {
            clsPagoCanalesOUT vResultado = new clsPagoCanalesOUT();

            try
            {
                if (!String.IsNullOrEmpty(pInput.OrigenTrn)
                    && !String.IsNullOrEmpty(pInput.Usuario)
                    && !String.IsNullOrEmpty(pInput.TerminalID)
                    && !String.IsNullOrEmpty(pInput.Oficina)
                    && !String.IsNullOrEmpty(pInput.MontoEfec.ToString())
                    && !String.IsNullOrEmpty(pInput.Moneda)
                    && !String.IsNullOrEmpty(pInput.Reverso)
                    //&& !String.IsNullOrEmpty(pInput.Referencia)
                    && !String.IsNullOrEmpty(pInput.Empresa.ToString())
                    && !String.IsNullOrEmpty(pInput.Entidad.ToString())
                    && pInput.ValidaTipoPago()
                    )
                {
                    vResultado = vServicio.PagoCanalesDAO(pInput);
                    return vResultado;
                }
                else
                {
                    vResultado.CodRespInterno = clsCodigoRespuesta.Error;
                    vResultado.Mensaje = clsMensajes.ValoresRequeridos;
                    return vResultado;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        /// <summary>
        /// Consultar los Programas de Lealtad 
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        public clsConsultaProgramasOUT ConsultaProgramas(clsConsultaProgramasIN pInput)
        {
            clsConsultaProgramasOUT vResultado = new clsConsultaProgramasOUT();

            try
            {
                if (!String.IsNullOrEmpty(pInput.Usuario)
                    && !String.IsNullOrEmpty(pInput.Estacion)
                    && !String.IsNullOrEmpty(pInput.Entidad.ToString())
                    && !String.IsNullOrEmpty(pInput.Empresa.ToString())
                    && !String.IsNullOrEmpty(pInput.Idtarjeta)
                    )
                {
                    vResultado = vServicio.ConsultaProgramasDAO(pInput);
                    return vResultado;
                }
                else
                {
                    vResultado.CodRespInterno = clsCodigoRespuesta.Error;
                    vResultado.Mensaje = clsMensajes.ValoresRequeridos;
                    return vResultado;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        /// <summary>
        /// Consultar los Programas de Lealtad 
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        public clsRedencionOUT RedencionPuntos(clsRedencionIN pInput)
        {
            clsRedencionOUT vResultado = new clsRedencionOUT();

            try
            {
                if (!String.IsNullOrEmpty(pInput.Usuario)
                    && !String.IsNullOrEmpty(pInput.Estacion)
                    && !String.IsNullOrEmpty(pInput.Oficina)
                    && !String.IsNullOrEmpty(pInput.Entidad.ToString())
                    && !String.IsNullOrEmpty(pInput.Empresa.ToString())
                    && !String.IsNullOrEmpty(pInput.TarjetaId)
                    && !String.IsNullOrEmpty(pInput.CodigoPlan)
                    && !String.IsNullOrEmpty(pInput.Puntos)
                    )
                {
                    vResultado = vServicio.RedencionPuntosDAO(pInput);
                    return vResultado;
                }
                else
                {
                    vResultado.CodRespInterno = clsCodigoRespuesta.Error;
                    vResultado.Mensaje = clsMensajes.ValoresRequeridos;
                    return vResultado;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        /// <summary>
        /// Actualización de tipo de cambio 
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        public clsTipoCambioActualizaOUT TipoCambioActualiza(clsTipoCambioActualizaIN pInput)
        {
            clsTipoCambioActualizaOUT vResultado = new clsTipoCambioActualizaOUT();

            try
            {
                if (!String.IsNullOrEmpty(pInput.Usuario)
                    && !String.IsNullOrEmpty(pInput.Estacion)
                    && !String.IsNullOrEmpty(pInput.Empresa.ToString())
                    && !String.IsNullOrEmpty(pInput.MonedaOrigen)
                    && !String.IsNullOrEmpty(pInput.MonedaDestino)
                    && !String.IsNullOrEmpty(pInput.Operacion)
                    && !String.IsNullOrEmpty(pInput.Factor.ToString())
                    )
                {
                    vResultado = vServicio.TipoCambioActualizaDAO(pInput);
                    return vResultado;
                }
                else
                {
                    vResultado.CodRespInterno = clsCodigoRespuesta.Error;
                    vResultado.Mensaje = clsMensajes.ValoresRequeridos;
                    return vResultado;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
