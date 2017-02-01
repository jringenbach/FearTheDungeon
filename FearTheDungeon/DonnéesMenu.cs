using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	abstract class DonnéesMenu
	{
							// ***************************************************
							//				DECLARATION DES VARIABLES
							// ***************************************************

		/// <summary>
		/// Options du menu principal
		/// </summary>
		static private string[] _menuPrincipalOptions = {"Lancer le jeu", "Options", "Quitter"};

		/// <summary>
		/// Menu principal
		/// </summary>
		static private Menu _menuPrincipal = new Menu(MenuPrincipalOptions);

		/// <summary>
		/// Options du menu des niveaux
		/// </summary>
		static private string[] _menuNiveauOptions = {"Nouvelle Partie", "Mot de Passe", "Retour"};

		/// <summary>
		/// Objet menu des niveaux
		/// </summary>
		static private Menu menuNiveau = new Menu(MenuNiveauOptions);

		/// <summary>
		/// Options du menu des options
		/// </summary>
		static private string[] _menuOptionsOptions = {"Difficulté","Retour"};

		/// <summary>
		/// Menu des options du jeu
		/// </summary>
		static private Menu _menuOptions = new Menu(_menuOptionsOptions);

		/// <summary>
		/// Options du menu de difficultés
		/// </summary>
		static private string[] _menuDifficulteOptions = {"Normal", "Difficile", "Retour" };

		/// <summary>
		/// Menu des difficultés
		/// </summary>
		static private Menu _menuDifficulte = new Menu(MenuDifficulteOptions);

		/// <summary>
		/// Variable qui contient le numéro de l'option choisie par le joueur dans le menu principal
		/// </summary>
		static private int _choixOptionsMenuPrincipal;

		/// <summary>
		/// Variable qui contient le numéro de l'option choisie par le joueur dans le menu de choix des niveaux
		/// </summary>
		static private int _choixOptionsMenuDesNiveaux;

		/// <summary>
		/// Consigne(s) du fonctionnement du menu
 		/// </summary>
		static private string[] fonctionnementMenu = {"Tapez le numéro correspondant à l'option désirée."};

		/// <summary>
		/// Tableau contenant tous les menus
		/// </summary>
		static private Menu[] _tableauDesMenus = { MenuPrincipal, MenuNiveau, MenuOptions, MenuDifficulte};


									// ***************************************************
									//				ACCESSEURS ET MUTATEURS
									// ***************************************************


		/// <summary>
		/// Options du menu principal
		/// </summary>
		public static string[] MenuPrincipalOptions
		{
			get
			{
				return _menuPrincipalOptions;
			}

			set
			{
				_menuPrincipalOptions = value;
			}
		}

		/// <summary>
		/// Les différentes options affichées après le choix de l'option "Lancer le jeu" dans le Menu Principal
		/// </summary>
		public static string[] MenuNiveauOptions
		{
			get
			{
				return _menuNiveauOptions;
			}

			set
			{
				_menuNiveauOptions = value;
			}
		}

		/// <summary>
		/// Permet d'obtenir le menu des options
		/// </summary>
		public static string[] MenuOptionsOptions
		{
			get
			{
				return _menuOptionsOptions;
			}

			set
			{
				_menuOptionsOptions = value;
			}
		}

		/// <summary>
		/// Menu principal
		/// </summary>
		public static Menu MenuPrincipal
		{
			get
			{
				return _menuPrincipal;
			}

			set
			{
				_menuPrincipal = value;
			}
		}

		/// <summary>
		/// Menu des niveaux
		/// </summary>
		public static Menu MenuNiveau
		{
			get
			{
				return menuNiveau;
			}

			set
			{
				menuNiveau = value;
			}
		}

		/// <summary>
		/// Menu des options
		/// </summary>
		public static Menu MenuOptions
		{
			get
			{
				return _menuOptions;
			}

			set
			{
				_menuOptions = value;
			}
		}

		/// <summary>
		/// Stocke l'option choisie dans le menu principal
		/// </summary>
		public static int ChoixOptionsMenuPrincipal
		{
			get
			{
				return _choixOptionsMenuPrincipal;
			}

			set
			{
				_choixOptionsMenuPrincipal = value;
			}
		}

		/// <summary>
		/// Stocke l'option choisie dans le menu de choix des niveaux
		/// </summary>
		public static int ChoixOptionsMenuDesNiveaux
		{
			get
			{
				return _choixOptionsMenuDesNiveaux;
			}

			set
			{
				_choixOptionsMenuDesNiveaux = value;
			}
		}

		/// <summary>
		/// Règles concernant le fonctionnement d'un menu
		/// </summary>
		public static string[] FonctionnementMenu
		{
			get
			{
				return fonctionnementMenu;
			}

			set
			{
				fonctionnementMenu = value;
			}
		}

		/// <summary>
		/// Tableau contenant tous les menus du jeu
		/// </summary>
		public static Menu[] TableauDesMenus
		{
			get
			{
				return _tableauDesMenus;
			}

			set
			{
				_tableauDesMenus = value;
			}
		}

		public static string[] MenuDifficulteOptions
		{
			get
			{
				return _menuDifficulteOptions;
			}

			set
			{
				_menuDifficulteOptions = value;
			}
		}

		public static Menu MenuDifficulte
		{
			get
			{
				return _menuDifficulte;
			}

			set
			{
				_menuDifficulte = value;
			}
		}





		// ***************************************************
		//						METHODES
		// ***************************************************

		static public void InitialisationDonnéesMenu()
		{
			DonnéesMenu.ChoixOptionsMenuPrincipal = 0;
			DonnéesMenu.ChoixOptionsMenuDesNiveaux = 0;
		}


	}
}
