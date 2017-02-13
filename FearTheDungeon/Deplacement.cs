using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	/// <summary>
	/// Contient toutes les fonctions relatives aux déplacements du personnage et des éléments de la carte
	/// </summary>
	abstract class Deplacement
	{

		/// <summary>
		/// Cette fonction gère le déplacement du joueur
		/// </summary>
		/// <param name="niveau">Niveau du jeu que l'on passera ensuite en paramètre dans le test de validité du mouvement</param>
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

			ModificationPositionElement(deplacementInt, DonneesNiveau.personnagePrincipal);

		}

		/// <summary>
		/// Modifie la position d'un élément dans le fichier DonneesNiveau (joueur, bloc...)
		/// </summary>
		/// <param name="deplacement">Touche de déplacement sur laquelle le joueur a appuyé : 2 - 4 - 6 - 8 ou 5</param>
		/// <param name="element">Element qui sera déplacé si le joueur le pousse (par exemple : un bloc )</param>
		static public void ModificationPositionElement(int deplacement, MapElement element)
		{
			switch (deplacement)
			{
				//Si le joueur est allé en bas
				case 2:
					if (element.Symbole == '*') DonneesNiveau.personnagePrincipal.PositionElement[0]++;
					else if (element.Symbole == 'B') element.PositionElement[0]++;
					break;

				//Si le joueur est allé à gauche
				case 4:
					if (element.Symbole == '*') DonneesNiveau.personnagePrincipal.PositionElement[1]--;
					else if (element.Symbole == 'B') element.PositionElement[1]--;
					break;

				//Si le joueur est allé à droite
				case 6:
					if (element.Symbole == '*') DonneesNiveau.personnagePrincipal.PositionElement[1]++;
					else if (element.Symbole == 'B') element.PositionElement[1]++;
					break;

				//Si le joueur est allé en haut
				case 8:
					if (element.Symbole == '*') DonneesNiveau.personnagePrincipal.PositionElement[0]--;
					else if (element.Symbole == 'B') element.PositionElement[0]--;
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
		/// <param name="niveau">Niveau du jeu</param>
		/// <param name="mouvement">Déplacement choisi par le joueur : bas(2) - gauche(4) - droite(6) - haut(6) - resetlevel(5)</param>
		static private bool TestValiditeDuMouvement(int mouvement, Niveau niveau)
		{
			bool mouvementValide;
			bool mauvaiseTouche = false, objetInfranchissable = false, sortDuTableau = false;
			int positionX, positionY;

			//Si le joueur a appuyé sur les bonnes touche de déplacement du pavé numérique
			if (mouvement == 2 || mouvement == 4 || mouvement == 6 || mouvement == 8 || mouvement == 5 || mouvement == 0)
			{
				switch (mouvement)
				{
					//Si le joueur appuie sur 0, il peut retourner au menu de choix des niveaux
					case 0:
						Affichage.AffichageMenuDesNiveaux(DonneesNiveau.tableauNiveaux);
						break;

					//Si le joueur veut descendre
					case 2:
						positionX = DonneesNiveau.personnagePrincipal.PositionElement[0] + 1;
						positionY = DonneesNiveau.personnagePrincipal.PositionElement[1];
						sortDuTableau = LeJoueurSortDeLaMap(niveau, positionX, positionY);
						objetInfranchissable = LaCaseEstPrise(niveau, positionX, positionY, mouvement);
						break;

					//Si le joueur veut aller à gauche
					case 4:
						positionX = DonneesNiveau.personnagePrincipal.PositionElement[0];
						positionY = DonneesNiveau.personnagePrincipal.PositionElement[1] - 1;
						sortDuTableau = LeJoueurSortDeLaMap(niveau, positionX, positionY);
						objetInfranchissable = LaCaseEstPrise(niveau, positionX, positionY, mouvement);
						break;

					//Si le joueur veut aller à droite
					case 6:
						positionX = DonneesNiveau.personnagePrincipal.PositionElement[0];
						positionY = DonneesNiveau.personnagePrincipal.PositionElement[1] + 1;
						sortDuTableau = LeJoueurSortDeLaMap(niveau, positionX, positionY);
						objetInfranchissable = LaCaseEstPrise(niveau, positionX, positionY, mouvement);
						break;

					//Si le joueur veut monter
					case 8:
						positionX = DonneesNiveau.personnagePrincipal.PositionElement[0] - 1;
						positionY = DonneesNiveau.personnagePrincipal.PositionElement[1];
						sortDuTableau = LeJoueurSortDeLaMap(niveau, positionX, positionY);
						objetInfranchissable = LaCaseEstPrise(niveau, positionX, positionY, mouvement);
						break;

					//Si le joueur appuie sur valider
					case 5:
						Initialisations.InitialisationNiveau(niveau);
						Affichage.AffichageNiveau(niveau);
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
		/// On regarde si le bloc peut bien se déplacer dans la direction dans laquelle le joueur le pousse
		/// </summary>
		/// <param name="mouvement">Déplacement choisi par le joueur : bas(2) - gauche(4) - droite(6) - haut(6) - resetlevel(5)</param>
		/// <param name="niveau">Niveau du jeu</param>
		/// <param name="bloc">Le bloc que le joueur vient de pousser.</param>
		/// <returns></returns>
		static private bool TestValiditeDuMouvementBloc(int mouvement, Niveau niveau, MapElement bloc)
		{
			bool leBlocPeutBouger = true;
			bool leBlocSortDeLaMap = false;
			bool laCaseEstDejaPrise = false;
			Porte porteTemp;
			Bouton boutonTemp;

			//Position en X du bloc si son déplacement est validé
			int positionBlocX = bloc.PositionElement[0];
			//Position en Y du bloc si son déplacement est validé
			int positionBlocY = bloc.PositionElement[1];

			switch (mouvement)
			{
				//Si le joueur le pousse vers le bas
				case 2:
					positionBlocX++;
					break;
				
				//Si le joueur le pousse vers la gauche
				case 4:
					positionBlocY--;
					break;

				//Si le joueur le pousse vers la droite
				case 6:
					positionBlocY++;
					break;

				//Si le joueur le pousse vers le haut
				case 8:
					positionBlocX--;
					break;

				default:
					break;
			}

			//Si le bloc sort de la carte
			if(positionBlocX<0 || positionBlocX >= niveau.CarteDuNiveau.NombreLignes ||
			   positionBlocY<0 || positionBlocY >= niveau.CarteDuNiveau.NombreColonnes)
			{
				leBlocSortDeLaMap = true;
			}

			//On consulte le tableau d'éléments du niveau pour voir si on pousse pas le bloc sur un objet infranchissable
			for(int i=0; i<niveau.elementsDuNiveau.Length-1; i++)
			{
				//Si un autre élément du niveau a la même position que la case sur laquelle va être poussé le bloc
				if(niveau.elementsDuNiveau[i].PositionElement[0] == positionBlocX &&
				   niveau.elementsDuNiveau[i].PositionElement[1] == positionBlocY)		
				{
					//Si c'est une porte
					if (niveau.ElementsDuNiveau[i].Symbole == 'P')
					{
						porteTemp = (Porte)niveau.ElementsDuNiveau[i];
						//Si la porte est fermée, le bloc ne peut pas être placé sur sa case
						if (porteTemp.Ouverte == false) laCaseEstDejaPrise = true;
					}

					//Si il y'a un mur, la sortie ou une case Danger
					else if (niveau.ElementsDuNiveau[i].Symbole == 'X' || niveau.ElementsDuNiveau[i].Symbole == 'S' || niveau.ElementsDuNiveau[i].Symbole == 'D') laCaseEstDejaPrise = true;


					//Si on le pousse sur un bouton
					else if (niveau.ElementsDuNiveau[i].Symbole == 'b')
					{
						boutonTemp = (Bouton)niveau.ElementsDuNiveau[i];

						//Si le niveau contient des portes
						if(niveau.TableauDePortes != null)
						{
							//On parcourt les éléments du niveau pour trouver la porte qu'il ouvre
							for (int j = 0; j < niveau.TableauDePortes.Length-1; j++)
							{
								//Si la porte que le bouton ouvre est la porte sur laquelle on est dans le tableau de portes
								if (boutonTemp.PorteQueJouvre == niveau.TableauDePortes[j])
								{
									niveau.TableauDePortes[j].Ouverte = true;
									niveau.TableauDePortes[j].Symbole = ' ';
								}
							}
						}
					} //Fin du else quand on pousse le bouton

				}
			}

			if (leBlocSortDeLaMap || laCaseEstDejaPrise) leBlocPeutBouger = false;

			return leBlocPeutBouger;
		}

		/// <summary>
		/// Permet de tester si le joueur sortirait de la map si il effectuait le déplacement qu'il vient de choisir
		/// </summary>
		/// <param name="niveau">Niveau du jeu</param>
		/// <param name="positionX">Position qu'aurait le joueur en X si son déplacement est validé</param>
		/// <param name="positionY">Position qu'aurait le joueur en Y si son déplacement est validé</param>
		/// <returns></returns>
		static private bool LeJoueurSortDeLaMap(Niveau niveau, int positionX, int positionY)
		{
			bool sortDuTableau = false;
			//Si cela sort de la carte
			if (positionX >= niveau.CarteDuNiveau.NombreLignes ||
				positionY >= niveau.CarteDuNiveau.NombreColonnes ||
				positionX < 0 || positionY < 0)
			{
				sortDuTableau = true;
			}

			return sortDuTableau;
		}

		/// <summary>
		/// Permet de tester si le joueur essaie d'aller sur une case sur laquelle un objet infranchissable est présent
		/// </summary>
		/// <param name="niveau">Niveau du jeu</param>
		/// <param name="positionX">Position qu'aurait le joueur en X si son déplacement est validé</param>
		/// <param name="positionY">Position qu'aurait le joueur en Y si son déplacement est validé</param>
		/// <param name="mouvement">Déplacement choisi par le joueur : bas(2) - gauche(4) - droite(6) - haut(6) - resetlevel(5)</param>
		/// <returns></returns>
		static private bool LaCaseEstPrise(Niveau niveau, int positionX, int positionY, int mouvement)
		{
			bool objetInfranchissable = false;
			bool leBlocPeutBouger = true;
			Porte porteTemp;
			Manivelle manivelleTemp;

			//On parcourt le tableau des éléments pour voir si il y'en a pas déjà un sur la case sur laquelle on veut aller
			//et que celui-ci n'autorise pas qu'on le survole
			for (int i = 0; i < niveau.ElementsDuNiveau.Length - 1; i++)
			{
				//Si il existe un élément à la position de la case sur laquelle veut aller le joueur
				if (niveau.ElementsDuNiveau[i].PositionElement[0] == positionX &&
					niveau.ElementsDuNiveau[i].PositionElement[1] == positionY)
				{
					//Si cet élément est un mur
					if (niveau.ElementsDuNiveau[i].Symbole == 'X') objetInfranchissable = true;

					//Si cet élément est une porte
					if(niveau.ElementsDuNiveau[i].Symbole == 'P')
					{
						porteTemp = (Porte)niveau.ElementsDuNiveau[i];
						if(porteTemp.Ouverte == false) objetInfranchissable = true;
					}

					//Si cet élément est un bloc
					else if (niveau.ElementsDuNiveau[i].Symbole == 'B')
					{
						leBlocPeutBouger = TestValiditeDuMouvementBloc(mouvement, niveau, niveau.ElementsDuNiveau[i]);

						if (leBlocPeutBouger) ModificationPositionElement(mouvement, niveau.ElementsDuNiveau[i]);
						else objetInfranchissable = true;

					}

					//Si cet élément est un danger
					else if(niveau.ElementsDuNiveau[i].Symbole == 'D')
					{
						Initialisations.InitialisationNiveau(niveau);
						Affichage.AffichageNiveau(niveau);
					}

					//Si cet élément est une manivelle
					else if(niveau.ElementsDuNiveau[i].Symbole == 'm')
					{
						manivelleTemp = (Manivelle)niveau.ElementsDuNiveau[i];
						if (manivelleTemp.Actionnee == false)
						{
							manivelleTemp.ChangementInherentALActivationDeLaManivelle(niveau);
							manivelleTemp.Actionnee = true;
							Affichage.AffichageNiveau(niveau); //On réaffiche la nouvelle configuration du niveau
						}

					}
				}
			}

			return objetInfranchissable;
		}

	} //Fin de la classe
}
