using System.Collections.Generic;

namespace v0449_shared
{
  public class DEF
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
    };
    #endregion
    #endregion

    #region DIRITTI

    public static string[] dirittiLabel =
    {
      "login      "
      ,"logoff  "
      ,"esci          "
      ,"gest. utenti  "
      ,"report        "
      ,"manutenzione  "
      ,"test"
    };

    public enum dirittiVal
    {
      Login = 0x0001,
      Logoff = 0x0002,
      Esci = 0x0004,
      GesUtenti = 0x0008,
      Report = 0x0010,
      Manutenzione = 0x0020,
      Test = 0x0040,
    }
    #endregion

    #endregion

#if v0449 || v0449b
     
    #region def



    
    #region Ao channel names Siemens

    public enum aoChNoS7
    {
      //SM 1232 AQ4, la prima, AO
      s7ANoJ120MAND
        , s7ANoJ200CIRC
        , s7ANoJ530RAFF
        , s7ANoRiserva3
    };

    public static string[] aoChNamesS7 =
      { 
        //SM 1232 AQ4, la prima, AO
        " s7ANoJ120MAND"              //21 - 0
        ,"s7ANoJ200CIRC"
        ,"s7ANoJ530RAFF"
        ,"s7ANoRiserva3"
      };
    #endregion

    #region Ao label short Siemens

    public static string[] aoLabelShortS7 =
      { 
        //SM 1232 AQ4, la prima, AO
        " Comando drive riempimento"
        ,"Comando drive circolazione"
        ,"Comando drive raffreddamento"
        ,"Riserva canale 3"
      };
    #endregion

    #region Ao label long Siemens
    public static string[] aoLabelLongS7 =
      { 
        //SM 1232 AQ4, la prima, AO
        " Comando drive riempimento"
        ,"Comando drive circolazione"
        ,"Comando drive raffreddamento"
        ,"Riserva canale 3"
      };
    #endregion



    
    #region I/O digitali

    public enum Wexxx
    {
      ec0
      , ec1
      , ec2
      , ec3
    }
    public enum Wuxxx
    {
      uc0
      , uc1
      , uc2
    }
    public enum Waxxx
    {
      ac0
      , ac1
      , ac2
    }

    #region input

    #region We0
    public enum We0
    {
       vWe000_FCePORTNOCH	
     , vWe001_CTeRISCFLUI	
     , vWe002_CTeRISCCAME	
     , vWe003_LVe2FLUPROOK
     , vWe004_LSe0TRAFFLUI
     , vWe005_PSe0PRESARIA
     , vWe006_FCe0SIRIRIPO
     , vWe007_FCe1SIRIXCOR
     , vWe008_LVe1OLIOBASS
     , vWe009_SNe2RECOPRIN
     , vWe010_SNe2RECOPRAV
     , vWe011_PSe0HP_1FRIGex
     , vWe012_TSe0LT_1FRIG
     , vWe013_FLe0LQ_1FRIG
     , vWe014_FLe0GQ_2FRIG
     , vWe015_LVe0HG_1FRIG
    }

    public static string[] we0Descr =
      {
         "vWe000_0.porta cella non chiusa                           "
        ,"vWe001_0.termostato sicurezza riscaldatore fluido         "
        ,"vWe002_0.termostato sicurezza cella climatica             "
        ,"vWe003_2.livello fluido prova sufficiente                 "
        ,"vWe004_0.trafilamento fluido da elementi in prova         "
        ,"vWe005_0.pressione aria sufficiente                       "
        ,"vWe006_0.cilindro comando pressione a riposo              "
        ,"vWe007_1.oltrecorsa cilindro comando pressione            "
        ,"vWe008_1.livello olio centralina insufficiente            "
        ,"vWe009_2.regolatore corsa cil.pressione indietro          "
        ,"vWe010_2.regolatore corsa cil.pressione avanti            "
        ,"vWe011_Riserva                                            "
        ,"vWe012_0.termostato di minima 1° stadio gr.frigorifero    "
        ,"vWe013_0.flussostato 1° stadio gruppo frigorifero         "
        ,"vWe014_0.fl circ.fl. in cella da 1° st./fl cond. 2° st    "
        ,"vWe015_0.livello fluido vasca 1° stadio gr.frigorifero    "
      };

    public static string[] we0Nick =
      {
         "vWe000_FCePORTNOCH	"
        ,"vWe001_CTeRISCFLUI	"
        ,"vWe002_CTeRISCCAME	"
        ,"vWe003_LVe2FLUPROOK"
        ,"vWe004_LSe0TRAFFLUI"
        ,"vWe005_PSe0PRESARIA"
        ,"vWe006_FCe0SIRIRIPO"
        ,"vWe007_FCe1SIRIXCOR"
        ,"vWe008_LVe1OLIOBASS"
        ,"vWe009_SNe2RECOPRIN"
        ,"vWe010_SNe2RECOPRAV"
        ,"vWe011_PSe0HP_1FRIG"
        ,"vWe012_TSe0LT_1FRIG"
        ,"vWe013_FLe0LQ_1FRIG"
        ,"vWe014_FLe0GQ_2FRIG"
        ,"vWe015_LVe0HG_1FRIG"
      };


    public static string[] we0Plc =
  {
         "vWe000"
        ,"vWe001"
        ,"vWe002"
        ,"vWe003"
        ,"vWe004"
        ,"vWe005"
        ,"vWe006"
        ,"vWe007"
        ,"vWe008"
        ,"vWe009"
        ,"vWe010"
        ,"vWe011"
        ,"vWe012"
        ,"vWe013"
        ,"vWe014"
        ,"vWe015"
      };


    public static string[] we0Comp =
  {
         "????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
      };
    #endregion

    #region We1
    public enum We1
    {
       vWe100_PSe0HP_2FRIGex
     , vWe101_PSe0LP_2FRIGex
     , vWe102_FCe0VIBRPOSI
     , vWe103_FCe0VIBRSPIN
     , vWe104_SNe0VIBR_RUN
     , vWe105_TEe0COMP1FRI
     , vWe106_TEe0COMP2FRI
     , vWe107_TEe0POMP1FRI
     , vWe108_TEe0POMPCELL
     , vWe109_TEe0POMPP1P2
     , vWe110_TEe0POMP_P3_
     , vWe111_TEe1POMP_P4_
     , vWe112_TEe2MREGCIPR
     , vWe113_TEe1VENTCELL
     , vWe114_TEe0RISCCELL
     , vWe115_SNe1FILTCECL
    }

    public static string[] we1Descr =
      {
         "vWe100_Riserva                                            "
        ,"vWe101_Riserva                                            "
        ,"vWe102_0.vibratore posizionato                            "
        ,"vWe103_0.spina vibratore introdotta                       "
        ,"vWe104_0.gruppo vibratore in marcia                       "
        ,"vWe105_0.interv.prot.mot.compressore 1°st.gr.frigor.      "
        ,"vWe106_0.interv.prot.mot.compressore 2°st.gr.frigor.      "
        ,"vWe107_0.interv.prot.mot.pompa circolazione               "
        ,"vWe108_0.interv.prot.mot.pompa raffr.vasca 1°st.frigor.   "
        ,"vWe109_0.interv.prot.mot.pompa raffr.cella da 1° stadio   "
        ,"vWe110_0.interv.prot.mot.ventilazione cella               "
        ,"vWe111_1.interv.prot.motore pompa P4                      "
        ,"vWe112_2.interv.prot.mot.regol.corsa cilindro pressione   "
        ,"vWe113_1.interv.prot.motore ventola cella                 "
        ,"vWe114_0.interv.prot.riscaldatore cella                   "
        ,"vWe115_1.filtro principale centralina intasato            "
      };

    public static string[] we1Nick =
  {
         "vWe100_PSe0HP_2FRIG"
        ,"vWe101_PSe0LP_2FRIG"
        ,"vWe102_FCe0VIBRPOSI"
        ,"vWe103_FCe0VIBRSPIN"
        ,"vWe104_SNe0VIBR_RUN"
        ,"vWe105_TEe0COMP1FRI"
        ,"vWe106_TEe0COMP2FRI"
        ,"vWe107_TEe0POMP1FRI"
        ,"vWe108_TEe0POMPCELL"
        ,"vWe109_TEe0POMPP1P2"
        ,"vWe110_TEe0POMP_P3_"
        ,"vWe111_TEe1POMP_P4_"
        ,"vWe112_TEe2MREGCIPR"
        ,"vWe113_TEe1VENTCELL"
        ,"vWe114_TEe0RISCCELL"
        ,"vWe115_SNe1FILTCECL"
      };


    public static string[] we1Plc =
  {
         "vWe100"
        ,"vWe101"
        ,"vWe102"
        ,"vWe103"
        ,"vWe104"
        ,"vWe105"
        ,"vWe106"
        ,"vWe107"
        ,"vWe108"
        ,"vWe109"
        ,"vWe110"
        ,"vWe111"
        ,"vWe112"
        ,"vWe113"
        ,"vWe114"
        ,"vWe115"
      };


    public static string[] we1Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };

    #endregion

    #region We2
    public enum We2
    {
       vWe200_SNe1FISER1CL
     , vWe201_SNe1FIVIBRCL
     , vWe202_SNe1FIPILOCL
     , vWe203_SNe0PROT_AUX
     , vWe204_SNe0PROTFIEL
     , vWe205_SIe0TUTTO_OK
     , vWe206_SNe0EMERRIPR
     , vWe207_SLe0AUTOMATI
     , vWe208_PUe0STARAUTO
     , vWe209_PUe0STOPAUTO
     , vWe210_PUe0COMAAVAN
     , vWe211_PUe0COMAINDI
     , vWe212_SNe1CENTMARC
     , vWe213_SNe1DRIVFLOK
     , vWe214_PUeACK_ALLA	
     , vWe215_PUeRESEALLA
    }

    public static string[] we2Descr =
      {
         "vWe200_1.filtro servizio cilindro 1 intasato        "
        ,"vWe201_1.filtro servizio vibratore intasato         "
        ,"vWe202_1.filtro servizio pilotaggio cil.1 intasato  "
        ,"vWe203_0.interv.prot.circuiti 24Vdc                 "
        ,"vWe204_0.intervento protez.filtro elettrostatico    "
        ,"vWe205_0.circuiti ausiliari inseriti                "
        ,"vWe206_0.emergenza ripristinata                     "
        ,"vWe207_0.selettore comandi automatici               "
        ,"vWe208_0.pulsante avvio ciclo automatico            "
        ,"vWe209_0.pulsante arresto ciclo automatico          "
        ,"vWe210_0.pulsante comando manuale avanti            "
        ,"vWe211_0.pulsante comando manuale indietro          "
        ,"vWe212_1.pompe idrauliche in marcia                 "
        ,"vWe213_1.nessuna anomalia inverter pompa circolaz.  "
        ,"vWe214_                                             "
        ,"vWe215_                                             "
      };

    public static string[] we2Nick =
{
         "vWe200_SNe1FISER1CL "
        ,"vWe201_SNe1FIVIBRCL "
        ,"vWe202_SNe1FIPILOCL "
        ,"vWe203_SNe0PROT_AUX "
        ,"vWe204_SNe0PROTFIEL "
        ,"vWe205_SIe0TUTTO_OK "
        ,"vWe206_SNe0EMERRIPR "
        ,"vWe207_SLe0AUTOMATI "
        ,"vWe208_PUe0STARAUTO "
        ,"vWe209_PUe0STOPAUTO "
        ,"vWe210_PUe0COMAAVAN "
        ,"vWe211_PUe0COMAINDI "
        ,"vWe212_SNe1CENTMARC "
        ,"vWe213_SNe1DRIVFLOK "
        ,"vWe214_PUeACK_ALLA	"
        ,"vWe215_PUeRESEALLA	"
      };


    public static string[] we2Plc =
  {
         "vWe200"
        ,"vWe201"
        ,"vWe202"
        ,"vWe203"
        ,"vWe204"
        ,"vWe205"
        ,"vWe206"
        ,"vWe207"
        ,"vWe208"
        ,"vWe209"
        ,"vWe210"
        ,"vWe211"
        ,"vWe212"
        ,"vWe213"
        ,"vWe214"
        ,"vWe215"
      };


    public static string[] we2Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };



    #endregion


    #region We3
    public enum We3
    {
       vWe300_PSe0HP_1FRIG
     , vWe301_PSe0LP_1FRIG
     , vWe302_PSe0HP_2FRIG
     , vWe303_PSe0LP_2FRIG
     , vWe304_
     , vWe305_
     , vWe306_
     , vWe307_
     , vWe308_
     , vWe309_
     , vWe310_
     , vWe311_
     , vWe312_
     , vWe313_
     , vWe314_
     , vWe315_
    }

    public static string[] we3Descr =
      {
         "vWe300_0.sovrapressione 1° stadio gr.frigorifero       "
        ,"vWe301_0.bassa pressione 1° st.gr.frigorifero          "
        ,"vWe302_0.sovrapressione 2° stadio gr.frigorifero         "
        ,"vWe303_0.bassa pressione 2° st.gr.frigorifero            "
        ,"vWe304_  "
        ,"vWe305_  "
        ,"vWe306_  "
        ,"vWe307_  "
        ,"vWe308_  "
        ,"vWe309_  "
        ,"vWe310_  "
        ,"vWe311_  "
        ,"vWe312_  "
        ,"vWe313_  "
        ,"vWe314_  "
        ,"vWe315_  "
      };

    public static string[] we3Nick =
{
         "vWe300_PSe0HP_1FRIG"
        ,"vWe301_PSe0LP_1FRIG"
        ,"vWe302_PSe0HP_2FRIG"
        ,"vWe303_PSe0LP_2FRIG"
        ,"vWe304_"
        ,"vWe305_"
        ,"vWe306_"
        ,"vWe307_"
        ,"vWe308_"
        ,"vWe309_"
        ,"vWe310_"
        ,"vWe311_"
        ,"vWe312_"
        ,"vWe313_"
        ,"vWe314_"
        ,"vWe315_"
      };


    public static string[] we3Plc =
  {
         "vWe300"
        ,"vWe301"
        ,"vWe302"
        ,"vWe303"
        ,"vWe304"
        ,"vWe305"
        ,"vWe306"
        ,"vWe307"
        ,"vWe308"
        ,"vWe309"
        ,"vWe310"
        ,"vWe311"
        ,"vWe312"
        ,"vWe313"
        ,"vWe314"
        ,"vWe315"
      };


    public static string[] we3Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };



    #endregion


    #endregion


    #region output

    #region Wu0
    public enum Wu0
    {
       vWu000_CTu0CMP1FRIG
     , vWu001_CTu0CMP2FRIG
     , vWu002_SNu0POMPCIRC
     , vWu003_CTu0PMP1FRIG
     , vWu004_CTu0PMPCCELL
     , vWu005_CTu0FILTELET
     , vWu006_CTu0PWRRISFL
     , vWu007_CTu0PWRRISCE
     , vWu008_CTu1VENTEXTE
     , vWu009_CTu0VENTCELL
     , vWu010_CTu0SOFFRICE
     , vWu011_SNu1POMRCIRC
     , vWu012_SNu2ALLUARPR
     , vWu013_SNu2ACCOARPR
     , vWu014_SNu2AVANCIPR
     , vWu015_SNu0STARVIBR
    }

    public static string[] wu0Descr =
      {
         "vWu000_0.marcia compressore 1°stadio                  "
        ,"vWu001_0.marcia compressore 2°stadio                  "
        ,"vWu002_0.marcia avanti pompa circolazione fluido      "
        ,"vWu003_0.marcia pompa raffredd.vasca 1°stadio         "
        ,"vWu004_0.marcia pompa raffreddamento cella            "
        ,"vWu005_0.abilitazione filtro elettrostatico           "
        ,"vWu006_0.abilitazione resistenze fluido circolante    "
        ,"vWu007_0.abilitazione riscaldatore cella              "
        ,"vWu008_1.ev ventilazione esterna                      "
        ,"vWu009_0.ventilatore destratificazione cella          "
        ,"vWu010_0.soffiante riscaldatore cella                 "
        ,"vWu011_1.marcia indietro pompa circolazione fluido    "
        ,"vWu012_2.allontana punto arresto cil.pressione        "
        ,"vWu013_2.avvicina punto arresto cil.pressione         "
        ,"vWu014_2.avanti cilindro pressione circuito prova     "
        ,"vWu015_0.start a vibratore                            "
      };

    public static string[] wu0Nick =
      {
         "vWu000_CTu0CMP1FRIG"
        ,"vWu001_CTu0CMP2FRIG"
        ,"vWu002_CTu0POMPCIRC"
        ,"vWu003_CTu0PMP1FRIG"
        ,"vWu004_CTu0PMPCCELL"
        ,"vWu005_CTu0FILTELET"
        ,"vWu006_CTu0PWRRISFL"
        ,"vWu007_CTu0PWRRISCE"
        ,"vWu008_CTu1VENTEXTE"
        ,"vWu009_CTu0VENTCELL"
        ,"vWu010_CTu0VENTRISC"
        ,"vWu011_SNu1POMRCIRC"
        ,"vWu012_SNu2ALLUARPR"
        ,"vWu013_SNu2ACCOARPR"
        ,"vWu014_SNu2AVANCIPR"
        ,"vWu015_SNu0STARVIBR"
      };


    public static string[] wu0Plc =
  {
         "vWu000"
        ,"vWu001"
        ,"vWu002"
        ,"vWu003"
        ,"vWu004"
        ,"vWu005"
        ,"vWu006"
        ,"vWu007"
        ,"vWu008"
        ,"vWu009"
        ,"vWu010"
        ,"vWu011"
        ,"vWu012"
        ,"vWu013"
        ,"vWu014"
        ,"vWu015"
      };


    public static string[] wu0Comp =
  {
         "????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
      };
    #endregion

    #region Wu1
    public enum Wu1
    {
       vWu100_SNu0CONS_RUN
     , vWu101_SNuLAMPALLA_
     , vWu102_SNu_PIU_PIU_
     , vWu103_EVu1PRLICISI
     , vWu104_EVu1PRLIVIBR
     , vWu105_EVu1RAFFCEOL
     , vWu106_EVu1CARICIPR
     , vWu107_EVu1SCARCIPR
     , vWu108_EVu1AUX_CASC
     , vWu109_EVu1AUX_SCCI
     , vWu110_EVu1ESCIRISC
     , vWu111_EVu0CIRCH2FL
     , vWu112_EVu0SPURCIRC
     , vWu113_EVu0RACOFRI1
     , vWu114_EVu0FREDCELL
     , vWu115_EVu0SVUOCELL
    }

    public static string[] wu1Descr =
      {
         "vWu100_0.consenso messa in servizio                          "
        ,"vWu101_0.lampada segn. allarme                               "
        ,"vWu102_0.cicalino allarme                                    "
        ,"vWu103_1.pressurizzazione linea circuito siringa             "
        ,"vWu104_1.pressurizzazione linea circuito vibratore           "
        ,"vWu105_1.raffreddamento olio centralina idraulica            "
        ,"vWu106_1.caricamento circuito prova                          "
        ,"vWu107_1.scarico circuito prova                              "
        ,"vWu108_1.com.valvola aus.carico/scarico                      "
        ,"vWu109_1.com.valvola ausiliaria svuotamento                  "
        ,"vWu110_1.esclusione circolaz.fluido nel riscaldatore         "
        ,"vWu111_0.circolaz.acqua raffredd.circuito di prova           "
        ,"vWu112_0.spurgo fluido circuito di prova                     "
        ,"vWu113_0.acqua raffredd.condensatore 1°st.frigor.            "
        ,"vWu114_0.mandata fluido freddo alla cella da 1°st.frigor.    "
        ,"vWu115_0.svuotamento fluido freddo dalla cella               "
      };

    public static string[] wu1Nick =
  {
         "vWu100_SNu0CONS_RUN  "
        ,"vWu101_SNuLAMPALLA_  "
        ,"vWu102_SNu_PIU_PIU_  "
        ,"vWu103_EVu1PRLICISI  "
        ,"vWu104_EVu1PRLIVIBR  "
        ,"vWu105_EVu1RAFFCEOL  "
        ,"vWu106_EVu1CARICIPR  "
        ,"vWu107_EVu1SCARCIPR  "
        ,"vWu108_EVu1AUX_CASC  "
        ,"vWu109_EVu1AUX_SCCI  "
        ,"vWu110_EVu1ESCIRISC  "
        ,"vWu111_EVu0CIRCH2FL  "
        ,"vWu112_EVu0SPURCIRC  "
        ,"vWu113_EVu0RACOFRI1  "
        ,"vWu114_EVu0FREDCELL  "
        ,"vWu115_EVu0SVUOCELL  "
      };


    public static string[] wu1Plc =
  {
         "vWu100"
        ,"vWu101"
        ,"vWu102"
        ,"vWu103"
        ,"vWu104"
        ,"vWu105"
        ,"vWu106"
        ,"vWu107"
        ,"vWu108"
        ,"vWu109"
        ,"vWu110"
        ,"vWu111"
        ,"vWu112"
        ,"vWu113"
        ,"vWu114"
        ,"vWu115"
      };


    public static string[] wu1Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };

    #endregion

    #region Wu2
    public enum Wu2
    {
       vWu200_EVu0CONDFRI2
     , vWu201_EVu0LIQUCELL
     , vWu202_EVu0LIQUFRI1
     , vWu203_LSu0_RIPOSO_
     , vWu204_LSu0AUTOMATI
     , vWu205_LSu0ANOMALIA
     , vWu206_LSu0SBLOPORT
     , vWu207_RSu1MODURICE
     , vWu208_RSu1MODURIFL
     , vWu209_CTu1POMPECEN
     , vWu210_EVu2CIRCMOPR
     , vWu211_EVu2CIRCVAPR
     , vWu212_EVu2PRESCIRC
     , vWu213_RISERVA
     , vWu214_RISERVA
     , vWu215_RISERVA
    }

    public static string[] wu2Descr =
      {
         "circol.acqua raffredd.condensatore 1°st.frigor. "
        ,"mandata fluido freddo alla cella da 1°st.frigor."
        ,"svuotamento fluido freddo dalla cella           "
        ,"mandata fluido freddo al condens.da 2°stadio    "
        ,"mandata gas alla cella da 2°stadio frigor.      "
        ,"mandata gas evaporat.gruppo frigor.1°stadio     "
        ,"ev ventilazione esterna                         "
        ,"ev circolaz.H2o raffr.fluido circolante         "
        ,"telerutt. comando centralina oleo              "
        ,"ev circolaz. monte prova                        "
        ,"ev circolaz. valle prova                        "
        ,"ev pressurizzazione circuito prova  riserva     "
        ,"  riserva                                       "
        ,"  riserva                                       "
        ,"  riserva                                       "
        ,"  riserva                                       "
      };

    public static string[] wu2Nick =
{
         "vWu200_EVu0CONDFRI2 "
        ,"vWu201_EVu0LIQUCELL "
        ,"vWu202_EVu0LIQUFRI1 "
        ,"vWu203_LSu0_RIPOSO_ "
        ,"vWu204_LSu0AUTOMATI "
        ,"vWu205_LSu0ANOMALIA "
        ,"vWu206_LSu0SBLOPORT "
        ,"vWu207_RSu1MODURICE "
        ,"vWu208_RSu1MODURIFL "
        ,"vWu209_CTu1POMPECEN "
        ,"vWu210_EVu2CIRCMOPR "
        ,"vWu211_EVu2CIRCVAPR "
        ,"vWu212_EVu2PRESCIRC "
        ,"vWu213_RISERVA      "
        ,"vWu214_RISERVA      "
        ,"vWu215_RISERVA      "
      };


    public static string[] wu2Plc =
  {
         "vWu200_"
        ,"vWu201_"
        ,"vWu202_"
        ,"vWu203_"
        ,"vWu204_"
        ,"vWu205_"
        ,"vWu206_"
        ,"vWu207_"
        ,"vWu208_"
        ,"vWu209_"
        ,"vWu210_"
        ,"vWu211_"
        ,"vWu212_"
        ,"vWu213_"
        ,"vWu214_"
        ,"vWu215_"
      };


    public static string[] wu2Comp =
  {
         " ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
      };



    #endregion

    #region Wu3
    public enum Wu3
    {
       vWu300_RISERVA
     , vWu301_RISERVA
     , vWu302_RISERVA
     , vWu303_RISERVA
     , vWu304_RISERVA
     , vWu305_RISERVA
     , vWu306_RISERVA
     , vWu307_RISERVA
     , vWu308_RISERVA
     , vWu309_RISERVA
     , vWu310_RISERVA
     , vWu311_RISERVA
     , vWu312_RISERVA
     , vWu313_RISERVA
     , vWu314_RISERVA
     , vWu315_RISERVA
    }

    public static string[] wu3Descr =
      {
         "  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
      };

    public static string[] wu3Nick =
{
         "vWu300_RISERVA "
        ,"vWu301_RISERVA "
        ,"vWu302_RISERVA "
        ,"vWu303_RISERVA "
        ,"vWu304_RISERVA "
        ,"vWu305_RISERVA "
        ,"vWu306_RISERVA "
        ,"vWu307_RISERVA "
        ,"vWu308_RISERVA "
        ,"vWu309_RISERVA      "
        ,"vWu310_RISERVA      "
        ,"vWu311_RISERVA      "
        ,"vWu312_RISERVA      "
        ,"vWu313_RISERVA      "
        ,"vWu314_RISERVA      "
        ,"vWu315_RISERVA      "
      };


    public static string[] wu3Plc =
  {
         "vWu300_"
        ,"vWu301_"
        ,"vWu302_"
        ,"vWu303_"
        ,"vWu304_"
        ,"vWu305_"
        ,"vWu306_"
        ,"vWu307_"
        ,"vWu308_"
        ,"vWu309_"
        ,"vWu310_"
        ,"vWu311_"
        ,"vWu312_"
        ,"vWu313_"
        ,"vWu314_"
        ,"vWu315_"
      };


    public static string[] wu3Comp =
  {
         " ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
      };



    #endregion

    #endregion

    #region flag e comandi DVP
    public enum Fp0
    {
      u000_iCmdPowerOn
     , u001_iCmdTorqueRev
     , u002_iCmdHome
     , u003_iCmdMove

     , u004_iCmdMovVel
     , u005_iCmdHalt
     , u006_iCmdErrRst
     , u007_iCmdStop

     , u008_iCmdCamin
     , u009_iCmdCamout
     , u010_iCmdMovMasterVel
     , u011_iCmdMoveRel

     , u012_xMoveVelEnable
     , u013_iCmdRes13
     , u014_iCmdRes14
     , u015_iCmdRes15
    }


    public static string[] Fp0Descr =
    {
       "u000_iCmdPowerOn"
      ,"u001_iCmdTorqueRev"
      ,"u002_iCmdHome"
      ,"u003_iCmdMove"

      ,"u004_iCmdMovVel"
      ,"u005_iCmdHalt"
      ,"u006_iCmdErrRst"
      ,"u007_iCmdStop"

      ,"u008_iCmdCamin"
      ,"u009_iCmdCamout"
      ,"u010_iCmdMovMasterVel"
      ,"u011_iCmdMoveRel"

      ,"u012_xMoveVelEnable"
      ,"u013_iCmdRes13"
      ,"u014_iCmdRes14"
      ,"u015_iCmdRes15"
    };


    public enum Fp1
    {
      u000_oCmdEnabJog
     , u001_oCmdJogFwd
     , u002_oCmdJogRev
     , u003_oCmdReqRdy

     , u004_oCmdEnabPulse
     , u005_oCmdHomeEnab
     , u006_oCmdGrapPid
     , u007_oCmdGrapSpeed

     , u008_oCmdCamin
     , u009_oCmdRes9
     , u010_oCmdRes10
     , u011_oCmdRes11

     , u012_oCmdRes12
     , u013_oCmdRes13
     , u014_oCmdRes14
     , u015_oCmdPidEn
    }

    public static string[] Fp1Descr =
    {
       "u000_oCmdEnabJog"
      ,"u001_oCmdJogFwd"
      ,"u002_oCmdJogRev"
      ,"u003_oCmdReqRdy"

      ,"u004_oCmdEnabPulse"
      ,"u005_oCmdHomeEnab"
      ,"u006_oCmdGrapPid"
      ,"u007_oCmdGrapSpeed"

      ,"u008_oCmdCamin"
      ,"u009_oCmdRes9"
      ,"u010_oCmdRes10"
      ,"u011_oCmdRes11"

      ,"u012_oCmdRes12"
      ,"u013_oCmdRes13"
      ,"u014_oCmdRes14"
      ,"u015_oCmdPidEn"
    };


    public enum Fp2
    {
      u000_flPowerOn
     , u001_flMov0Done
     , u002_flHomeDone
     , u003_flHaltDone

     , u004_flInTorque
     , u005_fl0Res5
     , u006_fl0Res6
     , u007_fl0Res7

     , u008_fl0Res8
     , u009_fl0Res9
     , u010_fl0Res10
     , u011_fl0Res11

     , u012_fl0Res12
     , u013_fl0Res13
     , u014_fl0Res14
     , u015_fl0Res15
    }

    public static string[] Fp2Descr =
    {
       "u000_flPowerOn"
      ,"u001_flMov0Done"
      ,"u002_flHomeDone"
      ,"u003_flHaltDone"

      ,"u004_flInTorque"
      ,"u005_fl0Res5"
      ,"u006_fl0Res6"
      ,"u007_fl0Res7"

      ,"u008_fl0Res8"
      ,"u009_fl0Res9"
      ,"u010_fl0Res10"
      ,"u011_fl0Res11"

      ,"u012_fl0Res12"
      ,"u013_fl0Res13"
      ,"u014_fl0Res14"
      ,"u015_fl0Res15"
    };


    public enum Fp3
    {
      u000_fliLockJog
     , u001_flIntRes1
     , u002_flIntRes2
     , u003_flIntRes3

     , u004_flIntRes4
     , u005_flIntRes5
     , u006_flIntRes6
     , u007_flIntRes7

     , u008_flIntRes8
     , u009_flIntRes9
     , u010_flIntRes10
     , u011_flIntRes11

     , u012_flIntRes12
     , u013_flIntRes13
     , u014_flIntRes14
     , u015_flIntRes15
    }

    public static string[] Fp3Descr =
    {
       "u000_fliLockJog"
      ,"u001_flIntRes1"
      ,"u002_flIntRes2"
      ,"u003_flIntRes3"

      ,"u004_flIntRes4"
      ,"u005_flIntRes5"
      ,"u006_flIntRes6"
      ,"u007_flIntRes7"

      ,"u008_flIntRes8"
      ,"u009_flIntRes9"
      ,"u010_flIntRes10"
      ,"u011_flIntRes11"

      ,"u012_flIntRes12"
      ,"u013_flIntRes13"
      ,"u014_flIntRes14"
      ,"u015_flIntRes15"
    };

    #endregion

    #region flag e comandi S7
    public enum S7flStat
    {
      u000_riempOk
     , u001_svuotaOk
     , u002_evalOk
     , u003_camRun

     , u004_i
     , u005_i
     , u006_i
     , u007_i

     , u008_i
     , u009_i
     , u010_i
     , u011_i

     , u012_x
     , u013_i
     , u014_i
     , u015_i
    }


    public static string[] S7flStDes =
    {
       "u000_RiempOk"
      ,"u001_svuotOk"
      ,"u002_eval_Ok"
      ,"u003_cammRun"

      ,"u004_"
      ,"u005_"
      ,"u006_"
      ,"u007_"

      ,"u008_"
      ,"u009_"
      ,"u010_"
      ,"u011_"

      ,"u012_"
      ,"u013_"
      ,"u014_"
      ,"u015_"
    };


    public enum S71
    {
      u000_oCmdEnabJog
     , u001_oCmdJogFwd
     , u002_oCmdJogRev
     , u003_oCmdReqRdy

     , u004_oCmdEnabPulse
     , u005_oCmdHomeEnab
     , u006_oCmdGrapPid
     , u007_oCmdGrapSpeed

     , u008_oCmdCamin
     , u009_oCmdRes9
     , u010_oCmdRes10
     , u011_oCmdRes11

     , u012_oCmdRes12
     , u013_oCmdRes13
     , u014_oCmdRes14
     , u015_oCmdPidEn
    }

    public static string[] S71Descr =
    {
       "u000_oCmdEnabJog"
      ,"u001_oCmdJogFwd"
      ,"u002_oCmdJogRev"
      ,"u003_oCmdReqRdy"

      ,"u004_oCmdEnabPulse"
      ,"u005_oCmdHomeEnab"
      ,"u006_oCmdGrapPid"
      ,"u007_oCmdGrapSpeed"

      ,"u008_oCmdCamin"
      ,"u009_oCmdRes9"
      ,"u010_oCmdRes10"
      ,"u011_oCmdRes11"

      ,"u012_oCmdRes12"
      ,"u013_oCmdRes13"
      ,"u014_oCmdRes14"
      ,"u015_oCmdPidEn"
    };


    public enum S72
    {
      u000_flPowerOn
     , u001_flMov0Done
     , u002_flHomeDone
     , u003_flHaltDone

     , u004_flInTorque
     , u005_fl0Res5
     , u006_fl0Res6
     , u007_fl0Res7

     , u008_fl0Res8
     , u009_fl0Res9
     , u010_fl0Res10
     , u011_fl0Res11

     , u012_fl0Res12
     , u013_fl0Res13
     , u014_fl0Res14
     , u015_fl0Res15
    }

    public static string[] S72Descr =
    {
       "u000_flPowerOn"
      ,"u001_flMov0Done"
      ,"u002_flHomeDone"
      ,"u003_flHaltDone"

      ,"u004_flInTorque"
      ,"u005_fl0Res5"
      ,"u006_fl0Res6"
      ,"u007_fl0Res7"

      ,"u008_fl0Res8"
      ,"u009_fl0Res9"
      ,"u010_fl0Res10"
      ,"u011_fl0Res11"

      ,"u012_fl0Res12"
      ,"u013_fl0Res13"
      ,"u014_fl0Res14"
      ,"u015_fl0Res15"
    };


    public enum S73
    {
      u000_fliLockJog
     , u001_flIntRes1
     , u002_flIntRes2
     , u003_flIntRes3

     , u004_flIntRes4
     , u005_flIntRes5
     , u006_flIntRes6
     , u007_flIntRes7

     , u008_flIntRes8
     , u009_flIntRes9
     , u010_flIntRes10
     , u011_flIntRes11

     , u012_flIntRes12
     , u013_flIntRes13
     , u014_flIntRes14
     , u015_flIntRes15
    }

    public static string[] S73Descr =
    {
       "u000_fliLockJog"
      ,"u001_flIntRes1"
      ,"u002_flIntRes2"
      ,"u003_flIntRes3"

      ,"u004_flIntRes4"
      ,"u005_flIntRes5"
      ,"u006_flIntRes6"
      ,"u007_flIntRes7"

      ,"u008_flIntRes8"
      ,"u009_flIntRes9"
      ,"u010_flIntRes10"
      ,"u011_flIntRes11"

      ,"u012_flIntRes12"
      ,"u013_flIntRes13"
      ,"u014_flIntRes14"
      ,"u015_flIntRes15"
    };

    #endregion

    #endregion
    

    #endregion

    #region allarmi
    public enum Wa00
    {
       AL0_0_SInTUTTO_OK 
     , AL0_1_FCn0PORTNOCH
     , AL0_2_TSn0RISCFLUI
     , AL0_3_TSn0TEMPCAME
     , AL0_4_LVn2FLUPROOK
     , AL0_5_LSn0TRAFFLUI
     , AL0_6_PSn0PRESARIA
     , AL0_7_LVn1OLIOBASS
     , AL0_8_PSn0HP_1FRIG
     , AL0_9_TSn0LT_1FRIG
     , AL0_a_FLn0LQ_1FRIG
     , AL0_b_FLn0GQ_2FRIG
     , AL0_c_LVn0HG_1FRIG
     , AL0_d_PSn0HP_2FRIG
     , AL0_e_PSn0LP_2FRIG
     , AL0_f_TEn0COMP1FRI
    }

    public static string[] wa0Descr =
  {
         "0.all. circuiti ausiliari inseriti "
        ,"0.all. porta cella non chiusa "
        ,"0.all. termostato sicurezza riscaldatore fluido "
        ,"0.all. termostato sicurezza cella climatica "
        ,"2.all. livello fluido prova sufficiente "
        ,"0.all. trafilamento fluido da elementi in prova "
        ,"0.all. pressione aria sufficiente "
        ,"1.all. livello olio centralina insufficiente "
        ,"0.all. sovrapressione 1° stadio gr.frigorifero "
        ,"0.all. termostato di minima 1° stadio gr.frigorifero "
        ,"0.all. flussostato 1° stadio gruppo frigorifero "
        ,"0.all. fl circ.fl. in cella da 1° st./fl cond. 2° st "
        ,"0.all. livello fluido vasca 1° stadio gr.frigorifero "
        ,"0.all. sovrapressione 2° stadio gr.frigorifero "
        ,"0.all. insufficiente pressione 2° st.gr.frigorifero "
        ,"0.all. interv.prot.mot.compressore 1°st.gr.frigor. "
      };

    public static string[] wa0Nick =
      {
         "SInTUTTO_OK  "
        ,"FCn0PORTNOCH "
        ,"TSn0RISCFLUI "
        ,"TSn0TEMPCAME "
        ,"LVn2FLUPROOK "
        ,"LSn0TRAFFLUI "
        ,"PSn0PRESARIA "
        ,"LVn1OLIOBASS "
        ,"PSn0HP_1FRIG "
        ,"TSn0LT_1FRIG "
        ,"FLn0LQ_1FRIG "
        ,"FLn0GQ_2FRIG "
        ,"LVn0HG_1FRIG "
        ,"PSn0HP_2FRIG "
        ,"PSn0LP_2FRIG "
        ,"TEn0COMP1FRI "
      };


    public static string[] wa0Plc =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public static string[] wa0Comp =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public enum Wa01
    {
       AL1_0_TEn0COMP2FRI
     , AL1_1_TEn0POMP1FRI
     , AL1_2_TEn0POMPCELL
     , AL1_3_TEn0POMPP1P2
     , AL1_4_TEn0POMP_P3_
     , AL1_5_TEn1POMP_P4_
     , AL1_6_TEn2MREGCIPR
     , AL1_7_TEn1VENTCELL
     , AL1_8_TEn0RISCCELL
     , AL1_9_SNn1FILTCECL
     , AL1_a_SNn1FISER1CL
     , AL1_b_SNn1FIVIBRCL
     , AL1_c_SNn1FIPILOCL
     , AL1_d_SNn0PROT_AUX
     , AL1_e_SNn0PROTFIEL
     , AL1_f_SNn0EMERRIPR
    }


    public static string[] wa1Descr =
  {
         "0.all. interv.prot.mot.compressore 2°st.gr.frigor."
        ,"0.all. interv.prot.mot.pompa raffr.vasca 1°st.frigor."
        ,"0.all. interv.prot.mot.pompa raffr.cella da 1° stadio"
        ,"1 all  interv. prot.mot.pompe P1-P2"
        ,"0.all. interv.prot.motore pompa P3"
        ,"1.all. interv.prot.motore pompa P4"
        ,"2.all. interv.prot.mot.regol.corsa cilindro pressione"
        ,"1.all. interv.prot.motore ventola cella"
        ,"0.all. interv.prot.riscaldatore cella"
        ,"1.all. filtro principale centralina intasato"
        ,"1.all. filtro servizio cilindro 1 intasato"
        ,"1.all. filtro servizio vibratore intasato"
        ,"1.all. filtro servizio pilotaggio cil.1 intasato"
        ,"0.all. interv.prot.circuiti 24Vdc"
        ,"0.all. intervento protez.filtro elettrostatico"
        ,"0.all. emergenza ripristinata"
      };

    public static string[] wa1Nick =
      {
         "TEn0COMP2FRI"
        ,"TEn0POMP1FRI"
        ,"TEn0POMPCELL"
        ,"TEn0POMPP1P2"
        ,"TEn0POMP_P3_"
        ,"TEn1POMP_P4_"
        ,"TEn2MREGCIPR"
        ,"TEn1VENTCELL"
        ,"TEn0RISCCELL"
        ,"SNn1FILTCECL"
        ,"SNn1FISER1CL"
        ,"SNn1FIVIBRCL"
        ,"SNn1FIPILOCL"
        ,"SNn0PROT_AUX"
        ,"SNn0PROTFIEL"
        ,"SNn0EMERRIPR"
      };


    public static string[] wa1Plc =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public static string[] wa1Comp =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public enum Wa02
    {
       AL2_0_SLn0AUTOMATI
     , AL2_1_SNn1DRIVFLOK
     , AL2_2_PSn0LOPRFRI1
     , AL2_3_SQnSTEPUNDF 
     , AL2_4_SQnTESTLIVE 
     , AL2_5_SBaSCOPTUBO 
     , AL2_6_WDaCOM_SERV 
     , AL2_7_WDaCOM_CLIE 
     , AL2_8_
     , AL2_9_
     , AL2_a_
     , AL2_b_
     , AL2_c_
     , AL2_d_
     , AL2_e_
     , AL2_f_
    }


    public static string[] wa2Descr =
  {
         "0.all. selettore comandi automatici"
        ,"1.all. nessuna anomalia inverter pompa circolaz."
        ,"0 all alta pressione primo stadio"
        ,"36 - step indefinito"
        ,"37 - prova attiva"
        ,"38 - Anomalia pulsazione, scoppio tubo "
        ,"39 - Mancanza comunicazione server "
        ,"40 - Mancanza comunicazione client "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
      };

    public static string[] wa2Nick =
      {
         "SLn0AUTOMATI "
        ,"SNn1DRIVFLOK "
        ,"PSn0LOPRFRI1 "
        ,"SQnSTEPUNDF "
        ,"SQnTESTLIVE "
        ,"SBaSCOPTUBO "
        ,"WDaCOM_SERV "
        ,"WDaCOM_CLIE "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
      };


    public static string[] wa2Plc =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public static string[] wa2Comp =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public string[,] msgAll =
 {
   {
 "AL0.0 SInTUTTO_OK "
,"AL0.1 FCn0PORTNOCH"
,"AL0.2 TSn0RISCFLUI"
,"AL0.3 TSn0TEMPCAME"
,"AL0.4 LVn2FLUPROOK"
,"AL0.5 LSn0TRAFFLUI"
,"AL0.6 PSn0PRESARIA"
,"AL0.7 LVn1OLIOBASS"
,"AL0.8 PSn0HP_1FRIG"
,"AL0.9 TSn0LT_1FRIG"
,"AL0.a FLn0LQ_1FRIG"
,"AL0.b FLn0GQ_2FRIG"
,"AL0.c LVn0HG_1FRIG"
,"AL0.d PSn0HP_2FRIG"
,"AL0.e PSn0LP_2FRIG"
,"AL0.f TEn0COMP1FRI"
     },
   {
 "AL1.0 TEn0COMP2FRI"
,"AL1.1 TEn0POMP1FRI"
,"AL1.2 TEn0POMPCELL"
,"AL1.3 TEn0POMPP1P2"
,"AL1.4 TEn0POMP_P3_"
,"AL1.5 TEn1POMP_P4_"
,"AL1.6 TEn2MREGCIPR"
,"AL1.7 TEn1VENTCELL"
,"AL1.8 TEn0RISCCELL"
,"AL1.9 SNn1FILTCECL"
,"AL1.a SNn1FISER1CL"
,"AL1.b SNn1FIVIBRCL"
,"AL1.c SNn1FIPILOCL"
,"AL1.d SNn0PROT_AUX"
,"AL1.e SNn0PROTFIEL"
,"AL1.f SNn0EMERRIPR"
  },
   {
 "AL1.0 SLn0AUTOMATI"
,"AL1.1 SNn1DRIVFLOK"
,"AL1.2 PSn0LOPRFRI1"
,"AL1.3 35 - step indefinito"
,"AL1.4 36 - prova attiva"
,"AL1.5 37 - Anomalia pulsazione, scoppio tubo "
,"AL1.6 38 - Mancanza comunicazione server "
,"AL1.7 39 - Mancanza comunicazione client "
,"AL1.8 "
,"AL1.9 "
,"AL1.a "
,"AL1.b "
,"AL1.c "
,"AL1.d "
,"AL1.e "
,"AL1.f "
  }
};

    #endregion

    #region Fasi e Cicli
    #region CicliPtr
    public enum ptrFaseFrigo
    {
      _00_Init                     = 00 ,
      _10_attesaStart              = 10 ,
      _20_avviamentoPompa          = 20 ,
      _30_attendeFlusso            = 30 ,
      _40_pronto_richiesta_freddo  = 40 ,
      _50_alimentazione_liquida    = 50 ,
      _60_funzione_Normale         = 60 ,
      _70_pump_down                = 70 ,
      _80_riposo_fermo             = 80 ,
      _90_pump_down                = 90 ,
      _1000_gestione_fault         = 1000,
      _1001_rientro_reset          = 1001,
    };

    
    public static string[] ptrFaseFrigoLbl =
    {
      "00 - Reset ciclo"
      ,"10 - Attesa comandi"
      ,"20 - Riempimento impianto"
      ,"30 - Caratterizzazione"
      ,"40 - Verifica prestazioni"
      ,"50 - Esecuzione passo prova"
      ,"60 - Svuotamento impianto"
      ,"100 - Fine"
    };

    public static Dictionary<int, string> faseFrigo = new Dictionary<int, string>(){
     {0  , "init: in teoria solo al power on plc				     "}
    ,{10 , "attesa richiesta marcia                          "}
    ,{20 , "avviamento pompa circolazione                    "}
    ,{30 , "attende flusso                                   "}
    ,{40 , "pronto alla marcia - attesa richiesta freddo     "}
    ,{50 , "Alimentazione liquida                            "}
    ,{60 , "Funzionamento normale                            "}
    ,{70 , "pump down                                        "}
    ,{80 , "riposo da fermo (antiripetizione)                "}
    ,{90 , "attesa arresto flusso                            "}
    ,{1000, "gestione fault                                  "}
    ,{1001, "rientro reset                                   "}
  };

    public static Dictionary<int, string> riscaldoCella = new Dictionary<int, string>(){
     {0  , "init: in teoria solo al power on plc				     "}
    ,{10 , "attesa richiesta marcia                          "}
    ,{20 , "                                                 "}
    ,{30 , "                                                 "}
    ,{40 , "pronto alla marcia - attesa richiesta caldo      "}
    ,{50 , "Regimazione ventilatore                          "}
    ,{60 , "Funzionamento normale                            "}
    ,{70 , "Spegnimento riscaldo                             "}
    ,{80 , "Arresto ventilatore                              "}
    ,{90 , "                                                 "}
    ,{1000, "gestione fault                                  "}
    ,{1001, "rientro reset                                   "}
  };

    public static Dictionary<int, string> raffreddamentoCella = new Dictionary<int, string>(){
     {0  , "init: in teoria solo al power on plc				     "}
    ,{10 , "attesa richiesta marcia                          "}
    ,{20 , "                    "}
    ,{30 , ""}
    ,{40 , "pronto alla marcia - attesa richiesta freddo     "}
    ,{50 , ""}
    ,{60 , ""}
    ,{70 , ""}
    ,{80 , ""}
    ,{90 , ""}
    ,{100, "Raffreddamento a glicole"}
    ,{110, "Da glicole a freon, svuotamento a tempo"}
    ,{200, "Raffreddamento freon, espansione diretta"}
    ,{400, "Conclusione fase raffreddamento"}
    ,{1000, "gestione fault                                  "}
    ,{1001, "rientro reset                                   "}
  };

    //  public static Dictionary<int, string> faseFrigo = new Dictionary<int, string>(){
    //   {0  , "init: in teoria solo al power on plc				     "}
    //  ,{10 , "attesa richiesta marcia                          "}
    //  ,{20 , "avviamento pompa circolazione                    "}
    //  ,{30 , "attende flusso                                   "}
    //  ,{40 , "pronto alla marcia - attesa richiesta freddo     "}
    //  ,{50 , "Alimentazione liquida                            "}
    //  ,{60 , "Funzionamento normale                            "}
    //  ,{70 , "pump down                                        "}
    //  ,{80 , "riposo da fermo (antiripetizione)                "}
    //  ,{90 , "attesa arresto flusso                            "}
    //  ,{1000, "gestione fault                                  "}
    //  ,{1001, "rientro reset                                   "}
    //};




    #endregion
    #endregion

