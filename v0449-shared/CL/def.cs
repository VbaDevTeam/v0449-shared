using System.Collections.Generic;

namespace v0449_shared
{
  public class DEF
  {

#if v0449
    #region def


    #region Canali analogici

    #region AI chNames Siemens


    public enum chNoS7ai
    {
      //SM1231 AI4 x HF, la seconda, Ai
        
        AIpFLUIPROV         //PRESS		  pressione fluido circolante
      , AItFLUIPROV         //TEMP      temperatura fluido circolante
      , AItRISCFLPR         //TEMP      temperat.riscaldatore fluido circolante
      , AItCELLCLIM         //TEMP      temperatura cella climatica
      , AItVASCFRI1         //TEMP      temperatura vasca 1°stadio
      , AIcESCUVIBR         //VOLT      escursione vibratore
      , AIaACCEVIBR         //VOLT      accelerazione vibratore
      , AItCENTOLIO         //TEMP      temperatura centralina olio
      , AIpHIPRFRIG1        //PRESS     alta pressione frigo 1
      , AIpLOPRFRIG1        //PRESS     bassa pressione frigo 1
      , AIpHIPRFRIG2        //PRESS     alta pressione frigo 2
      , AIpLOPRFRIG2        //PRESS     bassa pressione frigo 2
      , AItHIPRFRIG1        //TEMP      temperatura liquido frigo 1
      , AItLOPRFRIG1        //TEMP      temperatura vapore frigo 1
      , AItHIPRFRIG2        //TEMP      temperatura liquido frigo 2
      , AItLOPRFRIG2        //TEMP      temperatura vapore frigo 2
      , QC1                 //PORT      portata fluido circuito 1 
      , QC2                 //PORT      portata fluido circuito 2 

    }

    public static string[] aiChNamesS7 =
      {
        "AIpFLUIPROV "        //PRESS		  pressione fluido circolante
      , "AItFLUIPROV "        //TEMP      temperatura fluido circolante
      , "AItRISCFLPR "        //TEMP      temperat.riscaldatore fluido circolante
      , "AItCELLCLIM "        //TEMP      temperatura cella climatica
      , "AItVASCFRI1 "        //TEMP      temperatura vasca 1°stadio
      , "AIcESCUVIBR "        //VOLT      escursione vibratore
      , "AIaACCEVIBR "        //VOLT      accelerazione vibratore
      , "AItCENTOLIO "        //TEMP      temperatura centralina olio
      , "AIpHIPRFRIG1"        //PRESS     alta pressione frigo 1
      , "AIpLOPRFRIG1"        //PRESS     bassa pressione frigo 1
      , "AIpHIPRFRIG2"        //PRESS     alta pressione frigo 2
      , "AIpLOPRFRIG2"        //PRESS     bassa pressione frigo 2
      , "AItHIPRFRIG1"        //TEMP      temperatura liquido frigo 1
      , "AItLOPRFRIG1"        //TEMP      temperatura vapore frigo 1
      , "AItHIPRFRIG2"        //TEMP      temperatura liquido frigo 2
      , "AItLOPRFRIG2"        //TEMP      temperatura vapore frigo 2
      , "QC1"                 //PORT      portata fluido circuito 1 
      , "QC2"                 //PORT      portata fluido circuito 2 

      };

    #endregion

    #region AI label short Siemens

    public static string[] aiLabelShortS7 =
      {
        " pressione fluido circolante               "
      , " temperatura fluido circolante             "
      , " temperat.riscaldatore fluido circolante   "
      , " temperatura cella climatica               "
      , " temperatura vasca 1°stadio                "
      , " escursione vibratore                      "
      , " accelerazione vibratore                   "
      , " temperatura centralina olio               "
      , " alta pressione frigo 1                    "
      , " bassa pressione frigo 1                   "
      , " alta pressione frigo 2                    "
      , " bassa pressione frigo 2                   "
      , " temperatura liquido frigo 1               "
      , " temperatura vapore frigo 1                "
      , " temperatura liquido frigo 2               "
      , " temperatura vapore frigo 2                "
      , " portata C1               "
      , " portata C2               "

      };

    #endregion

