using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	/// <summary>
	/// Contient toutes les fonctions d'initialisation des niveaux du programme
	/// </summary>
	abstract class Initialisations
	{

		/// <summary>
		/// Initialise les données du niveau 1
		/// </summary>
		public static void InitialisationNiveau1()
		{
			//Nombre d'éléments : 13
			//ON AJOUTE LES ELEMENTS DU NIVEAU STOCKES DANS DONNEESNIVEAU CONCERNANT LE NIVEAU 1
			DonneesNiveau.niveau1.ResetNiveau();

						//Les cases message
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.message1Niveau1);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.message2Niveau1);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.message3Niveau1);


			//Les murs
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.tableauDeMurs[1,0]);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.tableauDeMurs[1, 1]);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.tableauDeMurs[1, 2]);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.tableauDeMurs[1, 3]);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.tableauDeMurs[3, 1]);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.tableauDeMurs[3, 3]);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.tableauDeMurs[3, 4]);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.tableauDeMurs[4, 1]);

						//La sortie du niveau
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.sortieNiveau1);

			//On définit la position du personnage principal au début du niveau
			DonneesNiveau.personnagePrincipal.PositionElement[0] = 4; //En X
			DonneesNiveau.personnagePrincipal.PositionElement[1] = 2; //En Y
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.personnagePrincipal);
		}

		/// <summary>
		/// Initialise les données du niveau 2
		/// </summary>
		public static void InitialisationNiveau2()
		{
			//Nombre d'éléments : 14
			//ON AJOUTE LES ELEMENTS DU NIVEAU STOCKES DANS DONNEESNIVEAU CONCERNANT LE NIVEAU 2

			DonneesNiveau.niveau2.ResetNiveau();

			//La case Bloc
			DonneesNiveau.niveau2.AjoutMapElement(DonneesNiveau.blocNiveau2);

			//Les cases message
			DonneesNiveau.niveau2.AjoutMapElement(DonneesNiveau.message1Niveau2);
			DonneesNiveau.niveau2.AjoutMapElement(DonneesNiveau.message2Niveau2);
			DonneesNiveau.niveau2.AjoutMapElement(DonneesNiveau.message3Niveau2);

			//Les murs
			DonneesNiveau.niveau2.AjoutMapElement(DonneesNiveau.tableauDeMurs[0,1]);
			DonneesNiveau.niveau2.AjoutMapElement(DonneesNiveau.tableauDeMurs[2, 1]);
			DonneesNiveau.niveau2.AjoutMapElement(DonneesNiveau.tableauDeMurs[3, 1]);
			DonneesNiveau.niveau2.AjoutMapElement(DonneesNiveau.tableauDeMurs[4, 1]);
			DonneesNiveau.niveau2.AjoutMapElement(DonneesNiveau.tableauDeMurs[0, 3]);
			DonneesNiveau.niveau2.AjoutMapElement(DonneesNiveau.tableauDeMurs[1, 3]);
			DonneesNiveau.niveau2.AjoutMapElement(DonneesNiveau.tableauDeMurs[2, 3]);
			DonneesNiveau.niveau2.AjoutMapElement(DonneesNiveau.tableauDeMurs[3, 3]);

			//La sortie du niveau
			DonneesNiveau.niveau2.AjoutMapElement(DonneesNiveau.sortieNiveau2);

			//On définit la position du personnage principal au début du niveau
			DonneesNiveau.personnagePrincipal.PositionElement[0] = 0; //En X
			DonneesNiveau.personnagePrincipal.PositionElement[1] = 4; //En Y
			DonneesNiveau.niveau2.AjoutMapElement(DonneesNiveau.personnagePrincipal);

			InitialisationDesBlocs(DonneesNiveau.niveau2);

		}

		/// <summary>
		/// Initialise les données du niveau 3
		/// </summary>
		public static void InitialisationNiveau3()
		{
			DonneesNiveau.niveau3.ResetNiveau();

			//La case Bloc
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.blocNiveau3);

			//Les cases message
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.message1Niveau3);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.message2Niveau3);

			//Les cases Mur
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.tableauDeMurs[1, 0]);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.tableauDeMurs[1, 1]);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.tableauDeMurs[1, 2]);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.tableauDeMurs[1, 4]);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.tableauDeMurs[1, 5]);

			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.tableauDeMurs[2, 0]);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.tableauDeMurs[2, 2]);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.tableauDeMurs[2, 5]);

			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.tableauDeMurs[3, 0]);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.tableauDeMurs[3, 5]);

			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.tableauDeMurs[4, 0]);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.tableauDeMurs[4, 2]);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.tableauDeMurs[4, 4]);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.tableauDeMurs[4, 5]);

			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.tableauDeMurs[5, 0]);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.tableauDeMurs[5, 1]);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.tableauDeMurs[5, 2]);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.tableauDeMurs[5, 4]);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.tableauDeMurs[5, 5]);

			//La case sortie
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.sortieNiveau3);

			//On définit la position du personnage principal au début du niveau
			DonneesNiveau.personnagePrincipal.PositionElement[0] = 0; //En X
			DonneesNiveau.personnagePrincipal.PositionElement[1] = 3; //En Y
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.personnagePrincipal);

			InitialisationDesBlocs(DonneesNiveau.niveau3);
		}

		/// <summary>
		/// Initialise les données du niveau 4
		/// </summary>
		public static void InitialisationNiveau4()
		{
			DonneesNiveau.niveau4.ResetNiveau();

			//La case Bloc
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.blocNiveau4);

			//La case bouton
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.boutonNiveau4);

			//Les cases message
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.message1Niveau4);
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.message2Niveau4);
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.message3Niveau4);
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.message4Niveau4);

			//Les cases Mur
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.tableauDeMurs[0, 0]);
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.tableauDeMurs[0, 1]);

			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.tableauDeMurs[1, 0]);
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.tableauDeMurs[1, 1]);

			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.tableauDeMurs[3, 0]);
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.tableauDeMurs[3, 1]);

			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.tableauDeMurs[4, 2]);
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.tableauDeMurs[5, 2]);
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.tableauDeMurs[7, 2]);

			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.tableauDeMurs[1, 3]);
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.tableauDeMurs[3, 3]);

			//La case porte
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.porteNiveau4);
			DonneesNiveau.niveau4.AjoutPorte(DonneesNiveau.porteNiveau4);

			//La case sortie
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.sortieNiveau4);

			//On définit la position du personnage principal au début du niveau
			DonneesNiveau.personnagePrincipal.PositionElement[0] = 0; //En X
			DonneesNiveau.personnagePrincipal.PositionElement[1] = 2; //En Y
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.personnagePrincipal);

			InitialisationDesBlocs(DonneesNiveau.niveau4);
			InitialisationDesPortes(DonneesNiveau.niveau4);
		}

		/// <summary>
		/// Initialise les données du niveau 5
		/// </summary>
		public static void InitialisationNiveau5()
		{
			DonneesNiveau.niveau5.ResetNiveau();

			//La case Bloc
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.blocNiveau5);

			//La case bouton
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.boutonNiveau5);

			//Les cases message
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.message1Niveau5);
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.message2Niveau5);


			//Les cases Mur
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.tableauDeMurs[0, 1]);
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.tableauDeMurs[1, 1]);
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.tableauDeMurs[3, 1]);
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.tableauDeMurs[4, 1]);
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.tableauDeMurs[5, 1]);
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.tableauDeMurs[6, 1]);

			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.tableauDeMurs[1, 3]);
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.tableauDeMurs[3, 3]);
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.tableauDeMurs[4, 3]);
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.tableauDeMurs[5, 3]);
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.tableauDeMurs[6, 3]);
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.tableauDeMurs[8, 3]);

			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.tableauDeMurs[6, 4]);
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.tableauDeMurs[8, 4]);

			//La case porte
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.porteNiveau5);
			DonneesNiveau.niveau5.AjoutPorte(DonneesNiveau.porteNiveau5);

			//La case sortie
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.sortieNiveau5);

			//On définit la position du personnage principal au début du niveau
			DonneesNiveau.personnagePrincipal.PositionElement[0] = 5; //En X
			DonneesNiveau.personnagePrincipal.PositionElement[1] = 4; //En Y
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.personnagePrincipal);

			InitialisationDesBlocs(DonneesNiveau.niveau5);
			InitialisationDesPortes(DonneesNiveau.niveau5);
		}

		/// <summary>
		/// Initialise les données du niveau 6
		/// </summary>
		public static void InitialisationNiveau6()
		{
			DonneesNiveau.niveau6.ResetNiveau();

			//La case Bloc
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.blocNiveau6);

			//La case bouton
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.boutonNiveau6);
		
			//Les cases message
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.message1Niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.message2Niveau6);

			//La case sortie
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.sortieNiveau6);

			//Les cases Mur
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[4, 0]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[5, 0]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[6, 0]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[7, 0]);

			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[4, 1]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[5, 1]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[6, 1]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[7, 1]);

			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[0, 2]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[7, 2]);

			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[0, 3]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[1, 3]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[2, 3]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[4, 3]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[5, 3]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[6, 3]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[7, 3]);

			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[0, 4]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[1, 4]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[2, 4]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[6, 4]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[7, 4]);

			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[0, 5]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[1, 5]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[2, 5]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[7, 5]);

			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[0, 6]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[1, 6]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[2, 6]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[3, 6]);

			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[0, 7]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[1, 7]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[2, 7]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[3, 7]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[4, 7]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[5, 7]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[7, 7]);

			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[0, 8]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[1, 8]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[2, 8]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[3, 8]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[4, 8]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[5, 8]);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.tableauDeMurs[7, 8]);

			//La case porte
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.porteNiveau6);
			DonneesNiveau.niveau6.AjoutPorte(DonneesNiveau.porteNiveau6);

			//On définit la position du personnage principal au début du niveau
			DonneesNiveau.personnagePrincipal.PositionElement[0] = 0; //En X
			DonneesNiveau.personnagePrincipal.PositionElement[1] = 0; //En Y
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.personnagePrincipal);

			InitialisationDesBlocs(DonneesNiveau.niveau6);
			InitialisationDesPortes(DonneesNiveau.niveau6);


		}

		/// <summary>
		/// Initialise les données du niveau 7
		/// </summary>
		public static void InitialisationNiveau7()
		{
			DonneesNiveau.niveau7.ResetNiveau();

			//Les cases message
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.message1Niveau7);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.message2Niveau7);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.message3Niveau7);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.message4Niveau7);

			//La case sortie
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.sortieNiveau7);

			//Les cases Danger
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.tableauDeDangers[0,0]);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 0]);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.tableauDeDangers[6, 0]);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.tableauDeDangers[7, 0]);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.tableauDeDangers[8, 0]);

			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 1]);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 1]);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.tableauDeDangers[5, 1]);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.tableauDeDangers[11, 1]);

			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 2]);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.tableauDeDangers[7, 2]);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.tableauDeDangers[8, 2]);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.tableauDeDangers[9, 2]);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.tableauDeDangers[10, 2]);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.tableauDeDangers[11, 2]);

			//On définit la position du personnage principal au début du niveau
			DonneesNiveau.personnagePrincipal.PositionElement[0] = 9; //En X
			DonneesNiveau.personnagePrincipal.PositionElement[1] = 0; //En Y
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.personnagePrincipal);

		}

		/// <summary>
		/// Initialise les données du niveau 8
		/// </summary>
		public static void InitialisationNiveau8()
		{
			DonneesNiveau.niveau8.ResetNiveau();

			//La case Bloc
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.blocNiveau8);

			//La case bouton
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.boutonNiveau8);

			//Les cases message
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.message1Niveau8);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.message2Niveau8);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.message3Niveau8);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.message4Niveau8);

			//Les cases Danger
			//colonne 0
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 0]);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[7, 0]);

			//colonne 1
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[2, 1]);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 1]);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[5, 1]);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[7, 1]);

			//colonne 2
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[0, 2]);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[5, 2]);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[7, 2]);

			//colonne 3
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[0, 3]);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[2, 3]);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 3]);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[5, 3]);

			//colonne 4
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[2, 4]);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 4]);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[5, 4]);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[6, 4]);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[7, 4]);

			//colonne 5
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[2, 5]);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 5]);

			//colonne 6
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[2, 6]);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 6]);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[4, 6]);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[5, 6]);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.tableauDeDangers[6, 6]);


			//La case sortie
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.sortieNiveau8);

			//La case porte
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.porteNiveau8);
			DonneesNiveau.niveau8.AjoutPorte(DonneesNiveau.porteNiveau8);

			//On définit la position du personnage principal au début du niveau
			DonneesNiveau.personnagePrincipal.PositionElement[0] = 7; //En X
			DonneesNiveau.personnagePrincipal.PositionElement[1] = 3; //En Y
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.personnagePrincipal);

			InitialisationDesBlocs(DonneesNiveau.niveau8);
			InitialisationDesPortes(DonneesNiveau.niveau8);
		}

		/// <summary>
		/// Initialise les données du niveau 9
		/// </summary>
		public static void InitialisationNiveau9()
		{
			DonneesNiveau.niveau9.ResetNiveau();

			//La case manivelle
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.manivelleNiveau9);

			//Les cases Danger
			//colonne 0
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[2, 0]);

			//colonne 1
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[0, 1]);
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 1]);

			//colonne 2
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 2]);
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[4, 2]);

			//colonne 3
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[2, 3]);
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[4, 3]);

			//colonne 4
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 4]);
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[4, 4]);

			//colonne 5
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[0, 5]);
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 5]);

			//colonne 6
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[2, 6]);

			//La case sortie
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.sortieNiveau9);

			//On définit la position du personnage principal au début du niveau
			DonneesNiveau.personnagePrincipal.PositionElement[0] = 0; //En X
			DonneesNiveau.personnagePrincipal.PositionElement[1] = 0; //En Y
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.personnagePrincipal);

			InitialisationDesManivelles(DonneesNiveau.niveau9);
		}

		/// <summary>
		/// Initialise la nouvelle configuration du niveau 9 une fois que le joueur a actionné la manivelle
		/// </summary>
		public static void InitialisationNouvelleConfigurationDuNiveau9()
		{
			DonneesNiveau.niveau9.ResetNiveau();

			//La case manivelle
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.manivelleNiveau9);

			//La case message
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.message2Niveau9);

			//Les cases Danger
			//colonne 1
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[0, 1]);
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 1]);
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 1]);
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[4, 1]);

			//colonne 3
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 3]);
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[2, 3]);
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 3]);
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[4, 3]);

			//colonne 5
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[0, 5]);
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 5]);
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[2, 5]);
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 5]);

			//La case sortie
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.sortieNiveau9);

			//On définit la position du personnage principal au début du niveau
			DonneesNiveau.personnagePrincipal.PositionElement[0] = 0; //En X
			DonneesNiveau.personnagePrincipal.PositionElement[1] = 6; //En Y
			DonneesNiveau.niveau9.AjoutMapElement(DonneesNiveau.personnagePrincipal);


		}

		/// <summary>
		/// Initialise les données du niveau 10
		/// </summary>
		public static void InitialisationNiveau10()
		{
			DonneesNiveau.niveau10.ResetNiveau();

			//Les cases manivelle
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.manivelle1Niveau10);

			//La case sortie
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.sortieNiveau10);

			//Les cases message
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.message1Niveau10);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.message2Niveau10);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.message3Niveau10);

			//Les cases Danger
			//colonne 1
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[0, 1]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 1]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[2, 1]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 1]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[4, 1]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[5, 1]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[6, 1]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[7, 1]);

			//colonne 2
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[7, 2]);

			//colonne 3
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 3]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[2, 3]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 3]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[4, 3]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[5, 3]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[7, 3]);

			//colonne 4
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 4]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[5, 4]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[7, 4]);

			//colonne 5
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 5]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 5]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[4, 5]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[5, 5]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[7, 5]);

			//colonne 6
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 6]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[7, 6]);

			//colonne 7
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 7]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[2, 7]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 7]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[4, 7]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[5, 7]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[6, 7]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[7, 7]);

			//colonne 9
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[0, 9]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 9]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[2, 9]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 9]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[4, 9]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[5, 9]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[6, 9]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[7, 9]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[8, 9]);

			//colonne 10
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[0, 10]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 10]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[2, 10]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 10]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[5, 10]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[6, 10]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[7, 10]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[8, 10]);

			//On définit la position du personnage principal au début du niveau
			DonneesNiveau.personnagePrincipal.PositionElement[0] = 0; //En X
			DonneesNiveau.personnagePrincipal.PositionElement[1] = 0; //En Y
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.personnagePrincipal);

			InitialisationDesManivelles(DonneesNiveau.niveau10);

		}

		/// <summary>
		/// Initialise la nouvelle configuration du niveau 10 une fois que le joueur a actionné la manivelle
		/// </summary>
		public static void InitialisationNouvelleConfigurationDuNiveau10()
		{

			DonneesNiveau.niveau10.ResetNiveau();

			//La case Bouton
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.boutonNiveau10);

			//La case Bloc
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.blocNiveau10);

			//Les cases Porte
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.porteNiveau10);
			DonneesNiveau.niveau10.AjoutPorte(DonneesNiveau.porteNiveau10);

			//Les cases Danger
			//colonne 0
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 0]);

			//colonne 1
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[0, 1]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 1]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 1]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[4, 1]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[5, 1]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[6, 1]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[7, 1]);

			//colonne 2
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[0, 2]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 2]);

			//colonne 3
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[0, 3]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[2, 3]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 3]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[4, 3]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[5, 3]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[7, 3]);

			//colonne 4
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[0, 4]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[5, 4]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[7, 4]);

			//colonne 5
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[0, 5]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 5]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[2, 5]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 5]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[4, 5]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[5, 5]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[7, 5]);

			//colonne 7
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 7]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 7]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[4, 7]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[5, 7]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[7, 7]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[8, 7]);

			//colonne 9
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[7, 9]);

			//colonne 10
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[0, 10]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 10]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[2, 10]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 10]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[5, 10]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[6, 10]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[7, 10]);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.tableauDeDangers[8, 10]);

			//La case sortie
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.sortieNiveau10);

			//Les cases message
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.message4Niveau10);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.message5Niveau10);
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.message6Niveau10);

			//On définit la position du personnage principal au début du niveau
			DonneesNiveau.personnagePrincipal.PositionElement[0] = 4; //En X
			DonneesNiveau.personnagePrincipal.PositionElement[1] = 4; //En Y
			DonneesNiveau.niveau10.AjoutMapElement(DonneesNiveau.personnagePrincipal);

			InitialisationDesManivelles(DonneesNiveau.niveau10);
			InitialisationDesBlocs(DonneesNiveau.niveau10);
			InitialisationDesPortes(DonneesNiveau.niveau10);
		}

		/// <summary>
		/// Initialise les données du niveau 11
		/// </summary>
		public static void InitialisationNiveau11()
		{
			DonneesNiveau.niveau11.ResetNiveau();

			//La case Bloc
			DonneesNiveau.niveau11.AjoutMapElement(DonneesNiveau.blocNiveau11);

			//La case bouton
			DonneesNiveau.niveau11.AjoutMapElement(DonneesNiveau.bouton1Niveau11);
			DonneesNiveau.niveau11.AjoutMapElement(DonneesNiveau.bouton2Niveau11);
			DonneesNiveau.niveau11.AjoutMapElement(DonneesNiveau.bouton3Niveau11);

			//La case message
			DonneesNiveau.niveau11.AjoutMapElement(DonneesNiveau.message1Niveau11);

			//Les cases porte
			DonneesNiveau.niveau11.AjoutMapElement(DonneesNiveau.porte1Niveau11);
			DonneesNiveau.niveau11.AjoutMapElement(DonneesNiveau.porte2Niveau11);
			DonneesNiveau.niveau11.AjoutMapElement(DonneesNiveau.porte3Niveau11);
			DonneesNiveau.niveau11.AjoutPorte(DonneesNiveau.porte1Niveau11);
			DonneesNiveau.niveau11.AjoutPorte(DonneesNiveau.porte2Niveau11);
			DonneesNiveau.niveau11.AjoutPorte(DonneesNiveau.porte3Niveau11);

			//Les cases Danger
			//colonne 1
			DonneesNiveau.niveau11.AjoutMapElement(DonneesNiveau.tableauDeDangers[1,1]);
			DonneesNiveau.niveau11.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 1]);
			DonneesNiveau.niveau11.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 1]);

			//colonne 3
			DonneesNiveau.niveau11.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 3]);

			//colonne 4
			DonneesNiveau.niveau11.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 4]);

			//colonne 5
			DonneesNiveau.niveau11.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 5]);

			//colonne 6
			DonneesNiveau.niveau11.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 6]);

			//colonne 7
			DonneesNiveau.niveau11.AjoutMapElement(DonneesNiveau.tableauDeDangers[1, 7]);
			DonneesNiveau.niveau11.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 7]);

			//colonne 8
			DonneesNiveau.niveau11.AjoutMapElement(DonneesNiveau.tableauDeDangers[3, 8]);

			//La case Sortie
			DonneesNiveau.niveau11.AjoutMapElement(DonneesNiveau.sortieNiveau11);

			//On définit la position du personnage principal au début du niveau
			DonneesNiveau.personnagePrincipal.PositionElement[0] = 2; //En X
			DonneesNiveau.personnagePrincipal.PositionElement[1] = 0; //En Y
			DonneesNiveau.niveau11.AjoutMapElement(DonneesNiveau.personnagePrincipal);

			InitialisationDesBlocs(DonneesNiveau.niveau11);
			InitialisationDesPortes(DonneesNiveau.niveau11);

		}

		/// <summary>
		/// Permet de charger le niveau suivant lorsque que le joueur a fini un niveau
		/// </summary>
		/// <param name="niveau">Niveau du jeu</param>
		public static void InitialisationNiveauSuivant(Niveau niveau)
		{
			switch (niveau.Numero)
			{
				//Si on est au niveau 1 on charge le niveau 2
				case 1:
					InitialisationNiveau2();
					break;

				//Si on est au niveau 2 on charge le niveau 3 etc...
				case 2:
					InitialisationNiveau3();
					break;

				case 3:
					InitialisationNiveau4();
					break;

				case 4:
					InitialisationNiveau5();
					break;

				case 5:
					InitialisationNiveau6();
					break;

				case 6:
					InitialisationNiveau7();
					break;

				case 7:
					InitialisationNiveau8();
					break;

				case 8:
					InitialisationNiveau9();
					break;

				case 9:
					InitialisationNiveau10();
					break;

				case 10:
					InitialisationNiveau11();
					break;

				default:
					break;
			}
		}

		/// <summary>
		/// Permet de recharger le niveau lorsque le joueur appuie sur "5"
		/// </summary>
		/// <param name="niveau">Niveau du jeu</param>
		public static void InitialisationNiveau(Niveau niveau)
		{
			switch (niveau.Numero)
			{
				//On recharge le niveau 1
				case 1:
					InitialisationNiveau1();
					break;

				//On recharge le niveau 2
				case 2:
					InitialisationNiveau2();
					break;

				//On recharge le niveau 3
				case 3:
					InitialisationNiveau3();
					break;

				case 4:
					InitialisationNiveau4();
					break;

				case 5:
					InitialisationNiveau5();
					break;

				case 6:
					InitialisationNiveau6();
					break;

				case 7:
					InitialisationNiveau7();
					break;

				case 8:
					InitialisationNiveau8();
					break;

				case 9:
					InitialisationNiveau9();
					break;

				case 10:
					InitialisationNiveau10();
					break;

				case 11:
					InitialisationNiveau11();
					break;

				default:
					break;
			}
		}

		/// <summary>
		/// Lors de la réinitialisation, cette fonction permet de replacer les blocs à leur position initiale
		/// </summary>
		/// <param name="niveau">Niveau du jeu</param>
		public static void InitialisationDesBlocs(Niveau niveau)
		{
			for (int i = 0; i < niveau.ElementsDuNiveau.Length - 1; i++)
			{
				Bloc blocTemp = new Bloc();
				if (niveau.ElementsDuNiveau[i].Symbole == 'B')
				{
					blocTemp = (Bloc)niveau.ElementsDuNiveau[i];
					blocTemp.PositionElement[0] = blocTemp.PositionInitiale[0];
					blocTemp.PositionElement[1] = blocTemp.PositionInitiale[1];
					niveau.ElementsDuNiveau[i] = blocTemp;
				}
			}
		}

		/// <summary>
		/// Lors de la réinitilisation, cette fonction permet de remettre les portes à leur état initial
		/// </summary>
		/// <param name="niveau">Niveau du jeu</param>
		public static void InitialisationDesPortes(Niveau niveau)
		{
			for (int i = 0; i < niveau.TableauDePortes.Length-1; i++)
			{
				niveau.TableauDePortes[i].EtatInitial();
			}
		}

		/// <summary>
		/// Lors de la réinitialisation, cette fonction permet de remettre les manivelles à leur état initial
		/// </summary>
		/// <param name="niveau"></param>
		public static void InitialisationDesManivelles(Niveau niveau)
		{
			for (int i = 0; i < niveau.ElementsDuNiveau.Length - 1; i++)
			{
				Manivelle manivelleTemp = new Manivelle();
				if (niveau.ElementsDuNiveau[i].Symbole == 'm')
				{
					manivelleTemp = (Manivelle)niveau.ElementsDuNiveau[i];
					manivelleTemp.Actionnee = manivelleTemp.ActionneeInitiale; //On remet la manivelle à son état initial
					niveau.ElementsDuNiveau[i] = manivelleTemp;
				}
			}
		}
		
		/// <summary>
		/// Modifie l'emplacement de nombreux éléments dans le niveau en cours
		/// </summary>
		/// <param name="niveau"></param>
		public static void ChangementDeConfigurationDuNiveau(Niveau niveau)
		{
			switch (niveau.Numero)
			{

				case 9:
					InitialisationNouvelleConfigurationDuNiveau9();
					break;

				case 10:
					InitialisationNouvelleConfigurationDuNiveau10();
					break;

				default:
					break;
			}
		}
	}
}