#elif v0470

    #region def
    //public const string strConnDb = @"Database=v0387_hosestress;Data Source=mysqlsrv;User Id=root;Password=mysqlpwd";
    //public const string strConnDb = @"Database=v0387_hosestress;Data Source=mysqlsrv;User Id=root;Password=mysqlpwd";

    public const string strDbName = "v0387_hosestress";
    public const string strConnDb = @"Database="+ strDbName + ";Data Source=mysqlsrv;User Id=root;Password=mysqlpwd";
    public const string strDbTableData = strDbName + ".datalog";

    //definizione percorso generale modelli report prove
    public const string strReport_ModelBasePath = @"D:\dataapplications\v0449\Report\Modello\";
    public const string strReport_ModelName = "v0449_model.xlsx";
    public const string strReportEx_BasePath = @"D:\dataapplications\v0449\Report\";

    #region Canali analogici

    #region Ao channel names Siemens

    public enum aoChNoS7
    {
      //SM 1232 AQ4, la prima, AO
          s7ANoJ120MAND
        , s7ANoJ200CIRC
        , s7ANoJ530RAFF
        , s7ANoRiserva3
    };

    public static string[] aoChNamesS7 =
      { 
        //SM 1232 AQ4, la prima, AO
        " s7ANoJ120MAND"              //21 - 0
        ,"s7ANoJ200CIRC"
        ,"s7ANoJ530RAFF"
        ,"s7ANoRiserva3"
      };
    #endregion

    #region Ao label short Siemens
    public static string[] aoLabelShortS7 =
      { 
        //SM 1232 AQ4, la prima, AO
        " Comando drive riempimento"
        ,"Comando drive circolazione"
        ,"Comando drive raffreddamento"
        ,"Riserva canale 3"
      };
    #endregion

    #region Ao label long Siemens
    public static string[] aoLabelLongS7 =
      { 
        //SM 1232 AQ4, la prima, AO
        " Comando drive riempimento"
        ,"Comando drive circolazione"
        ,"Comando drive raffreddamento"
        ,"Riserva canale 3"
      };
    #endregion


    #endregion

    #region I/O digitali

    public enum Wexxx
    {
      ec0
      , ec1
      , ec2
      , ec3
    }
    public enum Wuxxx
    {
      uc0
      , uc1
      , uc2
    }
    public enum Waxxx
    {
      ac0
      , ac1
      , ac2
    }

    public enum ptrFaseGenRepo
    {
      _00_Init = 00,
      _10_InWorking = 10,
      _1000_NoRulesFUser = 1000,
      _1010_NoHeaderOnDb = 1010,
    };


    #region input

    #region We0
    public enum We0
    {
      iFT1410_port_C1
    , iFT2410_port_C2
    , iPulsanteAva_C1
    , iPulsanteInd_C1
    , iPulsanteAva_C2
    , iPulsanteInd_C2
    , i0_6_RiserveFut
    , i0_7_RiserveFut
    , iPS310_presAria
    , iReset_Allarmi_
    , iSelettoMarcia1
    , iSelettoMarcia2
    , SIeTUTT1_OK_Aux
    , SIeTUTT2_OK_Aux
    , iRBK1220pmpAlim
    , iRBK1130pmpRefr
    }

    public static string[] we0Descr =
      {
         "Impulsi misuratore portata C1"
        ,"Impulsi misuratore portata C2"
        ,"Pulsante avanti C1           "
        ,"Pulsante indietro C1         "
        ,"Pulsante avanti C2           "
        ,"Pulsante indietro C2         "
        ,"i0_6Riserve                  "
        ,"i0_7Riserva                  "
        ,"Pressostato generale aria    "
        ,"Reset allarmi                "
        ,"Selettore marcia C1          "
        ,"Selettore marcia C2          "
        ,"Comandi inseriti C1          "
        ,"Comandi inseriti C2          "
        ,"Readback pompa alim. C1      "
        ,"Readback pompa refr. C1      "
      };

    public static string[] we0Nick =
      {
         "iFT1410_port_C1"
        ,"iFT2410_port_C2"
        ,"iPulsanteAva_C1"
        ,"iPulsanteInd_C1"
        ,"iPulsanteAva_C2"
        ,"iPulsanteInd_C2"
        ,"i0_6_RiserveFut"
        ,"i0_7_RiserveFut"
        ,"iPS310_presAria"
        ,"iReset_Allarmi_"
        ,"iSelettoMarcia1"
        ,"iSelettoMarcia2"
        ,"SIeTUTT1_OK_Aux"
        ,"SIeTUTT2_OK_Aux"
        ,"iRBK1220pmpAlim"
        ,"iRBK1130pmpRefr"
      };

    public static Dictionary<int, string> faseGenReport = new Dictionary<int, string>(){
     {0  , "Attesa richieste				                         "}
    ,{1  , "Verifica diritti utente                          "}
    ,{2  , "Verifica esistenza database                      "}
    ,{3  , "Attesa richieste				                         "}
    ,{4  , "Attesa richieste				                         "}
    ,{10 , "In lavorazione                                   "}
    ,{20 , "Recupero dati da database                        "}
    ,{30 , "Analisi dati                                     "}
    ,{40 , "Apertura modello report                          "}
    ,{50 , "Scrittura dati su modello                        "}
    ,{60 , "Salvataggio temporaneo                           "}
    ,{70 , "pump down                                        "}
    ,{80 , "riposo da fermo (antiripetizione)                "}
    ,{500 , "Attenzione! La selezione non racchiude dati sul Database!    "}
    ,{510 , "Attenzione! attesa arresto flusso                            "}
    ,{520 , "Attenzione! attesa arresto flusso                            "}
    ,{530 , "Attenzione! attesa arresto flusso                            "}
    ,{540 , "Attenzione! attesa arresto flusso                            "}
    ,{1000, "Errore! Utente con diritti insufficienti, Contattare l'amministratore "}
    ,{1010, "Errore! Identificativo prova non trovato sul Database!        "}
    ,{1020, "Errore! Database irragiungibile!                "}
    ,{1030, "Errore! Identificativo prova non trovato        "}
    ,{1040, "Errore! Identificativo prova non trovato        "}
    ,{1050, "Errore! Timount il server non rispode.          "}
  };

    public static string[] we0Plc =
  {
         "vWe000"
        ,"vWe001"
        ,"vWe002"
        ,"vWe003"
        ,"vWe004"
        ,"vWe005"
        ,"vWe006"
        ,"vWe007"
        ,"vWe008"
        ,"vWe009"
        ,"vWe010"
        ,"vWe011"
        ,"vWe012"
        ,"vWe013"
        ,"vWe014"
        ,"vWe015"
      };


    public static string[] we0Comp =
  {
         "????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
      };
    #endregion

    #region We1
    public enum We1
    {
      iRBK1160risFlui
    , iRBK1400pmpCirc
    , iLHH1470lvAlAlt
    , iLVH1470lvWaAlt
    , iLVL1470lvWaBas
    , iLLL1470lvAlBas
    , iRBK2220pmpAlim
    , iRBK2130pmpRefr
    , iRBK2160risFlui
    , iRBK2400pmpCirc
    , iLHH2470lvAlAlt
    , iLVH2470lvWaAlt
    , iLVL2470lvWaBas
    , iLLL2470lvAlBas
    , riserva14
    , riserva15
    }

    public static string[] we1Descr =
    {
       "Readback riscaldatore fluido C1 "
      ,"Readback pompa circolazione C1  "
      ,"Livello allarme alto C1         "
      ,"Livello attenzione alto C1      "
      ,"Livello attenzione basso C1     "
      ,"Livello allarme basso C1        "
      ,"Readback pompa alimento C2      "
      ,"Readback pompa refrigerante C2  "
      ,"Readback riscaldatore fluido C2 "
      ,"Readback pompa circolazione C2  "
      ,"Livello allarme alto C2         "
      ,"Livello attenzione alto C2      "
      ,"Livello attenzione basso C2     "
      ,"Livello allarme basso C2        "
      ,"Riserva 14                      "
      ,"Riserva 15                      "
    };

    public static string[] we1Nick =
    {
        "iRBK1160risFlui"
      , "iRBK1400pmpCirc"
      , "iLHH1470lvAlAlt"
      , "iLVH1470lvWaAlt"
      , "iLVL1470lvWaBas"
      , "iLLL1470lvAlBas"
      , "iRBK2220pmpAlim"
      , "iRBK2130pmpRefr"
      , "iRBK2160risFlui"
      , "iRBK2400pmpCirc"
      , "iLHH2470lvAlAlt"
      , "iLVH2470lvWaAlt"
      , "iLVL2470lvWaBas"
      , "iLLL2470lvAlBas"
      , "riserva14      "
      , "riserva15      "
    };


    public static string[] we1Plc =
  {
         "vWe100"
        ,"vWe101"
        ,"vWe102"
        ,"vWe103"
        ,"vWe104"
        ,"vWe105"
        ,"vWe106"
        ,"vWe107"
        ,"vWe108"
        ,"vWe109"
        ,"vWe110"
        ,"vWe111"
        ,"vWe112"
        ,"vWe113"
        ,"vWe114"
        ,"vWe115"
      };


    public static string[] we1Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };

    #endregion

    #region We2
    public enum We2
    {
       vWe200_RISERVA
     , vWe201_RISERVA
     , vWe202_RISERVA
     , vWe203_RISERVA
     , vWe204_RISERVA
     , vWe205_RISERVA
     , vWe206_RISERVA
     , vWe207_RISERVA
     , vWe208_RISERVA
     , vWe209_RISERVA
     , vWe210_RISERVA
     , vWe211_RISERVA
     , vWe212_RISERVA
     , vWe213_RISERVA
     , vWe214_RISERVA
     , vWe215_RISERVA
    }

    public static string[] we2Descr =
      {
         "vWe200_RISERVA"
        ,"vWe201_RISERVA"
        ,"vWe202_RISERVA"
        ,"vWe203_RISERVA"
        ,"vWe204_RISERVA"
        ,"vWe205_RISERVA"
        ,"vWe206_RISERVA"
        ,"vWe207_RISERVA"
        ,"vWe208_RISERVA"
        ,"vWe209_RISERVA"
        ,"vWe210_RISERVA"
        ,"vWe211_RISERVA"
        ,"vWe212_RISERVA"
        ,"vWe213_RISERVA"
        ,"vWe214_RISERVA"
        ,"vWe215_RISERVA"
      };

    public static string[] we2Nick =
{
         "vWe200_RISERVA"
        ,"vWe201_RISERVA"
        ,"vWe202_RISERVA"
        ,"vWe203_RISERVA"
        ,"vWe204_RISERVA"
        ,"vWe205_RISERVA"
        ,"vWe206_RISERVA"
        ,"vWe207_RISERVA"
        ,"vWe208_RISERVA"
        ,"vWe209_RISERVA"
        ,"vWe210_RISERVA"
        ,"vWe211_RISERVA"
        ,"vWe212_RISERVA"
        ,"vWe213_RISERVA"
        ,"vWe214_RISERVA"
        ,"vWe215_RISERVA"
      };


    public static string[] we2Plc =
  {
         "vWe200"
        ,"vWe201"
        ,"vWe202"
        ,"vWe203"
        ,"vWe204"
        ,"vWe205"
        ,"vWe206"
        ,"vWe207"
        ,"vWe208"
        ,"vWe209"
        ,"vWe210"
        ,"vWe211"
        ,"vWe212"
        ,"vWe213"
        ,"vWe214"
        ,"vWe215"
      };


    public static string[] we2Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };



    #endregion

    #region We3
    public enum We3
    {
       vWe300_RISERVA
     , vWe301_RISERVA
     , vWe302_RISERVA
     , vWe303_RISERVA
     , vWe304_RISERVA
     , vWe305_RISERVA
     , vWe306_RISERVA
     , vWe307_RISERVA
     , vWe308_RISERVA
     , vWe309_RISERVA
     , vWe310_RISERVA
     , vWe311_RISERVA
     , vWe312_RISERVA
     , vWe313_RISERVA
     , vWe314_RISERVA
     , vWe315_RISERVA
    }

    public static string[] we3Descr =
      {
         "vWe300_RISERVA"
        ,"vWe301_RISERVA"
        ,"vWe302_RISERVA"
        ,"vWe303_RISERVA"
        ,"vWe304_RISERVA"
        ,"vWe305_RISERVA"
        ,"vWe306_RISERVA"
        ,"vWe307_RISERVA"
        ,"vWe308_RISERVA"
        ,"vWe309_RISERVA"
        ,"vWe310_RISERVA"
        ,"vWe311_RISERVA"
        ,"vWe312_RISERVA"
        ,"vWe313_RISERVA"
        ,"vWe314_RISERVA"
        ,"vWe315_RISERVA"
      };

    public static string[] we3Nick =
{
         "vWe300_RISERVA"
        ,"vWe301_RISERVA"
        ,"vWe302_RISERVA"
        ,"vWe303_RISERVA"
        ,"vWe304_RISERVA"
        ,"vWe305_RISERVA"
        ,"vWe306_RISERVA"
        ,"vWe307_RISERVA"
        ,"vWe308_RISERVA"
        ,"vWe309_RISERVA"
        ,"vWe310_RISERVA"
        ,"vWe311_RISERVA"
        ,"vWe312_RISERVA"
        ,"vWe313_RISERVA"
        ,"vWe314_RISERVA"
        ,"vWe315_RISERVA"
      };


    public static string[] we3Plc =
  {
         "vWe300"
        ,"vWe301"
        ,"vWe302"
        ,"vWe303"
        ,"vWe304"
        ,"vWe305"
        ,"vWe306"
        ,"vWe307"
        ,"vWe308"
        ,"vWe309"
        ,"vWe310"
        ,"vWe311"
        ,"vWe312"
        ,"vWe313"
        ,"vWe314"
        ,"vWe315"
      };


    public static string[] we3Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };



    #endregion


    #endregion


    #region output

    #region Wu0
    public enum Wu0
    {
        q0_0UscitaRiserva
      , q0_1UscitaRiserva
      , q0_2UscitaRiserva
      , q0_3UscitaRiserva
      , q0_4UscitaRiserva
      , q0_5UscitaRiserva
      , q0_6UscitaRiserva
      , q0_7UscitaRiserva
      , qLampSegn_Allarme
      , qLampSegnRegolare
      , qKM1220__pompalim
      , qKM1130__pomprefr
      , qKM1160__riscflui
      , qKM1400__pompcirc
      , q2_4UscitaRiserva
      , q2_5UscitaRiserva
    }

    public static string[] wu0Descr =
    {
        "q0_0UscitaRiserva"
      , "q0_1UscitaRiserva"
      , "q0_2UscitaRiserva"
      , "q0_3UscitaRiserva"
      , "q0_4UscitaRiserva"
      , "q0_5UscitaRiserva"
      , "q0_6UscitaRiserva"
      , "q0_7UscitaRiserva"
      , "qLampSegn_Allarme"
      , "qLampSegnRegolare"
      , "qKM1220__pompalim"
      , "qKM1130__pomprefr"
      , "qKM1160__riscflui"
      , "qKM1400__pompcirc"
      , "q2_4UscitaRiserva"
      , "q2_5UscitaRiserva"

    };

    public static string[] wu0Nick =
    {
        "q0_0UscitaRiserva"
      , "q0_1UscitaRiserva"
      , "q0_2UscitaRiserva"
      , "q0_3UscitaRiserva"
      , "q0_4UscitaRiserva"
      , "q0_5UscitaRiserva"
      , "q0_6UscitaRiserva"
      , "q0_7UscitaRiserva"
      , "qLampSegn_Allarme"
      , "qLampSegnRegolare"
      , "qKM1220__pompalim"
      , "qKM1130__pomprefr"
      , "qKM1160__riscflui"
      , "qKM1400__pompcirc"
      , "q2_4UscitaRiserva"
      , "q2_5UscitaRiserva"
    };


    public static string[] wu0Plc =
    {
        "q0_0UscitaRiserva"
      , "q0_1UscitaRiserva"
      , "q0_2UscitaRiserva"
      , "q0_3UscitaRiserva"
      , "q0_4UscitaRiserva"
      , "q0_5UscitaRiserva"
      , "q0_6UscitaRiserva"
      , "q0_7UscitaRiserva"
      , "qLampSegn_Allarme"
      , "qLampSegnRegolare"
      , "qKM1220__pompalim"
      , "qKM1130__pomprefr"
      , "qKM1160__riscflui"
      , "qKM1400__pompcirc"
      , "q2_4UscitaRiserva"
      , "q2_5UscitaRiserva"
    };


    public static string[] wu0Comp =
  {
         "????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
      };
    #endregion

    #region Wu1
    public enum Wu1
    {
        q2_6UscitaRiserva
      , q2_7UscitaRiserva
      , qYV1230__alimScar
      , qYV1420__mandProv
      , qYV1430__ritoProv
      , qYV1440__scarLive
      , qYV1330A_aumePres
      , qYV1330B_dimiPres
      , qRST1160_moduRisc
      , qEN1400__abilCirc
      , qKM2220__pompalim
      , qKM2130__pomprefr
      , qKM2160__riscflui
      , qKM2400__pompcirc
      , q4_4UscitaRiserva
      , q4_5UscitaRiserva
    }

    public static string[] wu1Descr =
    {
        "q2_6UscitaRiserva"
      , "q2_7UscitaRiserva"
      , "qYV1230__alimScar"
      , "qYV1420__mandProv"
      , "qYV1430__ritoProv"
      , "qYV1440__scarLive"
      , "qYV1330A_aumePres"
      , "qYV1330B_dimiPres"
      , "qRST1160_moduRisc"
      , "qEN1400__abilCirc"
      , "qKM2220__pompalim"
      , "qKM2130__pomprefr"
      , "qKM2160__riscflui"
      , "qKM2400__pompcirc"
      , "q4_4UscitaRiserva"
      , "q4_5UscitaRiserva"
    };

    public static string[] wu1Nick =
    {
        "q2_6UscitaRiserva"
      , "q2_7UscitaRiserva"
      , "qYV1230__alimScar"
      , "qYV1420__mandProv"
      , "qYV1430__ritoProv"
      , "qYV1440__scarLive"
      , "qYV1330A_aumePres"
      , "qYV1330B_dimiPres"
      , "qRST1160_moduRisc"
      , "qEN1400__abilCirc"
      , "qKM2220__pompalim"
      , "qKM2130__pomprefr"
      , "qKM2160__riscflui"
      , "qKM2400__pompcirc"
      , "q4_4UscitaRiserva"
      , "q4_5UscitaRiserva"
    };


    public static string[] wu1Plc =
    {
        "q2_6UscitaRiserva"
      , "q2_7UscitaRiserva"
      , "qYV1230__alimScar"
      , "qYV1420__mandProv"
      , "qYV1430__ritoProv"
      , "qYV1440__scarLive"
      , "qYV1330A_aumePres"
      , "qYV1330B_dimiPres"
      , "qRST1160_moduRisc"
      , "qEN1400__abilCirc"
      , "qKM2220__pompalim"
      , "qKM2130__pomprefr"
      , "qKM2160__riscflui"
      , "qKM2400__pompcirc"
      , "q4_4UscitaRiserva"
      , "q4_5UscitaRiserva"
    };


    public static string[] wu1Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };

    #endregion

    #region Wu2
    public enum Wu2
    {
        q4_6UscitaRiserva
      , q4_7UscitaRiserva
      , qYV2230__alimScar
      , qYV2420__mandProv
      , qYV2430__ritoProv
      , qYV2440__scarLive
      , qYV2330A_aumePres
      , qYV2330B_dimiPres
      , qRST2160_moduRisc
      , qEN2400__abilCirc
      , ris42
      , ris43
      , ris44
      , ris45
      , ris46
      , ris47
    }

    public static string[] wu2Descr =
    {
       "q4_6UscitaRiserva"
      ,"q4_7UscitaRiserva"
      ,"qYV2230__alimScar"
      ,"qYV2420__mandProv"
      ,"qYV2430__ritoProv"
      ,"qYV2440__scarLive"
      ,"qYV2330A_aumePres"
      ,"qYV2330B_dimiPres"
      ,"qRST2160_moduRisc"
      ,"qEN2400__abilCirc"
      ,"ris42            "
      ,"ris43            "
      ,"ris44            "
      ,"ris45            "
      ,"ris46            "
      ,"ris47            "
    };

    public static string[] wu2Nick =
    {
       "q4_6UscitaRiserva"
      ,"q4_7UscitaRiserva"
      ,"qYV2230__alimScar"
      ,"qYV2420__mandProv"
      ,"qYV2430__ritoProv"
      ,"qYV2440__scarLive"
      ,"qYV2330A_aumePres"
      ,"qYV2330B_dimiPres"
      ,"qRST2160_moduRisc"
      ,"qEN2400__abilCirc"
      ,"ris42            "
      ,"ris43            "
      ,"ris44            "
      ,"ris45            "
      ,"ris46            "
      ,"ris47            "
    };


    public static string[] wu2Plc =
    {
       "q4_6UscitaRiserva"
      ,"q4_7UscitaRiserva"
      ,"qYV2230__alimScar"
      ,"qYV2420__mandProv"
      ,"qYV2430__ritoProv"
      ,"qYV2440__scarLive"
      ,"qYV2330A_aumePres"
      ,"qYV2330B_dimiPres"
      ,"qRST2160_moduRisc"
      ,"qEN2400__abilCirc"
      ,"ris42            "
      ,"ris43            "
      ,"ris44            "
      ,"ris45            "
      ,"ris46            "
      ,"ris47            "
    };


    public static string[] wu2Comp =
  {
         " ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
      };



    #endregion

    #region Wu3
    public enum Wu3
    {
       vWu300_RISERVA
     , vWu301_RISERVA
     , vWu302_RISERVA
     , vWu303_RISERVA
     , vWu304_RISERVA
     , vWu305_RISERVA
     , vWu306_RISERVA
     , vWu307_RISERVA
     , vWu308_RISERVA
     , vWu309_RISERVA
     , vWu310_RISERVA
     , vWu311_RISERVA
     , vWu312_RISERVA
     , vWu313_RISERVA
     , vWu314_RISERVA
     , vWu315_RISERVA
    }

    public static string[] wu3Descr =
      {
         "  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
      };

    public static string[] wu3Nick =
{
         "vWu300_RISERVA "
        ,"vWu301_RISERVA "
        ,"vWu302_RISERVA "
        ,"vWu303_RISERVA "
        ,"vWu304_RISERVA "
        ,"vWu305_RISERVA "
        ,"vWu306_RISERVA "
        ,"vWu307_RISERVA "
        ,"vWu308_RISERVA "
        ,"vWu309_RISERVA      "
        ,"vWu310_RISERVA      "
        ,"vWu311_RISERVA      "
        ,"vWu312_RISERVA      "
        ,"vWu313_RISERVA      "
        ,"vWu314_RISERVA      "
        ,"vWu315_RISERVA      "
      };


    public static string[] wu3Plc =
  {
         "vWu300_"
        ,"vWu301_"
        ,"vWu302_"
        ,"vWu303_"
        ,"vWu304_"
        ,"vWu305_"
        ,"vWu306_"
        ,"vWu307_"
        ,"vWu308_"
        ,"vWu309_"
        ,"vWu310_"
        ,"vWu311_"
        ,"vWu312_"
        ,"vWu313_"
        ,"vWu314_"
        ,"vWu315_"
      };


    public static string[] wu3Comp =
  {
         " ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
      };



    #endregion

    #endregion
    #endregion





