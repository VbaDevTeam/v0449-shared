using System;
using System.Collections.Generic;
using System.Text;

namespace v0449_shared.CL.DEF
{
  public class DefAiCh
  {
    #region Canali analogici

    #region AI1

    public enum chNoS7ai
    {
      pPrInternal_c      // Press. interno banco
      , tAusiliaria_d      // 
      , tVascaFrigo_d      // Temp. vasca frigo
      , tCentrOleod_d      // Temp. olio centralina
      , pHpChiller1_c      // HP frigo 1
      , pLpChiller1_c      // LP frigo 1
      , pHpChiller2_c      // HP frigo 2
      , pLpChiller2_c      // LP frigo 2
      , tHpChiller1_d      // Temp. liq. frigo 1
      , tLpChiller1_d      // Temp. vap. frigo 1
      , tHpChiller2_d      // Temp. liq. frigo 2
      , tLpChiller2_d      // Temp. vap. frigo 2
      , qRfrSecSalt_d      // Port. refr. scamb. secondo salto
      , qRfrPriSalt_d      // Port. refr. scamb. primo salto
      , qRfrMainRaf_d      // Port. refr. scamb. principale
      , mpAlimento_00      // Perc. veloc. pompa alimento
      , mpRafInter_00      // Perc. veloc. pompa circ. interm.

      , pProvaMonte_c      // Press.monte UUT
      , pProvaValle_c      // Press.valle UUT
      , tProvaMonte_d      // Temp.monte UUT
      , tProvaValle_d      // Temp.valle UUT
      , tCellaProva_d      // Temp.cella
      , qFluidProva_c      // Portata fluido prova
      , vEscursione_x      // Escursione vibrazione
      , vAccelerazi_x      // Accelerazione vibrazione
      , tRisc1Fluid_d      // Temp. risc. fluido 1
      , tRisc2Fluid_d      // Temp. risc. fluido 2
      , tCircInterm_d      // Temp. circ. intermedio raffr.
      , tIrradiator_d      // Temp. cartuccia irraggiamento (496)
      , vpRaffMain_00      // Pos. virt. valv. raff. princ.
      , vpRaffInte_00      // Pos. virt. valv. raff. II salto
      , mpCircProv_00      // Perc. veloc. pompa circolazione
    }

    public static string[] aiChNamesS7 =
      {
       "pPrInternal_c"
      ,"tAusiliaria_d"
      ,"tVascaFrigo_d"
      ,"tCentrOleod_d"
      ,"pHpChiller1_c"
      ,"pLpChiller1_c"
      ,"pHpChiller2_c"
      ,"pHpChiller3_c"
      ,"tHpChiller1_d"
      ,"tLpChiller1_d"
      ,"tHpChiller2_d"
      ,"tLpChiller2_d"
      ,"qRfrSecSalt_d"
      ,"qRfrPriSalt_d"
      ,"qRfrMainRaf_d"
      ,"mpAlimento_00"
      ,"mpRafInter_00"

      ,"pProvaMonte_c"
      ,"pProvaValle_c"
      ,"tProvaMonte_d"
      ,"tProvaValle_d"
      ,"tCellaProva_d"
      ,"qFluidProva_c"
      ,"vEscursione_x"
      ,"vAccelerazi_x"
      ,"tRisc1Fluid_d"
      ,"tRisc2Fluid_d"
      ,"tCircInterm_d"
      ,"vpRaffMain_00"
      ,"vpRaffInte_00"
      ,"mpCircProv_00"
      ,"tIrradiator_d"
    };


    #region AI1 label short Siemens

    public static string[] aiLabelShortS7 =
      {
        "Press. interno banco             "
      , "                                 "
      , "Temp. vasca frigo                "
      , "Temp. olio centralina            "
      , "HP frigo 1                       "
      , "LP frigo 1                       "
      , "HP frigo 2                       "
      , "LP frigo 2                       "
      , "Temp. liq. frigo 1               "
      , "Temp. vap. frigo 1               "
      , "Temp. liq. frigo 2               "
      , "Temp. vap. frigo 2               "
      , "Port. refr. scamb. secondo salto "
      , "Port. refr. scamb. primo salto   "
      , "Port. refr. scamb. principale    "
      , "Perc. veloc. pompa alimento      "
      , "Perc. veloc. pompa circ. interm. "

      , "Press.monte UUT                  "
      , "Press.valle UUT                  "
      , "Temp.monte UUT                   "
      , "Temp.valle UUT                   "
      , "Temp.cella                       "
      , "Portata fluido prova             "
      , "Escursione vibrazione            "
      , "Accelerazione vibrazione         "
      , "Temp. risc. fluido 1             "
      , "Temp. risc. fluido 2             "
      , "Temp. circ. intermedio raffr.    "
      , "Pos. virt. valv. raff. princ.    "
      , "Pos. virt. valv. raff. II salto  "
      , "Perc. veloc. pompa circolazione  "
      , "Temp. irradiatore                "
      };

    #endregion

    #region AI1 label Long Siemens

    public static string[] aiLabelLongS7 =
      {
        "Press. interno banco             "
      , "                                 "
      , "Temp. vasca frigo                "
      , "Temp. olio centralina            "
      , "HP frigo 1                       "
      , "LP frigo 1                       "
      , "HP frigo 2                       "
      , "LP frigo 2                       "
      , "Temp. liq. frigo 1               "
      , "Temp. vap. frigo 1               "
      , "Temp. liq. frigo 2               "
      , "Temp. vap. frigo 2               "
      , "Port. refr. scamb. secondo salto "
      , "Port. refr. scamb. primo salto   "
      , "Port. refr. scamb. principale    "
      , "Perc. veloc. pompa alimento      "
      , "Perc. veloc. pompa circ. interm. "

      , "Press.monte UUT                  "
      , "Press.valle UUT                  "
      , "Temp.monte UUT                   "
      , "Temp.valle UUT                   "
      , "Temp.cella                       "
      , "Portata fluido prova             "
      , "Escursione vibrazione            "
      , "Accelerazione vibrazione         "
      , "Temp. risc. fluido 1             "
      , "Temp. risc. fluido 2             "
      , "Temp. circ. intermedio raffr.    "
      , "Pos. virt. valv. raff. princ.    "
      , "Pos. virt. valv. raff. II salto  "
      , "Perc. veloc. pompa circolazione  "
      , "Temp. irradiatore                "
    };
    #endregion
    #endregion


    #endregion
  }
}
