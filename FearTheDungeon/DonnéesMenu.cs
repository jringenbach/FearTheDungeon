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
		static private string[] _menuPrincipal = {"Lancer le jeu", "Options", "Quitter"};

		/// <summary>
		/// Menu affiché lorsque le joueur a sélectionné "Lancer le jeu" dans le menu principal.
		/// </summary>
		static private string[] _menuNiveau = {"Nouvelle Partie", "Mot de Passe", "Retour"};

		/// <summary>
		/// Variable qui contient le numéro de l'option choisie par le joueur dans le menu principal
		/// </summary>
		static private int choixMenuPrincipal;

		/// <summary>
		/// Consigne(s) du fonctionnement du menu
 		/// </summary>
		static private string[] fonctionnementMenu = {"Tapez le numéro correspondant à l'option désirée."};
		

							// ***************************************************
							//				ACCESSEURS ET MUTATEURS
							// ***************************************************

		/// <summary>
		/// Options du menu principal
		/// </summary>
		public static string[] MenuPrincipal
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
		/// Les différentes options affichées après le choix de l'option "Lancer le jeu" dans le Menu Principal
		/// </summary>
		public static string[] MenuNiveau
		{
			get
			{
				return _menuNiveau;
			}

			set
			{
				_menuNiveau = value;
			}
		}

		/// <summary>
		/// Stocke l'option choisie dans le menu principal
		/// </summary>
		public static int ChoixMenuPrincipal
		{
			get
			{
				return choixMenuPrincipal;
			}

			set
			{
				choixMenuPrincipal = value;
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
	}
}