#if v0387
    #region allarmi 0449
    public enum Wa00
    {
       AL0_0_SInTUTTO_OK 
     , AL0_1_FCn0PORTNOCH
     , AL0_2_TSn0RISCFLUI
     , AL0_3_TSn0TEMPCAME
     , AL0_4_LVn2FLUPROOK
     , AL0_5_LSn0TRAFFLUI
     , AL0_6_PSn0PRESARIA
     , AL0_7_LVn1OLIOBASS
     , AL0_8_PSn0HP_1FRIG
     , AL0_9_TSn0LT_1FRIG
     , AL0_a_FLn0LQ_1FRIG
     , AL0_b_FLn0GQ_2FRIG
     , AL0_c_LVn0HG_1FRIG
     , AL0_d_PSn0HP_2FRIG
     , AL0_e_PSn0LP_2FRIG
     , AL0_f_TEn0COMP1FRI
    }

    public static string[] wa0Descr =
  {
         "0.all. circuiti ausiliari inseriti "
        ,"0.all. porta cella non chiusa "
        ,"0.all. termostato sicurezza riscaldatore fluido "
        ,"0.all. termostato sicurezza cella climatica "
        ,"2.all. livello fluido prova sufficiente "
        ,"0.all. trafilamento fluido da elementi in prova "
        ,"0.all. pressione aria sufficiente "
        ,"1.all. livello olio centralina insufficiente "
        ,"0.all. sovrapressione 1� stadio gr.frigorifero "
        ,"0.all. termostato di minima 1� stadio gr.frigorifero "
        ,"0.all. flussostato 1� stadio gruppo frigorifero "
        ,"0.all. fl circ.fl. in cella da 1� st./fl cond. 2� st "
        ,"0.all. livello fluido vasca 1� stadio gr.frigorifero "
        ,"0.all. sovrapressione 2� stadio gr.frigorifero "
        ,"0.all. insufficiente pressione 2� st.gr.frigorifero "
        ,"0.all. interv.prot.mot.compressore 1�st.gr.frigor. "
      };

    public static string[] wa0Nick =
      {
         "SInTUTTO_OK  "
        ,"FCn0PORTNOCH "
        ,"TSn0RISCFLUI "
        ,"TSn0TEMPCAME "
        ,"LVn2FLUPROOK "
        ,"LSn0TRAFFLUI "
        ,"PSn0PRESARIA "
        ,"LVn1OLIOBASS "
        ,"PSn0HP_1FRIG "
        ,"TSn0LT_1FRIG "
        ,"FLn0LQ_1FRIG "
        ,"FLn0GQ_2FRIG "
        ,"LVn0HG_1FRIG "
        ,"PSn0HP_2FRIG "
        ,"PSn0LP_2FRIG "
        ,"TEn0COMP1FRI "
      };


    public static string[] wa0Plc =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public static string[] wa0Comp =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public enum Wa01
    {
       AL1_0_TEn0COMP2FRI
     , AL1_1_TEn0POMP1FRI
     , AL1_2_TEn0POMPCELL
     , AL1_3_TEn0POMPP1P2
     , AL1_4_TEn0POMP_P3_
     , AL1_5_TEn1POMP_P4_
     , AL1_6_TEn2MREGCIPR
     , AL1_7_TEn1VENTCELL
     , AL1_8_TEn0RISCCELL
     , AL1_9_SNn1FILTCECL
     , AL1_a_SNn1FISER1CL
     , AL1_b_SNn1FIVIBRCL
     , AL1_c_SNn1FIPILOCL
     , AL1_d_SNn0PROT_AUX
     , AL1_e_SNn0PROTFIEL
     , AL1_f_SNn0EMERRIPR
    }


    public static string[] wa1Descr =
  {
         "0.all. interv.prot.mot.compressore 2�st.gr.frigor."
        ,"0.all. interv.prot.mot.pompa raffr.vasca 1�st.frigor."
        ,"0.all. interv.prot.mot.pompa raffr.cella da 1� stadio"
        ,"1 all interv. prot.mot.pompe P1-P2"
        ,"0.all. interv.prot.motore pompa P3"
        ,"1.all. interv.prot.motore pompa P4"
        ,"2.all. interv.prot.mot.regol.corsa cilindro pressione"
        ,"1.all. interv.prot.motore ventola cella"
        ,"0.all. interv.prot.riscaldatore cella"
        ,"1.all. filtro principale centralina intasato"
        ,"1.all. filtro servizio cilindro 1 intasato"
        ,"1.all. filtro servizio vibratore intasato"
        ,"1.all. filtro servizio pilotaggio cil.1 intasato"
        ,"0.all. interv.prot.circuiti 24Vdc"
        ,"0.all. intervento protez.filtro elettrostatico"
        ,"0.all. emergenza ripristinata"
      };

    public static string[] wa1Nick =
      {
         "TEn0COMP2FRI"
        ,"TEn0POMP1FRI"
        ,"TEn0POMPCELL"
        ,"TEn0POMPP1P2"
        ,"TEn0POMP_P3_"
        ,"TEn1POMP_P4_"
        ,"TEn2MREGCIPR"
        ,"TEn1VENTCELL"
        ,"TEn0RISCCELL"
        ,"SNn1FILTCECL"
        ,"SNn1FISER1CL"
        ,"SNn1FIVIBRCL"
        ,"SNn1FIPILOCL"
        ,"SNn0PROT_AUX"
        ,"SNn0PROTFIEL"
        ,"SNn0EMERRIPR"
      };


    public static string[] wa1Plc =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public static string[] wa1Comp =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public enum Wa02
    {
       AL2_0_SLn0AUTOMATI
     , AL2_1_SNn1DRIVFLOK
     , AL2_2_PSn0LOPRFRI1
     , AL2_3_SQnSTEPUNDF 
     , AL2_4_SQnTESTLIVE 
     , AL2_5_
     , AL2_6_
     , AL2_7_
     , AL2_8_
     , AL2_9_
     , AL2_a_
     , AL2_b_
     , AL2_c_
     , AL2_d_
     , AL2_e_
     , AL2_f_
    }


    public static string[] wa2Descr =
  {
         "0.all. selettore comandi automatici"
        ,"1.all. nessuna anomalia inverter pompa circolaz."
        ,"0 all alta pressione primo stadio"
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
      };

    public static string[] wa2Nick =
      {
         "SLn0AUTOMATI "
        ,"SNn1DRIVFLOK "
        ,"PSn0LOPRFRI1 "
        ,"SQnSTEPUNDF "
        ,"SQnTESTLIVE "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
      };


    public static string[] wa2Plc =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public static string[] wa2Comp =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public string[,] msgAll =
 {
   {
 "AL0.0 SInTUTTO_OK "
,"AL0.1 FCn0PORTNOCH"
,"AL0.2 TSn0RISCFLUI"
,"AL0.3 TSn0TEMPCAME"
,"AL0.4 LVn2FLUPROOK"
,"AL0.5 LSn0TRAFFLUI"
,"AL0.6 PSn0PRESARIA"
,"AL0.7 LVn1OLIOBASS"
,"AL0.8 PSn0HP_1FRIG"
,"AL0.9 TSn0LT_1FRIG"
,"AL0.a FLn0LQ_1FRIG"
,"AL0.b FLn0GQ_2FRIG"
,"AL0.c LVn0HG_1FRIG"
,"AL0.d PSn0HP_2FRIG"
,"AL0.e PSn0LP_2FRIG"
,"AL0.f TEn0COMP1FRI"
     },
   {
 "AL1.0 TEn0COMP2FRI"
,"AL1.1 TEn0POMP1FRI"
,"AL1.2 TEn0POMPCELL"
,"AL1.3 TEn0POMPP1P2"
,"AL1.4 TEn0POMP_P3_"
,"AL1.5 TEn1POMP_P4_"
,"AL1.6 TEn2MREGCIPR"
,"AL1.7 TEn1VENTCELL"
,"AL1.8 TEn0RISCCELL"
,"AL1.9 SNn1FILTCECL"
,"AL1.a SNn1FISER1CL"
,"AL1.b SNn1FIVIBRCL"
,"AL1.c SNn1FIPILOCL"
,"AL1.d SNn0PROT_AUX"
,"AL1.e SNn0PROTFIEL"
,"AL1.f SNn0EMERRIPR"
  },
   {
 "AL1.0 SLn0AUTOMATI"
,"AL1.1 SNn1DRIVFLOK"
,"AL1.2 PSn0LOPRFRI1"
,"AL1.3 SQnSTEPUNDF "
,"AL1.4 SQnTESTLIVE "
,"AL1.5 "
,"AL1.6 "
,"AL1.7 "
,"AL1.8 "
,"AL1.9 "
,"AL1.a "
,"AL1.b "
,"AL1.c "
,"AL1.d "
,"AL1.e "
,"AL1.f "
  }
};

    #endregion
#elif v0470
    #region allarmi 0470
    public enum Wa00
    {
       SnIeTUTT1_OK
     , SnIeTUTT2_OK
     , anPS310__presAria
     , anRBK1220_pompAlim
     , anRBK1130_pompRefr
     , anRBK1160_riscFlui
     , anRBK1400_pompCirc
     , anLHH1470_lvAlAlto
     , anLVH1470_lvWaAlto
     , anLVL1470_lvWaBass
     , anLLL1470_lvAlBass
     , anRBK2220_pompAlim
     , anRBK2130_pompRefr
     , anRBK2160_riscFlui
     , anRBK2400_pompCirc
     , anLHH2470_lvAlAlto
    }

    public static string[] wa0Descr =
  {
         "all. C1 - Comandi non inseriti C1               "
        ,"all. C2 - Comandi non inseriti C2               "
        ,"all. C1 - Bassa pressione aria                  "
        ,"all. C1 - Anomalia pompa alimento C1            "
        ,"all. C1 - Anomalia pompa aux raffreddamento C1  "
        ,"all. C1 - Anomalia riscaldatore C1              "
        ,"all. C1 - Anomalia pompa processo C1            "
        ,"all. C1 - allarme eccesso fluido                "
        ,"all. C1 - livello alto                          "
        ,"all. C1 - livello basso                         "
        ,"all. C1 - allarme mancanza fluido               "
        ,"all. C2 - Anomalia pompa alimento C1            "
        ,"all. C2 - Anomalia pompa aux raffreddamento C1  "
        ,"all. C2 - Anomalia riscaldatore C1              "
        ,"all. C2 - Anomalia pompa processo C1            "
        ,"all. C2 - allarme eccesso fluido                "

      };

    public static string[] wa0Nick =
      {
         "SnIeTUTT1_OK"
        ,"SnIeTUTT2_OK"
        ,"anPS310__presAria"
        ,"anRBK1220_pompAlim"
        ,"anRBK1130_pompRefr"
        ,"anRBK1160_riscFlui"
        ,"anRBK1400_pompCirc"
        ,"anLHH1470_lvAlAlto"
        ,"anLVH1470_lvWaAlto"
        ,"anLVL1470_lvWaBass"
        ,"anLLL1470_lvAlBass"
        ,"anRBK2220_pompAlim"
        ,"anRBK2130_pompRefr"
        ,"anRBK2160_riscFlui"
        ,"anRBK2400_pompCirc"
        ,"anLHH2470_lvAlAlto"
      };


    public static string[] wa0Plc =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public static string[] wa0Comp =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public enum Wa01
    {
       anLVH2470_lvWaAlto
     , anLVL2470_lvWaBass
     , anLLL2470_lvAlBass
     , SnQaSTEPUNDF_1
     , SnQaTESTLIVE_1
     , anRiserva
     , anRiserva_1
     , anRiserva_2
     , anRiserva_3
     , anRiserva_4
     , anRiserva_5
     , anRiserva_6
     , anRiserva_7
     , anRiserva_8
     , anRiserva_9
     , anRiserva_10
    }


    public static string[] wa1Descr =
  {
         "C2 - livello alto            "
        ,"C2 - livello basso           "
        ,"C2 - allarme mancanza fluido "
        ,"Passo prova non definito     "
        ,"Prova attiva                 "
        ,"                             "
        ,"                             "
        ,"                             "
        ,"                             "
        ,"                             "
        ,"                             "
        ,"                             "
        ,"                             "
        ,"                             "
        ,"                             "
        ,"                             "
      };                               


    public static string[] wa1Nick =
      {
         "anLVH2470_lvWaAlto"
        ,"anLVL2470_lvWaBass"
        ,"anLLL2470_lvAlBass"
        ,"SnQaSTEPUNDF_1    "
        ,"SnQaTESTLIVE_1    "
        ,"anRiserva         "
        ,"anRiserva_1       "
        ,"anRiserva_2       "
        ,"anRiserva_3       "
        ,"anRiserva_4       "
        ,"anRiserva_5       "
        ,"anRiserva_6       "
        ,"anRiserva_7       "
        ,"anRiserva_8       "
        ,"anRiserva_9       "
        ,"anRiserva_10      "
      };


    public static string[] wa1Plc =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public static string[] wa1Comp =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public enum Wa02
    {
       AL2_0_
     , AL2_1_
     , AL2_2_
     , AL2_3_
     , AL2_4_
     , AL2_5_
     , AL2_6_
     , AL2_7_
     , AL2_8_
     , AL2_9_
     , AL2_a_
     , AL2_b_
     , AL2_c_
     , AL2_d_
     , AL2_e_
     , AL2_f_
    }


    public static string[] wa2Descr =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };

    public static string[] wa2Nick =
      {
         " "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
      };


    public static string[] wa2Plc =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public static string[] wa2Comp =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public string[,] msgAll =
 {
   {
 "AL0.0 SnIeTUTT1_OK      "
,"AL0.1 SnIeTUTT2_OK      "
,"AL0.2 anPS310__presAria "
,"AL0.3 anRBK1220_pompAlim"
,"AL0.4 anRBK1130_pompRefr"
,"AL0.5 anRBK1160_riscFlui"
,"AL0.6 anRBK1400_pompCirc"
,"AL0.7 anLHH1470_lvAlAlto"
,"AL0.8 anLVH1470_lvWaAlto"
,"AL0.9 anLVL1470_lvWaBass"
,"AL0.a anLLL1470_lvAlBass"
,"AL0.b anRBK2220_pompAlim"
,"AL0.c anRBK2130_pompRefr"
,"AL0.d anRBK2160_riscFlui"
,"AL0.e anRBK2400_pompCirc"
,"AL0.f anLHH2470_lvAlAlto"
     },
   {
 "AL1.0 anLVH2470_lvWaAlto"
,"AL1.1 anLVL2470_lvWaBass"
,"AL1.2 anLLL2470_lvAlBass"
,"AL1.3 SnQaSTEPUNDF_1    "
,"AL1.4 SnQaTESTLIVE_1    "
,"AL1.5 anRiserva         "
,"AL1.6 anRiserva_1       "
,"AL1.7 anRiserva_2       "
,"AL1.8 anRiserva_3       "
,"AL1.9 anRiserva_4       "
,"AL1.a anRiserva_5       "
,"AL1.b anRiserva_6       "
,"AL1.c anRiserva_7       "
,"AL1.d anRiserva_8       "
,"AL1.e anRiserva_9       "
,"AL1.f anRiserva_10      "
  },
   {
 "AL1.0 " +
          ""
,"AL1.1 " +
          ""
,"AL1.2 " +
          ""
,"AL1.3 " +
          ""
,"AL1.4 " +
          ""
,"AL1.5 "
,"AL1.6 "
,"AL1.7 "
,"AL1.8 "
,"AL1.9 "
,"AL1.a "
,"AL1.b "
,"AL1.c "
,"AL1.d "
,"AL1.e "
,"AL1.f "
  }
};

    #endregion

#endif
    #region Fasi e Cicli
    #region CicliPtr
    public enum ptrFaseFrigo
    {
      _00_Init                     = 00 ,
      _10_attesaStart              = 10 ,
      _20_avviamentoPompa          = 20 ,
      _30_attendeFlusso            = 30 ,
      _40_pronto_richiesta_freddo  = 40 ,
      _50_alimentazione_liquida    = 50 ,
      _60_funzione_Normale         = 60 ,
      _70_pump_down                = 70 ,
      _80_riposo_fermo             = 80 ,
      _90_pump_down                = 90 ,
      _1000_gestione_fault         = 1000,
      _1001_rientro_reset          = 1001,
    };

    
    public static string[] ptrFaseFrigoLbl =
    {
      "00 - Reset ciclo"
      ,"10 - Attesa comandi"
      ,"20 - Riempimento impianto"
      ,"30 - Caratterizzazione"
      ,"40 - Verifica prestazioni"
      ,"50 - Esecuzione passo prova"
      ,"60 - Svuotamento impianto"
      ,"100 - Fine"
    };

    public static Dictionary<int, string> faseFrigo = new Dictionary<int, string>(){
     {0  , "init: in teoria solo al power on plc				     "}
    ,{10 , "attesa richiesta marcia                          "}
    ,{20 , "avviamento pompa circolazione                    "}
    ,{30 , "attende flusso                                   "}
    ,{40 , "pronto alla marcia - attesa richiesta freddo     "}
    ,{50 , "Alimentazione liquida                            "}
    ,{60 , "Funzionamento normale                            "}
    ,{70 , "pump down                                        "}
    ,{80 , "riposo da fermo (antiripetizione)                "}
    ,{90 , "attesa arresto flusso                            "}
    ,{1000, "gestione fault                                  "}
    ,{1001, "rientro reset                                   "}
  };

    public static Dictionary<int, string> riscaldoCella = new Dictionary<int, string>(){
     {0  , "init: in teoria solo al power on plc				     "}
    ,{10 , "attesa richiesta marcia                          "}
    ,{20 , "                                                 "}
    ,{30 , "                                                 "}
    ,{40 , "pronto alla marcia - attesa richiesta caldo      "}
    ,{50 , "Regimazione ventilatore                          "}
    ,{60 , "Funzionamento normale                            "}
    ,{70 , "Spegnimento riscaldo                             "}
    ,{80 , "Arresto ventilatore                              "}
    ,{90 , "                                                 "}
    ,{1000, "gestione fault                                  "}
    ,{1001, "rientro reset                                   "}
  };

    public static Dictionary<int, string> raffreddamentoCella = new Dictionary<int, string>(){
     {0  , "init: in teoria solo al power on plc				     "}
    ,{10 , "attesa richiesta marcia                          "}
    ,{20 , "                    "}
    ,{30 , ""}
    ,{40 , "pronto alla marcia - attesa richiesta freddo     "}
    ,{50 , ""}
    ,{60 , ""}
    ,{70 , ""}
    ,{80 , ""}
    ,{90 , ""}
    ,{100, "Raffreddamento a glicole"}
    ,{110, "Da glicole a freon, svuotamento a tempo"}
    ,{200, "Raffreddamento freon, espansione diretta"}
    ,{400, "Conclusione fase raffreddamento"}
    ,{1000, "gestione fault                                  "}
    ,{1001, "rientro reset                                   "}
  };

    //  public static Dictionary<int, string> faseFrigo = new Dictionary<int, string>(){
    //   {0  , "init: in teoria solo al power on plc				     "}
    //  ,{10 , "attesa richiesta marcia                          "}
    //  ,{20 , "avviamento pompa circolazione                    "}
    //  ,{30 , "attende flusso                                   "}
    //  ,{40 , "pronto alla marcia - attesa richiesta freddo     "}
    //  ,{50 , "Alimentazione liquida                            "}
    //  ,{60 , "Funzionamento normale                            "}
    //  ,{70 , "pump down                                        "}
    //  ,{80 , "riposo da fermo (antiripetizione)                "}
    //  ,{90 , "attesa arresto flusso                            "}
    //  ,{1000, "gestione fault                                  "}
    //  ,{1001, "rientro reset                                   "}
    //};




    #endregion
    #endregion
    #endregion

