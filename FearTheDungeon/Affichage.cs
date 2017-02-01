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
		/// Affiche le menu complet avec le titre du jeu. L'utilisateur devra choisir une option dans ce menu
		/// </summary>
		/// <param name="menu"></param>
		static public void SelectionDansLeMenu(Menu menu)
		{
			int optionChoisie;
			bool choixValide;

			do
			{

				Affichage.TitreDuJeu();
				Affichage.AffichageMenu(menu);
				
				choixValide = int.TryParse(Convert.ToString(Console.ReadKey(true).KeyChar), out optionChoisie);

				if (choixValide) choixValide = (optionChoisie < 1 || optionChoisie > menu.OptionsDuMenu.Length) ? false : true;
				

			} while (!choixValide);

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