    #region AI label Long Siemens

    public static string[] aiLabelLongS7 =
      {
        " pressione fluido circolante               "
      , " temperatura fluido circolante             "
      , " temperat.riscaldatore fluido circolante   "
      , " temperatura cella climatica               "
      , " temperatura vasca 1°stadio                "
      , " escursione vibratore                      "
      , " accelerazione vibratore                   "
      , " temperatura centralina olio               "
      , " alta pressione frigo 1                    "
      , " bassa pressione frigo 1                   "
      , " alta pressione frigo 2                    "
      , " bassa pressione frigo 2                   "
      , " temperatura liquido frigo 1               "
      , " temperatura vapore frigo 1                "
      , " temperatura liquido frigo 2               "
      , " temperatura vapore frigo 2                "
      , " portata C1               "
      , " portata C2               "
    };
    #endregion

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

#region AI chNames Siemens


    public enum chNoS7ai
    {
      //SM1231 AI4 x HF, la seconda, Ai
        
        aiPT1630monte       //PRESS		  pressione fluido circolante
      , aiPT1650valle       //TEMP      temperatura fluido circolante
      , aiPT2630monte       //TEMP      temperat.riscaldatore fluido circolante
      , aiPT2650valle       //TEMP      temperatura cella climatica
      , ai4vRiserva         //TEMP      temperatura vasca 1°stadio
      , ai5vRiserva         //VOLT      escursione vibratore
      , aiTT1170risc        //VOLT      accelerazione vibratore
      , aiTT2170risc        //TEMP      temperatura centralina olio
      , TT1610monte         //PRESS     alta pressione frigo 1
      , TT1680valle         //PRESS     bassa pressione frigo 1
      , TT1120refr          //PRESS     alta pressione frigo 2
      , TT1175risc          //PRESS     bassa pressione frigo 2
      , TT2610monte         //TEMP      temperatura liquido frigo 1
      , TT2680valle         //TEMP      temperatura vapore frigo 1
      , TT2120refr          //TEMP      temperatura liquido frigo 2
      , TT2175risc          //TEMP      temperatura vapore frigo 2
      , QC1                 //PORT      portata fluido circuito 1 
      , QC2                 //PORT      portata fluido circuito 2 
    }

    public static string[] aiChNamesS7 =
      {
        "aiPT1630monte"        //PRESS		  pressione fluido circolante
      , "aiPT1650valle"        //TEMP      temperatura fluido circolante
      , "aiPT2630monte"        //TEMP      temperat.riscaldatore fluido circolante
      , "aiPT2650valle"        //TEMP      temperatura cella climatica
      , "ai4vRiserva  "        //TEMP      temperatura vasca 1°stadio
      , "ai5vRiserva  "        //VOLT      escursione vibratore
      , "aiTT1170risc "        //VOLT      accelerazione vibratore
      , "aiTT2170risc "        //TEMP      temperatura centralina olio
      , "TT1610monte  "        //PRESS     alta pressione frigo 1
      , "TT1680valle  "        //PRESS     bassa pressione frigo 1
      , "TT1120refr   "        //PRESS     alta pressione frigo 2
      , "TT1175risc   "        //PRESS     bassa pressione frigo 2
      , "TT2610monte  "        //TEMP      temperatura liquido frigo 1
      , "TT2680valle  "        //TEMP      temperatura vapore frigo 1
      , "TT2120refr   "        //TEMP      temperatura liquido frigo 2
      , "TT2175risc   "        //TEMP      temperatura vapore frigo 2
      , "QC1"
      , "QC2"


      };

#endregion

#region AI label short Siemens

    public static string[] aiLabelShortS7 =
      {
        " pressione monte UUT C1          "
      , " pressione valle UUT C1          "
      , " pressione monte UUT C2          "
      , " pressione valle UUT C2          "
      , " riserva                         "
      , " riserva                         "
      , " temperatura riscaldatore 1 C1   "
      , " temperatura riscaldatore 1 C2   "
      , " temperatura monte C1            "
      , " temperatura valle C1            "
      , " temperatura refrigerata C1      "
      , " temperatura riscaldatore 2 C1   "
      , " temperatura monte C2            "
      , " temperatura valle C2            "
      , " temperatura refrigerata C2      "
      , " temperatura riscaldatore 2 C2   "
      , " portata fluido circuito 1       "
      , " portata fluido circuito 2       "

      };

#endregion

#region AI label Long Siemens

