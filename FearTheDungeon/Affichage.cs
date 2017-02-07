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
		/// Affiche le niveau
		/// </summary>
		/// <param name="niveau"></param>
		static public void AffichageNiveau(Niveau niveau)
		{
			Console.Clear();

			//On affiche le nom du niveau tout en haut de l'écran
			AffichageTexte(niveau.Nom);
			

			//Début de l'affichage du tableau
			for(int i=0; i<niveau.CarteDuNiveau.NombreLignes; i++)
			{
				NombreTiretsAdaptable(niveau);

				///Bord gauche de la première case tout à gauche
				Console.Write("\t\t\t|   ");
				for (int j=0; j < niveau.CarteDuNiveau.NombreColonnes; j++)
				{
					Console.Write("|   ");
				}
				Console.WriteLine();
			}

			NombreTiretsAdaptable(niveau); //Tirets tout en bas du tableau

			//Si le joueur est sur une case message, on lui affiche un message en dessous de la carte du niveau
			for(int i=0; i<niveau.ElementsDuNiveau.Length; i++)
			{
				//On regarde si la position du joueur est égal à la position d'une case Message
				if(niveau.ElementsDuNiveau[i].Symbole == 'M' &&
				   DonneesNiveau.personnagePrincipal.PositionElement[0] == niveau.ElementsDuNiveau[i].PositionElement[0] &&
				   DonneesNiveau.personnagePrincipal.PositionElement[1] == niveau.ElementsDuNiveau[i].PositionElement[1])
				{
					//AffichageTexte(); //Affiche le message contenu dans la case message
				}
			}

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
			Console.Write("\t\t\t ");
			for (int i = 0; i < menu.LongueurChaineMax() + 5; i++)
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

	}
}
