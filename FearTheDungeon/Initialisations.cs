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

			//La case sortie
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.sortieNiveau4);

			//On définit la position du personnage principal au début du niveau
			DonneesNiveau.personnagePrincipal.PositionElement[0] = 0; //En X
			DonneesNiveau.personnagePrincipal.PositionElement[1] = 2; //En Y
			DonneesNiveau.niveau4.AjoutMapElement(DonneesNiveau.personnagePrincipal);
		}

		/// <summary>
		/// Initialise les données du niveau 5
		/// </summary>
		public static void InitialisationNiveau5()
		{
			DonneesNiveau.niveau5.ResetNiveau();
		}

		/// <summary>
		/// Permet de charger le niveau suivant lorsque que le joueur a fini un niveau
		/// </summary>
		/// <param name="niveau"></param>
		public static void InitialisationNiveauSuivant(Niveau niveau)
		{
			switch (niveau.Numero)
			{
				//Si on est au niveau 1 on charge le niveau 2 etc...
				case 1:
					InitialisationNiveau2();
					break;

				case 2:
					InitialisationNiveau3();
					break;

				case 3:
					InitialisationNiveau4();
					break;

				case 4:
					InitialisationNiveau5();
					break;

				default:
					break;
			}
		}

		/// <summary>
		/// Permet de recharger le niveau lorsque le joueur appuie sur "5"
		/// </summary>
		/// <param name="niveau"></param>
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

				default:
					break;
			}
		}

		/// <summary>
		/// Lors de la réinitialisation, cette fonction permet de replacer les blocs à leur position initiale
		/// </summary>
		/// <param name="niveau"></param>
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
	}
}
