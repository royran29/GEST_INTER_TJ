using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GEST_INTER_TJ.Utils;

namespace GEST_INTER_TJ.Datos
{
    public class AccesoServicios
    {

        #region Canales

        /// <summary>
        /// Permite obtener el Identificador Syscards de una tarjeta por medio de datos como empresa, 
        /// identificación del TH y los últimos 4 dígitos de la tarjeta.
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        public clsRecuperaIdTCOUT RecuperaIDTCDAO(clsRecuperaIdTCIN pInput)
        {
            clsRecuperaIdTCOUT vResultado = new clsRecuperaIdTCOUT();

            try
            {

              /*  SR_INTERFACE_CANALES.MetodosClient vInterfaceConsulta = new SR_INTERFACE_CANALES.MetodosClient();
                //REQUEST
                SR_INTERFACE_CANALES.Tarjetas_RecuperaIDTCRequest vRequestRecuperaID = new SR_INTERFACE_CANALES.Tarjetas_RecuperaIDTCRequest();
                //RESPONSE
                SR_INTERFACE_CANALES.Tarjetas_RecuperaIDTCResponse vResponseRecuperaID = new SR_INTERFACE_CANALES.Tarjetas_RecuperaIDTCResponse();

                //SETEO DE VALORES
                vRequestRecuperaID.rtEmpresa = pInput.Empresa;
                vRequestRecuperaID.rtIdentifica = pInput.Identifica;
                vRequestRecuperaID.rtTipoIdent = pInput.TipoIdent;
                vRequestRecuperaID.rtUltDigitos = pInput.UltDigitos;
                vRequestRecuperaID.rtEntidad = pInput.Entidad;
                vRequestRecuperaID.rtOficina = pInput.Oficina;

                vInterfaceConsulta.Tarjetas_RecuperaIDTC(vRequestRecuperaID.rtEmpresa,
                                                       vRequestRecuperaID.rtIdentifica,
                                                       vRequestRecuperaID.rtTipoIdent,
                                                       vRequestRecuperaID.rtUltDigitos,
                                                       vRequestRecuperaID.rtOficina,
                                                       vRequestRecuperaID.rtEntidad,
                                                       ref vResponseRecuperaID.rtTarjetaId,
                                                       ref vResponseRecuperaID.rtCodCliente,
                                                       ref vResponseRecuperaID.rtCodMigracion,
                                                       ref vResponseRecuperaID.rtCuenta,
                                                       ref vResponseRecuperaID.rtCodRespInterno,
                                                       ref vResponseRecuperaID.rtMensaje);*/

               

                    vResultado.CodRespInterno = clsCodigoRespuesta.Exito;
                    vResultado.Mensaje = clsMensajes.Exito;
               

            }
            catch (Exception ex)
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Error;
                vResultado.Mensaje = clsMensajes.ErrorRegistro;
                
            }
            return vResultado;
        }


