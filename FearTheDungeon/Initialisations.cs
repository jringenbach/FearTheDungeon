using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	abstract class Initialisations
	{
		/// <summary>
		/// Initialise les données du niveau 1
		/// </summary>
		public static void InitialisationNiveau1()
		{
			//Nombre d'éléments : 13
			//ON AJOUTE LES ELEMENTS DU NIVEAU STOCKES DANS DONNEESNIVEAU CONCERNANT LE NIVEAU 1

						//Les cases message
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.message1Niveau1);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.message2Niveau1);

						//Les murs
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.murligne1colonne0);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.murligne1colonne1);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.murligne1colonne2);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.murligne1colonne3);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.murligne1colonne3);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.murligne3colonne1);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.murligne3colonne3);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.murligne3colonne4);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.murligne4colonne1);

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

		}

		/// <summary>
		/// Initialise les données du niveau 3
		/// </summary>
		public static void InitialisationNiveau3()
		{

		}
	}
}
