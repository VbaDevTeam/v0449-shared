using System;
using System.Collections.Generic;
using System.Text;
using v0449_shared.CL.DEF;

namespace v0449_shared.CL.DEF.benches
{
  public class _0387dioLO
	{

		public wBitInt[] We= new wBitInt[]
		{
			new wBitInt((int)wBitInt.types.We, 0, "We0", "We0", new lBitInt[]
			{
				new lBitInt(0, "vWe000_MSeF130EME2", "vWe000.Port.H20 Sec.Salto Emerg."),
				new lBitInt(1, "vWe001_SIeTutto_Ok", "vWe001.Ausiliari Pulsante Inseriti"),
				new lBitInt(2, "vWe002_MSeF130EME1", "vWe002.Port.H20 Pri.Salto Emerg."),
				new lBitInt(3, "vWe003_TEeP120MAND", "vWe003.Contatto Int.Pompa mandata"),
				new lBitInt(4, "vWe004_MSeF230RSIG", "vWe004.Port.H20 Raff. Siringa"),
				new lBitInt(5, "vWe005_KMeP120MAND", "vWe005.Contatto teleruttore Pompa mandata"),
				new lBitInt(6, "vWe006_MSeF340RANE", "vWe006.Port.H20 Raff. Circuito"),
				new lBitInt(7, "vWe007_DReP120OK", "vWe007.Drive pompa mandata OK"),
				new lBitInt(8, "vWe008_MSeF250PORTA", "vWe008.Port. Fluido Test A"),
				new lBitInt(9, "vWe009_MSeF250PORTB", "vWe009.Port. Fluido Test B"),
				new lBitInt(10, "vWe010_TEeP200CIRC", "vWe010.Contatto int.Pompa circolazione"),
				new lBitInt(11, "vWe011_KMeP200CIRC", "vWe011.Contatto teleruttore Pompa circolazione"),
				new lBitInt(12, "vWe012_DReP200OK", "vWe012.Drive pompa circolazione OK"),
				new lBitInt(13, "vWe013_TEeR210RISC", "vWe013.Contatto int.Circuito Riscaldo"),
				new lBitInt(14, "vWe014_SLeCICLAUTO", "vWe014.Selettore auto/manuale"),
				new lBitInt(15, "vWe015_Riserva", "vWe015.Riserva")
			}),


			new wBitInt((int)wBitInt.types.We, 1, "We1", "We1", new lBitInt[]
			{
				new lBitInt(0, "vWe100_KMeR210RISC", "vWe100.Contatto teleruttore circ.Riscaldo"),
				new lBitInt(1, "vWe101_TEeS230EROG", "vWe101.Contatto int.siringa"),
				new lBitInt(2, "vWe102_KMeS230EROG", "vWe102.Contatto teleruttore siringa"),
				new lBitInt(3, "vWe103_DReS230OK", "vWe103.Drive enable siringa"),
				new lBitInt(4, "vWe104_TSeR210OK", "vWe104.Termostato sicurezza"),
				new lBitInt(5, "vWe105_SNeP400PAIR", "vWe105.Pressostato presenza aria"),
				new lBitInt(6, "vWe106_PUeINDIETRO", "vWe106.Pulsante Indietro"),
				new lBitInt(7, "vWe107_PUeAVANTI", "vWe107.Pulsante Avanti"),
				new lBitInt(8, "vWe108_TEeP530RAFF", "vWe108.Contatto int.Pompa circolazione H2O"),
				new lBitInt(9, "vWe109_KMeP530RAFF", "vWe109.Contatto teleruttore Pompa circolazione H2O"),
				new lBitInt(10, "vWe110_DReP530__OK", "vWe110.Drive pompa circolazione OK H2O"),
				new lBitInt(11, "vWe111_LSeSERBNOHI", "vWe111.Livello Serbaoio Alto"),
				new lBitInt(12, "vWe112_LSeSERBNOLO", "vWe112.Livello serbatoio Basso"),
				new lBitInt(13, "vWe113_LSeSPUNOAIR", "vWe113.Livello Spurgo"),
				new lBitInt(14, "vWe114_OPeV190SVUO", "vWe114.Valvola scarico aperta"),
				new lBitInt(15, "vWe115_CLeV190SVUO", "vWe115.Valvola scarico chiusa")
			}),


			new wBitInt((int)wBitInt.types.We, 2, "We2", "We2", new lBitInt[]
			{
				new lBitInt(0, "vWe200_OPeV260MAND", "vWe200.Valvola mandata aperta"),
				new lBitInt(1, "vWe201_CLeV260MAND", "vWe201.Valvola mandata chiusa"),
				new lBitInt(2, "vWe202_OPeV320RITO", "vWe202.Valvola ritorno aperta"),
				new lBitInt(3, "vWe203_CLeV320RITO", "vWe203.Valvola ritorno chiusa"),
				new lBitInt(4, "vWe204_OPeV450PRES", "vWe204.Valvola pressione aperta"),
				new lBitInt(5, "vWe205_CLeV450PRES", "vWe205.Valvola pressione chiusa"),
				new lBitInt(6, "vWe206_OPeV360RAFF", "vWe206.Valvola raffreddamento aperta"),
				new lBitInt(7, "vWe207_CLeV360RAFF", "vWe207.Valvola raffreddamento chiusa"),
				new lBitInt(8, "vWe208_OPeV520INSE", "vWe208.Valvola inseguimento aperta"),
				new lBitInt(9, "vWe209_CLeV520INSE", "vWe209.Valvola inseguimento chiusa"),
				new lBitInt(10, "vWe210_PUeSTARAUTO", "vWe210.Pulsante marcia ciclo automatico"),
				new lBitInt(11, "vWe211_PUeSTOPAUTO", "vWe211.pulsante arresto ciclo automatico"),
				new lBitInt(12, "vWe212_PUeALARACKN", "vWe212.pulsante silenziamento allarmi"),
				new lBitInt(13, "vWe213_PUeALARREST", "vWe213.pulsante reset allarmi"),
				new lBitInt(14, "vWe214_SNeALLACHIL", "vWe214.Segnale chiller in allarme"),
				new lBitInt(15, "vWe215_SNeALLACIRC", "vWe215.Segnale allarme circolazione")
			}),


			new wBitInt((int)wBitInt.types.We, 3, "We3", "We3", new lBitInt[]
			{
				new lBitInt(0, "vWe300_", "vWe300_"),
				new lBitInt(1, "vWe301_", "vWe301_"),
				new lBitInt(2, "vWe302_", "vWe302_"),
				new lBitInt(3, "vWe303_", "vWe303_"),
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
				new lBitInt(0, "vWu000_CTuP120MAND", "vWu000.Comando potenza drive mandata"),
				new lBitInt(1, "vWu001_ENuP120MAND", "vWu001.Enable drive mandata"),
				new lBitInt(2, "vWu002_CTuP200CIRC", "vWu002.Comando potenza drive circolazione"),
				new lBitInt(3, "vWu003_ENuP200CIRC", "vWu003.Enable drive circolazione"),
				new lBitInt(4, "vWu004_CTuR210RISC", "vWu004.Comando potenza Riscaldo"),
				new lBitInt(5, "vWu005_RSuR210RISC", "vWu005.Com.Relè statico fase R"),
				new lBitInt(6, "vWu006_RSuS210RISC", "vWu006.Com.Relè statico fase S"),
				new lBitInt(7, "vWu007_RSuT210RISC", "vWu007.Com.Relè statico fase T"),
				new lBitInt(8, "vWu008_CTuS230EROG", "vWu008.Comando potenza azionamento siringa"),
				new lBitInt(9, "vWu009_SNuRISERV11", "vWu009.Riserva"),
				new lBitInt(10, "vWu010_CTuP530RAFF", "vWu010.Comando potenza drive cicrcolazione H20"),
				new lBitInt(11, "vWu011_ENuP530RAFF", "vWu011.Enable drive circolazione H20"),
				new lBitInt(12, "vWu012_YVuV190SVUO", "vWu012.Comando valvola scarico"),
				new lBitInt(13, "vWu013_YVuV260MAND", "vWu013.Comando valvola mandata"),
				new lBitInt(14, "vWu014_YVuV270SPUR", "vWu014.Comando valvola spurgo"),
				new lBitInt(15, "vWu015_YVuV320RITO", "vWu015.Comando valvola ritorno")
			}),


			new wBitInt((int)wBitInt.types.Wu, 1, "Wu1", "Wu1", new lBitInt[]
			{
				new lBitInt(0, "vWu100_YVuV370ChSc", "vWu100_0.Comando valvola scarico sic."),
				new lBitInt(1, "vWu101_YVuV420SUPP", "vWu101_0.Comando valvola immissione aria"),
				new lBitInt(2, "vWu102_YVuV450COMP", "vWu102_0.Comando valvola compensazione"),
				new lBitInt(3, "vWu103_OPuV360RAFF", "vWu103_1.Comando apertura valvola raffr."),
				new lBitInt(4, "vWu104_CLuV360RAFF", "vWu104_1.Comando chiusura valvola raffr."),
				new lBitInt(5, "vWu105_OPuV520INSE", "vWu105_1.Comando valvola inseguimento"),
				new lBitInt(6, "vWu106_CLuV520INSE", "vWu106_1.Comando valvola inseguimento"),
				new lBitInt(7, "vWu107_LBuTASTFUN1", "vWu107_1.Riserva"),
				new lBitInt(8, "vWu108_LBuTASTFUN2", "vWu108_1.Riserva"),
				new lBitInt(9, "vWu109_YVu200_SPUR", "vWu109_1.Comando valvola spurgo aria pompa circ."),
				new lBitInt(10, "vWu110_Riserva", "vWu110_1.Riserva"),
				new lBitInt(11, "vWu111_Riserva", "vWu111_0.Riserva"),
				new lBitInt(12, "vWu112_Riserva", "vWu112_0.Riserva"),
				new lBitInt(13, "vWu113_Riserva", "vWu113_0.Riserva"),
				new lBitInt(14, "vWu114_Riserva", "vWu114_0.Riserva"),
				new lBitInt(15, "vWu115_Riserva", "vWu115_0.Riserva")
			}),


			new wBitInt((int)wBitInt.types.Wu, 2, "Wu2", "Wu2", new lBitInt[]
			{
				new lBitInt(0, "vWu200_", "??????"),
				new lBitInt(1, "vWu201_", "??????"),
				new lBitInt(2, "vWu202_", "??????"),
				new lBitInt(3, "vWu203_", "??????"),
				new lBitInt(4, "vWu204_", "??????"),
				new lBitInt(5, "vWu205_", "??????"),
				new lBitInt(6, "vWu206_", "??????"),
				new lBitInt(7, "vWu207_", "??????"),
				new lBitInt(8, "vWu208_", "??????"),
				new lBitInt(9, "vWu209_", "??????"),
				new lBitInt(10, "vWu210_", "??????"),
				new lBitInt(11, "vWu211_", "??????"),
				new lBitInt(12, "vWu212_", "??????"),
				new lBitInt(13, "vWu213_", "??????"),
				new lBitInt(14, "vWu214_", "??????"),
				new lBitInt(15, "vWu215_", "??????")
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
				new lBitInt(0, "AL0_0_MSaF130EME2", "00 - anomalia misuratore portata"),
				new lBitInt(1, "AL0_1_SIaTutto_Ok", "01 - comandi inseriti"),
				new lBitInt(2, "AL0_2_TEaP120MAND", "02 - termica pompa mandata"),
				new lBitInt(3, "AL0_3_MSaF230RSIG", "03 - refr siringa"),
				new lBitInt(4, "AL0_4_KMaP120MAND", "04 - readback tele pompa P120"),
				new lBitInt(5, "AL0_5_MSaF340RANE", "05 - raffr. rane"),
				new lBitInt(6, "AL0_6_DRaP120OK", "06 - anomaliza drive pompa mandata"),
				new lBitInt(7, "AL0_7_MSaF250PRTA", "07 - refr. prta"),
				new lBitInt(8, "AL0_8_TEaP200CIRC", "08 - termica pompa circolazione"),
				new lBitInt(9, "AL0_9_KMaP200CIRC", "09 - readback tele pompa circolazioner"),
				new lBitInt(10, "AL0_a_DRaP200OK", "10 - anom. drive pompa circolazione"),
				new lBitInt(11, "AL0_b_TEaR210RISC", "11 - termica potenza riscaldatore"),
				new lBitInt(12, "AL0_c_KMaR210RISC", "12 - readback tele riscaldatore"),
				new lBitInt(13, "AL0_d_TEaS230EROG", "13 - termica siringa"),
				new lBitInt(14, "AL0_e_KMaS230EROG", "14 - readback siringa"),
				new lBitInt(15, "AL0_f_DRaS230OK", "15 - anomalia drive siringa")
			}),


			new wBitInt((int)wBitInt.types.Wa, 1, "Wa01", "Wa01", new lBitInt[]
			{
				new lBitInt(0, "AL1_0_TSaR210OK", "16 - termostato sicurezza riscaldatore"),
				new lBitInt(1, "AL1_1_SNaP400PAIR", "17 - presenza aria"),
				new lBitInt(2, "AL1_2_TEaP530RAFF", "18 - termica pompa raffreddamento"),
				new lBitInt(3, "AL1_3_KMaP530RAFF", "19 - readback tele pompa raffreddamento"),
				new lBitInt(4, "AL1_4_DRaP530__OK", "20 - anomalia drive pompa raffreddamento"),
				new lBitInt(5, "AL1_5_LSaSERBNOHI", "21 - serbatoio troppo pieno"),
				new lBitInt(6, "AL1_6_LSaSERBNOLO", "22 - allarme mancanza fluido"),
				new lBitInt(7, "AL1_7_LSaSPUNOAIR", "23 - timeout spurgo aria"),
				new lBitInt(8, "AL1_8_OPaV190SVUO", "24 - anomalia comando apertura valvola svuotamento"),
				new lBitInt(9, "AL1_9_CLaV190SVUO", "25 - anomalia comando chiusura valvola svuotamento"),
				new lBitInt(10, "AL1_a_OPaV260MAND", "26 - anomalia comando apertura valvola mandata"),
				new lBitInt(11, "AL1_b_CLaV260MAND", "27 - anomalia comando chiusura valvola mandata"),
				new lBitInt(12, "AL1_c_OPaV320RITO", "28 - anomalia comando apertura valvola ritorno"),
				new lBitInt(13, "AL1_d_CLaV320RITO", "29 - anomalia comando chiusura valvola ritorno"),
				new lBitInt(14, "AL1_e_OPaV450PRES", "30 - anomalia comando apertura valvola press"),
				new lBitInt(15, "AL1_f_CLaV450PRES", "31 - anomalia comando chiusura valvola press")
			}),


			new wBitInt((int)wBitInt.types.Wa, 2, "Wa02", "Wa02", new lBitInt[]
			{
				new lBitInt(0, "AL2_0_OPaV360RAFF", "32 - apertura valvola raffr"),
				new lBitInt(1, "AL2_1_CLaV360RAFF", "33 - chiusura valvola raffr"),
				new lBitInt(2, "AL2_2_OPaV520INSE", "34 - apertura valvola inseguimento"),
				new lBitInt(3, "AL2_3_CLaV520INSE", "35 - chiusura valvola inseguimento"),
				new lBitInt(4, "AL2_4_SQaSTEPUNDF", "36 - step indefinito"),
				new lBitInt(5, "AL2_5_SQaTESTLIVE", "37 - prova attiva"),
				new lBitInt(6, "AL2_6_Riserva", "38 - Riserva"),
				new lBitInt(7, "AL2_7_Riserva", "39 - Riserva"),
				new lBitInt(8, "AL2_8_Riserva", "40 - Riserva"),
				new lBitInt(9, "AL2_9_Riserva", "41 - Riserva"),
				new lBitInt(10, "AL2_a_Riserva", "42 - Riserva"),
				new lBitInt(11, "AL2_b_Riserva", "43 - Riserva"),
				new lBitInt(12, "AL2_c_Riserva", "44 - Riserva"),
				new lBitInt(13, "AL2_d_Riserva", "45 - Riserva"),
				new lBitInt(14, "AL2_e_Riserva", "46 - Riserva"),
				new lBitInt(15, "AL2_f_Riserva", "dummy")
			})
		};
	}
}
