using System;
using System.Collections.Generic;
using System.Text;
using v0449_shared.CL.DEF;

namespace v0449_shared.CL.DEF.benches
{
  public class _0511dio
	{

		public wBitInt[] We= new wBitInt[]
		{
			new wBitInt((int)wBitInt.types.We, 0, "We0", "We0", new lBitInt[]
			{
				new lBitInt(0, "vWe000_TEeP1020MAN", "vWe000.Termica pompa mandata"),
				new lBitInt(1, "vWe001_KMeP1020MAN", "vWe001.Readback pompa mandata"),
				new lBitInt(2, "vWe002_SNePS510AIR", "vWe002.Pressostato pres. aria compr."),
				new lBitInt(3, "vWe003_SNeLV1kSERB", "vWe003.Livello serbatoio fluido"),
				new lBitInt(4, "vWe004_OPeV1100RIT", "vWe004.Valvola ritorno aperta"),
				new lBitInt(5, "vWe005_CLeV1100RIT", "vWe005.Valvola ritorno chiusa"),
				new lBitInt(6, "vWe006_OPeV1070MAN", "vWe006.Valvola mandata aperta"),
				new lBitInt(7, "vWe007_CLeV1070MAN", "vWe007.Valvola mandata chiusa"),
				new lBitInt(8, "vWe008_", "vWe008."),
				new lBitInt(9, "vWe009_", "vWe009."),
				new lBitInt(10, "vWe010_", "vWe010."),
				new lBitInt(11, "vWe011_", "vWe011."),
				new lBitInt(12, "vWe012_", "vWe012."),
				new lBitInt(13, "vWe013_", "vWe013."),
				new lBitInt(14, "vWe014_", "vWe014."),
				new lBitInt(15, "vWe015_", "vWe015.")
			}),


			new wBitInt((int)wBitInt.types.We, 1, "We1", "We1", new lBitInt[]
			{
				new lBitInt(0, "vWe100_PSe0HP_2FRIGex", "vWe100_Riserva"),
				new lBitInt(1, "vWe101_PSe0LP_2FRIGex", "vWe101_Riserva"),
				new lBitInt(2, "vWe102_FCe0VIBRPOSI", "vWe102_0.vibratore posizionato"),
				new lBitInt(3, "vWe103_FCe0VIBRSPIN", "vWe103_0.spina vibratore introdotta"),
				new lBitInt(4, "vWe104_SNe0VIBR_RUN", "vWe104_0.gruppo vibratore in marcia"),
				new lBitInt(5, "vWe105_TEe0COMP1FRI", "vWe105_0.interv.prot.mot.compressore 1°st.gr.frigor."),
				new lBitInt(6, "vWe106_TEe0COMP2FRI", "vWe106_0.interv.prot.mot.compressore 2°st.gr.frigor."),
				new lBitInt(7, "vWe107_TEe0POMP1FRI", "vWe107_0.interv.prot.mot.pompa circolazione"),
				new lBitInt(8, "vWe108_TEe0POMPCELL", "vWe108_0.interv.prot.mot.pompa raffr.vasca 1°st.frigor."),
				new lBitInt(9, "vWe109_TEe0POMPP1P2", "vWe109_0.interv.prot.mot.pompa raffr.cella da 1° stadio"),
				new lBitInt(10, "vWe110_TEe0POMP_P3_", "vWe110_0.interv.prot.mot.ventilazione cella"),
				new lBitInt(11, "vWe111_TEe1POMP_P4_", "vWe111_1.interv.prot.motore pompa P4"),
				new lBitInt(12, "vWe112_TEe2MREGCIPR", "vWe112_2.interv.prot.mot.regol.corsa cilindro pressione"),
				new lBitInt(13, "vWe113_TEe1VENTCELL", "vWe113_1.interv.prot.motore ventola cella"),
				new lBitInt(14, "vWe114_TEe0RISCCELL", "vWe114_0.interv.prot.riscaldatore cella"),
				new lBitInt(15, "vWe115_SNe1FILTCECL", "vWe115_1.filtro principale centralina intasato")
			}),


			new wBitInt((int)wBitInt.types.We, 2, "We2", "We2", new lBitInt[]
			{
				new lBitInt(0, "vWe200_SNe1FISER1CL", "vWe200_1.filtro servizio cilindro 1 intasato"),
				new lBitInt(1, "vWe201_SNe1FIVIBRCL", "vWe201_1.filtro servizio vibratore intasato"),
				new lBitInt(2, "vWe202_SNe1FIPILOCL", "vWe202_1.filtro servizio pilotaggio cil.1 intasato"),
				new lBitInt(3, "vWe203_SNe0PROT_AUX", "vWe203_0.interv.prot.circuiti 24Vdc"),
				new lBitInt(4, "vWe204_SNe0PROTFIEL", "vWe204_0.intervento protez.filtro elettrostatico"),
				new lBitInt(5, "vWe205_SIe0TUTTO_OK", "vWe205_0.circuiti ausiliari inseriti"),
				new lBitInt(6, "vWe206_SNe0EMERRIPR", "vWe206_0.emergenza ripristinata"),
				new lBitInt(7, "vWe207_SLe0AUTOMATI", "vWe207_0.selettore comandi automatici"),
				new lBitInt(8, "vWe208_PUe0STARAUTO", "vWe208_0.pulsante avvio ciclo automatico"),
				new lBitInt(9, "vWe209_PUe0STOPAUTO", "vWe209_0.pulsante arresto ciclo automatico"),
				new lBitInt(10, "vWe210_PUe0COMAAVAN", "vWe210_0.pulsante comando manuale avanti"),
				new lBitInt(11, "vWe211_PUe0COMAINDI", "vWe211_0.pulsante comando manuale indietro"),
				new lBitInt(12, "vWe212_SNe1CENTMARC", "vWe212_1.pompe idrauliche in marcia"),
				new lBitInt(13, "vWe213_SNe1DRIVFLOK", "vWe213_1.nessuna anomalia inverter pompa circolaz."),
				new lBitInt(14, "vWe214_PUeACK_ALLA", "vWe214_"),
				new lBitInt(15, "vWe215_PUeRESEALLA", "vWe215_")
			}),


			new wBitInt((int)wBitInt.types.We, 3, "We3", "We3", new lBitInt[]
			{
				new lBitInt(0, "vWe300_PSe0HP_1FRIG", "vWe300_0.sovrapressione 1° stadio gr.frigorifero"),
				new lBitInt(1, "vWe301_PSe0LP_1FRIG", "vWe301_0.bassa pressione 1° st.gr.frigorifero"),
				new lBitInt(2, "vWe302_PSe0HP_2FRIG", "vWe302_0.sovrapressione 2° stadio gr.frigorifero"),
				new lBitInt(3, "vWe303_PSe0LP_2FRIG", "vWe303_0.bassa pressione 2° st.gr.frigorifero"),
				new lBitInt(4, "vWe304_", "vWe304_"),
				new lBitInt(5, "vWe305_", "vWe305_"),
				new lBitInt(6, "vWe306_", "vWe306_"),
				new lBitInt(7, "vWe307_", "vWe307_"),
				new lBitInt(8, "vWe308_", "vWe308_"),
				new lBitInt(9, "vWe309_", "vWe309_"),
				new lBitInt(10, "vWe310_", "vWe310_"),
				new lBitInt(11, "vWe311_", "vWe311_"),
				new lBitInt(12, "vWe312_", "vWe312_"),
				new lBitInt(13, "vWe313_", "vWe313_"),
				new lBitInt(14, "vWe314_", "vWe314_"),
				new lBitInt(15, "vWe315_", "vWe315_")
			}),


		};