    public static string[] aiLabelLongS7 =
      {
        " pressione monte UUT C1          "
      , " pressione valle UUT C1          "
      , " pressione monte UUT C2          "
      , " pressione valle UUT C2          "
      , " riserva                         "
      , " riserva                         "
      , " temperatura riscaldatore 1 C1   "
      , " temperatura riscaldatore 1 C2   "
      , " temperatura monte C1            "
      , " temperatura valle C1            "
      , " temperatura refrigerata C1      "
      , " temperatura riscaldatore 2 C1   "
      , " temperatura monte C2            "
      , " temperatura valle C2            "
      , " temperatura refrigerata C2      "
      , " temperatura riscaldatore 2 C2   "
      , " portata fluido circuito 1       "
      , " portata fluido circuito 2       "
    };
#endregion

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
       iFT1410_port_C_1_
     , iFT2410_port_C_2_
     , i_0_2_Pu_e_Avanti
     , i03_Pu_e_Indietro
     , i0_4_R_i_s_e_r_ve
     , i0_5_R_i_s_e_r_va
     , i0_6_R_i_s_e_r_ve
     , i0_7_R_i_s_e_r_va
     , iPS310__pres_Aria
     , iRstA_l_l_a_r_m_i
     , iSlM_a_r_c_i_a_C1
     , iSlM_a_r_c_i_a_C2
     , SIeTUTTO_C_1_O_K_
     , SIeTUTTO_C_2_O_K_
     , inesistente1_6
     , inesistente1_7
    }

    public static string[] we0Descr =
      {
         "Impulsi misuratore portata C1"
        ,"Impulsi misuratore portata C2"
        ,"Pulsante avanti              "
        ,"Pulsante indietro            "
        ,"i0_4Riserve                  "
        ,"i0_5Riserva                  "
        ,"i0_6Riserve                  "
        ,"i0_7Riserva                  "
        ,"Pressostato generale aria    "
        ,"Reset allarmi                "
        ,"Selettore marcia C1          "
        ,"Selettore marcia C2          "
        ,"Comandi inseriti C1          "
        ,"Comandi inseriti C2          "
        ,"                             "
        ,"                             "
      };

    public static string[] we0Nick =
      {
         "iFT1410_port_C_1_"
        ,"iFT2410_port_C_2_"
        ,"i_0_2_Pu_e_Avanti"
        ,"i03_Pu_e_Indietro"
        ,"i0_4_R_i_s_e_r_ve"
        ,"i0_5_R_i_s_e_r_va"
        ,"i0_6_R_i_s_e_r_ve"
        ,"i0_7_R_i_s_e_r_va"
        ,"iPS310__pres_Aria"
        ,"iRstA_l_l_a_r_m_i"
        ,"iSlM_a_r_c_i_a_C1"
        ,"iSlM_a_r_c_i_a_C2"
        ,"SIeTUTTO_C_1_O_K_"
        ,"SIeTUTTO_C_2_O_K_"
        ,""
        ,""
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
       iRBK1220_pompAlim
     , iRBK1130_pompRefr
     , iRBK1160_riscFlui
     , iRBK1400_pompCirc
     , iLHH1470_lvAlAlto
     , iLVH1470_lvWaAlto
     , iLVL1470_lvWaBass
     , iLLL1470_lvAlBass
     , iRBK2220_pompAlim
     , iRBK2130_pompRefr
     , iRBK2160_riscFlui
     , iRBK2400_pompCirc
     , iLHH2470_lvAlAlto
     , iLVH2470_lvWaAlto
     , iLVL2470_lvWaBass
     , iLLL2470_lvAlBass
    }

    public static string[] we1Descr =
      {
         "Readback pompa alimento C1      "
        ,"Readback pompa refrigerante C1  "
        ,"Readback riscaldatore fluido C1 "
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
      };

