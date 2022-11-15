using System;
using System.Collections.Generic;
using System.Text;
using v0449_shared.CL.DEF;

namespace v0449_shared.CL.DEF.benches
{
  public class _0496dio
	{

		public wBitInt[] Wa= new wBitInt[]
		{
			new wBitInt((int)wBitInt.types.Wa, 0, "Wa00", "Wa00", new lBitInt[]
			{
				new lBitInt(0, "AL0_0_SInTUTTO_OK", "0.all. circuiti ausiliari non inseriti"),
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
				new lBitInt(3, "AL2_3_SQnSTEPUNDF", "36 - step indefinito"),
				new lBitInt(4, "AL2_4_SQnTESTLIVE", "37 - prova attiva"),
				new lBitInt(5, "AL2_5_SBaSCOPTUBO", "38 - Anomalia pulsazione scoppio tubo"),
				new lBitInt(6, "AL2_6_WDaCOM_SERV", "39 - Mancanza comunicazione server"),
				new lBitInt(7, "AL2_7_WDaCOM_CLIE", "40 - Mancanza comunicazione client"),
				new lBitInt(8, "AL2_8_", ""),
				new lBitInt(9, "AL2_9_", ""),
				new lBitInt(10, "AL2_a_", ""),
				new lBitInt(11, "AL2_b_", ""),
				new lBitInt(12, "AL2_c_", ""),
				new lBitInt(13, "AL2_d_", ""),
				new lBitInt(14, "AL2_e_", ""),
				new lBitInt(15, "AL2_f_", "")
			}),


		};

		public wBitInt[] We= new wBitInt[]
		{
			new wBitInt((int)wBitInt.types.We, 0, "We0", "We0", new lBitInt[]
			{
				new lBitInt(0, "SIeTUTTO_OK", "Ausiliari inseriti"),
				new lBitInt(1, "iPSpresAria", "Pressostato presenza aria"),
				new lBitInt(2, "iLVallBass", "Livello fluido sufficiente"),
				new lBitInt(3, "TEeRISCFLUI", "Termica riscaldo fluido"),
				new lBitInt(4, "TEeRISCIRED", "Termica riscaldo infrarosso"),
				new lBitInt(5, "TEePWRPPULS", "Termica pompa circopulsazione"),
				new lBitInt(6, "SNeDRVPPULS", "Drive OK pompa circopulsazione"),
				new lBitInt(7, "TEePOMPRICI", "Termica pompa ricircolo"),
				new lBitInt(8, "Element_1", "Riserva"),
				new lBitInt(9, "SNeALLAALLA", "Livello allarme allagamento"),
				new lBitInt(10, "PUeAVANTI", "Pulsante comando avanti"),
				new lBitInt(11, "PUeINDIETRO", "Pulsante comando indietro"),
				new lBitInt(12, "PUeMARCIA", "Pulsante comando marcia"),
				new lBitInt(13, "PUeARRESTO", "Pulsante comando arresto"),
				new lBitInt(14, "SLeAUTO", "Selettore modale: automatico"),
				new lBitInt(15, "PUeReseAlla", "Pulsante reset allarmi")
			}),


			new wBitInt((int)wBitInt.types.We, 1, "We1", "We1", new lBitInt[]
			{
				new lBitInt(0, "SNePORTOPEN", "Segnale portellone cella aperto"),
				new lBitInt(1, "SNeEMERPRES", "Segnale emergenza premuta"),
				new lBitInt(2, "riserva2", "Riserva 2"),
				new lBitInt(3, "riserva3", "Riserva 3"),
				new lBitInt(4, "riserva4", "Riserva 4"),
				new lBitInt(5, "riserva5", "Riserva 5"),
				new lBitInt(6, "riserva6", "Riserva 6"),
				new lBitInt(7, "riserva7", "Riserva 7"),
				new lBitInt(8, "riserva8", "Riserva 8"),
				new lBitInt(9, "riserva9", "Riserva 9"),
				new lBitInt(10, "riserva10", "Riserva A"),
				new lBitInt(11, "riserva11", "Riserva B"),
				new lBitInt(12, "riserva12", "Riserva C"),
				new lBitInt(13, "riserva13", "Riserva D"),
				new lBitInt(14, "riserva14", "Riserva E"),
				new lBitInt(15, "riserva15", "Riserva F")
			}),


			new wBitInt((int)wBitInt.types.We, 2, "We2", "We2", new lBitInt[]
			{
				new lBitInt(0, "vWe200_RISERVA", "vWe200_RISERVA"),
				new lBitInt(1, "vWe201_RISERVA", "vWe201_RISERVA"),
				new lBitInt(2, "vWe202_RISERVA", "vWe202_RISERVA"),
				new lBitInt(3, "vWe203_RISERVA", "vWe203_RISERVA"),
				new lBitInt(4, "vWe204_RISERVA", "vWe204_RISERVA"),
				new lBitInt(5, "vWe205_RISERVA", "vWe205_RISERVA"),
				new lBitInt(6, "vWe206_RISERVA", "vWe206_RISERVA"),
				new lBitInt(7, "vWe207_RISERVA", "vWe207_RISERVA"),
				new lBitInt(8, "vWe208_RISERVA", "vWe208_RISERVA"),
				new lBitInt(9, "vWe209_RISERVA", "vWe209_RISERVA"),
				new lBitInt(10, "vWe210_RISERVA", "vWe210_RISERVA"),
				new lBitInt(11, "vWe211_RISERVA", "vWe211_RISERVA"),
				new lBitInt(12, "vWe212_RISERVA", "vWe212_RISERVA"),
				new lBitInt(13, "vWe213_RISERVA", "vWe213_RISERVA"),
				new lBitInt(14, "vWe214_RISERVA", "vWe214_RISERVA"),
				new lBitInt(15, "vWe215_RISERVA", "vWe215_RISERVA")
			}),


			new wBitInt((int)wBitInt.types.We, 3, "We3", "We3", new lBitInt[]
			{
				new lBitInt(0, "vWe300_RISERVA", "vWe300_RISERVA"),
				new lBitInt(1, "vWe301_RISERVA", "vWe301_RISERVA"),
				new lBitInt(2, "vWe302_RISERVA", "vWe302_RISERVA"),
				new lBitInt(3, "vWe303_RISERVA", "vWe303_RISERVA"),
				new lBitInt(4, "vWe304_RISERVA", "vWe304_RISERVA"),
				new lBitInt(5, "vWe305_RISERVA", "vWe305_RISERVA"),
				new lBitInt(6, "vWe306_RISERVA", "vWe306_RISERVA"),
				new lBitInt(7, "vWe307_RISERVA", "vWe307_RISERVA"),
				new lBitInt(8, "vWe308_RISERVA", "vWe308_RISERVA"),
				new lBitInt(9, "vWe309_RISERVA", "vWe309_RISERVA"),
				new lBitInt(10, "vWe310_RISERVA", "vWe310_RISERVA"),
				new lBitInt(11, "vWe311_RISERVA", "vWe311_RISERVA"),
				new lBitInt(12, "vWe312_RISERVA", "vWe312_RISERVA"),
				new lBitInt(13, "vWe313_RISERVA", "vWe313_RISERVA"),
				new lBitInt(14, "vWe314_RISERVA", "vWe314_RISERVA"),
				new lBitInt(15, "vWe315_RISERVA", "vWe315_RISERVA")
			}),


		};

