using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FearTheDungeon
{
	abstract class Affichage
	{

		/// <summary>
		/// Permet d'afficher proprement un objet de la classe Menu
		/// </summary>
		/// <param name="menu"></param>
		static private void AffichageMenu(Menu menu)
		{
			int longueurMax = menu.LongueurChaineMax(), nombreDEspaces = 0 ;

			Console.ForegroundColor = ConsoleColor.Yellow;

			NombreTiretsAdaptable(menu);

			for(int i=0; i < menu.OptionsDuMenu.Length; i++)
			{
				Console.Write("\t\t\t| "+(i+1)+". " + menu.OptionsDuMenu[i]);
				nombreDEspaces = longueurMax - menu.OptionsDuMenu[i].Length;
				while(nombreDEspaces >= 0)
				{
					Console.Write(" ");
					nombreDEspaces--;
				}
				Console.WriteLine("|");
			}

			NombreTiretsAdaptable(menu);

		}

		/// <summary>
		/// Permet d'afficher tous les niveaux du jeu
		/// </summary>
		static public void AffichageMenuDesNiveaux(Niveau[] niveau)
		{
			int niveauChoisie;
			bool choixValide = false;


			Console.Clear();
			Affichage.TitreDuJeu();

			//Boucle qui permet d'afficher les différents niveaux du jeu
			for (int i=0; i<niveau.Length; i++)
			{


				//Bordure supérieure du tableau
				Console.WriteLine("\t\t\t     ---------------");

				//Bordure gauche du tableau
				Console.Write("\t\t\t    |");

				//Si le niveau est débloqué on l'affiche en blanc, sinon en gris
				if (i <= DonneesPubliques.niveauDebloque) Console.ForegroundColor = ConsoleColor.White;
				else Console.ForegroundColor = ConsoleColor.Gray;
				Console.Write("   Niveau " + (i + 1));
				Console.ResetColor();

				//Bordure droite du tableau
				if (i < 10) Console.WriteLine("    |");
				else if (i < 100) Console.WriteLine("  |");

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

			//Le joueur choisit le niveau qu'il désire
			do
			{
				choixValide = int.TryParse(Convert.ToString(Console.ReadKey(true).KeyChar), out niveauChoisie);
				if (choixValide) choixValide = (niveauChoisie < 0 || niveauChoisie > niveau.Length) ? false : true;
			} while (!choixValide);

			//Si le joueur tape 0, il retourne au menu des options des niveaux
			if (niveauChoisie == 0) Affichage.JoueurChoisitUneOptionDansLeMenu(DonnéesMenu.MenuNiveau);
			else Fonctions.OptionChoisieMenuDesNiveaux(niveauChoisie);
		}

		/// <summary>
		/// Affichage d'un texte entouré d'un tableau
		/// </summary>
		/// <param name="nomDuNiveau"></param>
		static public void AffichageTexte(string nomDuNiveau)
		{
			//Les contours du tableau du nom du niveau sont affichés en jaune
			//Le nom du niveau est affiché en rouge

			Console.ForegroundColor = ConsoleColor.Yellow;
			NombreTiretsAdaptable(nomDuNiveau);
			Console.Write("\t\t\t| ");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write(nomDuNiveau);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(" |");
			NombreTiretsAdaptable(nomDuNiveau);
			Console.ResetColor();
		}

		/// <summary>
		/// Affiche le titre du niveau et sa carte contenant tous ses éléments
		/// </summary>
		/// <param name="niveau"></param>
		static public void AffichageNiveau(Niveau niveau)
		{
			int [] positionSortie = new int[2];
			bool leJoueurEstSurLaCaseDeLaSortie = false;

			RecherchePositionSortie(niveau, positionSortie);

			//La boucle du niveau continue tant que le joueur n'est pas sur la case de la sortie
			do
			{
				Console.Clear();

				//On affiche le nom du niveau tout en haut de l'écran
				AffichageTexte(niveau.Nom);

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
						//AffichageTexte(); //Affiche le message contenu dans la case message
					}
				}

				//Le joueur choisit son déplacement
				Deplacement.MouvementJoueur(niveau);

				//Si le joueur est sur la case de la sortie alors on quitte la boucle
				if (DonneesNiveau.personnagePrincipal.PositionElement[0] == positionSortie[0] &&
					DonneesNiveau.personnagePrincipal.PositionElement[1] == positionSortie[1])
					leJoueurEstSurLaCaseDeLaSortie = true;

			}while (!leJoueurEstSurLaCaseDeLaSortie);

			//On charge les paramètres du niveau suivant et on indique dans données publiques que le niveau suivant est débloqué
			Initialisations.InitialisationNiveauSuivant(niveau);
			DonneesPubliques.niveauDebloque++;

			AfficherLeNiveauSuivant(niveau);


		}

		/// <summary>
		/// Affiche à l'utilisateur comment le menu fonctionne
		/// </summary>
		static private void FonctionnementMenu(int consigneChoisie)
		{
			Console.ForegroundColor = ConsoleColor.Red;

            //Gestion des tabulations en fonction de la langue sélectionnée
            if (DonneesPubliques.langue == "Français") Console.Write("\n\t\t");
            else if (DonneesPubliques.langue == "Anglais") Console.Write("\n\t");

            Console.WriteLine(DonnéesMenu.FonctionnementMenu[consigneChoisie]+"\n");
			Console.ResetColor();
		}

		/// <summary>
		/// Affiche le menu complet avec le titre du jeu. L'utilisateur devra choisir une option dans ce menu
		/// </summary>
		/// <param name="menu"></param>
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

		/// <summary>
		/// Adapte le nombre de tirets dessinant les contours du tableau en fonction de la longueur de la chaîne la plus longue
		/// </summary>
		/// <param name="menu"></param>
		static private void NombreTiretsAdaptable(Menu menu)
		{
			int longueurChaineMax = menu.LongueurChaineMax();
			Console.Write("\t\t\t ");
			for (int i = 0; i < longueurChaineMax + 5; i++)
			{
				Console.Write("-");
			}
			Console.WriteLine();
		}

		/// <summary>
		/// Adapte le nombre de tirets dessinant les contours du tableau en fonction de la longueur de la chaîne la plus longue
		/// </summary>
		/// <param name="menu"></param>
		static private void NombreTiretsAdaptable(Niveau niveau)
		{
			Console.Write("\t\t\t ");
			for (int i = 0; i < niveau.CarteDuNiveau.NombreColonnes + 14; i++)
			{
				Console.Write("-");
			}
			Console.WriteLine();
		}

		/// <summary>
		/// Adapte le nombre de tirets dessinant les contours du tableau en fonction de la longueur de la chaîne la plus longue
		/// </summary>
		/// <param name="chaine"></param>
		static public void NombreTiretsAdaptable(string chaine)
		{
			Console.Write("\t\t\t");
			Console.Write(" ");

			for(int i = 1; i < chaine.Length+3; i++)
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
		/// Affiche la carte du niveau
		/// </summary>
		/// <param name="niveau"></param>
		static private void MapDuNiveau(Niveau niveau)
		{

			bool symbolePresent;
			int positionSymbole = 0;

			//Début de l'affichage du tableau
			for (int i = 0; i < niveau.CarteDuNiveau.NombreLignes; i++) //Boucle des lignes
			{
				NombreTiretsAdaptable(niveau);

				//Bord gauche de la première case tout à gauche
				Console.Write("\t\t\t|");
				for (int j = 0; j < niveau.CarteDuNiveau.NombreColonnes; j++) //Boucle des colonnes
				{
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
			NombreTiretsAdaptable(niveau); //Tirets tout en bas du tableau
		}

		/// <summary>
		/// Permet de mettre en forme un élément (couleur rouge si le joueur est présent sur cette case)
		/// </summary>
		static public void AffichageElement(bool symbolePresent, Niveau niveau, int positionTableauElements)
		{
			//Si un symbole est présent sur la case en train d'être dessinée, on le dessine
			if (symbolePresent == true)
			{
				//Si l'élément est sur la même case que le personnage, on l'affiche en rouge
				if(niveau.ElementsDuNiveau[positionTableauElements].PositionElement[0] == DonneesNiveau.personnagePrincipal.PositionElement[0] &&
				   niveau.ElementsDuNiveau[positionTableauElements].PositionElement[1] == DonneesNiveau.personnagePrincipal.PositionElement[1])
				{
					Console.ForegroundColor = ConsoleColor.Red;

				}

				Console.Write(" " + niveau.elementsDuNiveau[positionTableauElements].Symbole + " ");
				Console.ResetColor();
			}

			//Sinon on affiche des espaces
			else
			{
				Console.Write("   ");
			}
		}

		/// <summary>
		/// Permet d'afficher le niveau suivant celui dans lequel le joueur se trouve
		/// </summary>
		/// <param name="niveau"></param>
		static public void AfficherLeNiveauSuivant(Niveau niveau)
		{
			int i = 0;
			//On regarde dans quel niveau le joueur se trouve
			for(i=0; i<DonneesNiveau.tableauNiveaux.Length; i++)
			{
				if (i == niveau.Numero-1) break;
			}

			//Pour ensuite afficher le niveau suivant
			AffichageNiveau(DonneesNiveau.tableauNiveaux[i + 1]);

		}

		/// <summary>
		/// Cette fonction permet de stocker la position de la sortie afin d'éviter de reparcourir le tableau plusieurs fois
		/// </summary>
		/// <param name="niveau"></param>
		/// <param name="positionSortie"></param>
		static private void RecherchePositionSortie(Niveau niveau, int[] positionSortie)
		{
			for(int i=0; i<niveau.ElementsDuNiveau.Length-1; i++)
			{
				if(niveau.ElementsDuNiveau[i].Symbole == 'S')
				{
					positionSortie[0] = niveau.ElementsDuNiveau[i].PositionElement[0];
					positionSortie[1] = niveau.ElementsDuNiveau[i].PositionElement[1];
					break;
				}
			}
		}
		
	}
}
