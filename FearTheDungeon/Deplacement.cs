using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	abstract class Deplacement
	{

		/// <summary>
		/// Cette fonction gère le déplacement du joueur
		/// </summary>
		static public void MouvementJoueur(Niveau niveau)
		{
			char deplacement = '0';
			int deplacementInt;
			bool mouvementValide;

			//Tant que le joueur n'a pas saisi un déplacement valide, on le force à saisir autre chose
			do
			{
				deplacement = Console.ReadKey(true).KeyChar;
				mouvementValide = int.TryParse(Convert.ToString(deplacement), out deplacementInt);
				if (mouvementValide) mouvementValide = TestValiditeDuMouvement(deplacementInt, niveau);
			} while (!mouvementValide);

			ModificationPositionJoueur(deplacementInt);

		}

		/// <summary>
		/// Modifie la position du joueur dans le fichier DonneesNiveau
		/// </summary>
		/// <param name="deplacement"></param>
		static public void ModificationPositionJoueur(int deplacement)
		{
			switch (deplacement)
			{
				//Si le joueur est allé en bas
				case 2:
					DonneesNiveau.personnagePrincipal.PositionElement[0]++;
					break;

				//Si le joueur est allé à gauche
				case 4:
					DonneesNiveau.personnagePrincipal.PositionElement[1]--;
					break;

				//Si le joueur est allé à droite
				case 6:
					DonneesNiveau.personnagePrincipal.PositionElement[1]++;
					break;

				//Si le joueur est allé en haut
				case 8:
					DonneesNiveau.personnagePrincipal.PositionElement[0]--;
					break;

				default:
					break;
			}
		}

		//**********************************************************************
		//			LES DIFFERENTS TESTS DE VALIDITE DE MOUVEMENT
		//**********************************************************************


		/// <summary>
		/// On va regarder si le joueur désire progresser sur une case valide ou non.
		/// Renvoie true si le mouvement est valide, false sinon.
		/// </summary>
		static bool TestValiditeDuMouvement(int mouvement, Niveau niveau)
		{
			bool mouvementValide;
			bool mauvaiseTouche = false, objetInfranchissable = false, sortDuTableau = false;
			int positionX, positionY;

			//Si le joueur a appuyé sur les bonnes touche de déplacement du pavé numérique
			if (mouvement == 2 || mouvement == 4 || mouvement == 6 || mouvement == 8 || mouvement == 5)
			{
				switch (mouvement)
				{
					//Si le joueur veut descendre
					case 2:
						positionX = DonneesNiveau.personnagePrincipal.PositionElement[0] + 1;
						positionY = DonneesNiveau.personnagePrincipal.PositionElement[1];
						sortDuTableau = LeJoueurSortDeLaMap(niveau, positionX, positionY);
						objetInfranchissable = LaCaseEstPrise(niveau, positionX, positionY);
						break;

					//Si le joueur veut aller à gauche
					case 4:
						positionX = DonneesNiveau.personnagePrincipal.PositionElement[0];
						positionY = DonneesNiveau.personnagePrincipal.PositionElement[1] - 1;
						sortDuTableau = LeJoueurSortDeLaMap(niveau, positionX, positionY);
						objetInfranchissable = LaCaseEstPrise(niveau, positionX, positionY);
						break;

					//Si le joueur veut aller à droite
					case 6:
						positionX = DonneesNiveau.personnagePrincipal.PositionElement[0];
						positionY = DonneesNiveau.personnagePrincipal.PositionElement[1] + 1;
						sortDuTableau = LeJoueurSortDeLaMap(niveau, positionX, positionY);
						objetInfranchissable = LaCaseEstPrise(niveau, positionX, positionY);
						break;

					//Si le joueur veut monter
					case 8:
						positionX = DonneesNiveau.personnagePrincipal.PositionElement[0] - 1;
						positionY = DonneesNiveau.personnagePrincipal.PositionElement[1];
						sortDuTableau = LeJoueurSortDeLaMap(niveau, positionX, positionY);
						objetInfranchissable = LaCaseEstPrise(niveau, positionX, positionY);
						break;

					//Si le joueur appuie sur valider
					case 5:
						break;

					//Sinon
					default:
						break;
				}
			}

			//Sinon si il n'a pas appuyé sur les bonnes touches du pavé numérique
			else mauvaiseTouche = true;

			//On peut enfin voir si le mouvement est valide ou non
			if (objetInfranchissable == true || sortDuTableau == true || mauvaiseTouche == true) mouvementValide = false;
			else mouvementValide = true;

			return mouvementValide;
		}

		/// <summary>
		/// Permet de tester si le joueur sortirait de la map si il effectuait le déplacement qu'il vient de choisir
		/// </summary>
		/// <param name="niveau"></param>
		/// <param name="positionX"></param>
		/// <param name="positionY"></param>
		/// <returns></returns>
		static bool LeJoueurSortDeLaMap(Niveau niveau, int positionX, int positionY)
		{
			bool sortDuTableau = false;

			for (int i = 0; i < niveau.ElementsDuNiveau.Length; i++)
			{
				//Si cela sort de la carte
				if (DonneesNiveau.personnagePrincipal.PositionElement[0] + 1 >= niveau.CarteDuNiveau.NombreLignes ||
					DonneesNiveau.personnagePrincipal.PositionElement[1] + 1 >= niveau.CarteDuNiveau.NombreColonnes)
				{
					sortDuTableau = true;
				}
				if (sortDuTableau == true) break;
			}

			return sortDuTableau;
		}

		/// <summary>
		/// Permet de tester si le joueur essaie d'aller sur une case sur laquelle un objet infranchissable est présent
		/// </summary>
		/// <param name="niveau"></param>
		/// <param name="positionX"></param>
		/// <param name="positionY"></param>
		/// <returns></returns>
		static bool LaCaseEstPrise(Niveau niveau, int positionX, int positionY)
		{
			bool objetInfranchissable = false;

			//On parcourt le tableau des éléments pouvoir si il y'en a pas déjà un sur la case sur laquelle on veut aller
			//et que celui-ci n'autorise pas qu'on le survole
			for (int i = 0; i < niveau.ElementsDuNiveau.Length - 1; i++)
			{
				//Si il existe un élément à la position de la case sur laquelle veut aller le joueur
				if (niveau.ElementsDuNiveau[i].PositionElement[0] == DonneesNiveau.personnagePrincipal.PositionElement[0] + 1 &&
				    niveau.ElementsDuNiveau[i].PositionElement[1] == DonneesNiveau.personnagePrincipal.PositionElement[1] + 1)
				{
					//Si cet élément est un mur
					if (niveau.ElementsDuNiveau[i].Symbole == 'X')
					{
						objetInfranchissable = true;
					}
				}
			}

			return objetInfranchissable;
		}

	} //Fin de la classe
}