		public wBitInt[] Wu= new wBitInt[]
		{
			new wBitInt((int)wBitInt.types.Wu, 0, "Wu0", "Wu0", new lBitInt[]
			{
				new lBitInt(0, "CTuPWRRFLUI", "Contattore risc. fluido"),
				new lBitInt(1, "CTuPWRRIRED", " Contattore risc. infrarosso"),
				new lBitInt(2, "CTuPWRPPULS", " Contattore alim. drive p.pulsaz."),
				new lBitInt(3, "CTuPWRPRICI", " Contattore pompa ricircolo"),
				new lBitInt(4, "RSuMODRFLUI", " Relè statico risc. fluido"),
				new lBitInt(5, "RSuMODRIRED", " Relè statico risc. infrarosso"),
				new lBitInt(6, "SNuENAPPULS", " Comando abilitazione drive p.circ"),
				new lBitInt(7, "Element_1", " Riserva 7"),
				new lBitInt(8, "uLampAllarme", " Spia allarmi"),
				new lBitInt(9, "uLampAuto", " Spia automatico"),
				new lBitInt(10, "uLampStart", " Spia marcia"),
				new lBitInt(11, "uLampStop", " Spia arresto"),
				new lBitInt(12, "Element_2", " Riserva C"),
				new lBitInt(13, "Element_3", " Riserva D"),
				new lBitInt(14, "Element_4", " Riserva E"),
				new lBitInt(15, "SNuAPREPORT", " Comando sblocco portellone cella")
			}),


			new wBitInt((int)wBitInt.types.Wu, 1, "Wu1", "Wu1", new lBitInt[]
			{
				new lBitInt(0, "EVuSPURCIRC1", "EV 1 spurgo circuito"),
				new lBitInt(1, "EVuSPURCIRC2", " EV 2 spurgo circuito"),
				new lBitInt(2, "EVuALIMPROV", " EV alimentazione circ. prova"),
				new lBitInt(3, "EVuRIPODIRE", " EV ritorno bypass diretto"),
				new lBitInt(4, "EVuRIPOREGO", " EV ritorno bypass regolato"),
				new lBitInt(5, "EVuRIPRDIRE", " EV ritorno prova diretto"),
				new lBitInt(6, "EVuRIPRREGO", " EV ritorno prova regolato"),
				new lBitInt(7, "EVuRAFFFLUI", " EV raffreddamento fluido"),
				new lBitInt(8, "Element_5", " Element_5"),
				new lBitInt(9, "Element_6", " Element_6"),
				new lBitInt(10, "Element_7", " Element_7"),
				new lBitInt(11, "Element_8", " Element_8"),
				new lBitInt(12, "Element_9", " Element_9"),
				new lBitInt(13, "Element_10", " Element_10"),
				new lBitInt(14, "Element_11", " Element_11"),
				new lBitInt(15, "Element_12", " Element_12")
			}),


			new wBitInt((int)wBitInt.types.Wu, 2, "Wu2", "Wu2", new lBitInt[]
			{
				new lBitInt(0, "ris32", "ris32"),
				new lBitInt(1, "ris33", "ris33"),
				new lBitInt(2, "ris34", "ris34"),
				new lBitInt(3, "ris35", "ris35"),
				new lBitInt(4, "ris36", "ris36"),
				new lBitInt(5, "ris37", "ris37"),
				new lBitInt(6, "ris38", "ris38"),
				new lBitInt(7, "ris39", "ris39"),
				new lBitInt(8, "ris40", "ris40"),
				new lBitInt(9, "ris41", "ris41"),
				new lBitInt(10, "ris42", "ris42"),
				new lBitInt(11, "ris43", "ris43"),
				new lBitInt(12, "ris44", "ris44"),
				new lBitInt(13, "ris45", "ris45"),
				new lBitInt(14, "ris46", "ris46"),
				new lBitInt(15, "ris47", "ris47")
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
			})
		};
	}
}