    public static string[] we1Nick =
  {
         "iRBK1220_pompAlim"
        ,"iRBK1130_pompRefr"
        ,"iRBK1160_riscFlui"
        ,"iRBK1400_pompCirc"
        ,"iLHH1470_lvAlAlto"
        ,"iLVH1470_lvWaAlto"
        ,"iLVL1470_lvWaBass"
        ,"iLLL1470_lvAlBass"
        ,"iRBK2220_pompAlim"
        ,"iRBK2130_pompRefr"
        ,"iRBK2160_riscFlui"
        ,"iRBK2400_pompCirc"
        ,"iLHH2470_lvAlAlto"
        ,"iLVH2470_lvWaAlto"
        ,"iLVL2470_lvWaBass"
        ,"iLLL2470_lvAlBass"
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
       vWu000_q0_0Riserva
     , vWu001_q0_1Riserva
     , vWu002_q0_2Riserva
     , vWu003_q0_3Riserva
     , vWu004_q0_4Riserva
     , vWu005_q0_5Riserva
     , vWu006_q0_6Riserva
     , vWu007_q0_7Riserva
     , vWu008_uLampAllarme
     , vWu009_uLampRegolare
     , vWu010_
     , vWu011_
     , vWu012_
     , vWu013_
     , vWu014_
     , vWu015_
    }

    public static string[] wu0Descr =
      {
         "vWu000_0.                                     "
        ,"vWu001_0.                                     "
        ,"vWu002_0.                                     "
        ,"vWu003_0.                                     "
        ,"vWu004_0.                                     "
        ,"vWu005_0.                                     "
        ,"vWu006_0.                                     "
        ,"vWu007_0.Lampada segnalazione anomalia        "                                     
        ,"vWu008_1.Lampada segnalazione funz. regolare  "                                     
        ,"vWu009_0.                                     "
        ,"vWu010_0.                                     "
        ,"vWu011_1.                                     "
        ,"vWu012_2.                                     "
        ,"vWu013_2.                                     "
        ,"vWu014_2.                                     "
        ,"vWu015_0.                                     "

      };

    public static string[] wu0Nick =
      {
         "vWu000_q0_0Riserva      "
        ,"vWu001_q0_1Riserva      "
        ,"vWu002_q0_2Riserva      "
        ,"vWu003_q0_3Riserva      "
        ,"vWu004_q0_4Riserva      "
        ,"vWu005_q0_5Riserva      "
        ,"vWu006_q0_6Riserva      "
        ,"vWu007_q0_7Riserva      "
        ,"vWu008_uLampAllarme     "
        ,"vWu009_uLampRegolare    "
        ,"vWu010_                 "
        ,"vWu011_                 "
        ,"vWu012_                 "
        ,"vWu013_                 "
        ,"vWu014_                 "
        ,"vWu015_                 "
      };


    public static string[] wu0Plc =
  {
         "vWu000q0_0Riserva      "
        ,"vWu001q0_1Riserva      "
        ,"vWu002q0_2Riserva      "
        ,"vWu003q0_3Riserva      "
        ,"vWu004q0_4Riserva      "
        ,"vWu005q0_5Riserva      "
        ,"vWu006q0_6Riserva      "
        ,"vWu007q0_7Riserva      "
        ,"vWu008uLampAllarme     "
        ,"vWu009uLampRegolare    "
        ,"vWu010                 "
        ,"vWu011                 "
        ,"vWu012                 "
        ,"vWu013                 "
        ,"vWu014                 "
        ,"vWu015                 "
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
       vWu100_uKM1220_pompalim	
     , vWu101_uKM1130_pomprefr	
     , vWu102_uKM1160_riscflui	
     , vWu103_uKM1400_pompcirc	
     , vWu104_q2_4Riserva	     
     , vWu105_q2_5Riserva	     
     , vWu106_q2_6Riserva	     
     , vWu107_q2_7Riserva	     
     , vWu108_uYV1230__alimScar
     , vWu109_uYV1420__mandProv
     , vWu110_uYV1430__ritoProv
     , vWu111_uYV1440__scarLive
     , vWu112_uYV1330A_aumePres
     , vWu113_uYV1330B_dimiPres
     , vWu114_uRST1160_moduRisc
     , vWu115_uEN1400__abilCirc
    }

