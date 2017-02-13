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

		/// <summary>
		/// Définit le nombre de murs créés que l'on pourra aller charger dans un niveau
		/// </summary>
		private static int nombreDeMurs = 20;

		/// <summary>
		/// Définit le nombre de dangers créés que l'on pourra charger dans un niveau
		/// </summary>
		private static int nombreDeDangers = 20;

		/// <summary>
		/// Stocke tous les murs. Leur position dans ce tableau est équivalente à leur position sur la map du niveau lorsqu'ils seront chargés
		/// </summary>
		public static Mur[,] tableauDeMurs = new Mur[nombreDeMurs,nombreDeMurs];

		/// <summary>
		/// Stocke tous les dangers. Leur position dans ce tableau est équivalente à leur position sur la map du niveau lorsqu'ils seront chargés
		/// </summary>
		public static DangerElement[,] tableauDeDangers = new DangerElement[nombreDeDangers, nombreDeDangers];


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

		//La case Sortie
		public static SortieElement sortieNiveau7 = new SortieElement(0, 1);

		public static Niveau niveau7 = new Niveau(carteNiveau7, "On s'habitue vite", 7, "202JKA", false);
		#endregion

		#region niveau8
		//***********************************
		//				NIVEAU 8             ****************************************************************************************
		//***********************************

		private static Map carteNiveau8 = new Map(8, 7);

		//La case Porte
		public static Porte porteNiveau8 = new Porte(6, 5, false);

		//Case Bloc
		public static Bloc blocNiveau8 = new Bloc(1, 5);

		//Case Bouton
		public static Bouton boutonNiveau8 = new Bouton(2, 0, porteNiveau8);

		//Les cases Message
		public static MessageElement message1Niveau8 = new MessageElement(6, 3, "Mais que sont ces dangers ?");
		public static MessageElement message2Niveau8 = new MessageElement(4, 1, "Des piques ?");
		public static MessageElement message3Niveau8 = new MessageElement(1, 3, "De la lave ?");
		public static MessageElement message4Niveau8 = new MessageElement(7, 5, "Ou des \"D\" volants mangeurs d'hommes ?");

		//La case Sortie
		public static SortieElement sortieNiveau8 = new SortieElement(7, 6);


		public static Niveau niveau8 = new Niveau(carteNiveau8, "Des dangers inconnus", 8, "666MDP", false);
		#endregion

		#region niveau9
		//***********************************
		//				NIVEAU 9             ****************************************************************************************
		//***********************************

		private static Map carteNiveau9 = new Map(5, 7);

		//La case Manivelle
		public static Manivelle manivelleNiveau9 = new Manivelle(0,6);

		//Les cases Message
		public static MessageElement message1Niveau9 = new MessageElement(2, 1, "m ? Mais qu'est-ce que c'est ?");
		public static MessageElement message2Niveau9 = new MessageElement(2, 1, "m est une manivelle ! ");

		//La case Sortie
		public static SortieElement sortieNiveau9 = new SortieElement(4, 0);

		public static Niveau niveau9 = new Niveau(carteNiveau9, "Ce tutoriel n'en finit pas", 9, "VIP007", false);
		#endregion

		#region niveau10
		//***********************************
		//				NIVEAU 10            ****************************************************************************************
		//***********************************

		private static Map carteNiveau10 = new Map(9, 11);

		//La case Manivelle
		public static Manivelle manivelle1Niveau10 = new Manivelle(4, 4);

		//Les cases Porte
		public static Porte porteNiveau10 = new Porte(4,9, false);

		//La case Bloc
		public static Bloc blocNiveau10 = new Bloc(1, 8);

		//La case Bouton
		public static Bouton boutonNiveau10 = new Bouton(4,2, porteNiveau10);

		//Les cases Message
		public static MessageElement message1Niveau10 = new MessageElement(5, 0, "On prend les mêmes et on recommence !");
		public static MessageElement message2Niveau10 = new MessageElement(8, 4, "Où sont passés les murs classiques ?");
		public static MessageElement message3Niveau10 = new MessageElement(4, 8, "Silence ! Ca tourne !");

		public static MessageElement message4Niveau10 = new MessageElement(5, 0, "Mot de passe : 987654");
		public static MessageElement message5Niveau10 = new MessageElement(8, 4, "J'aimerais bien t'aider...");
		public static MessageElement message6Niveau10 = new MessageElement(4, 8, "J'aimerais bien te sortir de là...");

		//La case Sortie
		public static SortieElement sortieNiveau10 = new SortieElement(4, 10);

		public static Niveau niveau10 = new Niveau(carteNiveau10, "L'oeil du cyclope... euh cyclone", 10, "45AEZB", false);
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

		/// <summary>
		/// Permet d'initialiser un tableau de murs contenant les murs que l'on viendra charger pour afficher un niveau
		/// </summary>
		/// <param name="mur">Tableau de mur que l'on va remplir</param>
		static public void ChargementDesMurs(Mur[,] mur)
		{
			for (int i = 0; i < nombreDeMurs; i++)
			{
				for (int j = 0; j < nombreDeMurs; j++)
				{
					mur[i, j] = new Mur(i, j);
				}
			}
		}

		/// <summary>
		/// Permet d'initialiser un tableau de dangers contenant les dangers que l'on viendra charger pour un niveau
		/// </summary>
		/// <param name="danger">Tableau de dangers stocké en mémoire que l'on viendra charger lorsqu'on en aura besoin lors du chargement d'un niveau</param>
		static public void ChargementDesDangers(DangerElement[,] danger)
		{
			for (int i = 0; i < nombreDeDangers; i++)
			{
				for (int j = 0; j < nombreDeDangers; j++)
				{
					danger[i, j] = new DangerElement(i, j);
				}
			}
		}
	}
}
