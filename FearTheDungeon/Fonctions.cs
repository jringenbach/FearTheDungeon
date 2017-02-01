using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	abstract class Fonctions
	{
		/// <summary>
		/// On regarde dans quel menu le joueur vient d'effectuer un choix
		/// </summary>
		/// <param name="optionChoisie"></param>
		static public void AppelOptionChoisie(Menu menu)
		{
			bool menuAppelantEstLeMenuPrincipal = false;
			bool menuAppelantEstLeMenuDesNiveaux = false;
			int i = 0;

			for(i=0; i < DonnéesMenu.TableauDesMenus.Length; i++)
			{
				if(menu == DonnéesMenu.TableauDesMenus[i])
				{
					break;
				}
			}

			if (i == 0) menuAppelantEstLeMenuPrincipal = true;
			else if (i == 1) menuAppelantEstLeMenuDesNiveaux = true;

			if (menuAppelantEstLeMenuPrincipal) AppelOptionChoisieMenuPrincipal(menu);
			else if (menuAppelantEstLeMenuDesNiveaux) AppelOptionChoisieMenuDesNiveaux(menu);


		}

		/// <summary>
		/// On affiche l'action correspondante au choix du joueur dans le menu principal
		/// </summary>
		/// <param name="menu"></param>
		static public void AppelOptionChoisieMenuPrincipal(Menu menu)
		{
			switch (menu.OptionChoisie)
			{
				//Option "lancer le jeu" choisie
				case 1:
					Affichage.JoueurChoisitUneOptionDansLeMenu(DonnéesMenu.MenuNiveau);
					break;

				//Option "Options" choisie
				case 2:

					break;

				//Option "Quitter" choisie
				case 3:
					Environment.Exit(0);
					break;

				default:
					Console.WriteLine("Vous n'êtes pas censé être ici.");
					break;
			}
		}

		/// <summary>
		/// On regarde l'option choisie dans le menu des niveaux pour afficher les fonctionnalités qui lui sont associées
		/// </summary>
		/// <param name="optionChoisie"></param>
		static public void AppelOptionChoisieMenuDesNiveaux(Menu menu)
		{
			switch (menu.OptionChoisie)
			{
				//On lance le jeu à partir du premier niveau
				case 1:
					break;
				
				//L'utilisateur va entrer un mot de passe pour arriver au niveau désiré
				case 2:
					break;

				//Permet de retourner au menu précédent : ici, le menu principal.
				case 3:
					Affichage.JoueurChoisitUneOptionDansLeMenu(DonnéesMenu.MenuPrincipal);
					break;

				default:
					Console.WriteLine("Vous n'êtes pas censé être ici.");
					break;
			}

		}

	}
}