        /// <summary>
        /// Permite consultar las transacciones confirmadas y flotantes en un rango de fecha para 
        /// una tarjeta específica.Rango máximo de consulta 60 días.
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        public clsConsultaTransaccionesOUT ConsultaTransaccionesDAO(clsConsultaTransaccionesIN pInput) 
        {
            clsConsultaTransaccionesOUT vResultado = new clsConsultaTransaccionesOUT();

            try
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Exito;
                vResultado.Mensaje = clsMensajes.Exito;

            }
            catch (Exception ex)
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Error;
                vResultado.Mensaje = clsMensajes.ErrorRegistro;

            }
            return vResultado;
        }


        /// <summary>
        /// Para actualización de datos de cuenta 
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        public clsActualizaDatosOUT ActualizaDatosDAO(clsActualizaDatosIN pInput)
        {
            clsActualizaDatosOUT vResultado = new clsActualizaDatosOUT();

            try
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Exito;
                vResultado.Mensaje = clsMensajes.Exito;


            }
            catch (Exception ex)
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Error;
                vResultado.Mensaje = clsMensajes.ErrorRegistro;

            }
            return vResultado;
        }


        /// <summary>
        ///  Retiro de Efectivo con Tarjeta de Crédito
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        public clsRetiroCanalesOUT RetiroCanalesDAO(clsRetiroCanalesIN pInput)
        {
            clsRetiroCanalesOUT vResultado = new clsRetiroCanalesOUT();

            try
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Exito;
                vResultado.Mensaje = clsMensajes.Exito;


            }
            catch (Exception ex)
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Error;
                vResultado.Mensaje = clsMensajes.ErrorRegistro;

            }
            return vResultado;
        }


        /// <summary>
        /// Consulta de Saldos de Tarjeta de Crédito 
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        public clsConsultaSaldosOUT ConsultaSaldosDAO(clsConsultaSaldosIN pInput)
        {
            clsConsultaSaldosOUT vResultado = new clsConsultaSaldosOUT();

            try
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Exito;
                vResultado.Mensaje = clsMensajes.Exito;


            }
            catch (Exception ex)
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Error;
                vResultado.Mensaje = clsMensajes.ErrorRegistro;

            }
            return vResultado;
        }


        /// <summary>
        /// Pago/Abono Tarjeta de Crédito 
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        public clsPagoCanalesOUT PagoCanalesDAO(clsPagoCanalesIN pInput)
        {
            clsPagoCanalesOUT vResultado = new clsPagoCanalesOUT();

            try
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Exito;
                vResultado.Mensaje = clsMensajes.Exito;


            }
            catch (Exception ex)
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Error;
                vResultado.Mensaje = clsMensajes.ErrorRegistro;

            }
            return vResultado;
        }


        /// <summary>
        /// Consultar los Programas de Lealtad
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        public clsConsultaProgramasOUT ConsultaProgramasDAO(clsConsultaProgramasIN pInput)
        {
            clsConsultaProgramasOUT vResultado = new clsConsultaProgramasOUT();

            try
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Exito;
                vResultado.Mensaje = clsMensajes.Exito;


            }
            catch (Exception ex)
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Error;
                vResultado.Mensaje = clsMensajes.ErrorRegistro;

            }
            return vResultado;
        }


        /// <summary>
        /// Redimir Puntos
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        public clsRedencionOUT RedencionPuntosDAO(clsRedencionIN pInput)
        {
            clsRedencionOUT vResultado = new clsRedencionOUT();

            try
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Exito;
                vResultado.Mensaje = clsMensajes.Exito;


            }
            catch (Exception ex)
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Error;
                vResultado.Mensaje = clsMensajes.ErrorRegistro;

            }
            return vResultado;
        }


        /// <summary>
        /// Actualización de tipo de cambio 
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        public clsTipoCambioActualizaOUT TipoCambioActualizaDAO(clsTipoCambioActualizaIN pInput)
        {
            clsTipoCambioActualizaOUT vResultado = new clsTipoCambioActualizaOUT();

            try
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Exito;
                vResultado.Mensaje = clsMensajes.Exito;


            }
            catch (Exception ex)
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Error;
                vResultado.Mensaje = clsMensajes.ErrorRegistro;

            }
            return vResultado;
        }

        #endregion


        #region Clientes


        /// <summary>
        /// Entrada para mantenimiento de clientes
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        public clsGrabaClientesOut GrabaClientesDAO(clsGrabaClientesIn pInput)
        {
            clsGrabaClientesOut vResultado = new clsGrabaClientesOut();

            try
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Exito;
                vResultado.Mensaje = clsMensajes.Exito;

            }
            catch (Exception ex)
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Error;
                vResultado.Mensaje = clsMensajes.ErrorRegistro;

            }
            return vResultado;
        }


        /// <summary>
        /// Entrada para mantenimiento de direcciones 
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        public clsGrabaDireccionesOut GrabaDireccionesDAO(clsGrabaDireccionesIn pInput)
        {
            clsGrabaDireccionesOut vResultado = new clsGrabaDireccionesOut();

            try
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Exito;
                vResultado.Mensaje = clsMensajes.Exito;

            }
            catch (Exception ex)
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Error;
                vResultado.Mensaje = clsMensajes.ErrorRegistro;

            }
            return vResultado;
        }


        /// <summary>
        /// Entrada para mantenimiento de telefonos 
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        public clsGrabaTelefonosOut GrabaTelefonosDAO(clsGrabaTelefonosIn pInput)
        {
            clsGrabaTelefonosOut vResultado = new clsGrabaTelefonosOut();

            try
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Exito;
                vResultado.Mensaje = clsMensajes.Exito;

            }
            catch (Exception ex)
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Error;
                vResultado.Mensaje = clsMensajes.ErrorRegistro;

            }
            return vResultado;
        }


        #endregion


        #region Gestiones

        /// <summary>
        /// Procedimiento que graba tramites
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        public clsGrabaTramiteOut GrabaTramiteDAO(clsGrabaTramiteIN pInput)
        {
            clsGrabaTramiteOut vResultado = new clsGrabaTramiteOut();

            try
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Exito;
                vResultado.Mensaje = clsMensajes.Exito;

            }
            catch (Exception ex)
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Error;
                vResultado.Mensaje = clsMensajes.ErrorRegistro;

            }
            return vResultado;
        }


        #endregion


        #region HSM
        /// <summary>
        /// Interface de entrada para generación de Pin
        /// </summary>
        /// <param name="pInput"></param>
        /// <returns></returns>
        public clsGenPinPvvOut GenPinPVVDAO(clsGenPinPvvIn pInput)
        {
            clsGenPinPvvOut vResultado = new clsGenPinPvvOut();

            try
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Exito;
                vResultado.Mensaje = clsMensajes.Exito;

            }
            catch (Exception ex)
            {
                vResultado.CodRespInterno = clsCodigoRespuesta.Error;
                vResultado.Mensaje = clsMensajes.ErrorRegistro;

            }
            return vResultado;
        }
        #endregion
    }
}