    public static string[] wu1Descr =
      {
         "vWu100_0.Potenza pompa alimento C1         "
        ,"vWu101_0.Potenza pompa refrigerante C1     "
        ,"vWu102_0.Potenza riscaldatore C1           "
        ,"vWu103_1.Potenza pompa circolazione C1     "
        ,"vWu104_1.                                  "
        ,"vWu105_1.                                  "
        ,"vWu106_1.                                  "
        ,"vWu107_1.                                  "
        ,"vWu108_1.Valvola alimento/scarico C1       "
        ,"vWu109_1.Valvola mandata prova C1          "
        ,"vWu110_1.Valvola ritorno prova C1          "
        ,"vWu111_0.Valvola scarico press./livello C1 "
        ,"vWu112_0.Valvola pneum. aumento P C1       "
        ,"vWu113_0.Valvola pneum. diminuzione P C1   "
        ,"vWu114_0.Rel� statico riscaldatore C1      "
        ,"vWu115_0.Consenso marcia circolazione C1   "
      };

    public static string[] wu1Nick =
  {
         "vWu100_uKM1220_pompalim	"
        ,"vWu101_uKM1130_pomprefr	"
        ,"vWu102_uKM1160_riscflui	"
        ,"vWu103_uKM1400_pompcirc	"
        ,"vWu104_q2_4Riserva	    " 
        ,"vWu105_q2_5Riserva	    " 
        ,"vWu106_q2_6Riserva	    " 
        ,"vWu107_q2_7Riserva	    " 
        ,"vWu108_uYV1230__alimScar"
        ,"vWu109_uYV1420__mandProv"
        ,"vWu110_uYV1430__ritoProv"
        ,"vWu111_uYV1440__scarLive"
        ,"vWu112_uYV1330A_aumePres"
        ,"vWu113_uYV1330B_dimiPres"
        ,"vWu114_uRST1160_moduRisc"
        ,"vWu115_uEN1400__abilCirc"
      };


    public static string[] wu1Plc =
  {
         "vWu100uKM1220_pompalim	"
        ,"vWu101uKM1130_pomprefr	"
        ,"vWu102uKM1160_riscflui	"
        ,"vWu103uKM1400_pompcirc	"
        ,"vWu104q2_4Riserva	      "
        ,"vWu105q2_5Riserva	      "
        ,"vWu106q2_6Riserva	      "
        ,"vWu107q2_7Riserva	      "
        ,"vWu108uYV1230__alimScar "
        ,"vWu109uYV1420__mandProv "
        ,"vWu110uYV1430__ritoProv "
        ,"vWu111uYV1440__scarLive "
        ,"vWu112uYV1330A_aumePres "
        ,"vWu113uYV1330B_dimiPres "
        ,"vWu114uRST1160_moduRisc "
        ,"vWu115uEN1400__abilCirc "
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
       uKM2220_pompalim	
     , uKM2130_pomprefr	
     , uKM2160_riscflui	
     , uKM2400_pompcirc	
     , q4_4Riserva	      
     , q4_5Riserva	      
     , q4_6Riserva	      
     , q4_7Riserva	      
     , uYV2230__alimScar	
     , uYV2420__mandProv	
     , uYV2430__ritoProv	
     , uYV2440__scarLive	
     , uYV2330A_aumePres	
     , uYV2330B_dimiPres	
     , uRST2160_moduRisc	
     , uEN2400__abilCirc	
    }

    public static string[] wu2Descr =
      {
         "Potenza pompa alimento C2         "
        ,"Potenza pompa refrigerante C2     "
        ,"Potenza riscaldatore C2           "
        ,"Potenza pompa circolazione C2     "
        ,"                                  "
        ,"                                  "
        ,"                                  "
        ,"                                  "
        ,"Valvola alimento/scarico C2       "
        ,"Valvola mandata prova C2          "
        ,"Valvola ritorno prova C2          "
        ,"Valvola scarico press./livello C2 "
        ,"Valvola pneum. aumento P C2       "
        ,"Valvola pneum. diminuzione P C2   "
        ,"Rel� statico riscaldatore C2      "
        ,"Consenso marcia circolazione C2   "
      };

