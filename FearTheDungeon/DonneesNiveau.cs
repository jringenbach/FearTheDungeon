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

		#region niveau1
		//***********************************
		//				NIVEAU 1             ****************************************************************************************
		//***********************************

		private static Map carteNiveau1 = new Map(5, 5);

		//CREATION DES ELEMENTS DU NIVEAU 1

		//Les cases message
		public static MessageElement message1Niveau1 = new MessageElement(3, 2, "Les cases M vous donnent une information.");
		public static MessageElement message2Niveau1 = new MessageElement(4, 4, "Les cases S indiquent la sortie");
		public static MessageElement[] messagesNiveau1 = { message1Niveau1, message2Niveau1 };

		//Les cases mur
		public static Mur murligne1colonne0niveau1 = new Mur(1, 0);
		public static Mur murligne1colonne1niveau1 = new Mur(1, 1);
		public static Mur murligne1colonne2niveau1 = new Mur(1, 2);
		public static Mur murligne1colonne3niveau1 = new Mur(1, 3);
		public static Mur murligne3colonne1niveau1 = new Mur(3, 1);
		public static Mur murligne4colonne1niveau1 = new Mur(4, 1);
		public static Mur murligne3colonne3niveau1 = new Mur(3, 3);
		public static Mur murligne3colonne4niveau1 = new Mur(4, 3);

		//Case sortie niveau 1
		public static SortieElement sortieNiveau1 = new SortieElement(0, 0);

		public static Niveau niveau1 = new Niveau(carteNiveau1, "La grandeur des petits débuts", 1, "AEX171", true);
		#endregion

		#region Niveau2
		//***********************************
		//				NIVEAU 2             ****************************************************************************************
		//***********************************

		//CREATION DES ELEMENTS DU NIVEAU 2
		private static Map carteNiveau2 = new Map(5, 5);

		//Case Bloc
		public static Bloc blocNiveau2 = new Bloc(1,2);

		//Les cases message
		public static MessageElement message1Niveau2 = new MessageElement(3, 4, "Les cases B représentent des blocs.");
		public static MessageElement message2Niveau2 = new MessageElement(3, 2, "Vous pouvez pousser les blocs B");
		public static MessageElement message3Niveau2 = new MessageElement(0, 0, "Ces pièces sont étroites, non ?");

		//Les cases mur
		public static Mur murligne0colonne1niveau2 = new Mur(0, 1);
		public static Mur murligne2colonne1niveau2 = new Mur(2, 1);
		public static Mur murligne3colonne1niveau2 = new Mur(3, 1);
		public static Mur murligne4colonne1niveau2 = new Mur(4, 1);
		public static Mur murligne0colonne3niveau2 = new Mur(0, 3);
		public static Mur murligne1colonne3niveau2 = new Mur(1, 3);
		public static Mur murligne2colonne3niveau2 = new Mur(2, 3);
		public static Mur murligne3colonne3niveau2 = new Mur(3, 3);

		//Case sortie niveau 2
		public static SortieElement sortieNiveau2 = new SortieElement(4, 0);

		public static Niveau niveau2 = new Niveau(carteNiveau2, "Sans effort, pas de gloire", 2, "BGF211", false);

		#endregion

		#region niveau3
		//***********************************
		//				NIVEAU 3             ****************************************************************************************
		//***********************************

		private static Map carteNiveau3 = new Map(5, 5);

		public static Niveau niveau3 = new Niveau(carteNiveau3, "Le prince des chips", 3, "HDE841", false);
		#endregion

		//***************************************************************************************************************************

		/// <summary>
		/// Contient tous les niveaux du jeu
		/// </summary>
		public static Niveau[] tableauNiveaux = { niveau1, niveau2, niveau3};
		public static MessageElement[][] tousLesMessages = { messagesNiveau1 };

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