#elif v0387lastOriginale

    #region def


    #region I/O digitali

    public enum Wexxx
    {
      ec0
      , ec1
      , ec2
//      , ec3
    }
    public enum Wuxxx
    {
      uc0
      , uc1
//      , uc2
    }
    public enum Waxxx
    {
      ac0
      , ac1
      , ac2
      , ac3
    }

    #region input

    #region We0
    public enum We0
    {
       vWe000_MSeF130EME2 
     , vWe001_SIeTutto_Ok 
     , vWe002_MSeF130EME1 
     , vWe003_TEeP120MAND 
     , vWe004_MSeF230RSIG 
     , vWe005_KMeP120MAND 
     , vWe006_MSeF340RANE 
     , vWe007_DReP120OK 	
     , vWe008_MSeF250PORTA
     , vWe009_MSeF250PORTB
     , vWe010_TEeP200CIRC 
     , vWe011_KMeP200CIRC 
     , vWe012_DReP200OK 	
     , vWe013_TEeR210RISC 
     , vWe014_SLeCICLAUTO
     , vWe015_Riserva
    }

    public static string[] we0Descr =
      {
         "vWe000.Port.H20 Sec.Salto Emerg.  "
        ,"vWe001.Ausiliari Pulsante Inseriti  "
        ,"vWe002.Port.H20 Pri.Salto Emerg.  "
        ,"vWe003.Contatto Int.Pompa mandata  "
        ,"vWe004.Port.H20 Raff. Siringa  "
        ,"vWe005.Contatto teleruttore Pompa mandata  "
        ,"vWe006.Port.H20 Raff. Circuito  "
        ,"vWe007.Drive pompa mandata OK  "
        ,"vWe008.Port. Fluido Test A  "
        ,"vWe009.Port. Fluido Test B  "
        ,"vWe010.Contatto int.Pompa circolazione  "
        ,"vWe011.Contatto teleruttore Pompa circolazione  "
        ,"vWe012.Drive pompa circolazione OK  "
        ,"vWe013.Contatto int.Circuito Riscaldo  "
        ,"vWe014.Selettore auto/manuale  "
        ,"vWe015.Riserva  "
      };

    public static string[] we0Nick =
      {
         "vWe000_MSeF130EME2  "
        ,"vWe001_SIeTutto_Ok  "
        ,"vWe002_MSeF130EME1  "
        ,"vWe003_TEeP120MAND  "
        ,"vWe004_MSeF230RSIG  "
        ,"vWe005_KMeP120MAND  "
        ,"vWe006_MSeF340RANE  "
        ,"vWe007_DReP120OK 	  "
        ,"vWe008_MSeF250PORTA "
        ,"vWe009_MSeF250PORTB "
        ,"vWe010_TEeP200CIRC  "
        ,"vWe011_KMeP200CIRC  "
        ,"vWe012_DReP200OK 	  "
        ,"vWe013_TEeR210RISC  "
        ,"vWe014_SLeCICLAUTO  "
        ,"vWe015_Riserva      "
      };                      


    public static string[] we0Plc =
  {
         "vWe000"
        ,"vWe001"
        ,"vWe002"
        ,"vWe003"
        ,"vWe004"
        ,"vWe005"
        ,"vWe006"
        ,"vWe007"
        ,"vWe008"
        ,"vWe009"
        ,"vWe010"
        ,"vWe011"
        ,"vWe012"
        ,"vWe013"
        ,"vWe014"
        ,"vWe015"
      };


    public static string[] we0Comp =
  {
         "????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
      };
    #endregion

    #region We1
    public enum We1
    {
       vWe100_KMeR210RISC
     , vWe101_TEeS230EROG
     , vWe102_KMeS230EROG
     , vWe103_DReS230OK 	
     , vWe104_TSeR210OK 	
     , vWe105_SNeP400PAIR
     , vWe106_PUeINDIETRO
     , vWe107_PUeAVANTI
     , vWe108_TEeP530RAFF
     , vWe109_KMeP530RAFF
     , vWe110_DReP530__OK
     , vWe111_LSeSERBNOHI
     , vWe112_LSeSERBNOLO
     , vWe113_LSeSPUNOAIR
     , vWe114_OPeV190SVUO
     , vWe115_CLeV190SVUO
    }

    public static string[] we1Descr =
      {
         "vWe100.Contatto teleruttore circ.Riscaldo  "
        ,"vWe101.Contatto int.siringa  "
        ,"vWe102.Contatto teleruttore siringa  "
        ,"vWe103.Drive enable siringa  "
        ,"vWe104.Termostato sicurezza  "
        ,"vWe105.Pressostato presenza aria  "
        ,"vWe106.Pulsante Indietro  "
        ,"vWe107.Pulsante Avanti "
        ,"vWe108.Contatto int.Pompa circolazione H2O  "
        ,"vWe109.Contatto teleruttore Pompa circolazione H2O  "
        ,"vWe110.Drive pompa circolazione OK H2O  "
        ,"vWe111.Livello Serbaoio Alto  "
        ,"vWe112.Livello serbatoio Basso  "
        ,"vWe113.Livello Spurgo  "
        ,"vWe114.Valvola scarico aperta  "
        ,"vWe115.Valvola scarico chiusa  "
      };

    public static string[] we1Nick =
  {
         "vWe100_KMeR210RISC"
        ,"vWe101_TEeS230EROG"
        ,"vWe102_KMeS230EROG"
        ,"vWe103_DReS230OK 	"
        ,"vWe104_TSeR210OK 	"
        ,"vWe105_SNeP400PAIR"
        ,"vWe106_PUeINDIETRO"
        ,"vWe107_PUeAVANTI"
        ,"vWe108_TEeP530RAFF"
        ,"vWe109_KMeP530RAFF"
        ,"vWe110_DReP530__OK"
        ,"vWe111_LSeSERBNOHI"
        ,"vWe112_LSeSERBNOLO"
        ,"vWe113_LSeSPUNOAIR"
        ,"vWe114_OPeV190SVUO"
        ,"vWe115_CLeV190SVUO"
      };


    public static string[] we1Plc =
  {
         "vWe100"
        ,"vWe101"
        ,"vWe102"
        ,"vWe103"
        ,"vWe104"
        ,"vWe105"
        ,"vWe106"
        ,"vWe107"
        ,"vWe108"
        ,"vWe109"
        ,"vWe110"
        ,"vWe111"
        ,"vWe112"
        ,"vWe113"
        ,"vWe114"
        ,"vWe115"
      };


    public static string[] we1Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };

    #endregion

    #region We2
    public enum We2
    {
       vWe200_OPeV260MAND
     , vWe201_CLeV260MAND
     , vWe202_OPeV320RITO
     , vWe203_CLeV320RITO
     , vWe204_OPeV450PRES
     , vWe205_CLeV450PRES
     , vWe206_OPeV360RAFF
     , vWe207_CLeV360RAFF
     , vWe208_OPeV520INSE
     , vWe209_CLeV520INSE
     , vWe210_PUeSTARAUTO
     , vWe211_PUeSTOPAUTO
     , vWe212_PUeALARACKN
     , vWe213_PUeALARREST
     , vWe214_SNeALLACHIL
     , vWe215_SNeALLACIRC
    }

    public static string[] we2Descr =
      {
         "vWe200.Valvola mandata aperta "
        ,"vWe201.Valvola mandata chiusa "
        ,"vWe202.Valvola ritorno aperta "
        ,"vWe203.Valvola ritorno chiusa "
        ,"vWe204.Valvola pressione aperta "
        ,"vWe205.Valvola pressione chiusa "
        ,"vWe206.Valvola raffreddamento aperta "
        ,"vWe207.Valvola raffreddamento chiusa "
        ,"vWe208.Valvola inseguimento aperta "
        ,"vWe209.Valvola inseguimento chiusa "
        ,"vWe210.Pulsante marcia ciclo automatico  "
        ,"vWe211.pulsante arresto ciclo automatico "
        ,"vWe212.pulsante silenziamento allarmi"
        ,"vWe213.pulsante reset allarmi"
        ,"vWe214.Segnale chiller in allarme  "
        ,"vWe215.Segnale allarme circolazione  "
      };

    public static string[] we2Nick =
{
         "vWe200_OPeV260MAND"
        ,"vWe201_CLeV260MAND"
        ,"vWe202_OPeV320RITO"
        ,"vWe203_CLeV320RITO"
        ,"vWe204_OPeV450PRES"
        ,"vWe205_CLeV450PRES"
        ,"vWe206_OPeV360RAFF"
        ,"vWe207_CLeV360RAFF"
        ,"vWe208_OPeV520INSE"
        ,"vWe209_CLeV520INSE"
        ,"vWe210_PUeSTARAUTO"
        ,"vWe211_PUeSTOPAUTO"
        ,"vWe212_PUeALARACKN"
        ,"vWe213_PUeALARREST"
        ,"vWe214_SNeALLACHIL"
        ,"vWe215_SNeALLACIRC"
      };


    public static string[] we2Plc =
  {
         "vWe200"
        ,"vWe201"
        ,"vWe202"
        ,"vWe203"
        ,"vWe204"
        ,"vWe205"
        ,"vWe206"
        ,"vWe207"
        ,"vWe208"
        ,"vWe209"
        ,"vWe210"
        ,"vWe211"
        ,"vWe212"
        ,"vWe213"
        ,"vWe214"
        ,"vWe215"
      };


    public static string[] we2Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };



    #endregion


    #region We3
    public enum We3
    {
       vWe300_
     , vWe301_
     , vWe302_
     , vWe303_
     , vWe304_
     , vWe305_
     , vWe306_
     , vWe307_
     , vWe308_
     , vWe309_
     , vWe310_
     , vWe311_
     , vWe312_
     , vWe313_
     , vWe314_
     , vWe315_
    }

    public static string[] we3Descr =
      {
         "vWe300_  "
        ,"vWe301_  "
        ,"vWe302_  "
        ,"vWe303_  "
        ,"vWe304_  "
        ,"vWe305_  "
        ,"vWe306_  "
        ,"vWe307_  "
        ,"vWe308_  "
        ,"vWe309_  "
        ,"vWe310_  "
        ,"vWe311_  "
        ,"vWe312_  "
        ,"vWe313_  "
        ,"vWe314_  "
        ,"vWe315_  "
      };

    public static string[] we3Nick =
{
         "vWe300_"
        ,"vWe301_"
        ,"vWe302_"
        ,"vWe303_"
        ,"vWe304_"
        ,"vWe305_"
        ,"vWe306_"
        ,"vWe307_"
        ,"vWe308_"
        ,"vWe309_"
        ,"vWe310_"
        ,"vWe311_"
        ,"vWe312_"
        ,"vWe313_"
        ,"vWe314_"
        ,"vWe315_"
      };


    public static string[] we3Plc =
  {
         "vWe300"
        ,"vWe301"
        ,"vWe302"
        ,"vWe303"
        ,"vWe304"
        ,"vWe305"
        ,"vWe306"
        ,"vWe307"
        ,"vWe308"
        ,"vWe309"
        ,"vWe310"
        ,"vWe311"
        ,"vWe312"
        ,"vWe313"
        ,"vWe314"
        ,"vWe315"
      };


    public static string[] we3Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };



    #endregion


    #endregion

    #region output

    #region Wu0
    public enum Wu0
    {
       vWu000_CTuP120MAND
     , vWu001_ENuP120MAND
     , vWu002_CTuP200CIRC
     , vWu003_ENuP200CIRC
     , vWu004_CTuR210RISC
     , vWu005_RSuR210RISC
     , vWu006_RSuS210RISC
     , vWu007_RSuT210RISC
     , vWu008_CTuS230EROG
     , vWu009_SNuRISERV11
     , vWu010_CTuP530RAFF
     , vWu011_ENuP530RAFF
     , vWu012_YVuV190SVUO
     , vWu013_YVuV260MAND
     , vWu014_YVuV270SPUR
     , vWu015_YVuV320RITO
    }

    public static string[] wu0Descr =
      {
         "vWu000.Comando potenza drive mandata  "
        ,"vWu001.Enable drive mandata  "
        ,"vWu002.Comando potenza drive circolazione  "
        ,"vWu003.Enable drive circolazione  "
        ,"vWu004.Comando potenza Riscaldo  "
        ,"vWu005.Com.Relè statico fase R  "
        ,"vWu006.Com.Relè statico fase S  "
        ,"vWu007.Com.Relè statico fase T  "
        ,"vWu008.Comando potenza azionamento siringa  "
        ,"vWu009.Riserva  "
        ,"vWu010.Comando potenza drive cicrcolazione H20  "
        ,"vWu011.Enable drive circolazione H20  "
        ,"vWu012.Comando valvola scarico  "
        ,"vWu013.Comando valvola mandata  "
        ,"vWu014.Comando valvola spurgo  "
        ,"vWu015.Comando valvola ritorno  "
      };

    public static string[] wu0Nick =
      {
         "vWu000_CTuP120MAND"
        ,"vWu001_ENuP120MAND"
        ,"vWu002_CTuP200CIRC"
        ,"vWu003_ENuP200CIRC"
        ,"vWu004_CTuR210RISC"
        ,"vWu005_RSuR210RISC"
        ,"vWu006_RSuS210RISC"
        ,"vWu007_RSuT210RISC"
        ,"vWu008_CTuS230EROG"
        ,"vWu009_SNuRISERV11"
        ,"vWu010_CTuP530RAFF"
        ,"vWu011_ENuP530RAFF"
        ,"vWu012_YVuV190SVUO"
        ,"vWu013_YVuV260MAND"
        ,"vWu014_YVuV270SPUR"
        ,"vWu015_YVuV320RITO"
      };


    public static string[] wu0Plc =
  {
         "vWu000"
        ,"vWu001"
        ,"vWu002"
        ,"vWu003"
        ,"vWu004"
        ,"vWu005"
        ,"vWu006"
        ,"vWu007"
        ,"vWu008"
        ,"vWu009"
        ,"vWu010"
        ,"vWu011"
        ,"vWu012"
        ,"vWu013"
        ,"vWu014"
        ,"vWu015"
      };


    public static string[] wu0Comp =
  {
         "????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
      };
    #endregion

    #region Wu1
    public enum Wu1
    {
       vWu100_YVuV370ChSc
     , vWu101_YVuV420SUPP
     , vWu102_YVuV450COMP
     , vWu103_OPuV360RAFF
     , vWu104_CLuV360RAFF
     , vWu105_OPuV520INSE
     , vWu106_CLuV520INSE
     , vWu107_LBuTASTFUN1
     , vWu108_LBuTASTFUN2
     , vWu109_YVu200_SPUR
     , vWu110_Riserva 
     , vWu111_Riserva 
     , vWu112_Riserva 
     , vWu113_Riserva 
     , vWu114_Riserva 
     , vWu115_Riserva 
    }

    public static string[] wu1Descr =
      {
         "vWu100_0.Comando valvola scarico sic.    "
        ,"vWu101_0.Comando valvola immissione aria    "
        ,"vWu102_0.Comando valvola compensazione    "
        ,"vWu103_1.Comando apertura valvola raffr.    "
        ,"vWu104_1.Comando chiusura valvola raffr.    "
        ,"vWu105_1.Comando valvola inseguimento    "
        ,"vWu106_1.Comando valvola inseguimento    "
        ,"vWu107_1.Riserva     "
        ,"vWu108_1.Riserva     "
        ,"vWu109_1.Comando valvola spurgo aria pompa circ.    "
        ,"vWu110_1.Riserva     "
        ,"vWu111_0.Riserva     "
        ,"vWu112_0.Riserva     "
        ,"vWu113_0.Riserva     "
        ,"vWu114_0.Riserva     "
        ,"vWu115_0.Riserva     "
      };

    public static string[] wu1Nick =
  {
         "vWu100_YVuV370ChSc  "
        ,"vWu101_YVuV420SUPP  "
        ,"vWu102_YVuV450COMP  "
        ,"vWu103_OPuV360RAFF  "
        ,"vWu104_CLuV360RAFF  "
        ,"vWu105_OPuV520INSE  "
        ,"vWu106_CLuV520INSE  "
        ,"vWu107_LBuTASTFUN1  "
        ,"vWu108_LBuTASTFUN2  "
        ,"vWu109_YVu200_SPUR  "
        ,"vWu110_Riserva   "
        ,"vWu111_Riserva   "
        ,"vWu112_Riserva   "
        ,"vWu113_Riserva   "
        ,"vWu114_Riserva   "
        ,"vWu115_Riserva   "
      };


    public static string[] wu1Plc =
  {
         "vWu100"
        ,"vWu101"
        ,"vWu102"
        ,"vWu103"
        ,"vWu104"
        ,"vWu105"
        ,"vWu106"
        ,"vWu107"
        ,"vWu108"
        ,"vWu109"
        ,"vWu110"
        ,"vWu111"
        ,"vWu112"
        ,"vWu113"
        ,"vWu114"
        ,"vWu115"
      };


    public static string[] wu1Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };

    #endregion

    #region Wu2
    public enum Wu2
    {
       vWu200_
     , vWu201_
     , vWu202_
     , vWu203_
     , vWu204_
     , vWu205_
     , vWu206_
     , vWu207_
     , vWu208_
     , vWu209_
     , vWu210_
     , vWu211_
     , vWu212_
     , vWu213_
     , vWu214_
     , vWu215_
    }

    public static string[] wu2Descr =
      {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };

    public static string[] wu2Nick =
{
         "vWu200_ "
        ,"vWu201_ "
        ,"vWu202_ "
        ,"vWu203_ "
        ,"vWu204_ "
        ,"vWu205_ "
        ,"vWu206_ "
        ,"vWu207_ "
        ,"vWu208_ "
        ,"vWu209_ "
        ,"vWu210_ "
        ,"vWu211_ "
        ,"vWu212_ "
        ,"vWu213_ "
        ,"vWu214_ "
        ,"vWu215_ "
      };


    public static string[] wu2Plc =
  {
         "vWu200_"
        ,"vWu201_"
        ,"vWu202_"
        ,"vWu203_"
        ,"vWu204_"
        ,"vWu205_"
        ,"vWu206_"
        ,"vWu207_"
        ,"vWu208_"
        ,"vWu209_"
        ,"vWu210_"
        ,"vWu211_"
        ,"vWu212_"
        ,"vWu213_"
        ,"vWu214_"
        ,"vWu215_"
      };


    public static string[] wu2Comp =
  {
         " ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
      };



    #endregion

    #region Wu3
    public enum Wu3
    {
       vWu300_RISERVA
     , vWu301_RISERVA
     , vWu302_RISERVA
     , vWu303_RISERVA
     , vWu304_RISERVA
     , vWu305_RISERVA
     , vWu306_RISERVA
     , vWu307_RISERVA
     , vWu308_RISERVA
     , vWu309_RISERVA
     , vWu310_RISERVA
     , vWu311_RISERVA
     , vWu312_RISERVA
     , vWu313_RISERVA
     , vWu314_RISERVA
     , vWu315_RISERVA
    }

    public static string[] wu3Descr =
      {
         "  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
      };

    public static string[] wu3Nick =
{
         "vWu300_RISERVA "
        ,"vWu301_RISERVA "
        ,"vWu302_RISERVA "
        ,"vWu303_RISERVA "
        ,"vWu304_RISERVA "
        ,"vWu305_RISERVA "
        ,"vWu306_RISERVA "
        ,"vWu307_RISERVA "
        ,"vWu308_RISERVA "
        ,"vWu309_RISERVA      "
        ,"vWu310_RISERVA      "
        ,"vWu311_RISERVA      "
        ,"vWu312_RISERVA      "
        ,"vWu313_RISERVA      "
        ,"vWu314_RISERVA      "
        ,"vWu315_RISERVA      "
      };


    public static string[] wu3Plc =
  {
         "vWu300_"
        ,"vWu301_"
        ,"vWu302_"
        ,"vWu303_"
        ,"vWu304_"
        ,"vWu305_"
        ,"vWu306_"
        ,"vWu307_"
        ,"vWu308_"
        ,"vWu309_"
        ,"vWu310_"
        ,"vWu311_"
        ,"vWu312_"
        ,"vWu313_"
        ,"vWu314_"
        ,"vWu315_"
      };


    public static string[] wu3Comp =
  {
         " ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
      };



    #endregion

    #endregion

    #region flag e comandi DVP
    public enum Fp0
    {
      u000_iCmdPowerOn
     , u001_iCmdTorqueRev
     , u002_iCmdHome
     , u003_iCmdMove

     , u004_iCmdMovVel
     , u005_iCmdHalt
     , u006_iCmdErrRst
     , u007_iCmdStop

     , u008_iCmdCamin
     , u009_iCmdCamout
     , u010_iCmdMovMasterVel
     , u011_iCmdMoveRel

     , u012_xMoveVelEnable
     , u013_iCmdRes13
     , u014_iCmdRes14
     , u015_iCmdRes15
    }


    public static string[] Fp0Descr =
    {
       "u000_iCmdPowerOn"
      ,"u001_iCmdTorqueRev"
      ,"u002_iCmdHome"
      ,"u003_iCmdMove"

      ,"u004_iCmdMovVel"
      ,"u005_iCmdHalt"
      ,"u006_iCmdErrRst"
      ,"u007_iCmdStop"

      ,"u008_iCmdCamin"
      ,"u009_iCmdCamout"
      ,"u010_iCmdMovMasterVel"
      ,"u011_iCmdMoveRel"

      ,"u012_xMoveVelEnable"
      ,"u013_iCmdRes13"
      ,"u014_iCmdRes14"
      ,"u015_iCmdRes15"
    };


    public enum Fp1
    {
      u000_oCmdEnabJog
     , u001_oCmdJogFwd
     , u002_oCmdJogRev
     , u003_oCmdReqRdy

     , u004_oCmdEnabPulse
     , u005_oCmdHomeEnab
     , u006_oCmdGrapPid
     , u007_oCmdGrapSpeed

     , u008_oCmdCamin
     , u009_oCmdRes9
     , u010_oCmdRes10
     , u011_oCmdRes11

     , u012_oCmdRes12
     , u013_oCmdRes13
     , u014_oCmdRes14
     , u015_oCmdPidEn
    }

    public static string[] Fp1Descr =
    {
       "u000_oCmdEnabJog"
      ,"u001_oCmdJogFwd"
      ,"u002_oCmdJogRev"
      ,"u003_oCmdReqRdy"

      ,"u004_oCmdEnabPulse"
      ,"u005_oCmdHomeEnab"
      ,"u006_oCmdGrapPid"
      ,"u007_oCmdGrapSpeed"

      ,"u008_oCmdCamin"
      ,"u009_oCmdRes9"
      ,"u010_oCmdRes10"
      ,"u011_oCmdRes11"

      ,"u012_oCmdRes12"
      ,"u013_oCmdRes13"
      ,"u014_oCmdRes14"
      ,"u015_oCmdPidEn"
    };


    public enum Fp2
    {
      u000_flPowerOn
     , u001_flMov0Done
     , u002_flHomeDone
     , u003_flHaltDone

     , u004_flInTorque
     , u005_fl0Res5
     , u006_fl0Res6
     , u007_fl0Res7

     , u008_fl0Res8
     , u009_fl0Res9
     , u010_fl0Res10
     , u011_fl0Res11

     , u012_fl0Res12
     , u013_fl0Res13
     , u014_fl0Res14
     , u015_fl0Res15
    }

    public static string[] Fp2Descr =
    {
       "u000_flPowerOn"
      ,"u001_flMov0Done"
      ,"u002_flHomeDone"
      ,"u003_flHaltDone"

      ,"u004_flInTorque"
      ,"u005_fl0Res5"
      ,"u006_fl0Res6"
      ,"u007_fl0Res7"

      ,"u008_fl0Res8"
      ,"u009_fl0Res9"
      ,"u010_fl0Res10"
      ,"u011_fl0Res11"

      ,"u012_fl0Res12"
      ,"u013_fl0Res13"
      ,"u014_fl0Res14"
      ,"u015_fl0Res15"
    };


    public enum Fp3
    {
      u000_fliLockJog
     , u001_flIntRes1
     , u002_flIntRes2
     , u003_flIntRes3

     , u004_flIntRes4
     , u005_flIntRes5
     , u006_flIntRes6
     , u007_flIntRes7

     , u008_flIntRes8
     , u009_flIntRes9
     , u010_flIntRes10
     , u011_flIntRes11

     , u012_flIntRes12
     , u013_flIntRes13
     , u014_flIntRes14
     , u015_flIntRes15
    }

    public static string[] Fp3Descr =
    {
       "u000_fliLockJog"
      ,"u001_flIntRes1"
      ,"u002_flIntRes2"
      ,"u003_flIntRes3"

      ,"u004_flIntRes4"
      ,"u005_flIntRes5"
      ,"u006_flIntRes6"
      ,"u007_flIntRes7"

      ,"u008_flIntRes8"
      ,"u009_flIntRes9"
      ,"u010_flIntRes10"
      ,"u011_flIntRes11"

      ,"u012_flIntRes12"
      ,"u013_flIntRes13"
      ,"u014_flIntRes14"
      ,"u015_flIntRes15"
    };

    #endregion

    #region flag e comandi S7
    public enum S7flStat
    {
      u000_riempOk
     , u001_svuotaOk
     , u002_evalOk
     , u003_camRun

     , u004_i
     , u005_i
     , u006_i
     , u007_i

     , u008_i
     , u009_i
     , u010_i
     , u011_i

     , u012_x
     , u013_i
     , u014_i
     , u015_i
    }


    public static string[] S7flStDes =
    {
       "u000_RiempOk"
      ,"u001_svuotOk"
      ,"u002_eval_Ok"
      ,"u003_cammRun"

      ,"u004_"
      ,"u005_"
      ,"u006_"
      ,"u007_"

      ,"u008_"
      ,"u009_"
      ,"u010_"
      ,"u011_"

      ,"u012_"
      ,"u013_"
      ,"u014_"
      ,"u015_"
    };


    public enum S71
    {
      u000_oCmdEnabJog
     , u001_oCmdJogFwd
     , u002_oCmdJogRev
     , u003_oCmdReqRdy

     , u004_oCmdEnabPulse
     , u005_oCmdHomeEnab
     , u006_oCmdGrapPid
     , u007_oCmdGrapSpeed

     , u008_oCmdCamin
     , u009_oCmdRes9
     , u010_oCmdRes10
     , u011_oCmdRes11

     , u012_oCmdRes12
     , u013_oCmdRes13
     , u014_oCmdRes14
     , u015_oCmdPidEn
    }

    public static string[] S71Descr =
    {
       "u000_oCmdEnabJog"
      ,"u001_oCmdJogFwd"
      ,"u002_oCmdJogRev"
      ,"u003_oCmdReqRdy"

      ,"u004_oCmdEnabPulse"
      ,"u005_oCmdHomeEnab"
      ,"u006_oCmdGrapPid"
      ,"u007_oCmdGrapSpeed"

      ,"u008_oCmdCamin"
      ,"u009_oCmdRes9"
      ,"u010_oCmdRes10"
      ,"u011_oCmdRes11"

      ,"u012_oCmdRes12"
      ,"u013_oCmdRes13"
      ,"u014_oCmdRes14"
      ,"u015_oCmdPidEn"
    };


    public enum S72
    {
      u000_flPowerOn
     , u001_flMov0Done
     , u002_flHomeDone
     , u003_flHaltDone

     , u004_flInTorque
     , u005_fl0Res5
     , u006_fl0Res6
     , u007_fl0Res7

     , u008_fl0Res8
     , u009_fl0Res9
     , u010_fl0Res10
     , u011_fl0Res11

     , u012_fl0Res12
     , u013_fl0Res13
     , u014_fl0Res14
     , u015_fl0Res15
    }

    public static string[] S72Descr =
    {
       "u000_flPowerOn"
      ,"u001_flMov0Done"
      ,"u002_flHomeDone"
      ,"u003_flHaltDone"

      ,"u004_flInTorque"
      ,"u005_fl0Res5"
      ,"u006_fl0Res6"
      ,"u007_fl0Res7"

      ,"u008_fl0Res8"
      ,"u009_fl0Res9"
      ,"u010_fl0Res10"
      ,"u011_fl0Res11"

      ,"u012_fl0Res12"
      ,"u013_fl0Res13"
      ,"u014_fl0Res14"
      ,"u015_fl0Res15"
    };


    public enum S73
    {
      u000_fliLockJog
     , u001_flIntRes1
     , u002_flIntRes2
     , u003_flIntRes3

     , u004_flIntRes4
     , u005_flIntRes5
     , u006_flIntRes6
     , u007_flIntRes7

     , u008_flIntRes8
     , u009_flIntRes9
     , u010_flIntRes10
     , u011_flIntRes11

     , u012_flIntRes12
     , u013_flIntRes13
     , u014_flIntRes14
     , u015_flIntRes15
    }

    public static string[] S73Descr =
    {
       "u000_fliLockJog"
      ,"u001_flIntRes1"
      ,"u002_flIntRes2"
      ,"u003_flIntRes3"

      ,"u004_flIntRes4"
      ,"u005_flIntRes5"
      ,"u006_flIntRes6"
      ,"u007_flIntRes7"

      ,"u008_flIntRes8"
      ,"u009_flIntRes9"
      ,"u010_flIntRes10"
      ,"u011_flIntRes11"

      ,"u012_flIntRes12"
      ,"u013_flIntRes13"
      ,"u014_flIntRes14"
      ,"u015_flIntRes15"
    };

    #endregion

    #endregion
    
    #region DIRITTI

    public static string[] dirittiLabel =
    {
      "login      "
      ,"logoff  "
      ,"esci          "
      ,"gest. utenti  "
      ,"report        "
      ,"manutenzione  "
      ,"test"
    };

    public enum dirittiVal
    {
      Login = 0x0001,
      Logoff = 0x0002,
      Esci = 0x0004,
      GesUtenti = 0x0008,
      Report = 0x0010,
      Manutenzione = 0x0020,
      Test = 0x0040,
    }
    #endregion

    #endregion

    #region allarmi
    public enum Wa00
    {
       AL0_0_MSaF130EME2
     , AL0_1_SIaTutto_Ok
     , AL0_2_TEaP120MAND
     , AL0_3_MSaF230RSIG
     , AL0_4_KMaP120MAND
     , AL0_5_MSaF340RANE
     , AL0_6_DRaP120OK
     , AL0_7_MSaF250PRTA
     , AL0_8_TEaP200CIRC
     , AL0_9_KMaP200CIRC
     , AL0_a_DRaP200OK
     , AL0_b_TEaR210RISC
     , AL0_c_KMaR210RISC
     , AL0_d_TEaS230EROG
     , AL0_e_KMaS230EROG
     , AL0_f_DRaS230OK
    }

    public static string[] wa0Descr =
  {
         "00 - anomalia misuratore portata       "
        ,"01 - comandi inseriti                  "
        ,"02 - termica pompa mandata             "
        ,"03 - refr siringa                      "
        ,"04 - readback tele pompa P120          "
        ,"05 - raffr. rane                       "
        ,"06 - anomaliza drive pompa mandata     "
        ,"07 - refr. prta                        "
        ,"08 - termica pompa circolazione        "
        ,"09 - readback tele pompa circolazioner "
        ,"10 - anom. drive pompa circolazione    "
        ,"11 - termica potenza riscaldatore      "
        ,"12 - readback tele riscaldatore        "
        ,"13 - termica siringa                   "
        ,"14 - readback siringa                  "
        ,"15 - anomalia drive siringa            "
      };

    public static string[] wa0Nick =
      {
         "AL0_0_MSaF130EME2 "
        ,"AL0_1_SIaTutto_Ok "
        ,"AL0_2_TEaP120MAND "
        ,"AL0_3_MSaF230RSIG "
        ,"AL0_4_KMaP120MAND "
        ,"AL0_5_MSaF340RANE "
        ,"AL0_6_DRaP120OK "
        ,"AL0_7_MSaF250PRTA "
        ,"AL0_8_TEaP200CIRC "
        ,"AL0_9_KMaP200CIRC "
        ,"AL0_a_DRaP200OK "
        ,"AL0_b_TEaR210RISC "
        ,"AL0_c_KMaR210RISC "
        ,"AL0_d_TEaS230EROG "
        ,"AL0_e_KMaS230EROG "
        ,"AL0_f_DRaS230OK "
      };


    public static string[] wa0Plc =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public static string[] wa0Comp =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public enum Wa01
    {
       AL1_0_TSaR210OK
     , AL1_1_SNaP400PAIR
     , AL1_2_TEaP530RAFF
     , AL1_3_KMaP530RAFF
     , AL1_4_DRaP530__OK
     , AL1_5_LSaSERBNOHI
     , AL1_6_LSaSERBNOLO
     , AL1_7_LSaSPUNOAIR
     , AL1_8_OPaV190SVUO
     , AL1_9_CLaV190SVUO
     , AL1_a_OPaV260MAND
     , AL1_b_CLaV260MAND
     , AL1_c_OPaV320RITO
     , AL1_d_CLaV320RITO
     , AL1_e_OPaV450PRES
     , AL1_f_CLaV450PRES
    }


    public static string[] wa1Descr =
  {
         "16 - termostato sicurezza riscaldatore             "
        ,"17 - presenza aria                                 "
        ,"18 - termica pompa raffreddamento                  "
        ,"19 - readback tele pompa raffreddamento            "
        ,"20 - anomalia drive pompa raffreddamento           "
        ,"21 - serbatoio troppo pieno                        "
        ,"22 - allarme mancanza fluido                       "
        ,"23 - timeout spurgo aria                           "
        ,"24 - anomalia comando apertura valvola svuotamento "
        ,"25 - anomalia comando chiusura valvola svuotamento "
        ,"26 - anomalia comando apertura valvola mandata     "
        ,"27 - anomalia comando chiusura valvola mandata     "
        ,"28 - anomalia comando apertura valvola ritorno     "
        ,"29 - anomalia comando chiusura valvola ritorno     "
        ,"30 - anomalia comando apertura valvola press       "
        ,"31 - anomalia comando chiusura valvola press       "
      };                                                     

    public static string[] wa1Nick =
      {
         "AL1_0_TSaR210OK"
        ,"AL1_1_SNaP400PAIR"
        ,"AL1_2_TEaP530RAFF"
        ,"AL1_3_KMaP530RAFF"
        ,"AL1_4_DRaP530__OK"
        ,"AL1_5_LSaSERBNOHI"
        ,"AL1_6_LSaSERBNOLO"
        ,"AL1_7_LSaSPUNOAIR"
        ,"AL1_8_OPaV190SVUO"
        ,"AL1_9_CLaV190SVUO"
        ,"AL1_a_OPaV260MAND"
        ,"AL1_b_CLaV260MAND"
        ,"AL1_c_OPaV320RITO"
        ,"AL1_d_CLaV320RITO"
        ,"AL1_e_OPaV450PRES"
        ,"AL1_f_CLaV450PRES"
      };


    public static string[] wa1Plc =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public static string[] wa1Comp =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public enum Wa02
    {
       AL2_0_OPaV360RAFF
     , AL2_1_CLaV360RAFF
     , AL2_2_OPaV520INSE
     , AL2_3_CLaV520INSE
     , AL2_4_SQaSTEPUNDF
     , AL2_5_SQaTESTLIVE
     , AL2_6_Riserva
     , AL2_7_Riserva
     , AL2_8_Riserva
     , AL2_9_Riserva
     , AL2_a_Riserva
     , AL2_b_Riserva
     , AL2_c_Riserva
     , AL2_d_Riserva
     , AL2_e_Riserva
     , AL2_f_Riserva
    }


    public static string[] wa2Descr =
  {
         "32 - apertura valvola raffr "
        ,"33 - chiusura valvola raffr"
        ,"34 - apertura valvola inseguimento"
        ,"35 - chiusura valvola inseguimento"
        ,"36 - step indefinito"
        ,"37 - prova attiva"
        ,"38 - Riserva "
        ,"39 - Riserva "
        ,"40 - Riserva "
        ,"41 - Riserva "
        ,"42 - Riserva "
        ,"43 - Riserva "
        ,"44 - Riserva "
        ,"45 - Riserva "
        ,"46 - Riserva "
      };

    public static string[] wa2Nick =
      {
         "OPaV360RAFF "
        ,"CLaV360RAFF "
        ,"OPaV520INSE "
        ,"CLaV520INSE"
        ,"SQaSTEPUNDF"
        ,"SQaTESTLIVE "
        ,"Riserva "
        ,"Riserva "
        ,"Riserva "
        ,"Riserva "
        ,"Riserva "
        ,"Riserva "
        ,"Riserva "
        ,"Riserva "
        ,"Riserva "
        ,"Riserva "
      };


    public static string[] wa2Plc =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public static string[] wa2Comp =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public string[,] msgAll =
 {
   {
 "00 - anomalia misuratore portata       "
,"01 - comandi inseriti                  "
,"02 - termica pompa mandata             "
,"03 - refr siringa                      "
,"04 - readback tele pompa P120          "
,"05 - raffr. rane                       "
,"06 - anomaliza drive pompa mandata     "
,"07 - refr. prta                        "
,"08 - termica pompa circolazione        "
,"09 - readback tele pompa circolazioner "
,"10 - anom. drive pompa circolazione    "
,"11 - termica potenza riscaldatore      "
,"12 - readback tele riscaldatore        "
,"13 - termica siringa                   "
,"14 - readback siringa                  "
,"15 - anomalia drive siringa            "
     },
   {
 "16 - termostato sicurezza riscaldatore             "
,"17 - presenza aria                                 "
,"18 - termica pompa raffreddamento                  "
,"19 - readback tele pompa raffreddamento            "
,"20 - anomalia drive pompa raffreddamento           "
,"21 - serbatoio troppo pieno                        "
,"22 - allarme mancanza fluido                       "
,"23 - timeout spurgo aria                           "
,"24 - anomalia comando apertura valvola svuotamento "
,"25 - anomalia comando chiusura valvola svuotamento "
,"26 - anomalia comando apertura valvola mandata     "
,"27 - anomalia comando chiusura valvola mandata     "
,"28 - anomalia comando apertura valvola ritorno     "
,"29 - anomalia comando chiusura valvola ritorno     "
,"30 - anomalia comando apertura valvola press       "
,"31 - anomalia comando chiusura valvola press       "
  },
   {
 "32 - apertura valvola raffr "
,"33 - chiusura valvola raffr"
,"34 - apertura valvola inseguimento"
,"35 - chiusura valvola inseguimento"
,"36 - step indefinito"
,"37 - prova attiva"
,"38 - Riserva "
,"39 - Riserva "
,"40 - Riserva "
,"41 - Riserva "
,"42 - Riserva "
,"43 - Riserva "
,"44 - Riserva "
,"45 - Riserva "
,"46 - Riserva "
,""
      }
};

    #endregion

    #region Fasi e Cicli
    #region CicliPtr
    public enum ptrFaseFrigo
    {
      _00_Init                     = 00 ,
      _10_attesaStart              = 10 ,
      _20_avviamentoPompa          = 20 ,
      _30_attendeFlusso            = 30 ,
      _40_pronto_richiesta_freddo  = 40 ,
      _50_alimentazione_liquida    = 50 ,
      _60_funzione_Normale         = 60 ,
      _70_pump_down                = 70 ,
      _80_riposo_fermo             = 80 ,
      _90_pump_down                = 90 ,
      _1000_gestione_fault         = 1000,
      _1001_rientro_reset          = 1001,
    };

    
    public static string[] ptrFaseFrigoLbl =
    {
      "00 - Reset ciclo"
      ,"10 - Attesa comandi"
      ,"20 - Riempimento impianto"
      ,"30 - Caratterizzazione"
      ,"40 - Verifica prestazioni"
      ,"50 - Esecuzione passo prova"
      ,"60 - Svuotamento impianto"
      ,"100 - Fine"
    };

    public static Dictionary<int, string> faseFrigo = new Dictionary<int, string>(){
     {0  , "init: in teoria solo al power on plc				     "}
    ,{10 , "attesa richiesta marcia                          "}
    ,{20 , "avviamento pompa circolazione                    "}
    ,{30 , "attende flusso                                   "}
    ,{40 , "pronto alla marcia - attesa richiesta freddo     "}
    ,{50 , "Alimentazione liquida                            "}
    ,{60 , "Funzionamento normale                            "}
    ,{70 , "pump down                                        "}
    ,{80 , "riposo da fermo (antiripetizione)                "}
    ,{90 , "attesa arresto flusso                            "}
    ,{1000, "gestione fault                                  "}
    ,{1001, "rientro reset                                   "}
  };

    public static Dictionary<int, string> riscaldoCella = new Dictionary<int, string>(){
     {0  , "init: in teoria solo al power on plc				     "}
    ,{10 , "attesa richiesta marcia                          "}
    ,{20 , "                                                 "}
    ,{30 , "                                                 "}
    ,{40 , "pronto alla marcia - attesa richiesta caldo      "}
    ,{50 , "Regimazione ventilatore                          "}
    ,{60 , "Funzionamento normale                            "}
    ,{70 , "Spegnimento riscaldo                             "}
    ,{80 , "Arresto ventilatore                              "}
    ,{90 , "                                                 "}
    ,{1000, "gestione fault                                  "}
    ,{1001, "rientro reset                                   "}
  };

    public static Dictionary<int, string> raffreddamentoCella = new Dictionary<int, string>(){
     {0  , "init: in teoria solo al power on plc				     "}
    ,{10 , "attesa richiesta marcia                          "}
    ,{20 , "                    "}
    ,{30 , ""}
    ,{40 , "pronto alla marcia - attesa richiesta freddo     "}
    ,{50 , ""}
    ,{60 , ""}
    ,{70 , ""}
    ,{80 , ""}
    ,{90 , ""}
    ,{100, "Raffreddamento a glicole"}
    ,{110, "Da glicole a freon, svuotamento a tempo"}
    ,{200, "Raffreddamento freon, espansione diretta"}
    ,{400, "Conclusione fase raffreddamento"}
    ,{1000, "gestione fault                                  "}
    ,{1001, "rientro reset                                   "}
  };

    //  public static Dictionary<int, string> faseFrigo = new Dictionary<int, string>(){
    //   {0  , "init: in teoria solo al power on plc				     "}
    //  ,{10 , "attesa richiesta marcia                          "}
    //  ,{20 , "avviamento pompa circolazione                    "}
    //  ,{30 , "attende flusso                                   "}
    //  ,{40 , "pronto alla marcia - attesa richiesta freddo     "}
    //  ,{50 , "Alimentazione liquida                            "}
    //  ,{60 , "Funzionamento normale                            "}
    //  ,{70 , "pump down                                        "}
    //  ,{80 , "riposo da fermo (antiripetizione)                "}
    //  ,{90 , "attesa arresto flusso                            "}
    //  ,{1000, "gestione fault                                  "}
    //  ,{1001, "rientro reset                                   "}
    //};




    #endregion
    #endregion