		public wBitInt[] Wu= new wBitInt[]
		{
			new wBitInt((int)wBitInt.types.Wu, 0, "Wu0", "Wu0", new lBitInt[]
			{
				new lBitInt(0, "vWu000_KMuP1020MAN", "vWu000.KMuP1020MAN"),
				new lBitInt(1, "vWu001_YVu500GARIA", "vWu001.YVu500GARIA"),
				new lBitInt(2, "vWu002_YVu1070MAND", "vWu002.YVu1070MAND"),
				new lBitInt(3, "vWu003_YVu1100RITo", "vWu003.YVu1100RITo"),
				new lBitInt(4, "vWu004_KMaSelTrasd", "vWu004.KMaSelTrasd"),
				new lBitInt(5, "vWu005_Riserva_0_5", "vWu005.Riserva_0_5"),
				new lBitInt(6, "vWu006_", "vWu006."),
				new lBitInt(7, "vWu007_", "vWu007."),
				new lBitInt(8, "vWu008_", "vWu008."),
				new lBitInt(9, "vWu009_", "vWu009."),
				new lBitInt(10, "vWu010_", "vWu010."),
				new lBitInt(11, "vWu011_", "vWu011."),
				new lBitInt(12, "vWu012_", "vWu012."),
				new lBitInt(13, "vWu013_", "vWu013."),
				new lBitInt(14, "vWu014_", "vWu014."),
				new lBitInt(15, "vWu015_", "vWu015.")
			}),


			new wBitInt((int)wBitInt.types.Wu, 1, "Wu1", "Wu1", new lBitInt[]
			{
				new lBitInt(0, "vWu100_SNu0CONS_RUN", "vWu100_0.consenso messa in servizio"),
				new lBitInt(1, "vWu101_SNuLAMPALLA_", "vWu101_0.lampada segn. allarme"),
				new lBitInt(2, "vWu102_SNu_PIU_PIU_", "vWu102_0.cicalino allarme"),
				new lBitInt(3, "vWu103_EVu1PRLICISI", "vWu103_1.pressurizzazione linea circuito siringa"),
				new lBitInt(4, "vWu104_EVu1PRLIVIBR", "vWu104_1.pressurizzazione linea circuito vibratore"),
				new lBitInt(5, "vWu105_EVu1RAFFCEOL", "vWu105_1.raffreddamento olio centralina idraulica"),
				new lBitInt(6, "vWu106_EVu1CARICIPR", "vWu106_1.caricamento circuito prova"),
				new lBitInt(7, "vWu107_EVu1SCARCIPR", "vWu107_1.scarico circuito prova"),
				new lBitInt(8, "vWu108_EVu1AUX_CASC", "vWu108_1.com.valvola aus.carico/scarico"),
				new lBitInt(9, "vWu109_EVu1AUX_SCCI", "vWu109_1.com.valvola ausiliaria svuotamento"),
				new lBitInt(10, "vWu110_EVu1ESCIRISC", "vWu110_1.esclusione circolaz.fluido nel riscaldatore"),
				new lBitInt(11, "vWu111_EVu0CIRCH2FL", "vWu111_0.circolaz.acqua raffredd.circuito di prova"),
				new lBitInt(12, "vWu112_EVu0SPURCIRC", "vWu112_0.spurgo fluido circuito di prova"),
				new lBitInt(13, "vWu113_EVu0RACOFRI1", "vWu113_0.acqua raffredd.condensatore 1°st.frigor."),
				new lBitInt(14, "vWu114_EVu0FREDCELL", "vWu114_0.mandata fluido freddo alla cella da 1°st.frigor."),
				new lBitInt(15, "vWu115_EVu0SVUOCELL", "vWu115_0.svuotamento fluido freddo dalla cella")
			}),


			new wBitInt((int)wBitInt.types.Wu, 2, "Wu2", "Wu2", new lBitInt[]
			{
				new lBitInt(0, "vWu200_EVu0CONDFRI2", "circol.acqua raffredd.condensatore 1°st.frigor."),
				new lBitInt(1, "vWu201_EVu0LIQUCELL", "mandata fluido freddo alla cella da 1°st.frigor."),
				new lBitInt(2, "vWu202_EVu0LIQUFRI1", "svuotamento fluido freddo dalla cella"),
				new lBitInt(3, "vWu203_LSu0_RIPOSO_", "mandata fluido freddo al condens.da 2°stadio"),
				new lBitInt(4, "vWu204_LSu0AUTOMATI", "mandata gas alla cella da 2°stadio frigor."),
				new lBitInt(5, "vWu205_LSu0ANOMALIA", "mandata gas evaporat.gruppo frigor.1°stadio"),
				new lBitInt(6, "vWu206_LSu0SBLOPORT", "ev ventilazione esterna"),
				new lBitInt(7, "vWu207_RSu1MODURICE", "ev circolaz.H2o raffr.fluido circolante"),
				new lBitInt(8, "vWu208_RSu1MODURIFL", "telerutt. comando centralina oleo"),
				new lBitInt(9, "vWu209_CTu1POMPECEN", "ev circolaz. monte prova"),
				new lBitInt(10, "vWu210_EVu2CIRCMOPR", "ev circolaz. valle prova"),
				new lBitInt(11, "vWu211_EVu2CIRCVAPR", "ev pressurizzazione circuito prova  riserva"),
				new lBitInt(12, "vWu212_EVu2PRESCIRC", "  riserva"),
				new lBitInt(13, "vWu213_RISERVA", "  riserva"),
				new lBitInt(14, "vWu214_RISERVA", "  riserva"),
				new lBitInt(15, "vWu215_RISERVA", "  riserva")
			}),


			new wBitInt((int)wBitInt.types.Wu, 3, "Wu3", "Wu3", new lBitInt[]
			{
				new lBitInt(0, "vWu300_RISERVA", "  riserva"),
				new lBitInt(1, "vWu301_RISERVA", "  riserva"),
				new lBitInt(2, "vWu302_RISERVA", "  riserva"),
				new lBitInt(3, "vWu303_RISERVA", "  riserva"),
				new lBitInt(4, "vWu304_RISERVA", "  riserva"),
				new lBitInt(5, "vWu305_RISERVA", "  riserva"),
				new lBitInt(6, "vWu306_RISERVA", "  riserva"),
				new lBitInt(7, "vWu307_RISERVA", "  riserva"),
				new lBitInt(8, "vWu308_RISERVA", "  riserva"),
				new lBitInt(9, "vWu309_RISERVA", "  riserva"),
				new lBitInt(10, "vWu310_RISERVA", "  riserva"),
				new lBitInt(11, "vWu311_RISERVA", "  riserva"),
				new lBitInt(12, "vWu312_RISERVA", "  riserva"),
				new lBitInt(13, "vWu313_RISERVA", "  riserva"),
				new lBitInt(14, "vWu314_RISERVA", "  riserva"),
				new lBitInt(15, "vWu315_RISERVA", "  riserva")
			}),


		};