    public static string[] wu2Nick =
{
         "vWu200_uKM2220_pompalim	"
        ,"vWu201_uKM2130_pomprefr	"
        ,"vWu202_uKM2160_riscflui	"
        ,"vWu203_uKM2400_pompcirc	"
        ,"vWu204_q4_4Riserva	    "  
        ,"vWu205_q4_5Riserva	    "  
        ,"vWu206_q4_6Riserva	    "  
        ,"vWu207_q4_7Riserva	    "  
        ,"vWu208_uYV2230__alimScar"	
        ,"vWu209_uYV2420__mandProv"	
        ,"vWu210_uYV2430__ritoProv"	
        ,"vWu211_uYV2440__scarLive"	
        ,"vWu212_uYV2330A_aumePres"	
        ,"vWu213_uYV2330B_dimiPres"	
        ,"vWu214_uRST2160_moduRisc"	
        ,"vWu215_uEN2400__abilCirc"	
      };


    public static string[] wu2Plc =
  {
         "vWu200_uKM2220_pompalim	"
        ,"vWu201_uKM2130_pomprefr	"
        ,"vWu202_uKM2160_riscflui	"
        ,"vWu203_uKM2400_pompcirc	"
        ,"vWu204_q4_4Riserva	    "  
        ,"vWu205_q4_5Riserva	    "  
        ,"vWu206_q4_6Riserva	    "  
        ,"vWu207_q4_7Riserva	    "  
        ,"vWu208_uYV2230__alimScar"	
        ,"vWu209_uYV2420__mandProv"	
        ,"vWu210_uYV2430__ritoProv"	
        ,"vWu211_uYV2440__scarLive"	
        ,"vWu212_uYV2330A_aumePres"	
        ,"vWu213_uYV2330B_dimiPres"	
        ,"vWu214_uRST2160_moduRisc"	
        ,"vWu215_uEN2400__abilCirc"	
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

#elif v0387

#region def

#region Canali analogici

#region AI1

    public enum chNoS7ai
    {
      //SM1231 AI4 x HF, la seconda, Ai
        
        AItT210CIRC 	//TEMP		  temperatura circolazione fluido
      , AItT280MAND 	//TEMP			temperatura ingresso UUT
      , AItT310RETU 	//TEMP			temperatura uscita UUT
      , AItT520INSE 	//TEMP			temperatura circuito intermedio
      , AItTCellaSD		//TEMP			temperatura cella 
      , AItRiserva5		//NULL			riserva
      , AItTSIC2101 	//TEMP			temperatura sicurezza riscaldatore 1
      , AItTSIC2102 	//TEMP			temperatura sicurezza riscaldatore 2
      , AIpP240SIRI 	//PRESS			pressione uscita siringa
      , AIpP290MONT 	//PRESS			pressione ingresso UUT
      , AIpP300VALL 	//PRESS			pressione uscita UUT
      , AIpPXXXSCOP		//NULL			riserva
      , AIqPORTPROV 	//PORT			portata fluido prova
      , AIqSECOSALT		//NULL			riserva
      , AIqSIRINGA		//NULL			riserva
      , AIqPRIMSALT		//NULL			riserva					
      , AIqMAINRAFF		//NULL			riserva
      , VPoRAFFMAIN 	//VOLT?			posizione virtuale valvola raffreddamento
      , VPoRAFFINTE 	//VOLT?			posizione virtuale valvola circ. intermedio
      , MPoALIMENTO 	//VOLT?			velocità virtuale pompa alimento
      , MPoCIRCPROV 	//VOLT?			velocità virtuale pompa circolazione
      , MPoRAFFINTE 	//VOLT?			velocità virtuale pompa circ. intermedio

    }

    public static string[] aiChNamesS7 =
      {
        "AItT210CIRC"    //TEMP		  temperatura circolazione fluido
      , "AItT280MAND"    //TEMP	    temperatura ingresso UUT
      , "AItT310RETU"    //TEMP	    temperatura uscita UUT
      , "AItT520INSE"    //TEMP	    temperatura circuito intermedio
      , "AItTCellaSD"    //TEMP			temperatura cella 
      , "AItRiserva5"    //NULL	    riserva
      , "AItTSIC2101"    //TEMP	    temperatura sicurezza riscaldatore 1
      , "AItTSIC2102"    //TEMP	    temperatura sicurezza riscaldatore 2
      , "AIpP240SIRI"    //PRESS	  pressione uscita siringa
      , "AIpP290MONT"    //PRESS	  pressione ingresso UUT
      , "AIpP300VALL"    //PRESS	  pressione uscita UUT
      , "AIpPXXXSCOP"    //NULL	    riserva
      , "AIqPORTPROV"    //PORT	    portata fluido prova
      , "AIqSECOSALT"    //NULL	    riserva
      , "AIqSIRINGA"     //NULL	    riserva
      , "AIqPRIMSALT"    //NULL	    riserva					
      , "AIqMAINRAFF"    //NULL	    riserva
      , "VPoRAFFMAIN"    //VOLT?	  posizione virtuale valvola raffreddamento
      , "VPoRAFFINTE" 	//VOLT?			posizione virtuale valvola circ. intermedio"
      , "MPoALIMENTO" 	//VOLT?			velocità virtuale pompa alimento"
      , "MPoCIRCPROV" 	//VOLT?			velocità virtuale pompa circolazione"
      , "MPoRAFFINTE" 	//VOLT?			velocità virtuale pompa circ. intermedio"

      };


#region AI1 label short Siemens

    public static string[] aiLabelShortS7 =
      {
        " temperatura circolazione fluido            "
      , " temperatura ingresso UUT                   "
      , " temperatura uscita UUT                     "
      , " temperatura circuito intermedio            "
      , " riserva                                    "
      , " riserva                                    "
      , " temperatura sicurezza riscaldatore 1       "
      , " temperatura sicurezza riscaldatore 2       "
      , " pressione uscita siringa                   "
      , " pressione ingresso UUT                     "
      , " pressione uscita UUT                       "
      , " riserva                                    "
      , " portata fluido prova                       "
      , " riserva                                    "
      , " riserva                                    "
      , " riserva					                           "
      , " riserva                                    "
      , " posizione virtuale valvola raffreddamento  "
      , " posizione virtuale valvola circ. intermedio  "
      , " velocità virtuale pompa alimento  "
      , " velocità virtuale pompa circolazione  "
      , " velocità virtuale pompa circ. intermedio  "

      };

#endregion

#region AI1 label Long Siemens

    public static string[] aiLabelLongS7 =
      {
        " temperatura circolazione fluido            "
      , " temperatura ingresso UUT                   "
      , " temperatura uscita UUT                     "
      , " temperatura circuito intermedio            "
      , " riserva                                    "
      , " riserva                                    "
      , " temperatura sicurezza riscaldatore 1       "
      , " temperatura sicurezza riscaldatore 2       "
      , " pressione uscita siringa                   "
      , " pressione ingresso UUT                     "
      , " pressione uscita UUT                       "
      , " riserva                                    "
      , " portata fluido prova                       "
      , " riserva                                    "
      , " riserva                                    "
      , " riserva					                           "
      , " riserva                                    "
      , " posizione virtuale valvola raffreddamento  "
      , " posizione virtuale valvola circ. intermedio  "
      , " velocità virtuale pompa alimento  "
      , " velocità virtuale pompa circolazione  "
      , " velocità virtuale pompa circ. intermedio  "
    };
#endregion
#endregion
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

#elif v0449_B
#region def


#region Canali analogici

#region AI chNames Siemens


    public enum chNoS7ai
    {
      //SM1231 AI4 x HF, la seconda, Ai
        
        AIpFLUIPROV         //PRESS		  pressione fluido circolante
      , AItFLUIPROV         //TEMP      temperatura fluido circolante
      , AItRISCFLPR         //TEMP      temperat.riscaldatore fluido circolante
      , AItCELLCLIM         //TEMP      temperatura cella climatica
      , AItVASCFRI1         //TEMP      temperatura vasca 1°stadio
      , AIcESCUVIBR         //VOLT      escursione vibratore
      , AIaACCEVIBR         //VOLT      accelerazione vibratore
      , AItCENTOLIO         //TEMP      temperatura centralina olio
      , AIpHIPRFRIG1        //PRESS     alta pressione frigo 1
      , AIpLOPRFRIG1        //PRESS     bassa pressione frigo 1
      , AIpHIPRFRIG2        //PRESS     alta pressione frigo 2
      , AIpLOPRFRIG2        //PRESS     bassa pressione frigo 2
      , AItHIPRFRIG1        //TEMP      temperatura liquido frigo 1
      , AItLOPRFRIG1        //TEMP      temperatura vapore frigo 1
      , AItHIPRFRIG2        //TEMP      temperatura liquido frigo 2
      , AItLOPRFRIG2        //TEMP      temperatura vapore frigo 2
      , QC1                 //PORT      portata fluido circuito 1 
      , QC2                 //PORT      portata fluido circuito 2 

    }

    public static string[] aiChNamesS7 =
      {
        "AIpFLUIPROV "        //PRESS		  pressione fluido circolante
      , "AItFLUIPROV "        //TEMP      temperatura fluido circolante
      , "AItRISCFLPR "        //TEMP      temperat.riscaldatore fluido circolante
      , "AItCELLCLIM "        //TEMP      temperatura cella climatica
      , "AItVASCFRI1 "        //TEMP      temperatura vasca 1°stadio
      , "AIcESCUVIBR "        //VOLT      escursione vibratore
      , "AIaACCEVIBR "        //VOLT      accelerazione vibratore
      , "AItCENTOLIO "        //TEMP      temperatura centralina olio
      , "AIpHIPRFRIG1"        //PRESS     alta pressione frigo 1
      , "AIpLOPRFRIG1"        //PRESS     bassa pressione frigo 1
      , "AIpHIPRFRIG2"        //PRESS     alta pressione frigo 2
      , "AIpLOPRFRIG2"        //PRESS     bassa pressione frigo 2
      , "AItHIPRFRIG1"        //TEMP      temperatura liquido frigo 1
      , "AItLOPRFRIG1"        //TEMP      temperatura vapore frigo 1
      , "AItHIPRFRIG2"        //TEMP      temperatura liquido frigo 2
      , "AItLOPRFRIG2"        //TEMP      temperatura vapore frigo 2
      , "QC1"                 //PORT      portata fluido circuito 1 
      , "QC2"                 //PORT      portata fluido circuito 2 

      };

#endregion

#region AI label short Siemens

    public static string[] aiLabelShortS7 =
      {
        " pressione fluido circolante               "
      , " temperatura fluido circolante             "
      , " temperat.riscaldatore fluido circolante   "
      , " temperatura cella climatica               "
      , " temperatura vasca 1°stadio                "
      , " escursione vibratore                      "
      , " accelerazione vibratore                   "
      , " temperatura centralina olio               "
      , " alta pressione frigo 1                    "
      , " bassa pressione frigo 1                   "
      , " alta pressione frigo 2                    "
      , " bassa pressione frigo 2                   "
      , " temperatura liquido frigo 1               "
      , " temperatura vapore frigo 1                "
      , " temperatura liquido frigo 2               "
      , " temperatura vapore frigo 2                "
      , " portata C1               "
      , " portata C2               "

      };

#endregion

#region AI label Long Siemens

    public static string[] aiLabelLongS7 =
      {
        " pressione fluido circolante               "
      , " temperatura fluido circolante             "
      , " temperat.riscaldatore fluido circolante   "
      , " temperatura cella climatica               "
      , " temperatura vasca 1°stadio                "
      , " escursione vibratore                      "
      , " accelerazione vibratore                   "
      , " temperatura centralina olio               "
      , " alta pressione frigo 1                    "
      , " bassa pressione frigo 1                   "
      , " alta pressione frigo 2                    "
      , " bassa pressione frigo 2                   "
      , " temperatura liquido frigo 1               "
      , " temperatura vapore frigo 1                "
      , " temperatura liquido frigo 2               "
      , " temperatura vapore frigo 2                "
      , " portata C1               "
      , " portata C2               "
    };
#endregion

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
    

#endif






  }
}