#elif v0387

    #region def


    #region Ao channel names Siemens

    public enum aoChNoS7
    {
      //SM 1232 AQ4, la prima, AO
      s7ANoJ120MAND
        , s7ANoJ200CIRC
        , s7ANoJ530RAFF
        , s7ANoRiserva3
    };

    public static string[] aoChNamesS7 =
      { 
        //SM 1232 AQ4, la prima, AO
        " s7ANoJ120MAND"              //21 - 0
        ,"s7ANoJ200CIRC"
        ,"s7ANoJ530RAFF"
        ,"s7ANoRiserva3"
      };
    #endregion

    #region Ao label short Siemens

    public static string[] aoLabelShortS7 =
      { 
        //SM 1232 AQ4, la prima, AO
        " Comando drive riempimento"
        ,"Comando drive circolazione"
        ,"Comando drive raffreddamento"
        ,"Riserva canale 3"
      };
    #endregion

    #region Ao label long Siemens
    public static string[] aoLabelLongS7 =
      { 
        //SM 1232 AQ4, la prima, AO
        " Comando drive riempimento"
        ,"Comando drive circolazione"
        ,"Comando drive raffreddamento"
        ,"Riserva canale 3"
      };
    #endregion



    #endregion

    #region I/O digitali

    public enum Wexxx
    {
      ec0
      , ec1
      , ec2
//      , ec3
    }
    public enum Wuxxx
    {
      uc0
      , uc1
//      , uc2
    }
    public enum Waxxx
    {
      ac0
      , ac1
      , ac2
      , ac3
    }

    #region input

    #region We0
    public enum We0
    {
       vWe000_MSeF130EME2 
     , vWe001_SIeTutto_Ok 
     , vWe002_MSeF130EME1 
     , vWe003_TEeP120MAND 
     , vWe004_MSeF230RSIG 
     , vWe005_KMeP120MAND 
     , vWe006_MSeF340RANE 
     , vWe007_DReP120OK 	
     , vWe008_MSeF250PORTA
     , vWe009_MSeF250PORTB
     , vWe010_TEeP200CIRC 
     , vWe011_KMeP200CIRC 
     , vWe012_DReP200OK 	
     , vWe013_TEeR210RISC 
     , vWe014_SLeCICLAUTO
     , vWe015_Riserva
    }

    public static string[] we0Descr =
      {
         "vWe000.Port.H20 Sec.Salto Emerg.  "
        ,"vWe001.Ausiliari Pulsante Inseriti  "
        ,"vWe002.Port.H20 Pri.Salto Emerg.  "
        ,"vWe003.Contatto Int.Pompa mandata  "
        ,"vWe004.Port.H20 Raff. Siringa  "
        ,"vWe005.Contatto teleruttore Pompa mandata  "
        ,"vWe006.Port.H20 Raff. Circuito  "
        ,"vWe007.Drive pompa mandata OK  "
        ,"vWe008.Port. Fluido Test A  "
        ,"vWe009.Port. Fluido Test B  "
        ,"vWe010.Contatto int.Pompa circolazione  "
        ,"vWe011.Contatto teleruttore Pompa circolazione  "
        ,"vWe012.Drive pompa circolazione OK  "
        ,"vWe013.Contatto int.Circuito Riscaldo  "
        ,"vWe014.Selettore auto/manuale  "
        ,"vWe015.Riserva  "
      };

    public static string[] we0Nick =
      {
         "vWe000_MSeF130EME2  "
        ,"vWe001_SIeTutto_Ok  "
        ,"vWe002_MSeF130EME1  "
        ,"vWe003_TEeP120MAND  "
        ,"vWe004_MSeF230RSIG  "
        ,"vWe005_KMeP120MAND  "
        ,"vWe006_MSeF340RANE  "
        ,"vWe007_DReP120OK 	  "
        ,"vWe008_MSeF250PORTA "
        ,"vWe009_MSeF250PORTB "
        ,"vWe010_TEeP200CIRC  "
        ,"vWe011_KMeP200CIRC  "
        ,"vWe012_DReP200OK 	  "
        ,"vWe013_TEeR210RISC  "
        ,"vWe014_SLeCICLAUTO  "
        ,"vWe015_Riserva      "
      };                      


    public static string[] we0Plc =
  {
         "vWe000"
        ,"vWe001"
        ,"vWe002"
        ,"vWe003"
        ,"vWe004"
        ,"vWe005"
        ,"vWe006"
        ,"vWe007"
        ,"vWe008"
        ,"vWe009"
        ,"vWe010"
        ,"vWe011"
        ,"vWe012"
        ,"vWe013"
        ,"vWe014"
        ,"vWe015"
      };


    public static string[] we0Comp =
  {
         "????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
      };
    #endregion

    #region We1
    public enum We1
    {
       vWe100_KMeR210RISC
     , vWe101_TEeS230EROG
     , vWe102_KMeS230EROG
     , vWe103_DReS230OK 	
     , vWe104_TSeR210OK 	
     , vWe105_SNeP400PAIR
     , vWe106_PUeINDIETRO
     , vWe107_PUeAVANTI
     , vWe108_TEeP530RAFF
     , vWe109_KMeP530RAFF
     , vWe110_DReP530__OK
     , vWe111_LSeSERBNOHI
     , vWe112_LSeSERBNOLO
     , vWe113_LSeSPUNOAIR
     , vWe114_OPeV190SVUO
     , vWe115_CLeV190SVUO
    }

    public static string[] we1Descr =
      {
         "vWe100.Contatto teleruttore circ.Riscaldo  "
        ,"vWe101.Contatto int.siringa  "
        ,"vWe102.Contatto teleruttore siringa  "
        ,"vWe103.Drive enable siringa  "
        ,"vWe104.Termostato sicurezza  "
        ,"vWe105.Pressostato presenza aria  "
        ,"vWe106.Pulsante Indietro  "
        ,"vWe107.Pulsante Avanti "
        ,"vWe108.Contatto int.Pompa circolazione H2O  "
        ,"vWe109.Contatto teleruttore Pompa circolazione H2O  "
        ,"vWe110.Drive pompa circolazione OK H2O  "
        ,"vWe111.Livello Serbaoio Alto  "
        ,"vWe112.Livello serbatoio Basso  "
        ,"vWe113.Livello Spurgo  "
        ,"vWe114.Valvola scarico aperta  "
        ,"vWe115.Valvola scarico chiusa  "
      };

    public static string[] we1Nick =
  {
         "vWe100_KMeR210RISC"
        ,"vWe101_TEeS230EROG"
        ,"vWe102_KMeS230EROG"
        ,"vWe103_DReS230OK 	"
        ,"vWe104_TSeR210OK 	"
        ,"vWe105_SNeP400PAIR"
        ,"vWe106_PUeINDIETRO"
        ,"vWe107_PUeAVANTI"
        ,"vWe108_TEeP530RAFF"
        ,"vWe109_KMeP530RAFF"
        ,"vWe110_DReP530__OK"
        ,"vWe111_LSeSERBNOHI"
        ,"vWe112_LSeSERBNOLO"
        ,"vWe113_LSeSPUNOAIR"
        ,"vWe114_OPeV190SVUO"
        ,"vWe115_CLeV190SVUO"
      };


    public static string[] we1Plc =
  {
         "vWe100"
        ,"vWe101"
        ,"vWe102"
        ,"vWe103"
        ,"vWe104"
        ,"vWe105"
        ,"vWe106"
        ,"vWe107"
        ,"vWe108"
        ,"vWe109"
        ,"vWe110"
        ,"vWe111"
        ,"vWe112"
        ,"vWe113"
        ,"vWe114"
        ,"vWe115"
      };


    public static string[] we1Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };

    #endregion

    #region We2
    public enum We2
    {
       vWe200_OPeV260MAND
     , vWe201_CLeV260MAND
     , vWe202_OPeV320RITO
     , vWe203_CLeV320RITO
     , vWe204_OPeV450PRES
     , vWe205_CLeV450PRES
     , vWe206_OPeV360RAFF
     , vWe207_CLeV360RAFF
     , vWe208_OPeV520INSE
     , vWe209_CLeV520INSE
     , vWe210_PUeSTARAUTO
     , vWe211_PUeSTOPAUTO
     , vWe212_PUeALARACKN
     , vWe213_PUeALARREST
     , vWe214_SNeALLACHIL
     , vWe215_SNeALLACIRC
    }

    public static string[] we2Descr =
      {
         "vWe200.Valvola mandata aperta "
        ,"vWe201.Valvola mandata chiusa "
        ,"vWe202.Valvola ritorno aperta "
        ,"vWe203.Valvola ritorno chiusa "
        ,"vWe204.Valvola pressione aperta "
        ,"vWe205.Valvola pressione chiusa "
        ,"vWe206.Valvola raffreddamento aperta "
        ,"vWe207.Valvola raffreddamento chiusa "
        ,"vWe208.Valvola inseguimento aperta "
        ,"vWe209.Valvola inseguimento chiusa "
        ,"vWe210.Pulsante marcia ciclo automatico  "
        ,"vWe211.pulsante arresto ciclo automatico "
        ,"vWe212.pulsante silenziamento allarmi"
        ,"vWe213.pulsante reset allarmi"
        ,"vWe214.Segnale chiller in allarme  "
        ,"vWe215.Segnale allarme circolazione  "
      };

    public static string[] we2Nick =
{
         "vWe200_OPeV260MAND"
        ,"vWe201_CLeV260MAND"
        ,"vWe202_OPeV320RITO"
        ,"vWe203_CLeV320RITO"
        ,"vWe204_OPeV450PRES"
        ,"vWe205_CLeV450PRES"
        ,"vWe206_OPeV360RAFF"
        ,"vWe207_CLeV360RAFF"
        ,"vWe208_OPeV520INSE"
        ,"vWe209_CLeV520INSE"
        ,"vWe210_PUeSTARAUTO"
        ,"vWe211_PUeSTOPAUTO"
        ,"vWe212_PUeALARACKN"
        ,"vWe213_PUeALARREST"
        ,"vWe214_SNeALLACHIL"
        ,"vWe215_SNeALLACIRC"
      };


    public static string[] we2Plc =
  {
         "vWe200"
        ,"vWe201"
        ,"vWe202"
        ,"vWe203"
        ,"vWe204"
        ,"vWe205"
        ,"vWe206"
        ,"vWe207"
        ,"vWe208"
        ,"vWe209"
        ,"vWe210"
        ,"vWe211"
        ,"vWe212"
        ,"vWe213"
        ,"vWe214"
        ,"vWe215"
      };


    public static string[] we2Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };



    #endregion


    #region We3
    public enum We3
    {
       vWe300_
     , vWe301_
     , vWe302_
     , vWe303_
     , vWe304_
     , vWe305_
     , vWe306_
     , vWe307_
     , vWe308_
     , vWe309_
     , vWe310_
     , vWe311_
     , vWe312_
     , vWe313_
     , vWe314_
     , vWe315_
    }

    public static string[] we3Descr =
      {
         "vWe300_  "
        ,"vWe301_  "
        ,"vWe302_  "
        ,"vWe303_  "
        ,"vWe304_  "
        ,"vWe305_  "
        ,"vWe306_  "
        ,"vWe307_  "
        ,"vWe308_  "
        ,"vWe309_  "
        ,"vWe310_  "
        ,"vWe311_  "
        ,"vWe312_  "
        ,"vWe313_  "
        ,"vWe314_  "
        ,"vWe315_  "
      };

    public static string[] we3Nick =
{
         "vWe300_"
        ,"vWe301_"
        ,"vWe302_"
        ,"vWe303_"
        ,"vWe304_"
        ,"vWe305_"
        ,"vWe306_"
        ,"vWe307_"
        ,"vWe308_"
        ,"vWe309_"
        ,"vWe310_"
        ,"vWe311_"
        ,"vWe312_"
        ,"vWe313_"
        ,"vWe314_"
        ,"vWe315_"
      };


    public static string[] we3Plc =
  {
         "vWe300"
        ,"vWe301"
        ,"vWe302"
        ,"vWe303"
        ,"vWe304"
        ,"vWe305"
        ,"vWe306"
        ,"vWe307"
        ,"vWe308"
        ,"vWe309"
        ,"vWe310"
        ,"vWe311"
        ,"vWe312"
        ,"vWe313"
        ,"vWe314"
        ,"vWe315"
      };


    public static string[] we3Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };



    #endregion


    #endregion

    #region output

    #region Wu0
    public enum Wu0
    {
       vWu000_CTuP120MAND
     , vWu001_ENuP120MAND
     , vWu002_CTuP200CIRC
     , vWu003_ENuP200CIRC
     , vWu004_CTuR210RISC
     , vWu005_RSuR210RISC
     , vWu006_RSuS210RISC
     , vWu007_RSuT210RISC
     , vWu008_CTuS230EROG
     , vWu009_SNuRISERV11
     , vWu010_CTuP530RAFF
     , vWu011_ENuP530RAFF
     , vWu012_YVuV190SVUO
     , vWu013_YVuV260MAND
     , vWu014_YVuV270SPUR
     , vWu015_YVuV320RITO
    }

    public static string[] wu0Descr =
      {
         "vWu000.Comando potenza drive mandata  "
        ,"vWu001.Enable drive mandata  "
        ,"vWu002.Comando potenza drive circolazione  "
        ,"vWu003.Enable drive circolazione  "
        ,"vWu004.Comando potenza Riscaldo  "
        ,"vWu005.Com.Relè statico fase R  "
        ,"vWu006.Com.Relè statico fase S  "
        ,"vWu007.Com.Relè statico fase T  "
        ,"vWu008.Comando potenza azionamento siringa  "
        ,"vWu009.Riserva  "
        ,"vWu010.Comando potenza drive cicrcolazione H20  "
        ,"vWu011.Enable drive circolazione H20  "
        ,"vWu012.Comando valvola scarico  "
        ,"vWu013.Comando valvola mandata  "
        ,"vWu014.Comando valvola spurgo  "
        ,"vWu015.Comando valvola ritorno  "
      };

    public static string[] wu0Nick =
      {
         "vWu000_CTuP120MAND"
        ,"vWu001_ENuP120MAND"
        ,"vWu002_CTuP200CIRC"
        ,"vWu003_ENuP200CIRC"
        ,"vWu004_CTuR210RISC"
        ,"vWu005_RSuR210RISC"
        ,"vWu006_RSuS210RISC"
        ,"vWu007_RSuT210RISC"
        ,"vWu008_CTuS230EROG"
        ,"vWu009_SNuRISERV11"
        ,"vWu010_CTuP530RAFF"
        ,"vWu011_ENuP530RAFF"
        ,"vWu012_YVuV190SVUO"
        ,"vWu013_YVuV260MAND"
        ,"vWu014_YVuV270SPUR"
        ,"vWu015_YVuV320RITO"
      };


    public static string[] wu0Plc =
  {
         "vWu000"
        ,"vWu001"
        ,"vWu002"
        ,"vWu003"
        ,"vWu004"
        ,"vWu005"
        ,"vWu006"
        ,"vWu007"
        ,"vWu008"
        ,"vWu009"
        ,"vWu010"
        ,"vWu011"
        ,"vWu012"
        ,"vWu013"
        ,"vWu014"
        ,"vWu015"
      };


    public static string[] wu0Comp =
  {
         "????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
      };
    #endregion

    #region Wu1
    public enum Wu1
    {
       vWu100_YVuV370ChSc
     , vWu101_YVuV420SUPP
     , vWu102_YVuV450COMP
     , vWu103_OPuV360RAFF
     , vWu104_CLuV360RAFF
     , vWu105_OPuV520INSE
     , vWu106_CLuV520INSE
     , vWu107_LBuTASTFUN1
     , vWu108_LBuTASTFUN2
     , vWu109_YVu200_SPUR
     , vWu110_Riserva 
     , vWu111_Riserva 
     , vWu112_Riserva 
     , vWu113_Riserva 
     , vWu114_Riserva 
     , vWu115_Riserva 
    }

    public static string[] wu1Descr =
      {
         "vWu100_0.Comando valvola scarico sic.    "
        ,"vWu101_0.Comando valvola immissione aria    "
        ,"vWu102_0.Comando valvola compensazione    "
        ,"vWu103_1.Comando apertura valvola raffr.    "
        ,"vWu104_1.Comando chiusura valvola raffr.    "
        ,"vWu105_1.Comando valvola inseguimento    "
        ,"vWu106_1.Comando valvola inseguimento    "
        ,"vWu107_1.Riserva     "
        ,"vWu108_1.Riserva     "
        ,"vWu109_1.Comando valvola spurgo aria pompa circ.    "
        ,"vWu110_1.Riserva     "
        ,"vWu111_0.Riserva     "
        ,"vWu112_0.Riserva     "
        ,"vWu113_0.Riserva     "
        ,"vWu114_0.Riserva     "
        ,"vWu115_0.Riserva     "
      };

    public static string[] wu1Nick =
  {
         "vWu100_YVuV370ChSc  "
        ,"vWu101_YVuV420SUPP  "
        ,"vWu102_YVuV450COMP  "
        ,"vWu103_OPuV360RAFF  "
        ,"vWu104_CLuV360RAFF  "
        ,"vWu105_OPuV520INSE  "
        ,"vWu106_CLuV520INSE  "
        ,"vWu107_LBuTASTFUN1  "
        ,"vWu108_LBuTASTFUN2  "
        ,"vWu109_YVu200_SPUR  "
        ,"vWu110_Riserva   "
        ,"vWu111_Riserva   "
        ,"vWu112_Riserva   "
        ,"vWu113_Riserva   "
        ,"vWu114_Riserva   "
        ,"vWu115_Riserva   "
      };


    public static string[] wu1Plc =
  {
         "vWu100"
        ,"vWu101"
        ,"vWu102"
        ,"vWu103"
        ,"vWu104"
        ,"vWu105"
        ,"vWu106"
        ,"vWu107"
        ,"vWu108"
        ,"vWu109"
        ,"vWu110"
        ,"vWu111"
        ,"vWu112"
        ,"vWu113"
        ,"vWu114"
        ,"vWu115"
      };


    public static string[] wu1Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };

    #endregion

    #region Wu2
    public enum Wu2
    {
       vWu200_
     , vWu201_
     , vWu202_
     , vWu203_
     , vWu204_
     , vWu205_
     , vWu206_
     , vWu207_
     , vWu208_
     , vWu209_
     , vWu210_
     , vWu211_
     , vWu212_
     , vWu213_
     , vWu214_
     , vWu215_
    }

    public static string[] wu2Descr =
      {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };

    public static string[] wu2Nick =
{
         "vWu200_ "
        ,"vWu201_ "
        ,"vWu202_ "
        ,"vWu203_ "
        ,"vWu204_ "
        ,"vWu205_ "
        ,"vWu206_ "
        ,"vWu207_ "
        ,"vWu208_ "
        ,"vWu209_ "
        ,"vWu210_ "
        ,"vWu211_ "
        ,"vWu212_ "
        ,"vWu213_ "
        ,"vWu214_ "
        ,"vWu215_ "
      };


    public static string[] wu2Plc =
  {
         "vWu200_"
        ,"vWu201_"
        ,"vWu202_"
        ,"vWu203_"
        ,"vWu204_"
        ,"vWu205_"
        ,"vWu206_"
        ,"vWu207_"
        ,"vWu208_"
        ,"vWu209_"
        ,"vWu210_"
        ,"vWu211_"
        ,"vWu212_"
        ,"vWu213_"
        ,"vWu214_"
        ,"vWu215_"
      };


    public static string[] wu2Comp =
  {
         " ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
      };



    #endregion

    #region Wu3
    public enum Wu3
    {
       vWu300_RISERVA
     , vWu301_RISERVA
     , vWu302_RISERVA
     , vWu303_RISERVA
     , vWu304_RISERVA
     , vWu305_RISERVA
     , vWu306_RISERVA
     , vWu307_RISERVA
     , vWu308_RISERVA
     , vWu309_RISERVA
     , vWu310_RISERVA
     , vWu311_RISERVA
     , vWu312_RISERVA
     , vWu313_RISERVA
     , vWu314_RISERVA
     , vWu315_RISERVA
    }

    public static string[] wu3Descr =
      {
         "  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
      };

    public static string[] wu3Nick =
{
         "vWu300_RISERVA "
        ,"vWu301_RISERVA "
        ,"vWu302_RISERVA "
        ,"vWu303_RISERVA "
        ,"vWu304_RISERVA "
        ,"vWu305_RISERVA "
        ,"vWu306_RISERVA "
        ,"vWu307_RISERVA "
        ,"vWu308_RISERVA "
        ,"vWu309_RISERVA      "
        ,"vWu310_RISERVA      "
        ,"vWu311_RISERVA      "
        ,"vWu312_RISERVA      "
        ,"vWu313_RISERVA      "
        ,"vWu314_RISERVA      "
        ,"vWu315_RISERVA      "
      };


    public static string[] wu3Plc =
  {
         "vWu300_"
        ,"vWu301_"
        ,"vWu302_"
        ,"vWu303_"
        ,"vWu304_"
        ,"vWu305_"
        ,"vWu306_"
        ,"vWu307_"
        ,"vWu308_"
        ,"vWu309_"
        ,"vWu310_"
        ,"vWu311_"
        ,"vWu312_"
        ,"vWu313_"
        ,"vWu314_"
        ,"vWu315_"
      };


    public static string[] wu3Comp =
  {
         " ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
      };



    #endregion

    #endregion

    #region flag e comandi DVP
    public enum Fp0
    {
      u000_iCmdPowerOn
     , u001_iCmdTorqueRev
     , u002_iCmdHome
     , u003_iCmdMove

     , u004_iCmdMovVel
     , u005_iCmdHalt
     , u006_iCmdErrRst
     , u007_iCmdStop

     , u008_iCmdCamin
     , u009_iCmdCamout
     , u010_iCmdMovMasterVel
     , u011_iCmdMoveRel

     , u012_xMoveVelEnable
     , u013_iCmdRes13
     , u014_iCmdRes14
     , u015_iCmdRes15
    }


    public static string[] Fp0Descr =
    {
       "u000_iCmdPowerOn"
      ,"u001_iCmdTorqueRev"
      ,"u002_iCmdHome"
      ,"u003_iCmdMove"

      ,"u004_iCmdMovVel"
      ,"u005_iCmdHalt"
      ,"u006_iCmdErrRst"
      ,"u007_iCmdStop"

      ,"u008_iCmdCamin"
      ,"u009_iCmdCamout"
      ,"u010_iCmdMovMasterVel"
      ,"u011_iCmdMoveRel"

      ,"u012_xMoveVelEnable"
      ,"u013_iCmdRes13"
      ,"u014_iCmdRes14"
      ,"u015_iCmdRes15"
    };


    public enum Fp1
    {
      u000_oCmdEnabJog
     , u001_oCmdJogFwd
     , u002_oCmdJogRev
     , u003_oCmdReqRdy

     , u004_oCmdEnabPulse
     , u005_oCmdHomeEnab
     , u006_oCmdGrapPid
     , u007_oCmdGrapSpeed

     , u008_oCmdCamin
     , u009_oCmdRes9
     , u010_oCmdRes10
     , u011_oCmdRes11

     , u012_oCmdRes12
     , u013_oCmdRes13
     , u014_oCmdRes14
     , u015_oCmdPidEn
    }

    public static string[] Fp1Descr =
    {
       "u000_oCmdEnabJog"
      ,"u001_oCmdJogFwd"
      ,"u002_oCmdJogRev"
      ,"u003_oCmdReqRdy"

      ,"u004_oCmdEnabPulse"
      ,"u005_oCmdHomeEnab"
      ,"u006_oCmdGrapPid"
      ,"u007_oCmdGrapSpeed"

      ,"u008_oCmdCamin"
      ,"u009_oCmdRes9"
      ,"u010_oCmdRes10"
      ,"u011_oCmdRes11"

      ,"u012_oCmdRes12"
      ,"u013_oCmdRes13"
      ,"u014_oCmdRes14"
      ,"u015_oCmdPidEn"
    };


    public enum Fp2
    {
      u000_flPowerOn
     , u001_flMov0Done
     , u002_flHomeDone
     , u003_flHaltDone

     , u004_flInTorque
     , u005_fl0Res5
     , u006_fl0Res6
     , u007_fl0Res7

     , u008_fl0Res8
     , u009_fl0Res9
     , u010_fl0Res10
     , u011_fl0Res11

     , u012_fl0Res12
     , u013_fl0Res13
     , u014_fl0Res14
     , u015_fl0Res15
    }

    public static string[] Fp2Descr =
    {
       "u000_flPowerOn"
      ,"u001_flMov0Done"
      ,"u002_flHomeDone"
      ,"u003_flHaltDone"

      ,"u004_flInTorque"
      ,"u005_fl0Res5"
      ,"u006_fl0Res6"
      ,"u007_fl0Res7"

      ,"u008_fl0Res8"
      ,"u009_fl0Res9"
      ,"u010_fl0Res10"
      ,"u011_fl0Res11"

      ,"u012_fl0Res12"
      ,"u013_fl0Res13"
      ,"u014_fl0Res14"
      ,"u015_fl0Res15"
    };


    public enum Fp3
    {
      u000_fliLockJog
     , u001_flIntRes1
     , u002_flIntRes2
     , u003_flIntRes3

     , u004_flIntRes4
     , u005_flIntRes5
     , u006_flIntRes6
     , u007_flIntRes7

     , u008_flIntRes8
     , u009_flIntRes9
     , u010_flIntRes10
     , u011_flIntRes11

     , u012_flIntRes12
     , u013_flIntRes13
     , u014_flIntRes14
     , u015_flIntRes15
    }

    public static string[] Fp3Descr =
    {
       "u000_fliLockJog"
      ,"u001_flIntRes1"
      ,"u002_flIntRes2"
      ,"u003_flIntRes3"

      ,"u004_flIntRes4"
      ,"u005_flIntRes5"
      ,"u006_flIntRes6"
      ,"u007_flIntRes7"

      ,"u008_flIntRes8"
      ,"u009_flIntRes9"
      ,"u010_flIntRes10"
      ,"u011_flIntRes11"

      ,"u012_flIntRes12"
      ,"u013_flIntRes13"
      ,"u014_flIntRes14"
      ,"u015_flIntRes15"
    };

    #endregion

    #region flag e comandi S7
    public enum S7flStat
    {
      u000_riempOk
     , u001_svuotaOk
     , u002_evalOk
     , u003_camRun

     , u004_i
     , u005_i
     , u006_i
     , u007_i

     , u008_i
     , u009_i
     , u010_i
     , u011_i

     , u012_x
     , u013_i
     , u014_i
     , u015_i
    }


    public static string[] S7flStDes =
    {
       "u000_RiempOk"
      ,"u001_svuotOk"
      ,"u002_eval_Ok"
      ,"u003_cammRun"

      ,"u004_"
      ,"u005_"
      ,"u006_"
      ,"u007_"

      ,"u008_"
      ,"u009_"
      ,"u010_"
      ,"u011_"

      ,"u012_"
      ,"u013_"
      ,"u014_"
      ,"u015_"
    };


    public enum S71
    {
      u000_oCmdEnabJog
     , u001_oCmdJogFwd
     , u002_oCmdJogRev
     , u003_oCmdReqRdy

     , u004_oCmdEnabPulse
     , u005_oCmdHomeEnab
     , u006_oCmdGrapPid
     , u007_oCmdGrapSpeed

     , u008_oCmdCamin
     , u009_oCmdRes9
     , u010_oCmdRes10
     , u011_oCmdRes11

     , u012_oCmdRes12
     , u013_oCmdRes13
     , u014_oCmdRes14
     , u015_oCmdPidEn
    }

    public static string[] S71Descr =
    {
       "u000_oCmdEnabJog"
      ,"u001_oCmdJogFwd"
      ,"u002_oCmdJogRev"
      ,"u003_oCmdReqRdy"

      ,"u004_oCmdEnabPulse"
      ,"u005_oCmdHomeEnab"
      ,"u006_oCmdGrapPid"
      ,"u007_oCmdGrapSpeed"

      ,"u008_oCmdCamin"
      ,"u009_oCmdRes9"
      ,"u010_oCmdRes10"
      ,"u011_oCmdRes11"

      ,"u012_oCmdRes12"
      ,"u013_oCmdRes13"
      ,"u014_oCmdRes14"
      ,"u015_oCmdPidEn"
    };


    public enum S72
    {
      u000_flPowerOn
     , u001_flMov0Done
     , u002_flHomeDone
     , u003_flHaltDone

     , u004_flInTorque
     , u005_fl0Res5
     , u006_fl0Res6
     , u007_fl0Res7

     , u008_fl0Res8
     , u009_fl0Res9
     , u010_fl0Res10
     , u011_fl0Res11

     , u012_fl0Res12
     , u013_fl0Res13
     , u014_fl0Res14
     , u015_fl0Res15
    }

    public static string[] S72Descr =
    {
       "u000_flPowerOn"
      ,"u001_flMov0Done"
      ,"u002_flHomeDone"
      ,"u003_flHaltDone"

      ,"u004_flInTorque"
      ,"u005_fl0Res5"
      ,"u006_fl0Res6"
      ,"u007_fl0Res7"

      ,"u008_fl0Res8"
      ,"u009_fl0Res9"
      ,"u010_fl0Res10"
      ,"u011_fl0Res11"

      ,"u012_fl0Res12"
      ,"u013_fl0Res13"
      ,"u014_fl0Res14"
      ,"u015_fl0Res15"
    };


    public enum S73
    {
      u000_fliLockJog
     , u001_flIntRes1
     , u002_flIntRes2
     , u003_flIntRes3

     , u004_flIntRes4
     , u005_flIntRes5
     , u006_flIntRes6
     , u007_flIntRes7

     , u008_flIntRes8
     , u009_flIntRes9
     , u010_flIntRes10
     , u011_flIntRes11

     , u012_flIntRes12
     , u013_flIntRes13
     , u014_flIntRes14
     , u015_flIntRes15
    }

    public static string[] S73Descr =
    {
       "u000_fliLockJog"
      ,"u001_flIntRes1"
      ,"u002_flIntRes2"
      ,"u003_flIntRes3"

      ,"u004_flIntRes4"
      ,"u005_flIntRes5"
      ,"u006_flIntRes6"
      ,"u007_flIntRes7"

      ,"u008_flIntRes8"
      ,"u009_flIntRes9"
      ,"u010_flIntRes10"
      ,"u011_flIntRes11"

      ,"u012_flIntRes12"
      ,"u013_flIntRes13"
      ,"u014_flIntRes14"
      ,"u015_flIntRes15"
    };

    #endregion

    #endregion
    


    #region allarmi
    public enum Wa00
    {
       AL0_0_MSaF130EME2
     , AL0_1_SIaTutto_Ok
     , AL0_2_TEaP120MAND
     , AL0_3_MSaF230RSIG
     , AL0_4_KMaP120MAND
     , AL0_5_MSaF340RANE
     , AL0_6_DRaP120_OK_
     , AL0_7_MSaF250PRTA
     , AL0_8_TEaP200CIRC
     , AL0_9_KMaP200CIRC
     , AL0_a_DRaP200_OK_
     , AL0_b_TEaR210RISC
     , AL0_c_KMaR210RISC
     , AL0_d_TEaS230EROG
     , AL0_e_KMaS230EROG
     , AL0_f_DRaS230_OK_
    }

    public static string[] wa0Descr =
  {
         "00 - anomalia misuratore portata       "
        ,"01 - comandi inseriti                  "
        ,"02 - termica pompa mandata             "
        ,"03 - refr siringa                      "
        ,"04 - readback tele pompa P120          "
        ,"05 - raffr. rane                       "
        ,"06 - anomaliza drive pompa mandata     "
        ,"07 - refr. prta                        "
        ,"08 - termica pompa circolazione        "
        ,"09 - readback tele pompa circolazioner "
        ,"10 - anom. drive pompa circolazione    "
        ,"11 - termica potenza riscaldatore      "
        ,"12 - readback tele riscaldatore        "
        ,"13 - termica siringa                   "
        ,"14 - readback siringa                  "
        ,"15 - anomalia drive siringa            "
      };

    public static string[] wa0Nick =
      {
         "AL0_0_MSaF130EME2 "
        ,"AL0_1_SIaTutto_Ok "
        ,"AL0_2_TEaP120MAND "
        ,"AL0_3_MSaF230RSIG "
        ,"AL0_4_KMaP120MAND "
        ,"AL0_5_MSaF340RANE "
        ,"AL0_6_DRaP120OK "
        ,"AL0_7_MSaF250PRTA "
        ,"AL0_8_TEaP200CIRC "
        ,"AL0_9_KMaP200CIRC "
        ,"AL0_a_DRaP200OK "
        ,"AL0_b_TEaR210RISC "
        ,"AL0_c_KMaR210RISC "
        ,"AL0_d_TEaS230EROG "
        ,"AL0_e_KMaS230EROG "
        ,"AL0_f_DRaS230OK "
      };


    public static string[] wa0Plc =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public static string[] wa0Comp =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public enum Wa01
    {
       AL1_0_TSaR210_OK_
     , AL1_1_SNaP400PAIR
     , AL1_2_TEaP530RAFF
     , AL1_3_KMaP530RAFF
     , AL1_4_DRaP530_OK_
     , AL1_5_LSaSERBNOHI
     , AL1_6_LSaSERBNOLO
     , AL1_7_LSaSPUNOAIR
     , AL1_8_OPaV190SVUO
     , AL1_9_CLaV190SVUO
     , AL1_a_OPaV260MAND
     , AL1_b_CLaV260MAND
     , AL1_c_OPaV320RITO
     , AL1_d_CLaV320RITO
     , AL1_e_OPaV450PRES
     , AL1_f_CLaV450PRES
    }


    public static string[] wa1Descr =
  {
         "16 - termostato sicurezza riscaldatore             "
        ,"17 - presenza aria                                 "
        ,"18 - termica pompa raffreddamento                  "
        ,"19 - readback tele pompa raffreddamento            "
        ,"20 - anomalia drive pompa raffreddamento           "
        ,"21 - serbatoio troppo pieno                        "
        ,"22 - allarme mancanza fluido                       "
        ,"23 - timeout spurgo aria                           "
        ,"24 - anomalia comando apertura valvola svuotamento "
        ,"25 - anomalia comando chiusura valvola svuotamento "
        ,"26 - anomalia comando apertura valvola mandata     "
        ,"27 - anomalia comando chiusura valvola mandata     "
        ,"28 - anomalia comando apertura valvola ritorno     "
        ,"29 - anomalia comando chiusura valvola ritorno     "
        ,"30 - anomalia comando apertura valvola press       "
        ,"31 - anomalia comando chiusura valvola press       "
      };                                                     

    public static string[] wa1Nick =
      {
         "AL1_0_TSaR210OK"
        ,"AL1_1_SNaP400PAIR"
        ,"AL1_2_TEaP530RAFF"
        ,"AL1_3_KMaP530RAFF"
        ,"AL1_4_DRaP530__OK"
        ,"AL1_5_LSaSERBNOHI"
        ,"AL1_6_LSaSERBNOLO"
        ,"AL1_7_LSaSPUNOAIR"
        ,"AL1_8_OPaV190SVUO"
        ,"AL1_9_CLaV190SVUO"
        ,"AL1_a_OPaV260MAND"
        ,"AL1_b_CLaV260MAND"
        ,"AL1_c_OPaV320RITO"
        ,"AL1_d_CLaV320RITO"
        ,"AL1_e_OPaV450PRES"
        ,"AL1_f_CLaV450PRES"
      };


    public static string[] wa1Plc =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public static string[] wa1Comp =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public enum Wa02
    {
       AL2_0_OPaV360RAFF
     , AL2_1_CLaV360RAFF
     , AL2_2_OPaV520INSE
     , AL2_3_CLaV520INSE
     , AL2_4_SQaSTEPUNDF
     , AL2_5_SQaTESTLIVE
     , AL2_6_SBaSCOPTUBO
     , AL2_7_WDaCOM_SERV
     , AL2_8_WDaCOM_CLIE
     , AL2_9_All_Riserva
     , AL2_a_All_Riserva
     , AL2_b_All_Riserva
     , AL2_c_All_Riserva
     , AL2_d_All_Riserva
     , AL2_e_All_Riserva
     , AL2_f_All_Riserva
    }


    public static string[] wa2Descr =
  {
         "32 - apertura valvola raffr "
        ,"33 - chiusura valvola raffr"
        ,"34 - apertura valvola inseguimento"
        ,"35 - chiusura valvola inseguimento"
        ,"36 - step indefinito"
        ,"37 - prova attiva"
        ,"38 - Anomalia pulsazione, scoppio tubo "
        ,"39 - Mancanza comunicazione server "
        ,"40 - Mancanza comunicazione client "
        ,"41 - Riserva "
        ,"42 - Riserva "
        ,"43 - Riserva "
        ,"44 - Riserva "
        ,"45 - Riserva "
        ,"46 - Riserva "
      };

    public static string[] wa2Nick =
      {
         "OPaV360RAFF "
        ,"CLaV360RAFF "
        ,"OPaV520INSE "
        ,"CLaV520INSE "
        ,"SQaSTEPUNDF "
        ,"SQaTESTLIVE "
        ,"SBaSCOPTUBO "
        ,"WDaCOM_SERV "
        ,"WDaCOM_CLIE "
        ,"Riserva "
        ,"Riserva "
        ,"Riserva "
        ,"Riserva "
        ,"Riserva "
        ,"Riserva "
        ,"Riserva "
      };


    public static string[] wa2Plc =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public static string[] wa2Comp =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public string[,] msgAll =
 {
   {
 "00 - anomalia misuratore portata       "
,"01 - comandi inseriti                  "
,"02 - termica pompa mandata             "
,"03 - refr siringa                      "
,"04 - readback tele pompa P120          "
,"05 - raffr. rane                       "
,"06 - anomalia drive pompa mandata      "
,"07 - refr. prta                        "
,"08 - termica pompa circolazione        "
,"09 - readback tele pompa circolazioner "
,"10 - anom. drive pompa circolazione    "
,"11 - termica potenza riscaldatore      "
,"12 - readback tele riscaldatore        "
,"13 - termica siringa                   "
,"14 - readback siringa                  "
,"15 - anomalia drive siringa            "
     },
   {
 "16 - termostato sicurezza riscaldatore             "
,"17 - presenza aria                                 "
,"18 - termica pompa raffreddamento                  "
,"19 - readback tele pompa raffreddamento            "
,"20 - anomalia drive pompa raffreddamento           "
,"21 - serbatoio troppo pieno                        "
,"22 - allarme mancanza fluido                       "
,"23 - timeout spurgo aria                           "
,"24 - anomalia comando apertura valvola svuotamento "
,"25 - anomalia comando chiusura valvola svuotamento "
,"26 - anomalia comando apertura valvola mandata     "
,"27 - anomalia comando chiusura valvola mandata     "
,"28 - anomalia comando apertura valvola ritorno     "
,"29 - anomalia comando chiusura valvola ritorno     "
,"30 - anomalia comando apertura valvola press       "
,"31 - anomalia comando chiusura valvola press       "
  },
   {
 "32 - apertura valvola raffr "
,"33 - chiusura valvola raffr"
,"34 - apertura valvola inseguimento"
,"35 - chiusura valvola inseguimento"
,"36 - step indefinito"
,"37 - prova attiva"
,"38 - Anomalia pulsazione, scoppio tubo "
,"39 - Mancanza comunicazione server  "
,"40 - Mancanza comunicazione client  "
,"41 - Riserva "
,"42 - Riserva "
,"43 - Riserva "
,"44 - Riserva "
,"45 - Riserva "
,"46 - Riserva "
,""
      }
};

    #endregion

    #region Fasi e Cicli
    #region CicliPtr
    public enum ptrFaseFrigo
    {
      _00_Init                     = 00 ,
      _10_attesaStart              = 10 ,
      _20_avviamentoPompa          = 20 ,
      _30_attendeFlusso            = 30 ,
      _40_pronto_richiesta_freddo  = 40 ,
      _50_alimentazione_liquida    = 50 ,
      _60_funzione_Normale         = 60 ,
      _70_pump_down                = 70 ,
      _80_riposo_fermo             = 80 ,
      _90_pump_down                = 90 ,
      _1000_gestione_fault         = 1000,
      _1001_rientro_reset          = 1001,
    };

    
    public static string[] ptrFaseFrigoLbl =
    {
      "00 - Reset ciclo"
      ,"10 - Attesa comandi"
      ,"20 - Riempimento impianto"
      ,"30 - Caratterizzazione"
      ,"40 - Verifica prestazioni"
      ,"50 - Esecuzione passo prova"
      ,"60 - Svuotamento impianto"
      ,"100 - Fine"
    };

    public static Dictionary<int, string> faseFrigo = new Dictionary<int, string>(){
     {0  , "init: in teoria solo al power on plc				     "}
    ,{10 , "attesa richiesta marcia                          "}
    ,{20 , "avviamento pompa circolazione                    "}
    ,{30 , "attende flusso                                   "}
    ,{40 , "pronto alla marcia - attesa richiesta freddo     "}
    ,{50 , "Alimentazione liquida                            "}
    ,{60 , "Funzionamento normale                            "}
    ,{70 , "pump down                                        "}
    ,{80 , "riposo da fermo (antiripetizione)                "}
    ,{90 , "attesa arresto flusso                            "}
    ,{1000, "gestione fault                                  "}
    ,{1001, "rientro reset                                   "}
  };

    public static Dictionary<int, string> riscaldoCella = new Dictionary<int, string>(){
     {0  , "init: in teoria solo al power on plc				     "}
    ,{10 , "attesa richiesta marcia                          "}
    ,{20 , "                                                 "}
    ,{30 , "                                                 "}
    ,{40 , "pronto alla marcia - attesa richiesta caldo      "}
    ,{50 , "Regimazione ventilatore                          "}
    ,{60 , "Funzionamento normale                            "}
    ,{70 , "Spegnimento riscaldo                             "}
    ,{80 , "Arresto ventilatore                              "}
    ,{90 , "                                                 "}
    ,{1000, "gestione fault                                  "}
    ,{1001, "rientro reset                                   "}
  };

    public static Dictionary<int, string> raffreddamentoCella = new Dictionary<int, string>(){
     {0  , "init: in teoria solo al power on plc				     "}
    ,{10 , "attesa richiesta marcia                          "}
    ,{20 , "                    "}
    ,{30 , ""}
    ,{40 , "pronto alla marcia - attesa richiesta freddo     "}
    ,{50 , ""}
    ,{60 , ""}
    ,{70 , ""}
    ,{80 , ""}
    ,{90 , ""}
    ,{100, "Raffreddamento a glicole"}
    ,{110, "Da glicole a freon, svuotamento a tempo"}
    ,{200, "Raffreddamento freon, espansione diretta"}
    ,{400, "Conclusione fase raffreddamento"}
    ,{1000, "gestione fault                                  "}
    ,{1001, "rientro reset                                   "}
  };

    //  public static Dictionary<int, string> faseFrigo = new Dictionary<int, string>(){
    //   {0  , "init: in teoria solo al power on plc				     "}
    //  ,{10 , "attesa richiesta marcia                          "}
    //  ,{20 , "avviamento pompa circolazione                    "}
    //  ,{30 , "attende flusso                                   "}
    //  ,{40 , "pronto alla marcia - attesa richiesta freddo     "}
    //  ,{50 , "Alimentazione liquida                            "}
    //  ,{60 , "Funzionamento normale                            "}
    //  ,{70 , "pump down                                        "}
    //  ,{80 , "riposo da fermo (antiripetizione)                "}
    //  ,{90 , "attesa arresto flusso                            "}
    //  ,{1000, "gestione fault                                  "}
    //  ,{1001, "rientro reset                                   "}
    //};




    #endregion
    #endregion

