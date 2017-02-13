using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	/// <summary>
	/// Stocke toutes les données relatives aux niveaux du jeu.
	/// </summary>
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
		public static MessageElement message1Niveau1 = new MessageElement(3, 2, "Les cases M vous donnent une information");
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
		public static MessageElement message1Niveau2 = new MessageElement(3, 4, "Les cases B représentent des blocs");
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

		private static Map carteNiveau3 = new Map(6, 6);

		//Case Bloc
		public static Bloc blocNiveau3 = new Bloc(1, 3);

		//Les cases message
		public static MessageElement message1Niveau3 = new MessageElement(0, 5, "Pour recharger le niveau. Appuyez sur 5");
		public static MessageElement message2Niveau3 = new MessageElement(4, 1, "Vous avez bloqué la sortie, n'est-ce pas ?");

		//Les cases mur
		public static Mur murligne1colonne0niveau3 = new Mur(1, 0);
		public static Mur murligne1colonne1niveau3 = new Mur(1, 1);
		public static Mur murligne1colonne2niveau3 = new Mur(1, 2);
		public static Mur murligne1colonne4niveau3 = new Mur(1, 4);
		public static Mur murligne1colonne5niveau3 = new Mur(1, 5);

		public static Mur murligne2colonne0niveau3 = new Mur(2, 0);
		public static Mur murligne2colonne2niveau3 = new Mur(2, 2);
		public static Mur murligne2colonne5niveau3 = new Mur(2, 5);

		public static Mur murligne3colonne1niveau3 = new Mur(3, 0);
		public static Mur murligne3colonne5niveau3 = new Mur(3, 5);

		public static Mur murligne4colonne0niveau3 = new Mur(4, 0);
		public static Mur murligne4colonne2niveau3 = new Mur(4, 2);
		public static Mur murligne4colonne4niveau3 = new Mur(4, 4);
		public static Mur murligne4colonne5niveau3 = new Mur(4, 5);

		public static Mur murligne5colonne0niveau3 = new Mur(5, 0);
		public static Mur murligne5colonne1niveau3 = new Mur(5, 1);
		public static Mur murligne5colonne2niveau3 = new Mur(5, 2);
		public static Mur murligne5colonne4niveau3 = new Mur(5, 4);
		public static Mur murligne5colonne5niveau3 = new Mur(5, 5);

		//La case Sortie
		public static SortieElement sortieNiveau3 = new SortieElement(5,3);


		public static Niveau niveau3 = new Niveau(carteNiveau3, "On dirait un tutoriel", 3, "HDE841", false);
		#endregion

		#region niveau4
		//***********************************
		//				NIVEAU 4             ****************************************************************************************
		//***********************************

		private static Map carteNiveau4 = new Map(8, 5);

		//La case Porte
		public static Porte porteNiveau4 = new Porte(6, 2, false);

		//Case Bloc
		public static Bloc blocNiveau4 = new Bloc(1, 2);

		//Case Bouton
		public static Bouton boutonNiveau4 = new Bouton(2,0, porteNiveau4);

		//Les cases message
		public static MessageElement message1Niveau4 = new MessageElement(0, 3, "Les cases P sont des portes");
		public static MessageElement message2Niveau4 = new MessageElement(2, 4, "Poussez le bloc B sur le bouton b");
		public static MessageElement message3Niveau4 = new MessageElement(4, 1, "Vous êtes à bloc pour la suite ?");
		public static MessageElement message4Niveau4 = new MessageElement(4, 0, "Insérez une blague ici");

		//Les cases mur
		public static Mur murligne0colonne0niveau4 = new Mur(0, 0);
		public static Mur murligne0colonne1niveau4 = new Mur(0, 1);
		public static Mur murligne1colonne0niveau4 = new Mur(1, 0);
		public static Mur murligne1colonne1niveau4 = new Mur(1, 1);
		public static Mur murligne3colonne0niveau4 = new Mur(3, 0);
		public static Mur murligne3colonne1niveau4 = new Mur(3, 1);

		public static Mur murligne4colonne2niveau4 = new Mur(4, 2);
		public static Mur murligne5colonne2niveau4 = new Mur(5, 2);
		public static Mur murligne7colonne2niveau4 = new Mur(7, 2);

		public static Mur murligne1colonne3niveau4 = new Mur(1, 3);
		public static Mur murligne3colonne3niveau4 = new Mur(3, 3);

		//La case Sortie
		public static SortieElement sortieNiveau4 = new SortieElement(7, 0);

		public static Niveau niveau4 = new Niveau(carteNiveau4, "Vaincre l'invaincu", 4, "ODT48E", false);
		#endregion

		#region niveau5
		//***********************************
		//				NIVEAU 5             ****************************************************************************************
		//***********************************

		private static Map carteNiveau5 = new Map(9, 5);

		//La case Porte
		public static Porte porteNiveau5 = new Porte(7, 3, false);

		//Case Bloc
		public static Bloc blocNiveau5 = new Bloc(2, 3);

		//Case Bouton
		public static Bouton boutonNiveau5 = new Bouton(3, 4, porteNiveau5);

		//Les cases message
		public static MessageElement message1Niveau5 = new MessageElement(0, 0, "Pousse ce bloc ma kikoune !");
		public static MessageElement message2Niveau5 = new MessageElement(7, 1, "Réfléchissez avant d'agir !");

		//Les cases mur
		public static Mur murligne0colonne1niveau5 = new Mur(0, 1);
		public static Mur murligne1colonne1niveau5 = new Mur(1, 1);
		public static Mur murligne3colonne1niveau5 = new Mur(3, 1);
		public static Mur murligne4colonne1niveau5 = new Mur(4, 1);
		public static Mur murligne5colonne1niveau5 = new Mur(5, 1);
		public static Mur murligne6colonne1niveau5 = new Mur(6, 1);

		public static Mur murligne1colonne3niveau5 = new Mur(1, 3);
		public static Mur murligne3colonne3niveau5 = new Mur(3, 3);
		public static Mur murligne4colonne3niveau5 = new Mur(4, 3);
		public static Mur murligne5colonne3niveau5 = new Mur(5, 3);
		public static Mur murligne6colonne3niveau5 = new Mur(6, 3);
		public static Mur murligne8colonne3niveau5 = new Mur(8, 3);

		public static Mur murligne6colonne4niveau5 = new Mur(6, 4);
		public static Mur murligne8colonne4niveau5 = new Mur(8, 4);

		//La case Sortie
		public static SortieElement sortieNiveau5 = new SortieElement(7, 4);

		public static Niveau niveau5 = new Niveau(carteNiveau5, "Nuit d'ivresse", 5, "VRP666", false);
		#endregion

		#region niveau6
		//***********************************
		//				NIVEAU 6             ****************************************************************************************
		//***********************************

		private static Map carteNiveau6 = new Map(8, 9);

		//La case Porte
		public static Porte porteNiveau6 = new Porte(6, 7, false);

		//Case Bloc
		public static Bloc blocNiveau6 = new Bloc(5, 5);

		//Case Bouton
		public static Bouton boutonNiveau6 = new Bouton(6, 2, porteNiveau6);

		//Les cases message
		public static MessageElement message1Niveau6 = new MessageElement(3, 0, "On avance, on avance, on avance !");
		public static MessageElement message2Niveau6 = new MessageElement(7, 6, "Mot de passe : 879121");

		//Les cases mur

		//Colonne 0
		public static Mur murligne4colonne0niveau6 = new Mur(4, 0);
		public static Mur murligne5colonne0niveau6 = new Mur(5, 0);
		public static Mur murligne6colonne0niveau6 = new Mur(6, 0);
		public static Mur murligne7colonne0niveau6 = new Mur(7, 0);

					//Colonne 1
		public static Mur murligne4colonne1niveau6 = new Mur(4, 1);
		public static Mur murligne5colonne1niveau6 = new Mur(5, 1);
		public static Mur murligne6colonne1niveau6 = new Mur(6, 1);
		public static Mur murligne7colonne1niveau6 = new Mur(7, 1);

					//Colonne 2
		public static Mur murligne0colonne2niveau6 = new Mur(0, 2);
		public static Mur murligne7colonne2niveau6 = new Mur(7, 2);

					//Colonne 3
		public static Mur murligne0colonne3niveau6 = new Mur(0, 3);
		public static Mur murligne1colonne3niveau6 = new Mur(1, 3);
		public static Mur murligne2colonne3niveau6 = new Mur(2, 3);
		public static Mur murligne4colonne3niveau6 = new Mur(4, 3);
		public static Mur murligne5colonne3niveau6 = new Mur(5, 3);
		public static Mur murligne6colonne3niveau6 = new Mur(6, 3);
		public static Mur murligne7colonne3niveau6 = new Mur(7, 3);

					//Colonne 4
		public static Mur murligne0colonne4niveau6 = new Mur(0, 4);
		public static Mur murligne1colonne4niveau6 = new Mur(1, 4);
		public static Mur murligne2colonne4niveau6 = new Mur(2, 4);
		public static Mur murligne6colonne4niveau6 = new Mur(6, 4);
		public static Mur murligne7colonne4niveau6 = new Mur(7, 4);

					//Colonne 5
		public static Mur murligne0colonne5niveau6 = new Mur(0, 5);
		public static Mur murligne1colonne5niveau6 = new Mur(1, 5);
		public static Mur murligne2colonne5niveau6 = new Mur(2, 5);
		public static Mur murligne7colonne5niveau6 = new Mur(7, 5);

					//Colonne 6
		public static Mur murligne0colonne6niveau6 = new Mur(0, 6);
		public static Mur murligne1colonne6niveau6 = new Mur(1, 6);
		public static Mur murligne2colonne6niveau6 = new Mur(2, 6);
		public static Mur murligne3colonne6niveau6 = new Mur(3, 6);

					//Colonne 7
		public static Mur murligne0colonne7niveau6 = new Mur(0, 7);
		public static Mur murligne1colonne7niveau6 = new Mur(1, 7);
		public static Mur murligne2colonne7niveau6 = new Mur(2, 7);
		public static Mur murligne3colonne7niveau6 = new Mur(3, 7);
		public static Mur murligne4colonne7niveau6 = new Mur(4, 7);
		public static Mur murligne5colonne7niveau6 = new Mur(5, 7);
		public static Mur murligne7colonne7niveau6 = new Mur(7, 7);

					//Colonne 8
		public static Mur murligne0colonne8niveau6 = new Mur(0, 8);
		public static Mur murligne1colonne8niveau6 = new Mur(1, 8);
		public static Mur murligne2colonne8niveau6 = new Mur(2, 8);
		public static Mur murligne3colonne8niveau6 = new Mur(3, 8);
		public static Mur murligne4colonne8niveau6 = new Mur(4, 8);
		public static Mur murligne5colonne8niveau6 = new Mur(5, 8);
		public static Mur murligne7colonne8niveau6 = new Mur(7, 8);

		//La case Sortie
		public static SortieElement sortieNiveau6 = new SortieElement(6, 8);

		public static Niveau niveau6 = new Niveau(carteNiveau6, "Une salle sale", 6, "784UIO", false);
		#endregion

		#region niveau7
		//***********************************
		//				NIVEAU 7             ****************************************************************************************
		//***********************************

		private static Map carteNiveau7 = new Map(12, 3);

		//Les cases Message
		public static MessageElement message1Niveau7 = new MessageElement(10, 0, "Les cases D sont des cases \"Danger\"");
		public static MessageElement message2Niveau7 = new MessageElement(9, 1, "Marcher sur une case D recharge le niveau");
		public static MessageElement message3Niveau7 = new MessageElement(3, 0, "Vous êtes sur la bonne voie");
		public static MessageElement message4Niveau7 = new MessageElement(7, 6, "Attention à la marche !");

		//Les cases Danger

				//colonne 0
		public static DangerElement Dangerligne0colonne0niveau7 = new DangerElement(0, 0);
		public static DangerElement Dangerligne1colonne0niveau7 = new DangerElement(1, 0);
		public static DangerElement Dangerligne6colonne0niveau7 = new DangerElement(6, 0);
		public static DangerElement Dangerligne7colonne0niveau7 = new DangerElement(7, 0);
		public static DangerElement Dangerligne8colonne0niveau7 = new DangerElement(8, 0);

				//colonne 1
		public static DangerElement Dangerligne1colonne1niveau7 = new DangerElement(1, 1);
		public static DangerElement Dangerligne3colonne1niveau7 = new DangerElement(3, 1);
		public static DangerElement Dangerligne5colonne1niveau7 = new DangerElement(5, 1);
		public static DangerElement Dangerligne11colonne1niveau7 = new DangerElement(11, 1);

				//colonne 2
		public static DangerElement Dangerligne3colonne2niveau7 = new DangerElement(3, 2);
		public static DangerElement Dangerligne7colonne2niveau7 = new DangerElement(7, 2);
		public static DangerElement Dangerligne8colonne2niveau7 = new DangerElement(8, 2);
		public static DangerElement Dangerligne9colonne2niveau7 = new DangerElement(9, 2);
		public static DangerElement Dangerligne10colonne2niveau7 = new DangerElement(10, 2);
		public static DangerElement Dangerligne11colonne2niveau7 = new DangerElement(11, 2);

		//La case Sortie
		public static SortieElement sortieNiveau7 = new SortieElement(0, 1);

		public static Niveau niveau7 = new Niveau(carteNiveau7, "On s'habitue vite", 7, "202JKA", false);
		#endregion

		#region niveau8
		//***********************************
		//				NIVEAU 8             ****************************************************************************************
		//***********************************

		private static Map carteNiveau8 = new Map(12, 3);

		public static Niveau niveau8 = new Niveau(carteNiveau8, "On s'habitue vite", 7, "202JKA", false);
		#endregion

		#region niveau9
		//***********************************
		//				NIVEAU 9             ****************************************************************************************
		//***********************************

		private static Map carteNiveau9 = new Map(12, 3);

		public static Niveau niveau9 = new Niveau(carteNiveau9, "On s'habitue vite", 7, "202JKA", false);
		#endregion

		#region niveau10
		//***********************************
		//				NIVEAU 10            ****************************************************************************************
		//***********************************

		private static Map carteNiveau10 = new Map(12, 3);

		public static Niveau niveau10 = new Niveau(carteNiveau10, "On s'habitue vite", 7, "202JKA", false);
		#endregion

		//***************************************************************************************************************************

		/// <summary>
		/// Contient tous les niveaux du jeu
		/// </summary>
		public static Niveau[] tableauNiveaux = { niveau1, niveau2, niveau3, niveau4, niveau5, niveau6, niveau7, niveau8, niveau9, niveau10};

		//***********************************
		//				METHODES
		//***********************************

		/// <summary>
		/// On ajout un élément dans le niveau
		/// </summary>
		/// <param name="niveau">Niveau du jeu</param>
		/// <param name="element">Element contenu dans donneesNiveau qui sera ajouté au tableau d'élément du niveau envoyé en paramètre de la fonction</param>
		public void AjouterElement(Niveau niveau, MapElement element)
		{
			Array.Resize(ref niveau.elementsDuNiveau, niveau.elementsDuNiveau.Length + 1);
			niveau.elementsDuNiveau[niveau.elementsDuNiveau.Length - 1] = element;
		}
	}
}
