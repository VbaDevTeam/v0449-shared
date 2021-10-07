using System.Collections.Generic;

namespace v0449_shared
{
  public class DEF
  {
    #region def
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
     , vWu209_RISERVA
     , vWu210_RISERVA
     , vWu211_RISERVA
     , vWu212_RISERVA
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
        ,"  riserva                                       "
        ,"  riserva                                       "
        ,"  riserva                                       "
        ,"  riserva                                       "
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
        ,"vWu209_RISERVA      "
        ,"vWu210_RISERVA      "
        ,"vWu211_RISERVA      "
        ,"vWu212_RISERVA      "
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

    public enum ptrFaseGenRepo
    {
      _00_Init = 00,
      _10_InWorking = 10,
      _20_avviamentoPompa = 20,
      _30_attendeFlusso = 30,
      _40_pronto_richiesta_freddo = 40,
      _50_alimentazione_liquida = 50,
      _60_funzione_Normale = 60,
      _70_pump_down = 70,
      _80_riposo_fermo = 80,
      _90_pump_down = 90,
      _1000_NoRulesFUser = 1000,
      _1010_NoHeaderOnDb = 1010,
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


    #endregion
    #endregion
  }
}