#elif v0449b

    #region def

    #region Analog output

    #region Ao channel names Siemens

    public enum aoChNoS7
    {
      //SM 1232 AQ4, la prima, AO
      s7ANoJ120MAND
        , s7ANoJ200CIRC
        , s7ANoJ530RAFF
        , s7ANoRiserva3
    };

    public static string[] aoChNamesS7 =
      { 
        //SM 1232 AQ4, la prima, AO
        " s7ANoJ120MAND"              //21 - 0
        ,"s7ANoJ200CIRC"
        ,"s7ANoJ530RAFF"
        ,"s7ANoRiserva3"
      };
    #endregion

    #region Ao label short Siemens

    public static string[] aoLabelShortS7 =
      { 
        //SM 1232 AQ4, la prima, AO
        " Comando drive riempimento"
        ,"Comando drive circolazione"
        ,"Comando drive raffreddamento"
        ,"Riserva canale 3"
      };
    #endregion

    #region Ao label long Siemens
    public static string[] aoLabelLongS7 =
      { 
        //SM 1232 AQ4, la prima, AO
        " Comando drive riempimento"
        ,"Comando drive circolazione"
        ,"Comando drive raffreddamento"
        ,"Riserva canale 3"
      };
    #endregion
    #endregion


    #region I/O digitali

    public enum Wexxx
    {
      ec0
      , ec1
      , ec2
      , ec3
    }
    public enum Wuxxx
    {
      uc0
      , uc1
      , uc2
    }
    public enum Waxxx
    {
      ac0
      , ac1
      , ac2
    }

    #region input

    #region We0
    public enum We0
    {
       vWe000_FCePORTNOCH	
     , vWe001_CTeRISCFLUI	
     , vWe002_CTeRISCCAME	
     , vWe003_LVe2FLUPROOK
     , vWe004_LSe0TRAFFLUI
     , vWe005_PSe0PRESARIA
     , vWe006_FCe0SIRIRIPO
     , vWe007_FCe1SIRIXCOR
     , vWe008_LVe1OLIOBASS
     , vWe009_SNe2RECOPRIN
     , vWe010_SNe2RECOPRAV
     , vWe011_PSe0HP_1FRIGex
     , vWe012_TSe0LT_1FRIG
     , vWe013_FLe0LQ_1FRIG
     , vWe014_FLe0GQ_2FRIG
     , vWe015_LVe0HG_1FRIG
    }

    public static string[] we0Descr =
      {
         "vWe000_0.porta cella non chiusa                           "
        ,"vWe001_0.termostato sicurezza riscaldatore fluido         "
        ,"vWe002_0.termostato sicurezza cella climatica             "
        ,"vWe003_2.livello fluido prova sufficiente                 "
        ,"vWe004_0.trafilamento fluido da elementi in prova         "
        ,"vWe005_0.pressione aria sufficiente                       "
        ,"vWe006_0.cilindro comando pressione a riposo              "
        ,"vWe007_1.oltrecorsa cilindro comando pressione            "
        ,"vWe008_1.livello olio centralina insufficiente            "
        ,"vWe009_2.regolatore corsa cil.pressione indietro          "
        ,"vWe010_2.regolatore corsa cil.pressione avanti            "
        ,"vWe011_Riserva                                            "
        ,"vWe012_0.termostato di minima 1° stadio gr.frigorifero    "
        ,"vWe013_0.flussostato 1° stadio gruppo frigorifero         "
        ,"vWe014_0.fl circ.fl. in cella da 1° st./fl cond. 2° st    "
        ,"vWe015_0.livello fluido vasca 1° stadio gr.frigorifero    "
      };

    public static string[] we0Nick =
      {
         "vWe000_FCePORTNOCH	"
        ,"vWe001_CTeRISCFLUI	"
        ,"vWe002_CTeRISCCAME	"
        ,"vWe003_LVe2FLUPROOK"
        ,"vWe004_LSe0TRAFFLUI"
        ,"vWe005_PSe0PRESARIA"
        ,"vWe006_FCe0SIRIRIPO"
        ,"vWe007_FCe1SIRIXCOR"
        ,"vWe008_LVe1OLIOBASS"
        ,"vWe009_SNe2RECOPRIN"
        ,"vWe010_SNe2RECOPRAV"
        ,"vWe011_PSe0HP_1FRIG"
        ,"vWe012_TSe0LT_1FRIG"
        ,"vWe013_FLe0LQ_1FRIG"
        ,"vWe014_FLe0GQ_2FRIG"
        ,"vWe015_LVe0HG_1FRIG"
      };


    public static string[] we0Plc =
  {
         "vWe000"
        ,"vWe001"
        ,"vWe002"
        ,"vWe003"
        ,"vWe004"
        ,"vWe005"
        ,"vWe006"
        ,"vWe007"
        ,"vWe008"
        ,"vWe009"
        ,"vWe010"
        ,"vWe011"
        ,"vWe012"
        ,"vWe013"
        ,"vWe014"
        ,"vWe015"
      };


    public static string[] we0Comp =
  {
         "????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
      };
    #endregion

    #region We1
    public enum We1
    {
       vWe100_PSe0HP_2FRIGex
     , vWe101_PSe0LP_2FRIGex
     , vWe102_FCe0VIBRPOSI
     , vWe103_FCe0VIBRSPIN
     , vWe104_SNe0VIBR_RUN
     , vWe105_TEe0COMP1FRI
     , vWe106_TEe0COMP2FRI
     , vWe107_TEe0POMP1FRI
     , vWe108_TEe0POMPCELL
     , vWe109_TEe0POMPP1P2
     , vWe110_TEe0POMP_P3_
     , vWe111_TEe1POMP_P4_
     , vWe112_TEe2MREGCIPR
     , vWe113_TEe1VENTCELL
     , vWe114_TEe0RISCCELL
     , vWe115_SNe1FILTCECL
    }

    public static string[] we1Descr =
      {
         "vWe100_Riserva                                            "
        ,"vWe101_Riserva                                            "
        ,"vWe102_0.vibratore posizionato                            "
        ,"vWe103_0.spina vibratore introdotta                       "
        ,"vWe104_0.gruppo vibratore in marcia                       "
        ,"vWe105_0.interv.prot.mot.compressore 1°st.gr.frigor.      "
        ,"vWe106_0.interv.prot.mot.compressore 2°st.gr.frigor.      "
        ,"vWe107_0.interv.prot.mot.pompa circolazione               "
        ,"vWe108_0.interv.prot.mot.pompa raffr.vasca 1°st.frigor.   "
        ,"vWe109_0.interv.prot.mot.pompa raffr.cella da 1° stadio   "
        ,"vWe110_0.interv.prot.mot.ventilazione cella               "
        ,"vWe111_1.interv.prot.motore pompa P4                      "
        ,"vWe112_2.interv.prot.mot.regol.corsa cilindro pressione   "
        ,"vWe113_1.interv.prot.motore ventola cella                 "
        ,"vWe114_0.interv.prot.riscaldatore cella                   "
        ,"vWe115_1.filtro principale centralina intasato            "
      };

    public static string[] we1Nick =
  {
         "vWe100_PSe0HP_2FRIG"
        ,"vWe101_PSe0LP_2FRIG"
        ,"vWe102_FCe0VIBRPOSI"
        ,"vWe103_FCe0VIBRSPIN"
        ,"vWe104_SNe0VIBR_RUN"
        ,"vWe105_TEe0COMP1FRI"
        ,"vWe106_TEe0COMP2FRI"
        ,"vWe107_TEe0POMP1FRI"
        ,"vWe108_TEe0POMPCELL"
        ,"vWe109_TEe0POMPP1P2"
        ,"vWe110_TEe0POMP_P3_"
        ,"vWe111_TEe1POMP_P4_"
        ,"vWe112_TEe2MREGCIPR"
        ,"vWe113_TEe1VENTCELL"
        ,"vWe114_TEe0RISCCELL"
        ,"vWe115_SNe1FILTCECL"
      };


    public static string[] we1Plc =
  {
         "vWe100"
        ,"vWe101"
        ,"vWe102"
        ,"vWe103"
        ,"vWe104"
        ,"vWe105"
        ,"vWe106"
        ,"vWe107"
        ,"vWe108"
        ,"vWe109"
        ,"vWe110"
        ,"vWe111"
        ,"vWe112"
        ,"vWe113"
        ,"vWe114"
        ,"vWe115"
      };


    public static string[] we1Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };

    #endregion

    #region We2
    public enum We2
    {
       vWe200_SNe1FISER1CL
     , vWe201_SNe1FIVIBRCL
     , vWe202_SNe1FIPILOCL
     , vWe203_SNe0PROT_AUX
     , vWe204_SNe0PROTFIEL
     , vWe205_SIe0TUTTO_OK
     , vWe206_SNe0EMERRIPR
     , vWe207_SLe0AUTOMATI
     , vWe208_PUe0STARAUTO
     , vWe209_PUe0STOPAUTO
     , vWe210_PUe0COMAAVAN
     , vWe211_PUe0COMAINDI
     , vWe212_SNe1CENTMARC
     , vWe213_SNe1DRIVFLOK
     , vWe214_PUeACK_ALLA	
     , vWe215_PUeRESEALLA
    }

    public static string[] we2Descr =
      {
         "vWe200_1.filtro servizio cilindro 1 intasato        "
        ,"vWe201_1.filtro servizio vibratore intasato         "
        ,"vWe202_1.filtro servizio pilotaggio cil.1 intasato  "
        ,"vWe203_0.interv.prot.circuiti 24Vdc                 "
        ,"vWe204_0.intervento protez.filtro elettrostatico    "
        ,"vWe205_0.circuiti ausiliari inseriti                "
        ,"vWe206_0.emergenza ripristinata                     "
        ,"vWe207_0.selettore comandi automatici               "
        ,"vWe208_0.pulsante avvio ciclo automatico            "
        ,"vWe209_0.pulsante arresto ciclo automatico          "
        ,"vWe210_0.pulsante comando manuale avanti            "
        ,"vWe211_0.pulsante comando manuale indietro          "
        ,"vWe212_1.pompe idrauliche in marcia                 "
        ,"vWe213_1.nessuna anomalia inverter pompa circolaz.  "
        ,"vWe214_                                             "
        ,"vWe215_                                             "
      };

    public static string[] we2Nick =
{
         "vWe200_SNe1FISER1CL "
        ,"vWe201_SNe1FIVIBRCL "
        ,"vWe202_SNe1FIPILOCL "
        ,"vWe203_SNe0PROT_AUX "
        ,"vWe204_SNe0PROTFIEL "
        ,"vWe205_SIe0TUTTO_OK "
        ,"vWe206_SNe0EMERRIPR "
        ,"vWe207_SLe0AUTOMATI "
        ,"vWe208_PUe0STARAUTO "
        ,"vWe209_PUe0STOPAUTO "
        ,"vWe210_PUe0COMAAVAN "
        ,"vWe211_PUe0COMAINDI "
        ,"vWe212_SNe1CENTMARC "
        ,"vWe213_SNe1DRIVFLOK "
        ,"vWe214_PUeACK_ALLA	"
        ,"vWe215_PUeRESEALLA	"
      };


    public static string[] we2Plc =
  {
         "vWe200"
        ,"vWe201"
        ,"vWe202"
        ,"vWe203"
        ,"vWe204"
        ,"vWe205"
        ,"vWe206"
        ,"vWe207"
        ,"vWe208"
        ,"vWe209"
        ,"vWe210"
        ,"vWe211"
        ,"vWe212"
        ,"vWe213"
        ,"vWe214"
        ,"vWe215"
      };


    public static string[] we2Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };



    #endregion


    #region We3
    public enum We3
    {
       vWe300_PSe0HP_1FRIG
     , vWe301_PSe0LP_1FRIG
     , vWe302_PSe0HP_2FRIG
     , vWe303_PSe0LP_2FRIG
     , vWe304_
     , vWe305_
     , vWe306_
     , vWe307_
     , vWe308_
     , vWe309_
     , vWe310_
     , vWe311_
     , vWe312_
     , vWe313_
     , vWe314_
     , vWe315_
    }

    public static string[] we3Descr =
      {
         "vWe300_0.sovrapressione 1° stadio gr.frigorifero       "
        ,"vWe301_0.bassa pressione 1° st.gr.frigorifero          "
        ,"vWe302_0.sovrapressione 2° stadio gr.frigorifero         "
        ,"vWe303_0.bassa pressione 2° st.gr.frigorifero            "
        ,"vWe304_  "
        ,"vWe305_  "
        ,"vWe306_  "
        ,"vWe307_  "
        ,"vWe308_  "
        ,"vWe309_  "
        ,"vWe310_  "
        ,"vWe311_  "
        ,"vWe312_  "
        ,"vWe313_  "
        ,"vWe314_  "
        ,"vWe315_  "
      };

    public static string[] we3Nick =
{
         "vWe300_PSe0HP_1FRIG"
        ,"vWe301_PSe0LP_1FRIG"
        ,"vWe302_PSe0HP_2FRIG"
        ,"vWe303_PSe0LP_2FRIG"
        ,"vWe304_"
        ,"vWe305_"
        ,"vWe306_"
        ,"vWe307_"
        ,"vWe308_"
        ,"vWe309_"
        ,"vWe310_"
        ,"vWe311_"
        ,"vWe312_"
        ,"vWe313_"
        ,"vWe314_"
        ,"vWe315_"
      };


    public static string[] we3Plc =
  {
         "vWe300"
        ,"vWe301"
        ,"vWe302"
        ,"vWe303"
        ,"vWe304"
        ,"vWe305"
        ,"vWe306"
        ,"vWe307"
        ,"vWe308"
        ,"vWe309"
        ,"vWe310"
        ,"vWe311"
        ,"vWe312"
        ,"vWe313"
        ,"vWe314"
        ,"vWe315"
      };


    public static string[] we3Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };



    #endregion


    #endregion


    #region output

    #region Wu0
    public enum Wu0
    {
       vWu000_CTu0CMP1FRIG
     , vWu001_CTu0CMP2FRIG
     , vWu002_SNu0POMPCIRC
     , vWu003_CTu0PMP1FRIG
     , vWu004_CTu0PMPCCELL
     , vWu005_CTu0FILTELET
     , vWu006_CTu0PWRRISFL
     , vWu007_CTu0PWRRISCE
     , vWu008_CTu1VENTEXTE
     , vWu009_CTu0VENTCELL
     , vWu010_CTu0SOFFRICE
     , vWu011_SNu1POMRCIRC
     , vWu012_SNu2ALLUARPR
     , vWu013_SNu2ACCOARPR
     , vWu014_SNu2AVANCIPR
     , vWu015_SNu0STARVIBR
    }

    public static string[] wu0Descr =
      {
         "vWu000_0.marcia compressore 1°stadio                  "
        ,"vWu001_0.marcia compressore 2°stadio                  "
        ,"vWu002_0.marcia avanti pompa circolazione fluido      "
        ,"vWu003_0.marcia pompa raffredd.vasca 1°stadio         "
        ,"vWu004_0.marcia pompa raffreddamento cella            "
        ,"vWu005_0.abilitazione filtro elettrostatico           "
        ,"vWu006_0.abilitazione resistenze fluido circolante    "
        ,"vWu007_0.abilitazione riscaldatore cella              "
        ,"vWu008_1.ev ventilazione esterna                      "
        ,"vWu009_0.ventilatore destratificazione cella          "
        ,"vWu010_0.soffiante riscaldatore cella                 "
        ,"vWu011_1.marcia indietro pompa circolazione fluido    "
        ,"vWu012_2.allontana punto arresto cil.pressione        "
        ,"vWu013_2.avvicina punto arresto cil.pressione         "
        ,"vWu014_2.avanti cilindro pressione circuito prova     "
        ,"vWu015_0.start a vibratore                            "
      };

    public static string[] wu0Nick =
      {
         "vWu000_CTu0CMP1FRIG"
        ,"vWu001_CTu0CMP2FRIG"
        ,"vWu002_CTu0POMPCIRC"
        ,"vWu003_CTu0PMP1FRIG"
        ,"vWu004_CTu0PMPCCELL"
        ,"vWu005_CTu0FILTELET"
        ,"vWu006_CTu0PWRRISFL"
        ,"vWu007_CTu0PWRRISCE"
        ,"vWu008_CTu1VENTEXTE"
        ,"vWu009_CTu0VENTCELL"
        ,"vWu010_CTu0VENTRISC"
        ,"vWu011_SNu1POMRCIRC"
        ,"vWu012_SNu2ALLUARPR"
        ,"vWu013_SNu2ACCOARPR"
        ,"vWu014_SNu2AVANCIPR"
        ,"vWu015_SNu0STARVIBR"
      };


    public static string[] wu0Plc =
  {
         "vWu000"
        ,"vWu001"
        ,"vWu002"
        ,"vWu003"
        ,"vWu004"
        ,"vWu005"
        ,"vWu006"
        ,"vWu007"
        ,"vWu008"
        ,"vWu009"
        ,"vWu010"
        ,"vWu011"
        ,"vWu012"
        ,"vWu013"
        ,"vWu014"
        ,"vWu015"
      };


    public static string[] wu0Comp =
  {
         "????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
      };
    #endregion

    #region Wu1
    public enum Wu1
    {
       vWu100_SNu0CONS_RUN
     , vWu101_SNuLAMPALLA_
     , vWu102_SNu_PIU_PIU_
     , vWu103_EVu1PRLICISI
     , vWu104_EVu1PRLIVIBR
     , vWu105_EVu1RAFFCEOL
     , vWu106_EVu1CARICIPR
     , vWu107_EVu1SCARCIPR
     , vWu108_EVu1AUX_CASC
     , vWu109_EVu1AUX_SCCI
     , vWu110_EVu1ESCIRISC
     , vWu111_EVu0CIRCH2FL
     , vWu112_EVu0SPURCIRC
     , vWu113_EVu0RACOFRI1
     , vWu114_EVu0FREDCELL
     , vWu115_EVu0SVUOCELL
    }

    public static string[] wu1Descr =
      {
         "vWu100_0.consenso messa in servizio                          "
        ,"vWu101_0.lampada segn. allarme                               "
        ,"vWu102_0.cicalino allarme                                    "
        ,"vWu103_1.pressurizzazione linea circuito siringa             "
        ,"vWu104_1.pressurizzazione linea circuito vibratore           "
        ,"vWu105_1.raffreddamento olio centralina idraulica            "
        ,"vWu106_1.caricamento circuito prova                          "
        ,"vWu107_1.scarico circuito prova                              "
        ,"vWu108_1.com.valvola aus.carico/scarico                      "
        ,"vWu109_1.com.valvola ausiliaria svuotamento                  "
        ,"vWu110_1.esclusione circolaz.fluido nel riscaldatore         "
        ,"vWu111_0.circolaz.acqua raffredd.circuito di prova           "
        ,"vWu112_0.spurgo fluido circuito di prova                     "
        ,"vWu113_0.acqua raffredd.condensatore 1°st.frigor.            "
        ,"vWu114_0.mandata fluido freddo alla cella da 1°st.frigor.    "
        ,"vWu115_0.svuotamento fluido freddo dalla cella               "
      };

    public static string[] wu1Nick =
  {
         "vWu100_SNu0CONS_RUN  "
        ,"vWu101_SNuLAMPALLA_  "
        ,"vWu102_SNu_PIU_PIU_  "
        ,"vWu103_EVu1PRLICISI  "
        ,"vWu104_EVu1PRLIVIBR  "
        ,"vWu105_EVu1RAFFCEOL  "
        ,"vWu106_EVu1CARICIPR  "
        ,"vWu107_EVu1SCARCIPR  "
        ,"vWu108_EVu1AUX_CASC  "
        ,"vWu109_EVu1AUX_SCCI  "
        ,"vWu110_EVu1ESCIRISC  "
        ,"vWu111_EVu0CIRCH2FL  "
        ,"vWu112_EVu0SPURCIRC  "
        ,"vWu113_EVu0RACOFRI1  "
        ,"vWu114_EVu0FREDCELL  "
        ,"vWu115_EVu0SVUOCELL  "
      };


    public static string[] wu1Plc =
  {
         "vWu100"
        ,"vWu101"
        ,"vWu102"
        ,"vWu103"
        ,"vWu104"
        ,"vWu105"
        ,"vWu106"
        ,"vWu107"
        ,"vWu108"
        ,"vWu109"
        ,"vWu110"
        ,"vWu111"
        ,"vWu112"
        ,"vWu113"
        ,"vWu114"
        ,"vWu115"
      };


    public static string[] wu1Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };

    #endregion

    #region Wu2
    public enum Wu2
    {
       vWu200_EVu0CONDFRI2
     , vWu201_EVu0LIQUCELL
     , vWu202_EVu0LIQUFRI1
     , vWu203_LSu0_RIPOSO_
     , vWu204_LSu0AUTOMATI
     , vWu205_LSu0ANOMALIA
     , vWu206_LSu0SBLOPORT
     , vWu207_RSu1MODURICE
     , vWu208_RSu1MODURIFL
     , vWu209_CTu1POMPECEN
     , vWu210_EVu2CIRCMOPR
     , vWu211_EVu2CIRCVAPR
     , vWu212_EVu2PRESCIRC
     , vWu213_RISERVA
     , vWu214_RISERVA
     , vWu215_RISERVA
    }

    public static string[] wu2Descr =
      {
         "circol.acqua raffredd.condensatore 1°st.frigor. "
        ,"mandata fluido freddo alla cella da 1°st.frigor."
        ,"svuotamento fluido freddo dalla cella           "
        ,"mandata fluido freddo al condens.da 2°stadio    "
        ,"mandata gas alla cella da 2°stadio frigor.      "
        ,"mandata gas evaporat.gruppo frigor.1°stadio     "
        ,"ev ventilazione esterna                         "
        ,"ev circolaz.H2o raffr.fluido circolante         "
        ,"telerutt. comando centralina oleo              "
        ,"ev circolaz. monte prova                        "
        ,"ev circolaz. valle prova                        "
        ,"ev pressurizzazione circuito prova  riserva     "
        ,"  riserva                                       "
        ,"  riserva                                       "
        ,"  riserva                                       "
        ,"  riserva                                       "
      };

    public static string[] wu2Nick =
{
         "vWu200_EVu0CONDFRI2 "
        ,"vWu201_EVu0LIQUCELL "
        ,"vWu202_EVu0LIQUFRI1 "
        ,"vWu203_LSu0_RIPOSO_ "
        ,"vWu204_LSu0AUTOMATI "
        ,"vWu205_LSu0ANOMALIA "
        ,"vWu206_LSu0SBLOPORT "
        ,"vWu207_RSu1MODURICE "
        ,"vWu208_RSu1MODURIFL "
        ,"vWu209_CTu1POMPECEN "
        ,"vWu210_EVu2CIRCMOPR "
        ,"vWu211_EVu2CIRCVAPR "
        ,"vWu212_EVu2PRESCIRC "
        ,"vWu213_RISERVA      "
        ,"vWu214_RISERVA      "
        ,"vWu215_RISERVA      "
      };


    public static string[] wu2Plc =
  {
         "vWu200_"
        ,"vWu201_"
        ,"vWu202_"
        ,"vWu203_"
        ,"vWu204_"
        ,"vWu205_"
        ,"vWu206_"
        ,"vWu207_"
        ,"vWu208_"
        ,"vWu209_"
        ,"vWu210_"
        ,"vWu211_"
        ,"vWu212_"
        ,"vWu213_"
        ,"vWu214_"
        ,"vWu215_"
      };


    public static string[] wu2Comp =
  {
         " ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
      };



    #endregion

    #region Wu3
    public enum Wu3
    {
       vWu300_RISERVA
     , vWu301_RISERVA
     , vWu302_RISERVA
     , vWu303_RISERVA
     , vWu304_RISERVA
     , vWu305_RISERVA
     , vWu306_RISERVA
     , vWu307_RISERVA
     , vWu308_RISERVA
     , vWu309_RISERVA
     , vWu310_RISERVA
     , vWu311_RISERVA
     , vWu312_RISERVA
     , vWu313_RISERVA
     , vWu314_RISERVA
     , vWu315_RISERVA
    }

    public static string[] wu3Descr =
      {
         "  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
      };

    public static string[] wu3Nick =
{
         "vWu300_RISERVA "
        ,"vWu301_RISERVA "
        ,"vWu302_RISERVA "
        ,"vWu303_RISERVA "
        ,"vWu304_RISERVA "
        ,"vWu305_RISERVA "
        ,"vWu306_RISERVA "
        ,"vWu307_RISERVA "
        ,"vWu308_RISERVA "
        ,"vWu309_RISERVA      "
        ,"vWu310_RISERVA      "
        ,"vWu311_RISERVA      "
        ,"vWu312_RISERVA      "
        ,"vWu313_RISERVA      "
        ,"vWu314_RISERVA      "
        ,"vWu315_RISERVA      "
      };


    public static string[] wu3Plc =
  {
         "vWu300_"
        ,"vWu301_"
        ,"vWu302_"
        ,"vWu303_"
        ,"vWu304_"
        ,"vWu305_"
        ,"vWu306_"
        ,"vWu307_"
        ,"vWu308_"
        ,"vWu309_"
        ,"vWu310_"
        ,"vWu311_"
        ,"vWu312_"
        ,"vWu313_"
        ,"vWu314_"
        ,"vWu315_"
      };


    public static string[] wu3Comp =
  {
         " ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
      };



    #endregion

    #endregion

    #region flag e comandi DVP
    public enum Fp0
    {
      u000_iCmdPowerOn
     , u001_iCmdTorqueRev
     , u002_iCmdHome
     , u003_iCmdMove

     , u004_iCmdMovVel
     , u005_iCmdHalt
     , u006_iCmdErrRst
     , u007_iCmdStop

     , u008_iCmdCamin
     , u009_iCmdCamout
     , u010_iCmdMovMasterVel
     , u011_iCmdMoveRel

     , u012_xMoveVelEnable
     , u013_iCmdRes13
     , u014_iCmdRes14
     , u015_iCmdRes15
    }


    public static string[] Fp0Descr =
    {
       "u000_iCmdPowerOn"
      ,"u001_iCmdTorqueRev"
      ,"u002_iCmdHome"
      ,"u003_iCmdMove"

      ,"u004_iCmdMovVel"
      ,"u005_iCmdHalt"
      ,"u006_iCmdErrRst"
      ,"u007_iCmdStop"

      ,"u008_iCmdCamin"
      ,"u009_iCmdCamout"
      ,"u010_iCmdMovMasterVel"
      ,"u011_iCmdMoveRel"

      ,"u012_xMoveVelEnable"
      ,"u013_iCmdRes13"
      ,"u014_iCmdRes14"
      ,"u015_iCmdRes15"
    };


    public enum Fp1
    {
      u000_oCmdEnabJog
     , u001_oCmdJogFwd
     , u002_oCmdJogRev
     , u003_oCmdReqRdy

     , u004_oCmdEnabPulse
     , u005_oCmdHomeEnab
     , u006_oCmdGrapPid
     , u007_oCmdGrapSpeed

     , u008_oCmdCamin
     , u009_oCmdRes9
     , u010_oCmdRes10
     , u011_oCmdRes11

     , u012_oCmdRes12
     , u013_oCmdRes13
     , u014_oCmdRes14
     , u015_oCmdPidEn
    }

    public static string[] Fp1Descr =
    {
       "u000_oCmdEnabJog"
      ,"u001_oCmdJogFwd"
      ,"u002_oCmdJogRev"
      ,"u003_oCmdReqRdy"

      ,"u004_oCmdEnabPulse"
      ,"u005_oCmdHomeEnab"
      ,"u006_oCmdGrapPid"
      ,"u007_oCmdGrapSpeed"

      ,"u008_oCmdCamin"
      ,"u009_oCmdRes9"
      ,"u010_oCmdRes10"
      ,"u011_oCmdRes11"

      ,"u012_oCmdRes12"
      ,"u013_oCmdRes13"
      ,"u014_oCmdRes14"
      ,"u015_oCmdPidEn"
    };


    public enum Fp2
    {
      u000_flPowerOn
     , u001_flMov0Done
     , u002_flHomeDone
     , u003_flHaltDone

     , u004_flInTorque
     , u005_fl0Res5
     , u006_fl0Res6
     , u007_fl0Res7

     , u008_fl0Res8
     , u009_fl0Res9
     , u010_fl0Res10
     , u011_fl0Res11

     , u012_fl0Res12
     , u013_fl0Res13
     , u014_fl0Res14
     , u015_fl0Res15
    }

    public static string[] Fp2Descr =
    {
       "u000_flPowerOn"
      ,"u001_flMov0Done"
      ,"u002_flHomeDone"
      ,"u003_flHaltDone"

      ,"u004_flInTorque"
      ,"u005_fl0Res5"
      ,"u006_fl0Res6"
      ,"u007_fl0Res7"

      ,"u008_fl0Res8"
      ,"u009_fl0Res9"
      ,"u010_fl0Res10"
      ,"u011_fl0Res11"

      ,"u012_fl0Res12"
      ,"u013_fl0Res13"
      ,"u014_fl0Res14"
      ,"u015_fl0Res15"
    };


    public enum Fp3
    {
      u000_fliLockJog
     , u001_flIntRes1
     , u002_flIntRes2
     , u003_flIntRes3

     , u004_flIntRes4
     , u005_flIntRes5
     , u006_flIntRes6
     , u007_flIntRes7

     , u008_flIntRes8
     , u009_flIntRes9
     , u010_flIntRes10
     , u011_flIntRes11

     , u012_flIntRes12
     , u013_flIntRes13
     , u014_flIntRes14
     , u015_flIntRes15
    }

    public static string[] Fp3Descr =
    {
       "u000_fliLockJog"
      ,"u001_flIntRes1"
      ,"u002_flIntRes2"
      ,"u003_flIntRes3"

      ,"u004_flIntRes4"
      ,"u005_flIntRes5"
      ,"u006_flIntRes6"
      ,"u007_flIntRes7"

      ,"u008_flIntRes8"
      ,"u009_flIntRes9"
      ,"u010_flIntRes10"
      ,"u011_flIntRes11"

      ,"u012_flIntRes12"
      ,"u013_flIntRes13"
      ,"u014_flIntRes14"
      ,"u015_flIntRes15"
    };

    #endregion

    #region flag e comandi S7
    public enum S7flStat
    {
      u000_riempOk
     , u001_svuotaOk
     , u002_evalOk
     , u003_camRun

     , u004_i
     , u005_i
     , u006_i
     , u007_i

     , u008_i
     , u009_i
     , u010_i
     , u011_i

     , u012_x
     , u013_i
     , u014_i
     , u015_i
    }


    public static string[] S7flStDes =
    {
       "u000_RiempOk"
      ,"u001_svuotOk"
      ,"u002_eval_Ok"
      ,"u003_cammRun"

      ,"u004_"
      ,"u005_"
      ,"u006_"
      ,"u007_"

      ,"u008_"
      ,"u009_"
      ,"u010_"
      ,"u011_"

      ,"u012_"
      ,"u013_"
      ,"u014_"
      ,"u015_"
    };


    public enum S71
    {
      u000_oCmdEnabJog
     , u001_oCmdJogFwd
     , u002_oCmdJogRev
     , u003_oCmdReqRdy

     , u004_oCmdEnabPulse
     , u005_oCmdHomeEnab
     , u006_oCmdGrapPid
     , u007_oCmdGrapSpeed

     , u008_oCmdCamin
     , u009_oCmdRes9
     , u010_oCmdRes10
     , u011_oCmdRes11

     , u012_oCmdRes12
     , u013_oCmdRes13
     , u014_oCmdRes14
     , u015_oCmdPidEn
    }

    public static string[] S71Descr =
    {
       "u000_oCmdEnabJog"
      ,"u001_oCmdJogFwd"
      ,"u002_oCmdJogRev"
      ,"u003_oCmdReqRdy"

      ,"u004_oCmdEnabPulse"
      ,"u005_oCmdHomeEnab"
      ,"u006_oCmdGrapPid"
      ,"u007_oCmdGrapSpeed"

      ,"u008_oCmdCamin"
      ,"u009_oCmdRes9"
      ,"u010_oCmdRes10"
      ,"u011_oCmdRes11"

      ,"u012_oCmdRes12"
      ,"u013_oCmdRes13"
      ,"u014_oCmdRes14"
      ,"u015_oCmdPidEn"
    };


    public enum S72
    {
      u000_flPowerOn
     , u001_flMov0Done
     , u002_flHomeDone
     , u003_flHaltDone

     , u004_flInTorque
     , u005_fl0Res5
     , u006_fl0Res6
     , u007_fl0Res7

     , u008_fl0Res8
     , u009_fl0Res9
     , u010_fl0Res10
     , u011_fl0Res11

     , u012_fl0Res12
     , u013_fl0Res13
     , u014_fl0Res14
     , u015_fl0Res15
    }

    public static string[] S72Descr =
    {
       "u000_flPowerOn"
      ,"u001_flMov0Done"
      ,"u002_flHomeDone"
      ,"u003_flHaltDone"

      ,"u004_flInTorque"
      ,"u005_fl0Res5"
      ,"u006_fl0Res6"
      ,"u007_fl0Res7"

      ,"u008_fl0Res8"
      ,"u009_fl0Res9"
      ,"u010_fl0Res10"
      ,"u011_fl0Res11"

      ,"u012_fl0Res12"
      ,"u013_fl0Res13"
      ,"u014_fl0Res14"
      ,"u015_fl0Res15"
    };


    public enum S73
    {
      u000_fliLockJog
     , u001_flIntRes1
     , u002_flIntRes2
     , u003_flIntRes3

     , u004_flIntRes4
     , u005_flIntRes5
     , u006_flIntRes6
     , u007_flIntRes7

     , u008_flIntRes8
     , u009_flIntRes9
     , u010_flIntRes10
     , u011_flIntRes11

     , u012_flIntRes12
     , u013_flIntRes13
     , u014_flIntRes14
     , u015_flIntRes15
    }

    public static string[] S73Descr =
    {
       "u000_fliLockJog"
      ,"u001_flIntRes1"
      ,"u002_flIntRes2"
      ,"u003_flIntRes3"

      ,"u004_flIntRes4"
      ,"u005_flIntRes5"
      ,"u006_flIntRes6"
      ,"u007_flIntRes7"

      ,"u008_flIntRes8"
      ,"u009_flIntRes9"
      ,"u010_flIntRes10"
      ,"u011_flIntRes11"

      ,"u012_flIntRes12"
      ,"u013_flIntRes13"
      ,"u014_flIntRes14"
      ,"u015_flIntRes15"
    };

    #endregion

    #endregion
    

    #region allarmi
    public enum Wa00
    {
       AL0_0_SInTUTTO_OK 
     , AL0_1_FCn0PORTNOCH
     , AL0_2_TSn0RISCFLUI
     , AL0_3_TSn0TEMPCAME
     , AL0_4_LVn2FLUPROOK
     , AL0_5_LSn0TRAFFLUI
     , AL0_6_PSn0PRESARIA
     , AL0_7_LVn1OLIOBASS
     , AL0_8_PSn0HP_1FRIG
     , AL0_9_TSn0LT_1FRIG
     , AL0_a_FLn0LQ_1FRIG
     , AL0_b_FLn0GQ_2FRIG
     , AL0_c_LVn0HG_1FRIG
     , AL0_d_PSn0HP_2FRIG
     , AL0_e_PSn0LP_2FRIG
     , AL0_f_TEn0COMP1FRI
    }

    public static string[] wa0Descr =
  {
         "0.all. circuiti ausiliari inseriti "
        ,"0.all. porta cella non chiusa "
        ,"0.all. termostato sicurezza riscaldatore fluido "
        ,"0.all. termostato sicurezza cella climatica "
        ,"2.all. livello fluido prova sufficiente "
        ,"0.all. trafilamento fluido da elementi in prova "
        ,"0.all. pressione aria sufficiente "
        ,"1.all. livello olio centralina insufficiente "
        ,"0.all. sovrapressione 1° stadio gr.frigorifero "
        ,"0.all. termostato di minima 1° stadio gr.frigorifero "
        ,"0.all. flussostato 1° stadio gruppo frigorifero "
        ,"0.all. fl circ.fl. in cella da 1° st./fl cond. 2° st "
        ,"0.all. livello fluido vasca 1° stadio gr.frigorifero "
        ,"0.all. sovrapressione 2° stadio gr.frigorifero "
        ,"0.all. insufficiente pressione 2° st.gr.frigorifero "
        ,"0.all. interv.prot.mot.compressore 1°st.gr.frigor. "
      };

    public static string[] wa0Nick =
      {
         "SInTUTTO_OK  "
        ,"FCn0PORTNOCH "
        ,"TSn0RISCFLUI "
        ,"TSn0TEMPCAME "
        ,"LVn2FLUPROOK "
        ,"LSn0TRAFFLUI "
        ,"PSn0PRESARIA "
        ,"LVn1OLIOBASS "
        ,"PSn0HP_1FRIG "
        ,"TSn0LT_1FRIG "
        ,"FLn0LQ_1FRIG "
        ,"FLn0GQ_2FRIG "
        ,"LVn0HG_1FRIG "
        ,"PSn0HP_2FRIG "
        ,"PSn0LP_2FRIG "
        ,"TEn0COMP1FRI "
      };


    public static string[] wa0Plc =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public static string[] wa0Comp =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public enum Wa01
    {
       AL1_0_TEn0COMP2FRI
     , AL1_1_TEn0POMP1FRI
     , AL1_2_TEn0POMPCELL
     , AL1_3_TEn0POMPP1P2
     , AL1_4_TEn0POMP_P3_
     , AL1_5_TEn1POMP_P4_
     , AL1_6_TEn2MREGCIPR
     , AL1_7_TEn1VENTCELL
     , AL1_8_TEn0RISCCELL
     , AL1_9_SNn1FILTCECL
     , AL1_a_SNn1FISER1CL
     , AL1_b_SNn1FIVIBRCL
     , AL1_c_SNn1FIPILOCL
     , AL1_d_SNn0PROT_AUX
     , AL1_e_SNn0PROTFIEL
     , AL1_f_SNn0EMERRIPR
    }


    public static string[] wa1Descr =
  {
         "0.all. interv.prot.mot.compressore 2°st.gr.frigor."
        ,"0.all. interv.prot.mot.pompa raffr.vasca 1°st.frigor."
        ,"0.all. interv.prot.mot.pompa raffr.cella da 1° stadio"
        ,"1 all interv. prot.mot.pompe P1-P2"
        ,"0.all. interv.prot.motore pompa P3"
        ,"1.all. interv.prot.motore pompa P4"
        ,"2.all. interv.prot.mot.regol.corsa cilindro pressione"
        ,"1.all. interv.prot.motore ventola cella"
        ,"0.all. interv.prot.riscaldatore cella"
        ,"1.all. filtro principale centralina intasato"
        ,"1.all. filtro servizio cilindro 1 intasato"
        ,"1.all. filtro servizio vibratore intasato"
        ,"1.all. filtro servizio pilotaggio cil.1 intasato"
        ,"0.all. interv.prot.circuiti 24Vdc"
        ,"0.all. intervento protez.filtro elettrostatico"
        ,"0.all. emergenza ripristinata"
      };

    public static string[] wa1Nick =
      {
         "TEn0COMP2FRI"
        ,"TEn0POMP1FRI"
        ,"TEn0POMPCELL"
        ,"TEn0POMPP1P2"
        ,"TEn0POMP_P3_"
        ,"TEn1POMP_P4_"
        ,"TEn2MREGCIPR"
        ,"TEn1VENTCELL"
        ,"TEn0RISCCELL"
        ,"SNn1FILTCECL"
        ,"SNn1FISER1CL"
        ,"SNn1FIVIBRCL"
        ,"SNn1FIPILOCL"
        ,"SNn0PROT_AUX"
        ,"SNn0PROTFIEL"
        ,"SNn0EMERRIPR"
      };


    public static string[] wa1Plc =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public static string[] wa1Comp =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public enum Wa02
    {
       AL2_0_SLn0AUTOMATI
     , AL2_1_SNn1DRIVFLOK
     , AL2_2_PSn0LOPRFRI1
     , AL2_3_SQnSTEPUNDF 
     , AL2_4_SQnTESTLIVE 
     , AL2_5_
     , AL2_6_
     , AL2_7_
     , AL2_8_
     , AL2_9_
     , AL2_a_
     , AL2_b_
     , AL2_c_
     , AL2_d_
     , AL2_e_
     , AL2_f_
    }


    public static string[] wa2Descr =
  {
         "0.all. selettore comandi automatici"
        ,"1.all. nessuna anomalia inverter pompa circolaz."
        ,"0 all alta pressione primo stadio"
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
      };

    public static string[] wa2Nick =
      {
         "SLn0AUTOMATI "
        ,"SNn1DRIVFLOK "
        ,"PSn0LOPRFRI1 "
        ,"SQnSTEPUNDF "
        ,"SQnTESTLIVE "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
      };


    public static string[] wa2Plc =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public static string[] wa2Comp =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public string[,] msgAll =
 {
   {
 "AL0.0 SInTUTTO_OK "
,"AL0.1 FCn0PORTNOCH"
,"AL0.2 TSn0RISCFLUI"
,"AL0.3 TSn0TEMPCAME"
,"AL0.4 LVn2FLUPROOK"
,"AL0.5 LSn0TRAFFLUI"
,"AL0.6 PSn0PRESARIA"
,"AL0.7 LVn1OLIOBASS"
,"AL0.8 PSn0HP_1FRIG"
,"AL0.9 TSn0LT_1FRIG"
,"AL0.a FLn0LQ_1FRIG"
,"AL0.b FLn0GQ_2FRIG"
,"AL0.c LVn0HG_1FRIG"
,"AL0.d PSn0HP_2FRIG"
,"AL0.e PSn0LP_2FRIG"
,"AL0.f TEn0COMP1FRI"
     },
   {
 "AL1.0 TEn0COMP2FRI"
,"AL1.1 TEn0POMP1FRI"
,"AL1.2 TEn0POMPCELL"
,"AL1.3 TEn0POMPP1P2"
,"AL1.4 TEn0POMP_P3_"
,"AL1.5 TEn1POMP_P4_"
,"AL1.6 TEn2MREGCIPR"
,"AL1.7 TEn1VENTCELL"
,"AL1.8 TEn0RISCCELL"
,"AL1.9 SNn1FILTCECL"
,"AL1.a SNn1FISER1CL"
,"AL1.b SNn1FIVIBRCL"
,"AL1.c SNn1FIPILOCL"
,"AL1.d SNn0PROT_AUX"
,"AL1.e SNn0PROTFIEL"
,"AL1.f SNn0EMERRIPR"
  },
   {
 "AL1.0 SLn0AUTOMATI"
,"AL1.1 SNn1DRIVFLOK"
,"AL1.2 PSn0LOPRFRI1"
,"AL1.3 SQnSTEPUNDF "
,"AL1.4 SQnTESTLIVE "
,"AL1.5 "
,"AL1.6 "
,"AL1.7 "
,"AL1.8 "
,"AL1.9 "
,"AL1.a "
,"AL1.b "
,"AL1.c "
,"AL1.d "
,"AL1.e "
,"AL1.f "
  }
};

    #endregion

    #region Fasi e Cicli
    #region CicliPtr
    public enum ptrFaseFrigo
    {
      _00_Init                     = 00 ,
      _10_attesaStart              = 10 ,
      _20_avviamentoPompa          = 20 ,
      _30_attendeFlusso            = 30 ,
      _40_pronto_richiesta_freddo  = 40 ,
      _50_alimentazione_liquida    = 50 ,
      _60_funzione_Normale         = 60 ,
      _70_pump_down                = 70 ,
      _80_riposo_fermo             = 80 ,
      _90_pump_down                = 90 ,
      _1000_gestione_fault         = 1000,
      _1001_rientro_reset          = 1001,
    };

    
    public static string[] ptrFaseFrigoLbl =
    {
      "00 - Reset ciclo"
      ,"10 - Attesa comandi"
      ,"20 - Riempimento impianto"
      ,"30 - Caratterizzazione"
      ,"40 - Verifica prestazioni"
      ,"50 - Esecuzione passo prova"
      ,"60 - Svuotamento impianto"
      ,"100 - Fine"
    };

    public static Dictionary<int, string> faseFrigo = new Dictionary<int, string>(){
     {0  , "init: in teoria solo al power on plc				     "}
    ,{10 , "attesa richiesta marcia                          "}
    ,{20 , "avviamento pompa circolazione                    "}
    ,{30 , "attende flusso                                   "}
    ,{40 , "pronto alla marcia - attesa richiesta freddo     "}
    ,{50 , "Alimentazione liquida                            "}
    ,{60 , "Funzionamento normale                            "}
    ,{70 , "pump down                                        "}
    ,{80 , "riposo da fermo (antiripetizione)                "}
    ,{90 , "attesa arresto flusso                            "}
    ,{1000, "gestione fault                                  "}
    ,{1001, "rientro reset                                   "}
  };

    public static Dictionary<int, string> riscaldoCella = new Dictionary<int, string>(){
     {0  , "init: in teoria solo al power on plc				     "}
    ,{10 , "attesa richiesta marcia                          "}
    ,{20 , "                                                 "}
    ,{30 , "                                                 "}
    ,{40 , "pronto alla marcia - attesa richiesta caldo      "}
    ,{50 , "Regimazione ventilatore                          "}
    ,{60 , "Funzionamento normale                            "}
    ,{70 , "Spegnimento riscaldo                             "}
    ,{80 , "Arresto ventilatore                              "}
    ,{90 , "                                                 "}
    ,{1000, "gestione fault                                  "}
    ,{1001, "rientro reset                                   "}
  };

    public static Dictionary<int, string> raffreddamentoCella = new Dictionary<int, string>(){
     {0  , "init: in teoria solo al power on plc				     "}
    ,{10 , "attesa richiesta marcia                          "}
    ,{20 , "                    "}
    ,{30 , ""}
    ,{40 , "pronto alla marcia - attesa richiesta freddo     "}
    ,{50 , ""}
    ,{60 , ""}
    ,{70 , ""}
    ,{80 , ""}
    ,{90 , ""}
    ,{100, "Raffreddamento a glicole"}
    ,{110, "Da glicole a freon, svuotamento a tempo"}
    ,{200, "Raffreddamento freon, espansione diretta"}
    ,{400, "Conclusione fase raffreddamento"}
    ,{1000, "gestione fault                                  "}
    ,{1001, "rientro reset                                   "}
  };

    //  public static Dictionary<int, string> faseFrigo = new Dictionary<int, string>(){
    //   {0  , "init: in teoria solo al power on plc				     "}
    //  ,{10 , "attesa richiesta marcia                          "}
    //  ,{20 , "avviamento pompa circolazione                    "}
    //  ,{30 , "attende flusso                                   "}
    //  ,{40 , "pronto alla marcia - attesa richiesta freddo     "}
    //  ,{50 , "Alimentazione liquida                            "}
    //  ,{60 , "Funzionamento normale                            "}
    //  ,{70 , "pump down                                        "}
    //  ,{80 , "riposo da fermo (antiripetizione)                "}
    //  ,{90 , "attesa arresto flusso                            "}
    //  ,{1000, "gestione fault                                  "}
    //  ,{1001, "rientro reset                                   "}
    //};




    #endregion
    #endregion
    #endregion
   
