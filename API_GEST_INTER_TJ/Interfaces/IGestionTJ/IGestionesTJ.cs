using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GEST_INTER_TJ.Utils;

namespace GEST_INTER_TJ.Interfaces.IGestionTJ
{
    public interface IGestionesTJ
    {

        #region Canales

        clsRecuperaIdTCOUT RecuperaIdTC(clsRecuperaIdTCIN pInput);

        clsActualizaDatosOUT ActualizaDatos(clsActualizaDatosIN pInput);

        clsConsultaTransaccionesOUT ConsultaTransacciones(clsConsultaTransaccionesIN pInput);

        clsRetiroCanalesOUT RetiroCanales(clsRetiroCanalesIN pInput);

        clsConsultaSaldosOUT ConsultaSaldos(clsConsultaSaldosIN pInput);

        clsPagoCanalesOUT PagoCanales(clsPagoCanalesIN pInput);

        clsConsultaProgramasOUT ConsultaProgramas(clsConsultaProgramasIN pInput);

        clsRedencionOUT RedencionPuntos(clsRedencionIN pInput);

        clsTipoCambioActualizaOUT TipoCambioActualiza(clsTipoCambioActualizaIN pInput);

        #endregion


        #region Clientes

        clsGrabaClientesOut GrabaClientes(clsGrabaClientesIn pInput);

        clsGrabaDireccionesOut GrabaDirecciones(clsGrabaDireccionesIn pInput);

        clsGrabaTelefonosOut GrabaTelefonos(clsGrabaTelefonosIn pInput);

        #endregion


        #region Gestiones

        clsGrabaTramiteOut GrabaTramite(clsGrabaTramiteIN pInput);

        #endregion

        #region HSM

        clsGenPinPvvOut GenPinPVV(clsGenPinPvvIn pInput);

        #endregion

    }
}
