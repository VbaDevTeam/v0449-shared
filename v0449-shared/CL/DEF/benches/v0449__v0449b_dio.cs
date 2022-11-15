using System;
using System.Collections.Generic;
using System.Text;
using v0449_shared.CL.DEF;

namespace v0449_shared.CL.DEF.benches
{
  public class _0449dioAp
	{

		public wBitInt[] We= new wBitInt[]
		{
			new wBitInt((int)wBitInt.types.We, 0, "We0", "We0", new lBitInt[]
			{
				new lBitInt(0, "vWe000_FCePORTNOCH", "vWe000_0.porta cella non chiusa"),
				new lBitInt(1, "vWe001_CTeRISCFLUI", "vWe001_0.termostato sicurezza riscaldatore fluido"),
				new lBitInt(2, "vWe002_CTeRISCCAME", "vWe002_0.termostato sicurezza cella climatica"),
				new lBitInt(3, "vWe003_LVe2FLUPROOK", "vWe003_2.livello fluido prova sufficiente"),
				new lBitInt(4, "vWe004_LSe0TRAFFLUI", "vWe004_0.trafilamento fluido da elementi in prova"),
				new lBitInt(5, "vWe005_PSe0PRESARIA", "vWe005_0.pressione aria sufficiente"),
				new lBitInt(6, "vWe006_FCe0SIRIRIPO", "vWe006_0.cilindro comando pressione a riposo"),
				new lBitInt(7, "vWe007_FCe1SIRIXCOR", "vWe007_1.oltrecorsa cilindro comando pressione"),
				new lBitInt(8, "vWe008_LVe1OLIOBASS", "vWe008_1.livello olio centralina insufficiente"),
				new lBitInt(9, "vWe009_SNe2RECOPRIN", "vWe009_2.regolatore corsa cil.pressione indietro"),
				new lBitInt(10, "vWe010_SNe2RECOPRAV", "vWe010_2.regolatore corsa cil.pressione avanti"),
				new lBitInt(11, "vWe011_PSe0HP_1FRIGex", "vWe011_Riserva"),
				new lBitInt(12, "vWe012_TSe0LT_1FRIG", "vWe012_0.termostato di minima 1° stadio gr.frigorifero"),
				new lBitInt(13, "vWe013_FLe0LQ_1FRIG", "vWe013_0.flussostato 1° stadio gruppo frigorifero"),
				new lBitInt(14, "vWe014_FLe0GQ_2FRIG", "vWe014_0.fl circ.fl. in cella da 1° st./fl cond. 2° st"),
				new lBitInt(15, "vWe015_LVe0HG_1FRIG", "vWe015_0.livello fluido vasca 1° stadio gr.frigorifero")
			}),


			new wBitInt((int)wBitInt.types.We, 1, "We1", "We1", new lBitInt[]
			{
				new lBitInt(0, "vWe100_PSe0HP_2FRIGex", "e00_Riserva"),
				new lBitInt(1, "vWe101_PSe0LP_2FRIGex", "e01_Riserva"),
				new lBitInt(2, "vWe102_FCe0VIBRPOSI", "e02.vibratore posizionato"),
				new lBitInt(3, "vWe103_FCe0VIBRSPIN", "e03.spina vibratore introdotta"),
				new lBitInt(4, "vWe104_SNe0VIBR_RUN", "e04.gruppo vibratore in marcia"),
				new lBitInt(5, "vWe105_TEe0COMP1FRI", "e05.interv.prot.mot.compressore 1°st.gr.frigor."),
				new lBitInt(6, "vWe106_TEe0COMP2FRI", "e06.interv.prot.mot.compressore 2°st.gr.frigor."),
				new lBitInt(7, "vWe107_TEe0POMP1FRI", "e07.interv.prot.mot.pompa circolazione"),
				new lBitInt(8, "vWe108_TEe0POMPCELL", "e08.interv.prot.mot.pompa raffr.vasca 1°st.frigor."),
				new lBitInt(9, "vWe109_TEe0POMPP1P2", "e09.interv.prot.mot.pompa raffr.cella da 1° stadio"),
				new lBitInt(10, "vWe110_TEe0POMP_P3_", "e0a.interv.prot.mot.ventilazione cella"),
				new lBitInt(11, "vWe111_TEe1POMP_P4_", "e0b.interv.prot.motore pompa P4"),
				new lBitInt(12, "vWe112_TEe2MREGCIPR", "e0c.interv.prot.mot.regol.corsa cilindro pressione"),
				new lBitInt(13, "vWe113_TEe1VENTCELL", "e0d.interv.prot.motore ventola cella"),
				new lBitInt(14, "vWe114_TEe0RISCCELL", "e0e.interv.prot.riscaldatore cella"),
				new lBitInt(15, "vWe115_SNe1FILTCECL", "e0f.filtro principale centralina intasato")
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
				new lBitInt(0, "vWu000_CTu0CMP1FRIG", "vWu000_0.marcia compressore 1°stadio"),
				new lBitInt(1, "vWu001_CTu0CMP2FRIG", "vWu001_0.marcia compressore 2°stadio"),
				new lBitInt(2, "vWu002_SNu0POMPCIRC", "vWu002_0.marcia avanti pompa circolazione fluido"),
				new lBitInt(3, "vWu003_CTu0PMP1FRIG", "vWu003_0.marcia pompa raffredd.vasca 1°stadio"),
				new lBitInt(4, "vWu004_CTu0PMPCCELL", "vWu004_0.marcia pompa raffreddamento cella"),
				new lBitInt(5, "vWu005_CTu0FILTELET", "vWu005_0.abilitazione filtro elettrostatico"),
				new lBitInt(6, "vWu006_CTu0PWRRISFL", "vWu006_0.abilitazione resistenze fluido circolante"),
				new lBitInt(7, "vWu007_CTu0PWRRISCE", "vWu007_0.abilitazione riscaldatore cella"),
				new lBitInt(8, "vWu008_CTu1VENTEXTE", "vWu008_1.ev ventilazione esterna"),
				new lBitInt(9, "vWu009_CTu0VENTCELL", "vWu009_0.ventilatore destratificazione cella"),
				new lBitInt(10, "vWu010_CTu0SOFFRICE", "vWu010_0.soffiante riscaldatore cella"),
				new lBitInt(11, "vWu011_SNu1POMRCIRC", "vWu011_1.marcia indietro pompa circolazione fluido"),
				new lBitInt(12, "vWu012_SNu2ALLUARPR", "vWu012_2.allontana punto arresto cil.pressione"),
				new lBitInt(13, "vWu013_SNu2ACCOARPR", "vWu013_2.avvicina punto arresto cil.pressione"),
				new lBitInt(14, "vWu014_SNu2AVANCIPR", "vWu014_2.avanti cilindro pressione circuito prova"),
				new lBitInt(15, "vWu015_SNu0STARVIBR", "vWu015_0.start a vibratore")
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
				new lBitInt(0, "AL0_0_SInTUTTO_OK", "0.all. circuiti ausiliari inseriti"),
				new lBitInt(1, "AL0_1_FCn0PORTNOCH", "0.all. porta cella non chiusa"),
				new lBitInt(2, "AL0_2_TSn0RISCFLUI", "0.all. termostato sicurezza riscaldatore fluido"),
				new lBitInt(3, "AL0_3_TSn0TEMPCAME", "0.all. termostato sicurezza cella climatica"),
				new lBitInt(4, "AL0_4_LVn2FLUPROOK", "2.all. livello fluido prova sufficiente"),
				new lBitInt(5, "AL0_5_LSn0TRAFFLUI", "0.all. trafilamento fluido da elementi in prova"),
				new lBitInt(6, "AL0_6_PSn0PRESARIA", "0.all. pressione aria sufficiente"),
				new lBitInt(7, "AL0_7_LVn1OLIOBASS", "1.all. livello olio centralina insufficiente"),
				new lBitInt(8, "AL0_8_PSn0HP_1FRIG", "0.all. sovrapressione 1° stadio gr.frigorifero"),
				new lBitInt(9, "AL0_9_TSn0LT_1FRIG", "0.all. termostato di minima 1° stadio gr.frigorifero"),
				new lBitInt(10, "AL0_a_FLn0LQ_1FRIG", "0.all. flussostato 1° stadio gruppo frigorifero"),
				new lBitInt(11, "AL0_b_FLn0GQ_2FRIG", "0.all. fl circ.fl. in cella da 1° st./fl cond. 2° st"),
				new lBitInt(12, "AL0_c_LVn0HG_1FRIG", "0.all. livello fluido vasca 1° stadio gr.frigorifero"),
				new lBitInt(13, "AL0_d_PSn0HP_2FRIG", "0.all. sovrapressione 2° stadio gr.frigorifero"),
				new lBitInt(14, "AL0_e_PSn0LP_2FRIG", "0.all. insufficiente pressione 2° st.gr.frigorifero"),
				new lBitInt(15, "AL0_f_TEn0COMP1FRI", "0.all. interv.prot.mot.compressore 1°st.gr.frigor.")
			}),


			new wBitInt((int)wBitInt.types.Wa, 1, "Wa01", "Wa01", new lBitInt[]
			{
				new lBitInt(0, "AL1_0_TEn0COMP2FRI", "0.all. interv.prot.mot.compressore 2°st.gr.frigor."),
				new lBitInt(1, "AL1_1_TEn0POMP1FRI", "0.all. interv.prot.mot.pompa raffr.vasca 1°st.frigor."),
				new lBitInt(2, "AL1_2_TEn0POMPCELL", "0.all. interv.prot.mot.pompa raffr.cella da 1° stadio"),
				new lBitInt(3, "AL1_3_TEn0POMPP1P2", "1 all  interv. prot.mot.pompe P1-P2"),
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