#elif v0511
    #region def

    #region Analog output

    #region Ao channel names Siemens

    public enum aoChNoS7
    {
      //SM 1232 AQ4, la prima, AO
      s7ANoJ120MAND
        , s7ANoJ200CIRC
        , s7ANoJ530RAFF
        , s7ANoRiserva3
    };

    public static string[] aoChNamesS7 =
      { 
        //SM 1232 AQ4, la prima, AO
        " s7ANoJ120MAND"              //21 - 0
        ,"s7ANoJ200CIRC"
        ,"s7ANoJ530RAFF"
        ,"s7ANoRiserva3"
      };
    #endregion

    #region Ao label short Siemens

    public static string[] aoLabelShortS7 =
      { 
        //SM 1232 AQ4, la prima, AO
        " Comando drive riempimento"
        ,"Comando drive circolazione"
        ,"Comando drive raffreddamento"
        ,"Riserva canale 3"
      };
    #endregion

    #region Ao label long Siemens
    public static string[] aoLabelLongS7 =
      { 
        //SM 1232 AQ4, la prima, AO
        " Comando drive riempimento"
        ,"Comando drive circolazione"
        ,"Comando drive raffreddamento"
        ,"Riserva canale 3"
      };
    #endregion
    #endregion


    #region I/O digitali

    public enum Wexxx
    {
      ec0
      , ec1
      , ec2
      , ec3
    }
    public enum Wuxxx
    {
      uc0
      , uc1
      , uc2
    }
    public enum Waxxx
    {
      ac0
      , ac1
      , ac2
    }

    #region input

    #region We0
    public enum We0
    {
       vWe000_TEeP1020MAN
     , vWe001_KMeP1020MAN
     , vWe002_SNePS510AIR
     , vWe003_SNeLV1kSERB
     , vWe004_OPeV1100RIT
     , vWe005_CLeV1100RIT
     , vWe006_OPeV1070MAN
     , vWe007_CLeV1070MAN
     , vWe008_
     , vWe009_
     , vWe010_
     , vWe011_
     , vWe012_
     , vWe013_
     , vWe014_
     , vWe015_
    }

    public static string[] we0Descr =
      {
         "vWe000.Termica pompa mandata              "
        ,"vWe001.Readback pompa mandata             "
        ,"vWe002.Pressostato pres. aria compr.      "
        ,"vWe003.Livello serbatoio fluido           "
        ,"vWe004.Valvola ritorno aperta             "
        ,"vWe005.Valvola ritorno chiusa             "
        ,"vWe006.Valvola mandata aperta             "
        ,"vWe007.Valvola mandata chiusa             "
        ,"vWe008.                                   "
        ,"vWe009.                                   "
        ,"vWe010.                                   "
        ,"vWe011.                                   "
        ,"vWe012.                                   "
        ,"vWe013.                                   "
        ,"vWe014.                                   "
        ,"vWe015.                                   "
      };

    public static string[] we0Nick =
      {
         "vWe000_TEeP1020MAN"
        ,"vWe001_KMeP1020MAN"
        ,"vWe002_SNePS510AIR"
        ,"vWe003_SNeLV1kSERB"
        ,"vWe004_OPeV1100RIT"
        ,"vWe005_CLeV1100RIT"
        ,"vWe006_OPeV1070MAN"
        ,"vWe007_CLeV1070MAN"
        ,"vWe008_"
        ,"vWe009_"
        ,"vWe010_"
        ,"vWe011_"
        ,"vWe012_"
        ,"vWe013_"
        ,"vWe014_"
        ,"vWe015_"
      };


    public static string[] we0Plc =
  {
         "vWe000"
        ,"vWe001"
        ,"vWe002"
        ,"vWe003"
        ,"vWe004"
        ,"vWe005"
        ,"vWe006"
        ,"vWe007"
        ,"vWe008"
        ,"vWe009"
        ,"vWe010"
        ,"vWe011"
        ,"vWe012"
        ,"vWe013"
        ,"vWe014"
        ,"vWe015"
      };


    public static string[] we0Comp =
  {
         "????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
      };
#endregion

#region We1
    public enum We1
    {
       vWe100_PSe0HP_2FRIGex
     , vWe101_PSe0LP_2FRIGex
     , vWe102_FCe0VIBRPOSI
     , vWe103_FCe0VIBRSPIN
     , vWe104_SNe0VIBR_RUN
     , vWe105_TEe0COMP1FRI
     , vWe106_TEe0COMP2FRI
     , vWe107_TEe0POMP1FRI
     , vWe108_TEe0POMPCELL
     , vWe109_TEe0POMPP1P2
     , vWe110_TEe0POMP_P3_
     , vWe111_TEe1POMP_P4_
     , vWe112_TEe2MREGCIPR
     , vWe113_TEe1VENTCELL
     , vWe114_TEe0RISCCELL
     , vWe115_SNe1FILTCECL
    }

    public static string[] we1Descr =
      {
         "vWe100_Riserva                                            "
        ,"vWe101_Riserva                                            "
        ,"vWe102_0.vibratore posizionato                            "
        ,"vWe103_0.spina vibratore introdotta                       "
        ,"vWe104_0.gruppo vibratore in marcia                       "
        ,"vWe105_0.interv.prot.mot.compressore 1°st.gr.frigor.      "
        ,"vWe106_0.interv.prot.mot.compressore 2°st.gr.frigor.      "
        ,"vWe107_0.interv.prot.mot.pompa circolazione               "
        ,"vWe108_0.interv.prot.mot.pompa raffr.vasca 1°st.frigor.   "
        ,"vWe109_0.interv.prot.mot.pompa raffr.cella da 1° stadio   "
        ,"vWe110_0.interv.prot.mot.ventilazione cella               "
        ,"vWe111_1.interv.prot.motore pompa P4                      "
        ,"vWe112_2.interv.prot.mot.regol.corsa cilindro pressione   "
        ,"vWe113_1.interv.prot.motore ventola cella                 "
        ,"vWe114_0.interv.prot.riscaldatore cella                   "
        ,"vWe115_1.filtro principale centralina intasato            "
      };

    public static string[] we1Nick =
  {
         "vWe100_PSe0HP_2FRIG"
        ,"vWe101_PSe0LP_2FRIG"
        ,"vWe102_FCe0VIBRPOSI"
        ,"vWe103_FCe0VIBRSPIN"
        ,"vWe104_SNe0VIBR_RUN"
        ,"vWe105_TEe0COMP1FRI"
        ,"vWe106_TEe0COMP2FRI"
        ,"vWe107_TEe0POMP1FRI"
        ,"vWe108_TEe0POMPCELL"
        ,"vWe109_TEe0POMPP1P2"
        ,"vWe110_TEe0POMP_P3_"
        ,"vWe111_TEe1POMP_P4_"
        ,"vWe112_TEe2MREGCIPR"
        ,"vWe113_TEe1VENTCELL"
        ,"vWe114_TEe0RISCCELL"
        ,"vWe115_SNe1FILTCECL"
      };


    public static string[] we1Plc =
  {
         "vWe100"
        ,"vWe101"
        ,"vWe102"
        ,"vWe103"
        ,"vWe104"
        ,"vWe105"
        ,"vWe106"
        ,"vWe107"
        ,"vWe108"
        ,"vWe109"
        ,"vWe110"
        ,"vWe111"
        ,"vWe112"
        ,"vWe113"
        ,"vWe114"
        ,"vWe115"
      };


    public static string[] we1Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };

