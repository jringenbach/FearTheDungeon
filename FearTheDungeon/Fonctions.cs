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
			bool menuAppelantEstLeMenuDesOptionsDesNiveaux = false;
			bool menuAppelantEstLeMenuDesOptions = false;
			bool menuAppelantEstLeMenuDesDifficultes = false;
            bool menuAppelantEstLeMenuDesLangues = false;

			int i = 0;

			for(i=0; i < DonnéesMenu.TableauDesMenus.Length; i++)
			{
				if(menu == DonnéesMenu.TableauDesMenus[i])
				{
					break;
				}
			}

            //On regarde quel menu est appelé
            if (i == 0) menuAppelantEstLeMenuPrincipal = true;
            else if (i == 1) menuAppelantEstLeMenuDesOptionsDesNiveaux = true;
            else if (i == 2) menuAppelantEstLeMenuDesOptions = true;
            else if (i == 3) menuAppelantEstLeMenuDesDifficultes = true;
            else if (i == 4) menuAppelantEstLeMenuDesLangues = true;

            //On appelle ensuite le bon menu
            if (menuAppelantEstLeMenuPrincipal) AppelOptionChoisieMenuPrincipal(menu);
            else if (menuAppelantEstLeMenuDesOptionsDesNiveaux) AppelOptionChoisieMenuDesOptionsDesNiveaux(menu);
            else if (menuAppelantEstLeMenuDesOptions) AppelOptionChoisieMenuDesOptions(menu);
            else if (menuAppelantEstLeMenuDesDifficultes) AppelOptionChoisieMenuDifficultes(menu);
            else if (menuAppelantEstLeMenuDesLangues) AppelOptionChoisieMenuDesLangues(menu);


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
					Affichage.JoueurChoisitUneOptionDansLeMenu(DonnéesMenu.MenuOptions);
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

		static public void OptionChoisieMenuDesNiveaux(int niveauChoisie)
		{

				Affichage.AffichageNiveau(DonneesNiveau.tableauNiveaux[niveauChoisie - 1]);

		}

		/// <summary>
		/// On regarde l'option choisie dans le menu des niveaux pour afficher les fonctionnalités qui lui sont associées
		/// </summary>
		/// <param name="optionChoisie"></param>
		static public void AppelOptionChoisieMenuDesOptionsDesNiveaux(Menu menu)
		{
			switch (menu.OptionChoisie)
			{
				//On lance le jeu à partir du premier niveau
				case 1:
					Affichage.AffichageMenuDesNiveaux(DonneesNiveau.tableauNiveaux);
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

		/// <summary>
		/// On regarde ce que le joueur a choisi dans le menu des options
		/// </summary>
		/// <param name="menu"></param>
		static public void AppelOptionChoisieMenuDesOptions(Menu menu)
		{
			switch (menu.OptionChoisie)
			{
				//Le joueur accède au menu des difficultés
				case 1:
					Affichage.JoueurChoisitUneOptionDansLeMenu(DonnéesMenu.MenuDifficulte);
					break;

                //Choix de la langue
                case 2:
                    Affichage.JoueurChoisitUneOptionDansLeMenu(DonnéesMenu.MenuDesLangues);
                    break;

					//Le joueur retourne au menu principal
				case 3:
					Affichage.JoueurChoisitUneOptionDansLeMenu(DonnéesMenu.MenuPrincipal);
					break;

				default:
					break;
			}
		}

		/// <summary>
		/// Actions résultants du choix du joueur dans le menu du choix de difficultés
		/// </summary>
		/// <param name="menu"></param>
		static public void AppelOptionChoisieMenuDifficultes(Menu menu)
		{
			switch (menu.OptionChoisie)
			{
				case 1:
					DonneesPubliques.difficulte = "normal";
					Affichage.JoueurChoisitUneOptionDansLeMenu(DonnéesMenu.MenuOptions);
					break;

				case 2:
					DonneesPubliques.difficulte = "difficile";
					Affichage.JoueurChoisitUneOptionDansLeMenu(DonnéesMenu.MenuOptions);
					break;

				case 3:
					Affichage.JoueurChoisitUneOptionDansLeMenu(DonnéesMenu.MenuOptions);
					break;

				default:
					break;
			}
		}

        /// <summary>
        /// Actions résultants du choix du joueur dans le menu des langues.
        /// </summary>
        /// <param name="menu"></param>
        static public void AppelOptionChoisieMenuDesLangues(Menu menu)
        {
            switch (menu.OptionChoisie)
            {
                //L'utilisateur choisit de mettre le jeu en français
                case 1:
                    if (DonneesPubliques.langue == "Français") Affichage.JoueurChoisitUneOptionDansLeMenu(DonnéesMenu.MenuOptions);
                    else
                    {
                        DonneesPubliques.langue = "Français";
                        LangageFrancais();
                    } 
                    break;
                
                //L'utilisateur choisit de mettre le jeu en anglais
                case 2:
                    if (DonneesPubliques.langue == "Anglais") Affichage.JoueurChoisitUneOptionDansLeMenu(DonnéesMenu.MenuOptions);
                    else
                    {
                        DonneesPubliques.langue = "Anglais";
                        LangageAnglais();
                    }
                    break;
                
                //L'utilisateur retourne au menu précédent : le menu des options
                case 3:
                    
                    break;

                default:
                    break;
            }

            Affichage.JoueurChoisitUneOptionDansLeMenu(DonnéesMenu.MenuOptions);
        }

        /// <summary>
        /// Fonction qui permet de passer le jeu en anglais
        /// </summary>
        static public void LangageAnglais()
        {
            //Langue du menu principal
            DonnéesMenu.MenuPrincipal.OptionsDuMenu[0] = "Play The Game";
            DonnéesMenu.MenuPrincipal.OptionsDuMenu[1] = "Settings";
            DonnéesMenu.MenuPrincipal.OptionsDuMenu[2] = "Quit";

            //Langue du menu des niveaux
            DonnéesMenu.MenuNiveau.OptionsDuMenu[0] = "New Game";
            DonnéesMenu.MenuNiveau.OptionsDuMenu[1] = "Password";
            DonnéesMenu.MenuNiveau.OptionsDuMenu[2] = "Back";

            //Langue du menu des options
            DonnéesMenu.MenuOptions.OptionsDuMenu[0] = "Difficulty";
            DonnéesMenu.MenuOptions.OptionsDuMenu[1] = "Language";
            DonnéesMenu.MenuOptions.OptionsDuMenu[2] = "Back";

            //Langue du menu des difficultés
            DonnéesMenu.MenuDifficulte.OptionsDuMenu[0] = "Normal";
            DonnéesMenu.MenuDifficulte.OptionsDuMenu[1] = "Hard";
            DonnéesMenu.MenuDifficulte.OptionsDuMenu[2] = "Back";

            //Langue du menu des langues
            DonnéesMenu.MenuDesLangues.OptionsDuMenu[0] = "French";
            DonnéesMenu.MenuDesLangues.OptionsDuMenu[1] = "English";
            DonnéesMenu.MenuDesLangues.OptionsDuMenu[2] = "Back";

            //Langue de la consigne des menus
            DonnéesMenu.FonctionnementMenu[0] = "Select the number corresponding to the desired option";
			DonnéesMenu.FonctionnementMenu[1] = "Select the number corresponding to the desired level";

        }

        /// <summary>
        /// Fonction qui permet de passer le jeu en français
        /// </summary>
        static public void LangageFrancais()
        {
            //Langue du menu principal
            DonnéesMenu.MenuPrincipal.OptionsDuMenu[0] = "Lancer le jeu";
            DonnéesMenu.MenuPrincipal.OptionsDuMenu[1] = "Options";
            DonnéesMenu.MenuPrincipal.OptionsDuMenu[2] = "Quitter";

            //Langue du menu des niveaux
            DonnéesMenu.MenuNiveau.OptionsDuMenu[0] = "Nouvelle Partie";
            DonnéesMenu.MenuNiveau.OptionsDuMenu[1] = "Mot De Passe";
            DonnéesMenu.MenuNiveau.OptionsDuMenu[2] = "Retour";

            //Langue du menu des options
            DonnéesMenu.MenuOptions.OptionsDuMenu[0] = "Difficulté";
            DonnéesMenu.MenuOptions.OptionsDuMenu[1] = "Choix de la langue";
            DonnéesMenu.MenuOptions.OptionsDuMenu[2] = "Retour";

            //Langue du menu des difficultés
            DonnéesMenu.MenuDifficulte.OptionsDuMenu[0] = "Normal";
            DonnéesMenu.MenuDifficulte.OptionsDuMenu[1] = "Difficile";
            DonnéesMenu.MenuDifficulte.OptionsDuMenu[2] = "Retour";

            //Langue du menu des langues
            DonnéesMenu.MenuDesLangues.OptionsDuMenu[0] = "Français";
            DonnéesMenu.MenuDesLangues.OptionsDuMenu[1] = "Anglais";
            DonnéesMenu.MenuDesLangues.OptionsDuMenu[2] = "Retour";

            //Langue de la consigne des menus
            DonnéesMenu.FonctionnementMenu[0] = "Tapez le numéro correspondant à l'option désirée.";
			DonnéesMenu.FonctionnementMenu[1] = "Tapez le numéro du niveau désiré.";

		}
	}
}
