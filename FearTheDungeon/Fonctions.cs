﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{

	/// <summary>
	/// Contient toutes les fonctions relatives aux menus : choix de l'utilisateur dans un menu
	/// </summary>
	abstract class Fonctions
	{

		// ************************************************************************
		//			FONCTIONS VERIFIANT LE CHOIX DU JOUEUR DANS LES MENUS
		// ************************************************************************

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

		/// <summary>
		/// Affiche le niveau sélectionné dans le menu des niveaux
		/// </summary>
		/// <param name="niveauChoisie"></param>
		static public void OptionChoisieMenuDesNiveaux(int niveauChoisie)
		{
			char appuiTouche;

			//Si le niveau que le joueur a choisi a bien été débloqué
			if(DonneesNiveau.tableauNiveaux[niveauChoisie-1].Debloque == true)
			{
				Initialisations.InitialisationNiveau(DonneesNiveau.tableauNiveaux[niveauChoisie - 1]);
				Affichage.AffichageNiveau(DonneesNiveau.tableauNiveaux[niveauChoisie - 1]);
			}

			//Sinon on lui affiche le message d'erreur correspondant contenu dans le tableau FonctionnementMenu
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write("\t\t");
				Console.WriteLine(DonnéesMenu.FonctionnementMenu[2]); //"Vous n'avez pas débloqué ce niveau"
				Console.Write("\t\t");
				Console.WriteLine(DonnéesMenu.FonctionnementMenu[3]);//"Appuyez sur une touche pour continuer"
				Console.ResetColor();
				appuiTouche = Console.ReadKey(true).KeyChar;

				//Une fois que le joueur a appuyé sur une touche, on le ramène au menu de choix des niveaux
				Affichage.AffichageMenuDesNiveaux(DonneesNiveau.tableauNiveaux);
			}


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
					string chaineSaisiePourLeMotDePasse;
					int niveauDebloque;
					char toucheSaisie;

					Affichage.AffichageTexte(DonnéesMenu.MenuNiveauOptions[1], 1);
					Console.WriteLine("Le mot de passe comporte 6 caractères");
					chaineSaisiePourLeMotDePasse = SaisieDuMotDePasse();
					niveauDebloque = VerificationMotDePasse(chaineSaisiePourLeMotDePasse, DonneesNiveau.tableauNiveaux);

					//Si la variable niveau débloqué égal 0, c'est que le mot de passe saisie était incorrecte
					if(niveauDebloque == 0)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						//On indique que le mot de passe est erroné et qu'il doit appuyer sur une touche pour continuer
						Console.WriteLine();
						Console.WriteLine(DonnéesMenu.FonctionnementMenu[4]);
						Console.WriteLine(DonnéesMenu.FonctionnementMenu[3]);
						Console.ResetColor();

						//L'utilisateur doit appuyer sur une touche pour avancer
						toucheSaisie = Console.ReadKey(true).KeyChar;
						Affichage.JoueurChoisitUneOptionDansLeMenu(DonnéesMenu.MenuNiveau);
					}

					//Si le mot de passe entré était bon
					else
					{
						DebloquageDesNiveaux(niveauDebloque);
						Affichage.JoueurChoisitUneOptionDansLeMenu(DonnéesMenu.MenuNiveau);

					}
					
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

		// ************************************************************************
		//						FONCTIONS DES MOTS DE PASSE
		// ************************************************************************

		/// <summary>
		/// Fonction de saisie du mot de passe
		/// </summary>
		/// <param name="niveau"></param>
		static string SaisieDuMotDePasse()
		{
			Console.WriteLine();

			char[] chaineMdp = new char[6];
			string mdp = "";


			//On initialise la chaine du mot de passe par des étoiles
			for (int i = 0; i < chaineMdp.Length; i++) chaineMdp[i] = '*';
			Console.Write("Mot de Passe : ");

			//Boucle qui permet à l'utilisateur de saisir chaque caractère
			for(int i = 0; i<chaineMdp.Length; i++)
			{
				chaineMdp[i] = Console.ReadKey(false).KeyChar;
			}

			//On insère les caractères saisis dans une chaine de caractères
			for(int i=0; i<chaineMdp.Length; i++)
			{
				mdp += chaineMdp[i];
			}

			//On retourne la chaine saisie par l'utilisateur
			return mdp;
		}

		/// <summary>
		/// On vérifie si le mot de passe débloque un niveau ou non
		/// </summary>
		/// <param name="mdpSaisie"></param>
		/// <param name="niveau"></param>
		/// <returns></returns>
		static private int VerificationMotDePasse(string mdpSaisie, Niveau[] niveau)
		{
			int niveauDebloque = 0;

			//On parcourt les mots de passe de chaque niveau pour voir si y'en a un qui est égal à la saisie du niveau
			for(int i = 0; i<niveau.Length; i++)
			{
				if(mdpSaisie == niveau[i].Password) niveauDebloque = i + 1;
			}

			return niveauDebloque;
		}

		// ********************************************************************************************
		//						FONCTIONS TRAVAILLANT SUR LES DONNEES PUBLIQUES
		// ********************************************************************************************


		/// <summary>
		/// On débloque tous les niveaux jusqu'au niveau qui possède le mot de passe entré par le joueur
		/// </summary>
		/// <param name="niveauDebloque"></param>
		static public void DebloquageDesNiveaux(int niveauDebloque)
		{
			for(int i=0; i< niveauDebloque; i++)
			{
				DonneesNiveau.tableauNiveaux[i].Debloque = true;
			}
			DonneesPubliques.niveauDebloque = niveauDebloque-1;
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
			DonnéesMenu.FonctionnementMenu[2] = "You haven't unlocked this level yet";
			DonnéesMenu.FonctionnementMenu[3] = "Press a key to continue";
			DonnéesMenu.FonctionnementMenu[4] = "Wrong Password";
			DonnéesMenu.FonctionnementMenu[5] = "The Password is 6 characters long";

			//Nom des niveaux
			DonneesNiveau.tableauNiveaux[0].Nom = "Greatness from small beginnings";
			DonneesNiveau.tableauNiveaux[1].Nom = "No pain, no gain";
			DonneesNiveau.tableauNiveaux[2].Nom = "It looks like a tutorial";
			DonneesNiveau.tableauNiveaux[3].Nom = "Defeat the Unbeaten";
			DonneesNiveau.tableauNiveaux[4].Nom = "Drunk night";
			DonneesNiveau.tableauNiveaux[5].Nom = "A Dirty Room";
			DonneesNiveau.tableauNiveaux[6].Nom = "We get used to it pretty quickly";

			//Messages des niveaux
			DonneesNiveau.message1Niveau1.Message = "M squares give you information";
			DonneesNiveau.message2Niveau1.Message = "S squares show you the exit";

			DonneesNiveau.message1Niveau2.Message = "B squares are blocks";
			DonneesNiveau.message2Niveau2.Message = "You can push Blocks B";
			DonneesNiveau.message3Niveau2.Message = "These rooms are narrow, aren't they?";

			DonneesNiveau.message1Niveau3.Message = "If you want to reset the level, press 5";
			DonneesNiveau.message2Niveau3.Message = "You can't go out now, can you?";

			DonneesNiveau.message1Niveau4.Message = "P squares are doors";
			DonneesNiveau.message2Niveau4.Message = "Push the block B on the button b";
			DonneesNiveau.message3Niveau4.Message = "Are you ready for what's coming Next ?";
			DonneesNiveau.message4Niveau4.Message = "Insert a joke here";

			DonneesNiveau.message1Niveau5.Message = "Push that block my little sunshine !";
			DonneesNiveau.message2Niveau5.Message = "Think before Acting !";


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
			DonnéesMenu.FonctionnementMenu[2] = "Vous n'avez pas débloqué ce niveau !";
			DonnéesMenu.FonctionnementMenu[3] = "Appuyez sur une touche pour continuer";
			DonnéesMenu.FonctionnementMenu[4] = "Mot de passe erroné";
			DonnéesMenu.FonctionnementMenu[5] = "Le mot de passe contient 6 caractères";

			//Nom des niveaux
			DonneesNiveau.tableauNiveaux[0].Nom = "La grandeur des petits débuts";
			DonneesNiveau.tableauNiveaux[1].Nom = "Sans effort, pas de gloire";
			DonneesNiveau.tableauNiveaux[2].Nom = "On dirait un tutoriel";
			DonneesNiveau.tableauNiveaux[3].Nom = "Vaincre l'invaincu";
			DonneesNiveau.tableauNiveaux[4].Nom = "Nuit d'ivresse";
			DonneesNiveau.tableauNiveaux[5].Nom = "Une salle sale";
			DonneesNiveau.tableauNiveaux[6].Nom = "On s'habitue vite";

			//Messages des niveaux
			DonneesNiveau.message1Niveau1.Message = "Les cases M vous donnent une information";
			DonneesNiveau.message2Niveau1.Message = "Les cases S indiquent la sortie";

			DonneesNiveau.message1Niveau2.Message = "Les cases B représentent des blocs";
			DonneesNiveau.message2Niveau2.Message = "Vous pouvez pousser les blocs B";
			DonneesNiveau.message3Niveau2.Message = "Ces pièces sont étroites, non ?";

			DonneesNiveau.message1Niveau3.Message = "Pour recharger le niveau. Appuyez sur 5";
			DonneesNiveau.message2Niveau3.Message = "Vous avez bloqué la sortie, n'est-ce pas ?";

			DonneesNiveau.message1Niveau4.Message = "Les cases P sont des portes";
			DonneesNiveau.message2Niveau4.Message = "Poussez le bloc B sur le bouton b";
			DonneesNiveau.message3Niveau4.Message = "Vous êtes à bloc pour la suite ?";
			DonneesNiveau.message4Niveau4.Message = "Insérez une blague ici";

			DonneesNiveau.message1Niveau5.Message = "Pousse ce bloc ma kikoune !";
			DonneesNiveau.message2Niveau5.Message = "Réfléchissez avant d'agir !";


		}

	}
	
}