		public wBitInt[] Wa= new wBitInt[]
		{
			new wBitInt((int)wBitInt.types.Wa, 0, "Wa00", "Wa00", new lBitInt[]
			{
				new lBitInt(0, "SInTUTTO_OK", "0.all. circuiti ausiliari inseriti"),
				new lBitInt(1, "TEnPOMPMAND", "0.all. termica pompa mandata"),
				new lBitInt(2, "KMnPOMPMAND", "0.all. readback pompa mandata"),
				new lBitInt(3, "SNnPRESARIA", "0.all. mancanza aria compressa"),
				new lBitInt(4, "OPnV1070MAN", "2.all. anomalia apertura valvola mandata"),
				new lBitInt(5, "CLnV1070MAN", "0.all. anomalia chiusura valvola mandata"),
				new lBitInt(6, "OPnV1100RIT", "0.all. anomalia apertura valvola ritorno"),
				new lBitInt(7, "CLnV1100RIT", "1.all. anomalia apertura valvola ritorno"),
				new lBitInt(8, "ALnSPARE008", "0.all."),
				new lBitInt(9, "ALnSPARE009", "0.all."),
				new lBitInt(10, "ALnSPARE010", "0.all."),
				new lBitInt(11, "ALnSPARE011", "0.all."),
				new lBitInt(12, "ALnSPARE012", "0.all."),
				new lBitInt(13, "ALnSPARE013", "0.all."),
				new lBitInt(14, "ALnSPARE014", "0.all."),
				new lBitInt(15, "ALnSPARE015", "0.all.")
			}),


			new wBitInt((int)wBitInt.types.Wa, 1, "Wa01", "Wa01", new lBitInt[]
			{
				new lBitInt(0, "AL1_0_TEn0COMP2FRI", "0.all. interv.prot.mot.compressore 2°st.gr.frigor."),
				new lBitInt(1, "AL1_1_TEn0POMP1FRI", "0.all. interv.prot.mot.pompa raffr.vasca 1°st.frigor."),
				new lBitInt(2, "AL1_2_TEn0POMPCELL", "0.all. interv.prot.mot.pompa raffr.cella da 1° stadio"),
				new lBitInt(3, "AL1_3_TEn0POMPP1P2", "1 all interv. prot.mot.pompe P1-P2"),
				new lBitInt(4, "AL1_4_TEn0POMP_P3_", "0.all. interv.prot.motore pompa P3"),
				new lBitInt(5, "AL1_5_TEn1POMP_P4_", "1.all. interv.prot.motore pompa P4"),
				new lBitInt(6, "AL1_6_TEn2MREGCIPR", "2.all. interv.prot.mot.regol.corsa cilindro pressione"),
				new lBitInt(7, "AL1_7_TEn1VENTCELL", "1.all. interv.prot.motore ventola cella"),
				new lBitInt(8, "AL1_8_TEn0RISCCELL", "0.all. interv.prot.riscaldatore cella"),
				new lBitInt(9, "AL1_9_SNn1FILTCECL", "1.all. filtro principale centralina intasato"),
				new lBitInt(10, "AL1_a_SNn1FISER1CL", "1.all. filtro servizio cilindro 1 intasato"),
				new lBitInt(11, "AL1_b_SNn1FIVIBRCL", "1.all. filtro servizio vibratore intasato"),
				new lBitInt(12, "AL1_c_SNn1FIPILOCL", "1.all. filtro servizio pilotaggio cil.1 intasato"),
				new lBitInt(13, "AL1_d_SNn0PROT_AUX", "0.all. interv.prot.circuiti 24Vdc"),
				new lBitInt(14, "AL1_e_SNn0PROTFIEL", "0.all. intervento protez.filtro elettrostatico"),
				new lBitInt(15, "AL1_f_SNn0EMERRIPR", "0.all. emergenza ripristinata")
			}),


			new wBitInt((int)wBitInt.types.Wa, 2, "Wa02", "Wa02", new lBitInt[]
			{
				new lBitInt(0, "AL2_0_SLn0AUTOMATI", "0.all. selettore comandi automatici"),
				new lBitInt(1, "AL2_1_SNn1DRIVFLOK", "1.all. nessuna anomalia inverter pompa circolaz."),
				new lBitInt(2, "AL2_2_PSn0LOPRFRI1", "0 all alta pressione primo stadio"),
				new lBitInt(3, "AL2_3_SQnSTEPUNDF", ""),
				new lBitInt(4, "AL2_4_SQnTESTLIVE", ""),
				new lBitInt(5, "AL2_5_", ""),
				new lBitInt(6, "AL2_6_", ""),
				new lBitInt(7, "AL2_7_", ""),
				new lBitInt(8, "AL2_8_", ""),
				new lBitInt(9, "AL2_9_", ""),
				new lBitInt(10, "AL2_a_", ""),
				new lBitInt(11, "AL2_b_", ""),
				new lBitInt(12, "AL2_c_", ""),
				new lBitInt(13, "AL2_d_", ""),
				new lBitInt(14, "AL2_e_", ""),
				new lBitInt(15, "AL2_f_", "")
			})
		};
	}
}