#endregion

#region We2
    public enum We2
    {
       vWe200_SNe1FISER1CL
     , vWe201_SNe1FIVIBRCL
     , vWe202_SNe1FIPILOCL
     , vWe203_SNe0PROT_AUX
     , vWe204_SNe0PROTFIEL
     , vWe205_SIe0TUTTO_OK
     , vWe206_SNe0EMERRIPR
     , vWe207_SLe0AUTOMATI
     , vWe208_PUe0STARAUTO
     , vWe209_PUe0STOPAUTO
     , vWe210_PUe0COMAAVAN
     , vWe211_PUe0COMAINDI
     , vWe212_SNe1CENTMARC
     , vWe213_SNe1DRIVFLOK
     , vWe214_PUeACK_ALLA	
     , vWe215_PUeRESEALLA
    }

    public static string[] we2Descr =
      {
         "vWe200_1.filtro servizio cilindro 1 intasato        "
        ,"vWe201_1.filtro servizio vibratore intasato         "
        ,"vWe202_1.filtro servizio pilotaggio cil.1 intasato  "
        ,"vWe203_0.interv.prot.circuiti 24Vdc                 "
        ,"vWe204_0.intervento protez.filtro elettrostatico    "
        ,"vWe205_0.circuiti ausiliari inseriti                "
        ,"vWe206_0.emergenza ripristinata                     "
        ,"vWe207_0.selettore comandi automatici               "
        ,"vWe208_0.pulsante avvio ciclo automatico            "
        ,"vWe209_0.pulsante arresto ciclo automatico          "
        ,"vWe210_0.pulsante comando manuale avanti            "
        ,"vWe211_0.pulsante comando manuale indietro          "
        ,"vWe212_1.pompe idrauliche in marcia                 "
        ,"vWe213_1.nessuna anomalia inverter pompa circolaz.  "
        ,"vWe214_                                             "
        ,"vWe215_                                             "
      };

    public static string[] we2Nick =
{
         "vWe200_SNe1FISER1CL "
        ,"vWe201_SNe1FIVIBRCL "
        ,"vWe202_SNe1FIPILOCL "
        ,"vWe203_SNe0PROT_AUX "
        ,"vWe204_SNe0PROTFIEL "
        ,"vWe205_SIe0TUTTO_OK "
        ,"vWe206_SNe0EMERRIPR "
        ,"vWe207_SLe0AUTOMATI "
        ,"vWe208_PUe0STARAUTO "
        ,"vWe209_PUe0STOPAUTO "
        ,"vWe210_PUe0COMAAVAN "
        ,"vWe211_PUe0COMAINDI "
        ,"vWe212_SNe1CENTMARC "
        ,"vWe213_SNe1DRIVFLOK "
        ,"vWe214_PUeACK_ALLA	"
        ,"vWe215_PUeRESEALLA	"
      };


    public static string[] we2Plc =
  {
         "vWe200"
        ,"vWe201"
        ,"vWe202"
        ,"vWe203"
        ,"vWe204"
        ,"vWe205"
        ,"vWe206"
        ,"vWe207"
        ,"vWe208"
        ,"vWe209"
        ,"vWe210"
        ,"vWe211"
        ,"vWe212"
        ,"vWe213"
        ,"vWe214"
        ,"vWe215"
      };


    public static string[] we2Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };



#endregion


#region We3
    public enum We3
    {
       vWe300_PSe0HP_1FRIG
     , vWe301_PSe0LP_1FRIG
     , vWe302_PSe0HP_2FRIG
     , vWe303_PSe0LP_2FRIG
     , vWe304_
     , vWe305_
     , vWe306_
     , vWe307_
     , vWe308_
     , vWe309_
     , vWe310_
     , vWe311_
     , vWe312_
     , vWe313_
     , vWe314_
     , vWe315_
    }

    public static string[] we3Descr =
      {
         "vWe300_0.sovrapressione 1° stadio gr.frigorifero       "
        ,"vWe301_0.bassa pressione 1° st.gr.frigorifero          "
        ,"vWe302_0.sovrapressione 2° stadio gr.frigorifero         "
        ,"vWe303_0.bassa pressione 2° st.gr.frigorifero            "
        ,"vWe304_  "
        ,"vWe305_  "
        ,"vWe306_  "
        ,"vWe307_  "
        ,"vWe308_  "
        ,"vWe309_  "
        ,"vWe310_  "
        ,"vWe311_  "
        ,"vWe312_  "
        ,"vWe313_  "
        ,"vWe314_  "
        ,"vWe315_  "
      };

    public static string[] we3Nick =
{
         "vWe300_PSe0HP_1FRIG"
        ,"vWe301_PSe0LP_1FRIG"
        ,"vWe302_PSe0HP_2FRIG"
        ,"vWe303_PSe0LP_2FRIG"
        ,"vWe304_"
        ,"vWe305_"
        ,"vWe306_"
        ,"vWe307_"
        ,"vWe308_"
        ,"vWe309_"
        ,"vWe310_"
        ,"vWe311_"
        ,"vWe312_"
        ,"vWe313_"
        ,"vWe314_"
        ,"vWe315_"
      };


    public static string[] we3Plc =
  {
         "vWe300"
        ,"vWe301"
        ,"vWe302"
        ,"vWe303"
        ,"vWe304"
        ,"vWe305"
        ,"vWe306"
        ,"vWe307"
        ,"vWe308"
        ,"vWe309"
        ,"vWe310"
        ,"vWe311"
        ,"vWe312"
        ,"vWe313"
        ,"vWe314"
        ,"vWe315"
      };


    public static string[] we3Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };



#endregion


#endregion


#region output

#region Wu0
    public enum Wu0
    {
       vWu000_KMuP1020MAN
     , vWu001_YVu500GARIA
     , vWu002_YVu1070MAND
     , vWu003_YVu1100RITo
     , vWu004_KMaSelTrasd
     , vWu005_Riserva_0_5
     , vWu006_
     , vWu007_
     , vWu008_
     , vWu009_
     , vWu010_
     , vWu011_
     , vWu012_
     , vWu013_
     , vWu014_
     , vWu015_
    }








    public static string[] wu0Descr =
      {
         "vWu000.KMuP1020MAN"
        ,"vWu001.YVu500GARIA"
        ,"vWu002.YVu1070MAND"
        ,"vWu003.YVu1100RITo"
        ,"vWu004.KMaSelTrasd"
        ,"vWu005.Riserva_0_5"
        ,"vWu006."
        ,"vWu007."
        ,"vWu008."
        ,"vWu009."
        ,"vWu010."
        ,"vWu011."
        ,"vWu012."
        ,"vWu013."
        ,"vWu014."
        ,"vWu015."
      };

    public static string[] wu0Nick =
      {
         "vWu000_KMuP1020MAN "
        ,"vWu001_YVu500GARIA "
        ,"vWu002_YVu1070MAND "
        ,"vWu003_YVu1100RITo "
        ,"vWu004_KMaSelTrasd "
        ,"vWu005_Riserva_0_5 "
        ,"vWu006_"
        ,"vWu007_"
        ,"vWu008_"
        ,"vWu009_"
        ,"vWu010_"
        ,"vWu011_"
        ,"vWu012_"
        ,"vWu013_"
        ,"vWu014_"
        ,"vWu015_"
      };


    public static string[] wu0Plc =
  {
         "vWu000"
        ,"vWu001"
        ,"vWu002"
        ,"vWu003"
        ,"vWu004"
        ,"vWu005"
        ,"vWu006"
        ,"vWu007"
        ,"vWu008"
        ,"vWu009"
        ,"vWu010"
        ,"vWu011"
        ,"vWu012"
        ,"vWu013"
        ,"vWu014"
        ,"vWu015"
      };


    public static string[] wu0Comp =
  {
         "????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
        ,"????"
      };
#endregion

#region Wu1
    public enum Wu1
    {
       vWu100_SNu0CONS_RUN
     , vWu101_SNuLAMPALLA_
     , vWu102_SNu_PIU_PIU_
     , vWu103_EVu1PRLICISI
     , vWu104_EVu1PRLIVIBR
     , vWu105_EVu1RAFFCEOL
     , vWu106_EVu1CARICIPR
     , vWu107_EVu1SCARCIPR
     , vWu108_EVu1AUX_CASC
     , vWu109_EVu1AUX_SCCI
     , vWu110_EVu1ESCIRISC
     , vWu111_EVu0CIRCH2FL
     , vWu112_EVu0SPURCIRC
     , vWu113_EVu0RACOFRI1
     , vWu114_EVu0FREDCELL
     , vWu115_EVu0SVUOCELL
    }

    public static string[] wu1Descr =
      {
         "vWu100_0.consenso messa in servizio                          "
        ,"vWu101_0.lampada segn. allarme                               "
        ,"vWu102_0.cicalino allarme                                    "
        ,"vWu103_1.pressurizzazione linea circuito siringa             "
        ,"vWu104_1.pressurizzazione linea circuito vibratore           "
        ,"vWu105_1.raffreddamento olio centralina idraulica            "
        ,"vWu106_1.caricamento circuito prova                          "
        ,"vWu107_1.scarico circuito prova                              "
        ,"vWu108_1.com.valvola aus.carico/scarico                      "
        ,"vWu109_1.com.valvola ausiliaria svuotamento                  "
        ,"vWu110_1.esclusione circolaz.fluido nel riscaldatore         "
        ,"vWu111_0.circolaz.acqua raffredd.circuito di prova           "
        ,"vWu112_0.spurgo fluido circuito di prova                     "
        ,"vWu113_0.acqua raffredd.condensatore 1°st.frigor.            "
        ,"vWu114_0.mandata fluido freddo alla cella da 1°st.frigor.    "
        ,"vWu115_0.svuotamento fluido freddo dalla cella               "
      };

    public static string[] wu1Nick =
  {
         "vWu100_SNu0CONS_RUN  "
        ,"vWu101_SNuLAMPALLA_  "
        ,"vWu102_SNu_PIU_PIU_  "
        ,"vWu103_EVu1PRLICISI  "
        ,"vWu104_EVu1PRLIVIBR  "
        ,"vWu105_EVu1RAFFCEOL  "
        ,"vWu106_EVu1CARICIPR  "
        ,"vWu107_EVu1SCARCIPR  "
        ,"vWu108_EVu1AUX_CASC  "
        ,"vWu109_EVu1AUX_SCCI  "
        ,"vWu110_EVu1ESCIRISC  "
        ,"vWu111_EVu0CIRCH2FL  "
        ,"vWu112_EVu0SPURCIRC  "
        ,"vWu113_EVu0RACOFRI1  "
        ,"vWu114_EVu0FREDCELL  "
        ,"vWu115_EVu0SVUOCELL  "
      };


    public static string[] wu1Plc =
  {
         "vWu100"
        ,"vWu101"
        ,"vWu102"
        ,"vWu103"
        ,"vWu104"
        ,"vWu105"
        ,"vWu106"
        ,"vWu107"
        ,"vWu108"
        ,"vWu109"
        ,"vWu110"
        ,"vWu111"
        ,"vWu112"
        ,"vWu113"
        ,"vWu114"
        ,"vWu115"
      };


    public static string[] wu1Comp =
  {
         "??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
        ,"??????"
      };

#endregion

#region Wu2
    public enum Wu2
    {
       vWu200_EVu0CONDFRI2
     , vWu201_EVu0LIQUCELL
     , vWu202_EVu0LIQUFRI1
     , vWu203_LSu0_RIPOSO_
     , vWu204_LSu0AUTOMATI
     , vWu205_LSu0ANOMALIA
     , vWu206_LSu0SBLOPORT
     , vWu207_RSu1MODURICE
     , vWu208_RSu1MODURIFL
     , vWu209_CTu1POMPECEN
     , vWu210_EVu2CIRCMOPR
     , vWu211_EVu2CIRCVAPR
     , vWu212_EVu2PRESCIRC
     , vWu213_RISERVA
     , vWu214_RISERVA
     , vWu215_RISERVA
    }

    public static string[] wu2Descr =
      {
         "circol.acqua raffredd.condensatore 1°st.frigor. "
        ,"mandata fluido freddo alla cella da 1°st.frigor."
        ,"svuotamento fluido freddo dalla cella           "
        ,"mandata fluido freddo al condens.da 2°stadio    "
        ,"mandata gas alla cella da 2°stadio frigor.      "
        ,"mandata gas evaporat.gruppo frigor.1°stadio     "
        ,"ev ventilazione esterna                         "
        ,"ev circolaz.H2o raffr.fluido circolante         "
        ,"telerutt. comando centralina oleo              "
        ,"ev circolaz. monte prova                        "
        ,"ev circolaz. valle prova                        "
        ,"ev pressurizzazione circuito prova  riserva     "
        ,"  riserva                                       "
        ,"  riserva                                       "
        ,"  riserva                                       "
        ,"  riserva                                       "
      };

    public static string[] wu2Nick =
{
         "vWu200_EVu0CONDFRI2 "
        ,"vWu201_EVu0LIQUCELL "
        ,"vWu202_EVu0LIQUFRI1 "
        ,"vWu203_LSu0_RIPOSO_ "
        ,"vWu204_LSu0AUTOMATI "
        ,"vWu205_LSu0ANOMALIA "
        ,"vWu206_LSu0SBLOPORT "
        ,"vWu207_RSu1MODURICE "
        ,"vWu208_RSu1MODURIFL "
        ,"vWu209_CTu1POMPECEN "
        ,"vWu210_EVu2CIRCMOPR "
        ,"vWu211_EVu2CIRCVAPR "
        ,"vWu212_EVu2PRESCIRC "
        ,"vWu213_RISERVA      "
        ,"vWu214_RISERVA      "
        ,"vWu215_RISERVA      "
      };


    public static string[] wu2Plc =
  {
         "vWu200_"
        ,"vWu201_"
        ,"vWu202_"
        ,"vWu203_"
        ,"vWu204_"
        ,"vWu205_"
        ,"vWu206_"
        ,"vWu207_"
        ,"vWu208_"
        ,"vWu209_"
        ,"vWu210_"
        ,"vWu211_"
        ,"vWu212_"
        ,"vWu213_"
        ,"vWu214_"
        ,"vWu215_"
      };


    public static string[] wu2Comp =
  {
         " ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
      };



#endregion

#region Wu3
    public enum Wu3
    {
       vWu300_RISERVA
     , vWu301_RISERVA
     , vWu302_RISERVA
     , vWu303_RISERVA
     , vWu304_RISERVA
     , vWu305_RISERVA
     , vWu306_RISERVA
     , vWu307_RISERVA
     , vWu308_RISERVA
     , vWu309_RISERVA
     , vWu310_RISERVA
     , vWu311_RISERVA
     , vWu312_RISERVA
     , vWu313_RISERVA
     , vWu314_RISERVA
     , vWu315_RISERVA
    }

    public static string[] wu3Descr =
      {
         "  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
        ,"  riserva  "
      };

    public static string[] wu3Nick =
{
         "vWu300_RISERVA "
        ,"vWu301_RISERVA "
        ,"vWu302_RISERVA "
        ,"vWu303_RISERVA "
        ,"vWu304_RISERVA "
        ,"vWu305_RISERVA "
        ,"vWu306_RISERVA "
        ,"vWu307_RISERVA "
        ,"vWu308_RISERVA "
        ,"vWu309_RISERVA      "
        ,"vWu310_RISERVA      "
        ,"vWu311_RISERVA      "
        ,"vWu312_RISERVA      "
        ,"vWu313_RISERVA      "
        ,"vWu314_RISERVA      "
        ,"vWu315_RISERVA      "
      };


    public static string[] wu3Plc =
  {
         "vWu300_"
        ,"vWu301_"
        ,"vWu302_"
        ,"vWu303_"
        ,"vWu304_"
        ,"vWu305_"
        ,"vWu306_"
        ,"vWu307_"
        ,"vWu308_"
        ,"vWu309_"
        ,"vWu310_"
        ,"vWu311_"
        ,"vWu312_"
        ,"vWu313_"
        ,"vWu314_"
        ,"vWu315_"
      };


    public static string[] wu3Comp =
  {
         " ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ?????? "
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
        ," ??????"
      };



#endregion

#endregion


#region flag e comandi S7
    public enum S7flStat
    {
      u000_riempOk
     , u001_svuotaOk
     , u002_evalOk
     , u003_camRun

     , u004_i
     , u005_i
     , u006_i
     , u007_i

     , u008_i
     , u009_i
     , u010_i
     , u011_i

     , u012_x
     , u013_i
     , u014_i
     , u015_i
    }


    public static string[] S7flStDes =
    {
       "u000_RiempOk"
      ,"u001_svuotOk"
      ,"u002_eval_Ok"
      ,"u003_cammRun"

      ,"u004_"
      ,"u005_"
      ,"u006_"
      ,"u007_"

      ,"u008_"
      ,"u009_"
      ,"u010_"
      ,"u011_"

      ,"u012_"
      ,"u013_"
      ,"u014_"
      ,"u015_"
    };


    public enum S71
    {
      u000_oCmdEnabJog
     , u001_oCmdJogFwd
     , u002_oCmdJogRev
     , u003_oCmdReqRdy

     , u004_oCmdEnabPulse
     , u005_oCmdHomeEnab
     , u006_oCmdGrapPid
     , u007_oCmdGrapSpeed

     , u008_oCmdCamin
     , u009_oCmdRes9
     , u010_oCmdRes10
     , u011_oCmdRes11

     , u012_oCmdRes12
     , u013_oCmdRes13
     , u014_oCmdRes14
     , u015_oCmdPidEn
    }

    public static string[] S71Descr =
    {
       "u000_oCmdEnabJog"
      ,"u001_oCmdJogFwd"
      ,"u002_oCmdJogRev"
      ,"u003_oCmdReqRdy"

      ,"u004_oCmdEnabPulse"
      ,"u005_oCmdHomeEnab"
      ,"u006_oCmdGrapPid"
      ,"u007_oCmdGrapSpeed"

      ,"u008_oCmdCamin"
      ,"u009_oCmdRes9"
      ,"u010_oCmdRes10"
      ,"u011_oCmdRes11"

      ,"u012_oCmdRes12"
      ,"u013_oCmdRes13"
      ,"u014_oCmdRes14"
      ,"u015_oCmdPidEn"
    };


    public enum S72
    {
      u000_flPowerOn
     , u001_flMov0Done
     , u002_flHomeDone
     , u003_flHaltDone

     , u004_flInTorque
     , u005_fl0Res5
     , u006_fl0Res6
     , u007_fl0Res7

     , u008_fl0Res8
     , u009_fl0Res9
     , u010_fl0Res10
     , u011_fl0Res11

     , u012_fl0Res12
     , u013_fl0Res13
     , u014_fl0Res14
     , u015_fl0Res15
    }

    public static string[] S72Descr =
    {
       "u000_flPowerOn"
      ,"u001_flMov0Done"
      ,"u002_flHomeDone"
      ,"u003_flHaltDone"

      ,"u004_flInTorque"
      ,"u005_fl0Res5"
      ,"u006_fl0Res6"
      ,"u007_fl0Res7"

      ,"u008_fl0Res8"
      ,"u009_fl0Res9"
      ,"u010_fl0Res10"
      ,"u011_fl0Res11"

      ,"u012_fl0Res12"
      ,"u013_fl0Res13"
      ,"u014_fl0Res14"
      ,"u015_fl0Res15"
    };


    public enum S73
    {
      u000_fliLockJog
     , u001_flIntRes1
     , u002_flIntRes2
     , u003_flIntRes3

     , u004_flIntRes4
     , u005_flIntRes5
     , u006_flIntRes6
     , u007_flIntRes7

     , u008_flIntRes8
     , u009_flIntRes9
     , u010_flIntRes10
     , u011_flIntRes11

     , u012_flIntRes12
     , u013_flIntRes13
     , u014_flIntRes14
     , u015_flIntRes15
    }

    public static string[] S73Descr =
    {
       "u000_fliLockJog"
      ,"u001_flIntRes1"
      ,"u002_flIntRes2"
      ,"u003_flIntRes3"

      ,"u004_flIntRes4"
      ,"u005_flIntRes5"
      ,"u006_flIntRes6"
      ,"u007_flIntRes7"

      ,"u008_flIntRes8"
      ,"u009_flIntRes9"
      ,"u010_flIntRes10"
      ,"u011_flIntRes11"

      ,"u012_flIntRes12"
      ,"u013_flIntRes13"
      ,"u014_flIntRes14"
      ,"u015_flIntRes15"
    };

#endregion

#endregion
    
#endregion

#region allarmi
    public enum Wa00
    {
       SInTUTTO_OK
     , TEnPOMPMAND
     , KMnPOMPMAND
     , SNnPRESARIA
     , OPnV1070MAN
     , CLnV1070MAN
     , OPnV1100RIT
     , CLnV1100RIT
     , ALnSPARE008
     , ALnSPARE009
     , ALnSPARE010
     , ALnSPARE011
     , ALnSPARE012
     , ALnSPARE013
     , ALnSPARE014
     , ALnSPARE015
    }

    public static string[] wa0Descr =
  {
         "0.all. circuiti ausiliari inseriti "
        ,"0.all. termica pompa mandata "
        ,"0.all. readback pompa mandata "
        ,"0.all. mancanza aria compressa "
        ,"2.all. anomalia apertura valvola mandata "
        ,"0.all. anomalia chiusura valvola mandata "
        ,"0.all. anomalia apertura valvola ritorno "
        ,"1.all. anomalia apertura valvola ritorno "
        ,"0.all.                                   "
        ,"0.all.                                   "
        ,"0.all.                                   "
        ,"0.all.                                   "
        ,"0.all.                                   "
        ,"0.all.                                   "
        ,"0.all.                                   "
        ,"0.all.                                   "
      };

    public static string[] wa0Nick =
      {
         "SInTUTTO_OK"
        ,"TEnPOMPMAND"
        ,"KMnPOMPMAND"
        ,"SNnPRESARIA"
        ,"OPnV1070MAN"
        ,"CLnV1070MAN"
        ,"OPnV1100RIT"
        ,"CLnV1100RIT"
        ,"ALnSPARE008"
        ,"ALnSPARE009"
        ,"ALnSPARE010"
        ,"ALnSPARE011"
        ,"ALnSPARE012"
        ,"ALnSPARE013"
        ,"ALnSPARE014"
        ,"ALnSPARE015"
      };


    public static string[] wa0Plc =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public static string[] wa0Comp =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public enum Wa01
    {
       AL1_0_TEn0COMP2FRI
     , AL1_1_TEn0POMP1FRI
     , AL1_2_TEn0POMPCELL
     , AL1_3_TEn0POMPP1P2
     , AL1_4_TEn0POMP_P3_
     , AL1_5_TEn1POMP_P4_
     , AL1_6_TEn2MREGCIPR
     , AL1_7_TEn1VENTCELL
     , AL1_8_TEn0RISCCELL
     , AL1_9_SNn1FILTCECL
     , AL1_a_SNn1FISER1CL
     , AL1_b_SNn1FIVIBRCL
     , AL1_c_SNn1FIPILOCL
     , AL1_d_SNn0PROT_AUX
     , AL1_e_SNn0PROTFIEL
     , AL1_f_SNn0EMERRIPR
    }


    public static string[] wa1Descr =
  {
         "0.all. interv.prot.mot.compressore 2°st.gr.frigor."
        ,"0.all. interv.prot.mot.pompa raffr.vasca 1°st.frigor."
        ,"0.all. interv.prot.mot.pompa raffr.cella da 1° stadio"
        ,"1 all interv. prot.mot.pompe P1-P2"
        ,"0.all. interv.prot.motore pompa P3"
        ,"1.all. interv.prot.motore pompa P4"
        ,"2.all. interv.prot.mot.regol.corsa cilindro pressione"
        ,"1.all. interv.prot.motore ventola cella"
        ,"0.all. interv.prot.riscaldatore cella"
        ,"1.all. filtro principale centralina intasato"
        ,"1.all. filtro servizio cilindro 1 intasato"
        ,"1.all. filtro servizio vibratore intasato"
        ,"1.all. filtro servizio pilotaggio cil.1 intasato"
        ,"0.all. interv.prot.circuiti 24Vdc"
        ,"0.all. intervento protez.filtro elettrostatico"
        ,"0.all. emergenza ripristinata"
      };

    public static string[] wa1Nick =
      {
         "TEn0COMP2FRI"
        ,"TEn0POMP1FRI"
        ,"TEn0POMPCELL"
        ,"TEn0POMPP1P2"
        ,"TEn0POMP_P3_"
        ,"TEn1POMP_P4_"
        ,"TEn2MREGCIPR"
        ,"TEn1VENTCELL"
        ,"TEn0RISCCELL"
        ,"SNn1FILTCECL"
        ,"SNn1FISER1CL"
        ,"SNn1FIVIBRCL"
        ,"SNn1FIPILOCL"
        ,"SNn0PROT_AUX"
        ,"SNn0PROTFIEL"
        ,"SNn0EMERRIPR"
      };


    public static string[] wa1Plc =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public static string[] wa1Comp =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public enum Wa02
    {
       AL2_0_SLn0AUTOMATI
     , AL2_1_SNn1DRIVFLOK
     , AL2_2_PSn0LOPRFRI1
     , AL2_3_SQnSTEPUNDF 
     , AL2_4_SQnTESTLIVE 
     , AL2_5_
     , AL2_6_
     , AL2_7_
     , AL2_8_
     , AL2_9_
     , AL2_a_
     , AL2_b_
     , AL2_c_
     , AL2_d_
     , AL2_e_
     , AL2_f_
    }


    public static string[] wa2Descr =
  {
         "0.all. selettore comandi automatici"
        ,"1.all. nessuna anomalia inverter pompa circolaz."
        ,"0 all alta pressione primo stadio"
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
        ,"                                                "
      };

    public static string[] wa2Nick =
      {
         "SLn0AUTOMATI "
        ,"SNn1DRIVFLOK "
        ,"PSn0LOPRFRI1 "
        ,"SQnSTEPUNDF "
        ,"SQnTESTLIVE "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
        ," "
      };


    public static string[] wa2Plc =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public static string[] wa2Comp =
  {
         ""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
        ,""
      };


    public string[,] msgAll =
 {
   {
 "AL0.0 SInTUTTO_OK "
,"AL0.1 FCn0PORTNOCH"
,"AL0.2 TSn0RISCFLUI"
,"AL0.3 TSn0TEMPCAME"
,"AL0.4 LVn2FLUPROOK"
,"AL0.5 LSn0TRAFFLUI"
,"AL0.6 PSn0PRESARIA"
,"AL0.7 LVn1OLIOBASS"
,"AL0.8 PSn0HP_1FRIG"
,"AL0.9 TSn0LT_1FRIG"
,"AL0.a FLn0LQ_1FRIG"
,"AL0.b FLn0GQ_2FRIG"
,"AL0.c LVn0HG_1FRIG"
,"AL0.d PSn0HP_2FRIG"
,"AL0.e PSn0LP_2FRIG"
,"AL0.f TEn0COMP1FRI"
     },
   {
 "AL1.0 TEn0COMP2FRI"
,"AL1.1 TEn0POMP1FRI"
,"AL1.2 TEn0POMPCELL"
,"AL1.3 TEn0POMPP1P2"
,"AL1.4 TEn0POMP_P3_"
,"AL1.5 TEn1POMP_P4_"
,"AL1.6 TEn2MREGCIPR"
,"AL1.7 TEn1VENTCELL"
,"AL1.8 TEn0RISCCELL"
,"AL1.9 SNn1FILTCECL"
,"AL1.a SNn1FISER1CL"
,"AL1.b SNn1FIVIBRCL"
,"AL1.c SNn1FIPILOCL"
,"AL1.d SNn0PROT_AUX"
,"AL1.e SNn0PROTFIEL"
,"AL1.f SNn0EMERRIPR"
  },
   {
 "AL1.0 SLn0AUTOMATI"
,"AL1.1 SNn1DRIVFLOK"
,"AL1.2 PSn0LOPRFRI1"
,"AL1.3 SQnSTEPUNDF "
,"AL1.4 SQnTESTLIVE "
,"AL1.5 "
,"AL1.6 "
,"AL1.7 "
,"AL1.8 "
,"AL1.9 "
,"AL1.a "
,"AL1.b "
,"AL1.c "
,"AL1.d "
,"AL1.e "
,"AL1.f "
  }
};

#endregion

#region Fasi e Cicli
#region CicliPtr
    public enum ptrFaseFrigo
    {
      _00_Init                     = 00 ,
      _10_attesaStart              = 10 ,
      _20_avviamentoPompa          = 20 ,
      _30_attendeFlusso            = 30 ,
      _40_pronto_richiesta_freddo  = 40 ,
      _50_alimentazione_liquida    = 50 ,
      _60_funzione_Normale         = 60 ,
      _70_pump_down                = 70 ,
      _80_riposo_fermo             = 80 ,
      _90_pump_down                = 90 ,
      _1000_gestione_fault         = 1000,
      _1001_rientro_reset          = 1001,
    };

    
    public static string[] ptrFaseFrigoLbl =
    {
      "00 - Reset ciclo"
      ,"10 - Attesa comandi"
      ,"20 - Riempimento impianto"
      ,"30 - Caratterizzazione"
      ,"40 - Verifica prestazioni"
      ,"50 - Esecuzione passo prova"
      ,"60 - Svuotamento impianto"
      ,"100 - Fine"
    };

    public static Dictionary<int, string> faseFrigo = new Dictionary<int, string>(){
     {0  , "init: in teoria solo al power on plc				     "}
    ,{10 , "attesa richiesta marcia                          "}
    ,{20 , "avviamento pompa circolazione                    "}
    ,{30 , "attende flusso                                   "}
    ,{40 , "pronto alla marcia - attesa richiesta freddo     "}
    ,{50 , "Alimentazione liquida                            "}
    ,{60 , "Funzionamento normale                            "}
    ,{70 , "pump down                                        "}
    ,{80 , "riposo da fermo (antiripetizione)                "}
    ,{90 , "attesa arresto flusso                            "}
    ,{1000, "gestione fault                                  "}
    ,{1001, "rientro reset                                   "}
  };

    public static Dictionary<int, string> riscaldoCella = new Dictionary<int, string>(){
     {0  , "init: in teoria solo al power on plc				     "}
    ,{10 , "attesa richiesta marcia                          "}
    ,{20 , "                                                 "}
    ,{30 , "                                                 "}
    ,{40 , "pronto alla marcia - attesa richiesta caldo      "}
    ,{50 , "Regimazione ventilatore                          "}
    ,{60 , "Funzionamento normale                            "}
    ,{70 , "Spegnimento riscaldo                             "}
    ,{80 , "Arresto ventilatore                              "}
    ,{90 , "                                                 "}
    ,{1000, "gestione fault                                  "}
    ,{1001, "rientro reset                                   "}
  };

    public static Dictionary<int, string> raffreddamentoCella = new Dictionary<int, string>(){
     {0  , "init: in teoria solo al power on plc				     "}
    ,{10 , "attesa richiesta marcia                          "}
    ,{20 , "                    "}
    ,{30 , ""}
    ,{40 , "pronto alla marcia - attesa richiesta freddo     "}
    ,{50 , ""}
    ,{60 , ""}
    ,{70 , ""}
    ,{80 , ""}
    ,{90 , ""}
    ,{100, "Raffreddamento a glicole"}
    ,{110, "Da glicole a freon, svuotamento a tempo"}
    ,{200, "Raffreddamento freon, espansione diretta"}
    ,{400, "Conclusione fase raffreddamento"}
    ,{1000, "gestione fault                                  "}
    ,{1001, "rientro reset                                   "}
  };

    //  public static Dictionary<int, string> faseFrigo = new Dictionary<int, string>(){
    //   {0  , "init: in teoria solo al power on plc				     "}
    //  ,{10 , "attesa richiesta marcia                          "}
    //  ,{20 , "avviamento pompa circolazione                    "}
    //  ,{30 , "attende flusso                                   "}
    //  ,{40 , "pronto alla marcia - attesa richiesta freddo     "}
    //  ,{50 , "Alimentazione liquida                            "}
    //  ,{60 , "Funzionamento normale                            "}
    //  ,{70 , "pump down                                        "}
    //  ,{80 , "riposo da fermo (antiripetizione)                "}
    //  ,{90 , "attesa arresto flusso                            "}
    //  ,{1000, "gestione fault                                  "}
    //  ,{1001, "rientro reset                                   "}
    //};




#endregion
#endregion
   

#endif
  }
}
