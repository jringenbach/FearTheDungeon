﻿using System;
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


						//Les murs
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.murligne1colonne0niveau1);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.murligne1colonne1niveau1);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.murligne1colonne2niveau1);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.murligne1colonne3niveau1);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.murligne1colonne3niveau1);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.murligne3colonne1niveau1);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.murligne3colonne3niveau1);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.murligne3colonne4niveau1);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.murligne4colonne1niveau1);

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
			DonneesNiveau.niveau2.AjoutMapElement(DonneesNiveau.murligne0colonne1niveau2);
			DonneesNiveau.niveau2.AjoutMapElement(DonneesNiveau.murligne2colonne1niveau2);
			DonneesNiveau.niveau2.AjoutMapElement(DonneesNiveau.murligne3colonne1niveau2);
			DonneesNiveau.niveau2.AjoutMapElement(DonneesNiveau.murligne4colonne1niveau2);
			DonneesNiveau.niveau2.AjoutMapElement(DonneesNiveau.murligne0colonne3niveau2);
			DonneesNiveau.niveau2.AjoutMapElement(DonneesNiveau.murligne1colonne3niveau2);
			DonneesNiveau.niveau2.AjoutMapElement(DonneesNiveau.murligne2colonne3niveau2);
			DonneesNiveau.niveau2.AjoutMapElement(DonneesNiveau.murligne3colonne3niveau2);

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
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.murligne1colonne0niveau3);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.murligne1colonne1niveau3);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.murligne1colonne2niveau3);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.murligne1colonne4niveau3);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.murligne1colonne5niveau3);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.murligne2colonne0niveau3);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.murligne2colonne2niveau3);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.murligne2colonne5niveau3);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.murligne3colonne1niveau3);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.murligne3colonne5niveau3);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.murligne4colonne0niveau3);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.murligne4colonne2niveau3);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.murligne4colonne4niveau3);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.murligne4colonne5niveau3);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.murligne5colonne0niveau3);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.murligne5colonne1niveau3);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.murligne5colonne2niveau3);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.murligne5colonne4niveau3);
			DonneesNiveau.niveau3.AjoutMapElement(DonneesNiveau.murligne5colonne5niveau3);

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
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.murligne0colonne0niveau4);
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.murligne0colonne1niveau4);

			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.murligne1colonne0niveau4);
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.murligne1colonne1niveau4);

			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.murligne3colonne0niveau4);
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.murligne3colonne1niveau4);

			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.murligne4colonne2niveau4);
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.murligne5colonne2niveau4);
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.murligne7colonne2niveau4);

			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.murligne1colonne3niveau4);
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.murligne3colonne3niveau4);

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
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.murligne0colonne1niveau5);
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.murligne1colonne1niveau5);
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.murligne3colonne1niveau5);
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.murligne4colonne1niveau5);
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.murligne5colonne1niveau5);
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.murligne6colonne1niveau5);

			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.murligne1colonne3niveau5);
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.murligne3colonne3niveau5);
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.murligne4colonne3niveau5);
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.murligne5colonne3niveau5);
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.murligne6colonne3niveau5);
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.murligne8colonne3niveau5);

			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.murligne6colonne4niveau5);
			DonneesNiveau.niveau5.AjoutMapElement(DonneesNiveau.murligne8colonne4niveau5);

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
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne4colonne0niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne5colonne0niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne6colonne0niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne7colonne0niveau6);

			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne4colonne1niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne5colonne1niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne6colonne1niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne7colonne1niveau6);

			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne0colonne2niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne7colonne2niveau6);

			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne0colonne3niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne1colonne3niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne2colonne3niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne4colonne3niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne5colonne3niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne6colonne3niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne7colonne3niveau6);

			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne0colonne4niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne1colonne4niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne2colonne4niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne6colonne4niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne7colonne4niveau6);

			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne0colonne5niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne1colonne5niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne2colonne5niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne7colonne5niveau6);

			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne0colonne6niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne1colonne6niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne2colonne6niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne3colonne6niveau6);

			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne0colonne7niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne1colonne7niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne2colonne7niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne3colonne7niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne4colonne7niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne5colonne7niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne7colonne7niveau6);

			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne0colonne8niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne1colonne8niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne2colonne8niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne3colonne8niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne4colonne8niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne5colonne8niveau6);
			DonneesNiveau.niveau6.AjoutMapElement(DonneesNiveau.murligne7colonne8niveau6);

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
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.Dangerligne0colonne0niveau7);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.Dangerligne1colonne0niveau7);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.Dangerligne6colonne0niveau7);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.Dangerligne7colonne0niveau7);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.Dangerligne8colonne0niveau7);

			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.Dangerligne1colonne1niveau7);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.Dangerligne3colonne1niveau7);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.Dangerligne5colonne1niveau7);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.Dangerligne11colonne1niveau7);

			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.Dangerligne3colonne2niveau7);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.Dangerligne7colonne2niveau7);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.Dangerligne8colonne2niveau7);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.Dangerligne9colonne2niveau7);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.Dangerligne10colonne2niveau7);
			DonneesNiveau.niveau7.AjoutMapElement(DonneesNiveau.Dangerligne11colonne2niveau7);

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
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne3colonne0niveau8);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne7colonne0niveau8);

			//colonne 1
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne2colonne1niveau8);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne3colonne1niveau8);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne5colonne1niveau8);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne7colonne1niveau8);

			//colonne 2
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne0colonne2niveau8);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne5colonne2niveau8);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne7colonne2niveau8);

			//colonne 3
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne0colonne3niveau8);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne2colonne3niveau8);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne3colonne3niveau8);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne5colonne3niveau8);

			//colonne 4
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne2colonne4niveau8);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne3colonne4niveau8);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne5colonne4niveau8);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne6colonne4niveau8);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne7colonne4niveau8);

			//colonne 5
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne2colonne5niveau8);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne3colonne5niveau8);

			//colonne 6
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne2colonne6niveau8);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne3colonne6niveau8);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne4colonne6niveau8);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne5colonne6niveau8);
			DonneesNiveau.niveau8.AjoutMapElement(DonneesNiveau.Dangerligne6colonne6niveau8);


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

		}

		/// <summary>
		/// Initialise les données du niveau 10
		/// </summary>
		public static void InitialisationNiveau10()
		{

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
	}
}
