using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	abstract class DonneesNiveau
	{
		//Cartes des niveaux
		private static Map carteNiveau1 = new Map(5, 5);
		private static Map carteNiveau2 = new Map(5, 5);
		private static Map carteNiveau3 = new Map(5, 5);

		//Element des niveaux
		MapElement personnagePrincipal = new MapElement();

		//*************************************************
		//					LES NIVEAUX
		//*************************************************

		//***********************************
		//				NIVEAU 1
		//***********************************
		public static Niveau niveau1 = new Niveau(carteNiveau1, "La grandeur des petits débuts", 1, "AEX171", true);

		static int[] positionMessage1Niveau1 = { 3, 2 };
		static int[] positionMessage2Niveau1 = { 4, 4 };
		public static MessageElement message1Niveau1 = new MessageElement(false, positionMessage1Niveau1, 'M', "Les cases M vous donnent une information.");
		public static MessageElement message2Niveau1 = new MessageElement(false, positionMessage2Niveau1, 'M', "Les cases S indiquent la sortie");

		//***********************************
		//				NIVEAU 2
		//***********************************
		public static Niveau niveau2 = new Niveau(carteNiveau2, "Sans effort, pas de gloire", 2, "BGF211", false);

		//***********************************
		//				NIVEAU 3
		//***********************************
		public static Niveau niveau3 = new Niveau(carteNiveau3, "Niveau 3", 3, "HDE841", false);

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
