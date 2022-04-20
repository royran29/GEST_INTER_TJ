using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GEST_INTER_TJ.Utils
{
    public class clsUtils
    {
    }

    #region General

    /// <summary>
    /// Codigos de respuesta
    /// </summary>
    public static class clsCodigoRespuesta
    {
        public static readonly string Exito = "0000";
        public static readonly string Error = "9999";

    }


    /// <summary>
    /// Mensajes para retroalimentacion
    /// </summary>
    public static class clsMensajes
    {
        public static readonly string Exito = "Exito";
        public static readonly string ValoresRequeridos = "Todos los valores de entrada son requeridos";
        public static readonly string ErrorRegistro = "Problemas al realizar el registro, por favor intente nuevamente.";
    }


    /// <summary>
    /// Tipos de forma de pago
    /// </summary>
    public static class clsTipoPago
    {
        public static readonly string Efectivo = "1";
        public static readonly string TranfInterna = "2";
        public static readonly string TranfExterna = "3";
        public static readonly string Cheque = "4";
        public static readonly string Otro = "5";
    } 
    #endregion


    #region Canales


    #region Tarjeta_RecuperaIDTC
    public class clsRecuperaIdTCIN
    {
        public Int16 Empresa { get; set; }
        public string Identifica { get; set; }
        public string TipoIdent { get; set; }
        public string UltDigitos { get; set; }
        public int Entidad { get; set; }
        public string Oficina { get; set; }
      

    }

    public class clsRecuperaIdTCOUT
    {
        public string TarjetaId { get; set; }
        public int CodCliente { get; set; }
        public int CodMigracion { get; set; }
        public int Cuenta { get; set; }
        public string CodRespInterno { get; set; }
        public string Mensaje { get; set; }
    }

    #endregion

    #region Tarjeta_ConsultaTransacciones
    public class clsConsultaTransaccionesIN
    {
        public string TarjetaID { get; set; }
        public Int16 Empresa { get; set; }
        public int Entidad { get; set; }
        public string FechaDesde { get; set; }
        public string FechaHasta { get; set; }
        public string Usuario { get; set; }
        public string TipoMov { get; set; }

    }

    public class clsConsultaTransaccionesOUT
    {
        public List<DetalleMovimientos> Movimientos { get; set; }
        public string Mensaje { get; set; }

        public string CodRespInterno { get; set; }
    }


    public class DetalleMovimientos
    {
        public string TipoMov { get; set; }
        public int Lote { get; set; }
        public int Secuencia { get; set; }
        public string Autorizacion { get; set; }
        public string FechaTransaccion { get; set; }
        public string FechaProceso { get; set; }
        public string NumeroReferencia { get; set; }
        public string DescripcionComercio { get; set; }
        public decimal MontoAutorizacion { get; set; }
        public string Moneda { get; set; }
        public string TipoTrx { get; set; }
        public string Razon { get; set; }
        public string Transcode { get; set; }
        public string CodMovimientoExt { get; set; }
        public string DescripcionMovimiento { get; set; }
    }


    #endregion

    #region Cuenta_ActualizaDatos
    public class clsActualizaDatosIN
    {
        public string Usuario { get; set; }
        public string Estacion { get; set; }
        public string Oficina { get; set; }
        public int Entidad { get; set; }
        public Int16 Empresa { get; set; }
        public int CuentaCliente { get; set; }
        public string Email { get; set; }
        public string FormaPago { get; set; }

    }

    public class clsActualizaDatosOUT
    {
        public string Mensaje { get; set; }
        public string CodRespInterno { get; set; }
    }

    #endregion

    #region Tarjeta_RetiroCanales
    public class clsRetiroCanalesIN
    {
        public Int16 Empresa { get; set; }
        public string Tarjeta { get; set; }
        public string TarjetaId { get; set; }
        public string Dispositivo { get; set; }
        public string Expira { get; set; }/*mmyy*/
        public int Entidad { get; set; } /**/
        public string GiroEst { get; set; }
        public string FchSis { get; set; }
        public decimal Monto { get; set; }
        public string MerchantName { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public string Oficina { get; set; }/**/
        public string Reverso { get; set; }
        public string CodSeguridad { get; set; }
        public string TipoExtraf { get; set; }
        public string PlazoExtraf { get; set; }
        public string Moneda { get; set; }
        public string Identifica { get; set; }/**/
        public string TipoIdent { get; set; }/**/
        public string PosCondCode { get; set; }
        public string OrigenTrn { get; set; }
        public string Autoriza { get; set; }

    }

    public class clsRetiroCanalesOUT
    {
        public string Autoriza { get; set; }
        public decimal Disponible { get; set; }
        public string CodRespInterno { get; set; }
        public string Mensaje { get; set; }
    }

    #endregion

    #region Tarjeta_ConsultaSaldos
    public class clsConsultaSaldosIN
    {
        public string Tarjeta { get; set; }
        public string TarjetaId { get; set; }
        public string Moneda { get; set; }
        public int Entidad { get; set; }
        public Int16 Empresa { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaTrn { get; set; }
        public string HoraTrn { get; set; }

    }

    public class clsConsultaSaldosOUT
    {
        public string Afinidad { get; set; }
        public string DescAfinidad { get; set; }
        public string PrinciAdicio { get; set; }
        public string PlNombre1 { get; set; }
        public string EstadosTC { get; set; }
        public string EstadosTCExt { get; set; }
        public string EstadosCta { get; set; }
        public string EstadosCtaExt { get; set; }
        public int Cuenta { get; set; }
        public decimal TasaRotativo { get; set; }
        public decimal CupoRotativo { get; set; }
        public decimal SaldoActual { get; set; }
        public decimal Compras { get; set; }
        public decimal Avances { get; set; }
        public decimal Pagos { get; set; }
        public decimal Creditos { get; set; }
        public decimal Debitos { get; set; }
        public decimal AutorizacionesRot { get; set; }
        public decimal DisponibleRotativo { get; set; }
        public decimal DisponibleAdelanto { get; set; }
        public decimal PagoMinimo { get; set; }
        public decimal SaldoContado { get; set; }
        public decimal PmVencido030 { get; set; }
        public decimal PmVencido060 { get; set; }
        public decimal PmVencido090 { get; set; }
        public decimal PmVencido90m { get; set; }
        public decimal MonPagosVenci { get; set; }
        public decimal NumPagosVenci { get; set; }
        public int DiasVencidos { get; set; }
        public string PagosUltFch { get; set; }
        public decimal MontoUltpago { get; set; }
        public string FchTopePago { get; set; }
        public int DiaCorte { get; set; }
        public decimal Sobregiro { get; set; }
        public string FchCorteActual { get; set; }
        public decimal SaldoAnterior { get; set; }
        public decimal ComprasCorte { get; set; }
        public decimal AvancesCorte { get; set; }
        public decimal InteresCorte { get; set; }
        public decimal CargosCorte { get; set; }
        public decimal DebitosCorte { get; set; }
        public decimal PagosCorte { get; set; }
        public decimal CreditosCorte { get; set; }
        public decimal SaldoCorte { get; set; }
        public decimal CargosBonificablesCorte { get; set; }
        public decimal CargoNoBonificables { get; set; }
        public decimal CreditosAplicadosEF { get; set; }
        public decimal CreditoTransito { get; set; }
        public decimal DebitosAplicadosEF { get; set; }
        public decimal DebitoTransito { get; set; }
        public decimal DisponibleEF { get; set; }
        public decimal LimiteEF { get; set; }
        public decimal RecargoCuotaVencida { get; set; }
        public decimal SaldoFinalEF { get; set; }
        public decimal SaldoFinalPlazo { get; set; }
        public decimal SaldoInicialEF { get; set; }
        public string Mensaje { get; set; }
        public string CodRespInterno { get; set; }
    }
    #endregion

    #region Tarjeta_PagoCanales

    public class clsPagoCanalesIN
    {
        public string Tarjeta { get; set; }
        public string TarjetaId { get; set; }
        public string OrigenTrn { get; set; }
        public string Usuario { get; set; }
        public string TerminalID { get; set; }
        public string Oficina { get; set; }
        public decimal MontoEfec { get; set; }
        public string Moneda { get; set; }
        public string Reverso { get; set; }
        public Int16 Empresa { get; set; }
        public int Entidad { get; set; }
        public string TipoPago { get; set; }
        public string ReferenciaExtraf { get; set; }
        public string CodigoEmisorCheque { get; set; }
        public string NumeroCheque { get; set; }
        public string PlazaCheque { get; set; }


        /// <summary>
        /// Valida que TipoPago no sea vacio y si es cheque los campos CodigoEmisorCheque, NumeroCheque, NumeroCheque no deben ser vacios.
        /// </summary>
        /// <returns>True si se cumplen las condiciones, False en caso contrario</returns>
        public bool ValidaTipoPago()
        {
            if (String.IsNullOrEmpty(TipoPago))
                return false;
            else
            {
                if (TipoPago == clsTipoPago.Cheque)
                {
                    if (!String.IsNullOrEmpty(CodigoEmisorCheque)
                        && !String.IsNullOrEmpty(NumeroCheque)
                        && !String.IsNullOrEmpty(NumeroCheque))
                    {
                        return true;
                    }
                  return false;
                }
                return true;
            }
        }

    }

    public class clsPagoCanalesOUT
    {
        public string Referencia { get; set; }
        public int Lote { get; set; }
        public int Secuencia { get; set; }
        public decimal SaldoActual { get; set; }
        public string CodRespInterno { get; set; }
        public string Mensaje { get; set; }
    }
    #endregion

    #region Puntos_ConsultaProgramas
    public class clsConsultaProgramasIN
    {
        public string Usuario { get; set; }
        public string Estacion { get; set; }
        public int Entidad { get; set; }
        public Int16 Empresa { get; set; }
        public string Idtarjeta { get; set; }

    }

    public class clsConsultaProgramasOUT
    {
        public List<DetalleProgramaLealtad> plProgramas { get; set; }
        public string Mensaje { get; set; }
        public string CodRespInterno { get; set; }
    }

    public class DetalleProgramaLealtad
    {
        public string CodPlan { get; set; }
        public string DescripciónPlan { get; set; }
        public Int32 PuntosDisponibles { get; set; }
        public string FechaVencimiento { get; set; }
    }
    #endregion

    #region Puntos_Redencion

    public class clsRedencionIN
    {
        public string Usuario { get; set; }
        public string Estacion { get; set; }
        public string Oficina { get; set; }
        public int Entidad { get; set; }
        public Int16 Empresa { get; set; }
        public string TarjetaId { get; set; }
        public string CodigoPlan { get; set; }
        public string CodMovimientoExt { get; set; }
        public string Moneda { get; set; }
        public string Comercio { get; set; }
        public string Puntos { get; set; }
        public string TipoTrx { get; set; }
        public string Razon { get; set; }
        public string Observacion { get; set; }

    }

    public class clsRedencionOUT
    {
        public string Mensaje { get; set; }
        public string CodRespInterno { get; set; }
    }
    #endregion

    #region TipoCambio_Actualiza
    public class clsTipoCambioActualizaIN
    {
        public string Usuario { get; set; }
        public string Estacion { get; set; }
        public Int16 Empresa { get; set; }
        public string MonedaOrigen { get; set; }
        public string MonedaDestino { get; set; }
        public string Operacion { get; set; }
        public decimal Factor { get; set; }

    }

    public class clsTipoCambioActualizaOUT
    {
        public string Mensaje { get; set; }
        public string CodRespInterno { get; set; }
    }

    #endregion


    #endregion


    #region Gestiones


    #endregion


    #region Clientes

    #region Clientes_GrabaClientes
    public class clsGrabaClientesIn
    {
        public string Usuario { get; set; }
        public string Estacion { get; set; }
        public string Oficina { get; set; }
        public string Identifica { get; set; }
        public string TipoIdent { get; set; }
        public string PaisIdent { get; set; }
        public string DepartIdent { get; set; }
        public string MunIdent { get; set; }
        public string DistritoIdent { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string ApellidoCasada { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string TercerNombre { get; set; }
        public string FchNacimie { get; set; }
        public string PaisNacimie { get; set; }
        public string DepartNacimie { get; set; }
        public string MuniNacimie { get; set; }
        public string DistritoNacimie { get; set; }
        public string Situacion { get; set; }
        public string ActEconomica { get; set; }
        public string Nacionalidad { get; set; }
        public string EstadoCivil { get; set; }
        public string Profesion { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string Instruccion { get; set; }
        public string CodTributario { get; set; }
        public String FchIngresoPais { get; set; }
        public string TituloPersona { get; set; }
        public Int16 Empresa { get; set; }
        public Int16 Entidad { get; set; }
        public String CodMigracion { get; set; }
        public Int32 CodMigracionConyuge { get; set; }

    }

    public class clsGrabaClientesOut
    {
        public string Mensaje { get; set; }
        public Int32 Codigocliente { get; set; }
        public string CodRespInterno { get; set; }
    }

    #endregion

    #region Clientes_GrabaDirecciones
    public class clsGrabaDireccionesIn
    {
        public string Usuario { get; set; }
        public string Estacion { get; set; }
        public string Oficina { get; set; }
        public string TipoDirec { get; set; }
        public string TipoVivienda { get; set; }
        public string Zona { get; set; }
        public string Direccion { get; set; }
        public string Arrendador { get; set; }
        public string Pais { get; set; }
        public string Provincia { get; set; }
        public string Ciudad { get; set; }
        public string Distrito { get; set; }
        public string RutaDeEntrega { get; set; }
        public string DirCodPostal { get; set; }
        public string MarcaEnvio { get; set; }
        public string MarcaEnvioPlas { get; set; }
        public Int16 Empresa { get; set; }
        public Int16 Entidad { get; set; }
        public Int32 Codigo { get; set; }
    }

    public class clsGrabaDireccionesOut
    {
        public string Mensaje { get; set; }
        public string CodRespInterno { get; set; }
    }
    #endregion

    #region Clientes_GrabaTelefonos

    public class clsGrabaTelefonosIn
    {
        public string UltUserActualiza { get; set; }
        public string UltEstacionActualiza { get; set; }
        public string Oficina { get; set; }
        public string TipoTelf { get; set; }
        public string Telefono { get; set; }
        public string Extencion { get; set; }
        public string Telefono2 { get; set; }
        public string Extencion2 { get; set; }
        public string CodigoArea { get; set; }
        public string CodigoArea2 { get; set; }
        public string CodigoArea3 { get; set; }
        public string Telefono3 { get; set; }
        public string Extencion3 { get; set; }
        public string Principal { get; set; }
        public int Empresa { get; set; }
        public int Entidad { get; set; }
        public int Codigo { get; set; }
    }
    public class clsGrabaTelefonosOut
    {
        public string Mensaje { get; set; }
        public string CodRespInterno { get; set; }
    }
    #endregion

    #endregion


}
