using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FearTheDungeon
{
	/// <summary>
	/// Contient toutes les fonctions d'affichage. Elle ne peut être instanciée.
	/// </summary>
	abstract class Affichage
	{
		// *****************************************************
		//					OUTILS D'AFFICHAGE
		// ****************************************************

		/// <summary>
		/// Affichage d'un texte entouré d'un tableau
		/// </summary>
		/// <param name="nomDuNiveau">Nom du niveau en cours dont on doit afficher le titre</param>
		/// <param name="typeDeTexte">Si typeDeTexte = 1 : titre du jeu. Si typeDeTexte = 2, message du niveau.</param>
		static public void AffichageTexte(string nomDuNiveau, int typeDeTexte)
		{
			//Les contours du tableau du nom du niveau sont affichés en jaune
			//Le nom du niveau est affiché en rouge
			//Si typeDeTexte vaut 1, alors on formate un titre
			//Si typeDeTexte vaut 2, alors on formate un message issu de MessageElement

			//Si c'est le titre d'un niveau
			if (typeDeTexte == 1)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				NombreTiretsAdaptable(nomDuNiveau, 1);
				Console.Write("\t\t\t| ");
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(nomDuNiveau);
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine(" |");
				NombreTiretsAdaptable(nomDuNiveau, 1);
				Console.ResetColor();
			}

			//Si c'est un message
			else if (typeDeTexte == 2)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				NombreTiretsAdaptable(nomDuNiveau, 2);
				Console.Write("\t\t| ");
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(nomDuNiveau);
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine(" |");
				NombreTiretsAdaptable(nomDuNiveau, 2);
				Console.ResetColor();
			}

		}

		/// <summary>
		/// Adapte le nombre de tirets dessinant les contours du tableau en fonction de la longueur de la chaîne la plus longue
		/// </summary>
		/// <param name="menu">On récupère la longueur de l'option du menu envoyé la plus longue pour adapter le nombre de tirets.</param>
		/// <param name="typeDeTexte">Si typeDeTexte = 1 : titre du jeu. Si typeDeTexte = 2, message du niveau.</param>
		static private void NombreTiretsAdaptable(Menu menu, int typeDeTexte)
		{
			int longueurChaineMax = menu.LongueurChaineMax();
			if (typeDeTexte == 1) Console.Write("\t\t\t ");
			else if (typeDeTexte == 2) Console.Write("\t\t ");

			for (int i = 0; i < longueurChaineMax + 5; i++)
			{
				Console.Write("-");
			}
			Console.WriteLine();
		}

		/// <summary>
		/// Adapte le nombre de tirets dessinant les contours du tableau en fonction de la longueur de la chaîne la plus longue
		/// </summary>
		/// <param name="niveau">On va récupérer le nombre de colonnes de la carte du niveau pour afficher la carte proprement.</param>
		/// <param name="typeDeTexte">Si typeDeTexte = 1 : titre du jeu. Si typeDeTexte = 2, message du niveau.</param>
		static private void NombreTiretsAdaptable(Niveau niveau, int typeDeTexte)
		{
			if (typeDeTexte == 1) Console.Write("\t\t\t ");
			else if (typeDeTexte == 2) Console.Write("\t\t ");
			for (int i = 0; i < niveau.CarteDuNiveau.NombreColonnes * 4 - 1; i++)
			{
				Console.Write("-");
			}
			Console.WriteLine();
		}

		/// <summary>
		/// Adapte le nombre de tirets dessinant les contours du tableau en fonction de la longueur de la chaîne la plus longue
		/// </summary>
		/// <param name="chaine">Chaine dont on va récupérer la longueur pour adapter le nombre de tirets du tableau qui l'entourera.</param>
		/// <param name="typeDeTexte">Si typeDeTexte = 1 : titre du jeu. Si typeDeTexte = 2, message du niveau.</param>
		static public void NombreTiretsAdaptable(string chaine, int typeDeTexte)
		{
			//Suivant le type de texte (titre du niveau ou message) on adapte le nombre de tabulation.
			if (typeDeTexte == 1) Console.Write("\t\t\t "); //Pour le titre du jeu ou le titre de niveau
			else if (typeDeTexte == 2) Console.Write("\t\t "); //Pour les messages à afficher

			for (int i = 1; i < chaine.Length + 3; i++)
			{
				Console.Write("-");
			}
			Console.WriteLine();
		}

		/// <summary>
		/// Permet d'adapter la position de la console à la taille de l'écran
		/// </summary>
		static public void PositionConsole()
		{
			int largeur, hauteur;
			largeur = Screen.PrimaryScreen.Bounds.Width;
			largeur /= 3;
			hauteur = Screen.PrimaryScreen.Bounds.Height;
			hauteur /= 3;

		}

		// *****************************************************
		//					AFFICHAGE NIVEAU
		// *****************************************************

		/// <summary>
		/// Affiche le titre du niveau et sa carte contenant tous ses éléments
		/// </summary>
		/// <param name="niveau">Niveau du jeu</param>
		static public void AffichageNiveau(Niveau niveau)
		{
			int[] positionSortie = new int[2];
			bool leJoueurEstSurLaCaseDeLaSortie = false;

			RecherchePositionSortie(niveau, positionSortie);

			//La boucle du niveau continue tant que le joueur n'est pas sur la case de la sortie
			do
			{
				Console.Clear();

				//On affiche le nom du niveau tout en haut de l'écran
				AffichageTexte(niveau.Nom, 1);

				//On affiche la carte du niveau
				MapDuNiveau(niveau);

				//Si le joueur est sur une case message, on lui affiche un message en dessous de la carte du niveau
				for (int i = 0; i < niveau.ElementsDuNiveau.Length - 1; i++)
				{
					//On regarde si la position du joueur est égal à la position d'une case Message
					if (niveau.ElementsDuNiveau[i].Symbole == 'M' &&
					   DonneesNiveau.personnagePrincipal.PositionElement[0] == niveau.ElementsDuNiveau[i].PositionElement[0] &&
					   DonneesNiveau.personnagePrincipal.PositionElement[1] == niveau.ElementsDuNiveau[i].PositionElement[1])
					{
						AffichageTexte(((MessageElement)niveau.ElementsDuNiveau[i]).Message, 2);
					}
				}

				//Le joueur choisit son déplacement
				Deplacement.MouvementJoueur(niveau);

				//Si le joueur est sur la case de la sortie alors on quitte la boucle
				if (DonneesNiveau.personnagePrincipal.PositionElement[0] == positionSortie[0] &&
					DonneesNiveau.personnagePrincipal.PositionElement[1] == positionSortie[1])
					leJoueurEstSurLaCaseDeLaSortie = true;

			} while (!leJoueurEstSurLaCaseDeLaSortie);

			//On charge les paramètres du niveau suivant et on indique dans données publiques que le niveau suivant est débloqué
			Initialisations.InitialisationNiveauSuivant(niveau);
			DonneesPubliques.niveauDebloque++;

			AfficherLeNiveauSuivant(niveau);


		}

		/// <summary>
		/// Affiche la carte du niveau
		/// </summary>
		/// <param name="niveau">Niveau du jeu</param>
		static private void MapDuNiveau(Niveau niveau)
		{

			bool symbolePresent;
			//Position de l'objet que l'on veut afficher
			int positionSymbole = 0;

			//Début de l'affichage du tableau
			for (int i = 0; i < niveau.CarteDuNiveau.NombreLignes; i++) //Boucle des lignes
			{
				NombreTiretsAdaptable(niveau, 1);

				//Bord gauche de la première case tout à gauche
				Console.Write("\t\t\t|");
				for (int j = 0; j < niveau.CarteDuNiveau.NombreColonnes; j++) //Boucle des colonnes
				{
					positionSymbole = 0;
					symbolePresent = false;

					//On parcourt la boucle des éléments du niveau
					//On la parcourt à Length-1 car on a ajouté une case vide en ajoutant le dernier élément
					for (int k = 0; k < niveau.ElementsDuNiveau.Length - 1; k++)
					{
						//Si dans le tableau des éléments, un élément a la même position que celle sur laquelle on est en construisant
						//le tableau, on passe symbolePresent à true
						if (niveau.ElementsDuNiveau[k].PositionElement[0] == i && //PositionElement[0] : position de l'élément en X
							niveau.ElementsDuNiveau[k].PositionElement[1] == j)   //PositionElement[1] : position de l'élément en Y
						{
							symbolePresent = true;
							positionSymbole = k;
							break;
						}
					}

					AffichageElement(symbolePresent, niveau, positionSymbole);

					//Bord droit de la dernière colonne d'une ligne
					Console.Write("|");
				}
				Console.WriteLine();
			}
			NombreTiretsAdaptable(niveau, 1); //Tirets tout en bas du tableau
		}

		/// <summary>
		/// Permet de mettre en forme un élément (couleur rouge si le joueur est présent sur cette case)
		/// </summary>
		/// <param name="symbolePresent">Booléen qui permet de savoir si il y'a un élément sur la carte. Il vaut true si un élément est présent sur la case.</param>
		/// <param name="niveau">Niveau du jeu</param>
		/// <param name="positionTableauElements">Position de l'élément dans le tableau d'éléments du niveau</param>
		static public void AffichageElement(bool symbolePresent, Niveau niveau, int positionTableauElements)
		{
			Porte porteTemp;

			//Si un symbole est présent sur la case en train d'être dessinée, on le dessine
			if (symbolePresent == true)
			{
				//Si l'élément est sur la même case que le personnage, on l'affiche en rouge
				if (niveau.ElementsDuNiveau[positionTableauElements].PositionElement[0] == DonneesNiveau.personnagePrincipal.PositionElement[0] &&
				   niveau.ElementsDuNiveau[positionTableauElements].PositionElement[1] == DonneesNiveau.personnagePrincipal.PositionElement[1])
				{
					Console.ForegroundColor = ConsoleColor.Red;

					//Si cet élément est une porte
					if (niveau.ElementsDuNiveau[positionTableauElements].Nom == "Porte")
					{
						porteTemp = (Porte)niveau.ElementsDuNiveau[positionTableauElements];
						//Si la porte est ouverte on affiche le symbole du personnage
						if (porteTemp.Ouverte == true) Console.Write(" " + DonneesNiveau.personnagePrincipal.Symbole + " ");

					}//Fin du "si cet élément est une porte"

					//Si cet élément est une manivelle
					else if (niveau.ElementsDuNiveau[positionTableauElements].Nom == "manivelle")
					{
						Console.Write(" " + DonneesNiveau.personnagePrincipal.Symbole + " ");
					}

					//Sinon
					else Console.Write(" " + niveau.elementsDuNiveau[positionTableauElements].Symbole + " ");

					Console.ResetColor();
				} //FIn du "si un symbole est présent sur la même case que le personnage"

				//Si il n'est pas sur la même case que le personnage
				else
				{
					CouleurDuSymbole(niveau.ElementsDuNiveau[positionTableauElements]);
				}

			} //Fin du "si un symbole est présent"

			//Sinon on affiche des espaces
			else
			{
				Console.Write("   ");
			}
		}

		/// <summary>
		/// On affiche l'élément avec une couleur prédéfinie dans cette fonction
		/// </summary>
		/// <param name="element"></param>
		static private void CouleurDuSymbole(MapElement element)
		{
			//Si c'est un message
			if (element.Symbole == 'M') Console.ForegroundColor = ConsoleColor.Green;

			//Si c'est un bloc ou un bouton
			else if (element.Symbole == 'B' || element.Symbole == 'b') Console.ForegroundColor = ConsoleColor.Cyan;

			//Si c'est un mur
			else if (element.Symbole == 'X') Console.ForegroundColor = ConsoleColor.DarkRed;

			//Si c'est un danger
			else if (element.Symbole == 'D') Console.ForegroundColor = ConsoleColor.Magenta;

			//Si c'est la sortie
			else if (element.Symbole == 'S') Console.ForegroundColor = ConsoleColor.Yellow;

			Console.Write(" " + element.Symbole + " ");
			Console.ResetColor();

		}

		/// <summary>
		/// Permet d'afficher le niveau suivant celui dans lequel le joueur se trouve
		/// </summary>
		/// <param name="niveau">Niveau du jeu</param>
		static public void AfficherLeNiveauSuivant(Niveau niveau)
		{
			int i = 0;
			//On regarde dans quel niveau le joueur se trouve
			for (i = 0; i < DonneesNiveau.tableauNiveaux.Length; i++)
			{
				if (i == niveau.Numero - 1) break;
			}

			//Pour ensuite afficher le niveau suivant
			AffichageNiveau(DonneesNiveau.tableauNiveaux[i + 1]);

		}

		/// <summary>
		/// Cette fonction permet de stocker la position de la sortie afin d'éviter de reparcourir le tableau plusieurs fois
		/// </summary>
		/// <param name="niveau">Niveau du jeu dans lequel on ira chercher la position de la sortie</param>
		/// <param name="positionSortie">Indique la position en abscisse et en ordonnée de la sortie du jeu</param>
		static private void RecherchePositionSortie(Niveau niveau, int[] positionSortie)
		{
			for (int i = 0; i < niveau.ElementsDuNiveau.Length - 1; i++)
			{
				//Si le symbole de l'élément du niveau sur lequel on est dans le tableau est un S, c'est qu'on est sur un élément Sortie
				if (niveau.ElementsDuNiveau[i].Symbole == 'S')
				{
					positionSortie[0] = niveau.ElementsDuNiveau[i].PositionElement[0];
					positionSortie[1] = niveau.ElementsDuNiveau[i].PositionElement[1];
					break;
				}
			}
		}

		// *****************************************************
		//					AFFICHAGE MENU
		// *****************************************************

		/// <summary>
		/// Permet d'afficher le titre du jeu
		/// </summary>
		static private void TitreDuJeu()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\t\t\t ------ ----- ---------");
			Console.Write("\t\t\t|");

			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("-FEAR---THE---DUNGEON-");

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("|");
			Console.WriteLine("\t\t\t ------ ----- ---------\n");

			Console.ResetColor();

		}

		/// <summary>
		/// Permet d'afficher proprement un objet de la classe Menu
		/// </summary>
		/// <param name="menu">Menu qui sera affiché par la fonction</param>
		static private void AffichageMenu(Menu menu)
		{
			int longueurMax = menu.LongueurChaineMax(), nombreDEspaces = 0;

			Console.ForegroundColor = ConsoleColor.Yellow;

			NombreTiretsAdaptable(menu, 1);

			for (int i = 0; i < menu.OptionsDuMenu.Length; i++)
			{
				Console.Write("\t\t\t| " + (i + 1) + ". " + menu.OptionsDuMenu[i]);
				nombreDEspaces = longueurMax - menu.OptionsDuMenu[i].Length;
				while (nombreDEspaces >= 0)
				{
					Console.Write(" ");
					nombreDEspaces--;
				}
				Console.WriteLine("|");
			}

			NombreTiretsAdaptable(menu, 1);

		}

		/// <summary>
		/// Permet d'afficher tous les niveaux du jeu
		/// </summary>
		/// <param name="niveau">Niveau du jeu</param>
		static public void AffichageMenuDesNiveaux(Niveau[] niveau)
		{
			int niveauChoisie;
			bool choixValide = false;

			//Le joueur choisit le niveau qu'il désire
			do
			{
				Console.Clear();
				Affichage.TitreDuJeu();

				//Boucle qui permet d'afficher les différents niveaux du jeu
				for (int i = 0; i < niveau.Length; i++)
				{


					//Bordure supérieure du tableau
					Console.WriteLine("\t\t\t     ---------------");

					//Bordure gauche du tableau
					Console.Write("\t\t\t    |");

					//Si le niveau est débloqué on l'affiche en blanc, sinon en gris
					if (i <= DonneesPubliques.niveauDebloque) Console.ForegroundColor = ConsoleColor.White;
					else Console.ForegroundColor = ConsoleColor.DarkGray;
					Console.Write("   Niveau " + (i + 1));
					Console.ResetColor();

					//Bordure droite du tableau
					if (i < 9) Console.WriteLine("    |");
					else if (i < 100) Console.WriteLine("   |");

				}

				//Bordure inférieure du tableau
				Console.WriteLine("\t\t\t     ---------------");

				//Case Retour
				Console.Write("\t\t\t    |");
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write("   0. Retour  ");
				Console.ResetColor();
				Console.WriteLine(" |");
				Console.WriteLine("\t\t\t     ---------------");

				FonctionnementMenu(1);


				choixValide = int.TryParse(Console.ReadLine(), out niveauChoisie);
				if (!choixValide)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Veuillez taper un nombre correspondant à un niveau que vous avez débloqué !");
					Console.WriteLine("Appuyez sur n'importe quelle touche pour continuer");
					Console.ReadKey(true);
					Console.ResetColor();
				} 
				if (choixValide) choixValide = (niveauChoisie < 0 || niveauChoisie > niveau.Length) ? false : true;
			} while (!choixValide);

			//Si le joueur tape 0, il retourne au menu des options des niveaux
			if (niveauChoisie == 0) Affichage.JoueurChoisitUneOptionDansLeMenu(DonnéesMenu.MenuNiveau);
			else Fonctions.OptionChoisieMenuDesNiveaux(niveauChoisie);
		}

		/// <summary>
		/// Affiche à l'utilisateur comment le menu fonctionne
		/// </summary>
		///<param name="consigneChoisie">Instruction à afficher pour expliquer au joueur comment fonctionne le menu</param>
		static private void FonctionnementMenu(int consigneChoisie)
		{
			Console.ForegroundColor = ConsoleColor.Red;

			//Gestion des tabulations en fonction de la langue sélectionnée
			if (DonneesPubliques.langue == "Français") Console.Write("\n\t\t");
			else if (DonneesPubliques.langue == "Anglais") Console.Write("\n\t");

			Console.WriteLine(DonnéesMenu.FonctionnementMenu[consigneChoisie] + "\n");
			Console.ResetColor();
		}

		/// <summary>
		/// Affiche le menu complet avec le titre du jeu. L'utilisateur devra choisir une option dans ce menu
		/// </summary>
		/// <param name="menu">Paramètre dans lequel on va récupérer les options du menu</param>
		static public void JoueurChoisitUneOptionDansLeMenu(Menu menu)
		{
			int optionChoisie;
			bool choixValide;

			do
			{
				Console.Clear();
				Affichage.TitreDuJeu();
				Affichage.AffichageMenu(menu);
				Affichage.FonctionnementMenu(0);

				choixValide = int.TryParse(Convert.ToString(Console.ReadKey(true).KeyChar), out optionChoisie);

				if (choixValide) choixValide = (optionChoisie < 1 || optionChoisie > menu.OptionsDuMenu.Length) ? false : true;
			} while (!choixValide);


			menu.OptionChoisie = optionChoisie;

			Fonctions.AppelOptionChoisie(menu);

		}

	}
}
