using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	abstract class DonneesNiveau
	{

		public static MapElement personnagePrincipal = new MapElement(true, '*');

		//*************************************************
		//					LES NIVEAUX
		//*************************************************

		//***********************************
		//				NIVEAU 1             ****************************************************************************************
		//***********************************

		private static Map carteNiveau1 = new Map(5, 5);

		public static Niveau niveau1 = new Niveau(carteNiveau1, "La grandeur des petits débuts", 1, "AEX171", true);

		static int[] positionMessage1Niveau1 = { 3, 2 };
		static int[] positionMessage2Niveau1 = { 4, 4 };
		static int[] positionSortieNiveau1 = { 0, 0 };

		public static MessageElement message1Niveau1 = new MessageElement(false, positionMessage1Niveau1, "Les cases M vous donnent une information.");
		public static MessageElement message2Niveau1 = new MessageElement(false, positionMessage2Niveau1, "Les cases S indiquent la sortie");
		public static SortieElement sortieNiveau1 = new SortieElement(false, positionSortieNiveau1);

		//***********************************
		//				NIVEAU 2             ****************************************************************************************
		//***********************************

		private static Map carteNiveau2 = new Map(5, 5);

		public static Niveau niveau2 = new Niveau(carteNiveau2, "Sans effort, pas de gloire", 2, "BGF211", false);

		//***********************************
		//				NIVEAU 3             ****************************************************************************************
		//***********************************

		private static Map carteNiveau3 = new Map(5, 5);

		public static Niveau niveau3 = new Niveau(carteNiveau3, "Le prince des chips", 3, "HDE841", false);

		//***************************************************************************************************************************

		/// <summary>
		/// Contient tous les niveaux du jeu
		/// </summary>
		public static Niveau[] tableauNiveaux = { niveau1, niveau2, niveau3};

		//***********************************
		//				METHODES
		//***********************************

		/// <summary>
		/// On ajout un élément dans le niveau
		/// </summary>
		/// <param name="niveau"></param>
		/// <param name="element"></param>
		public void AjouterElement(Niveau niveau, MapElement element)
		{
			Array.Resize(ref niveau.elementsDuNiveau, niveau.elementsDuNiveau.Length + 1);
			niveau.elementsDuNiveau[niveau.elementsDuNiveau.Length - 1] = element;
		}
	}
}
