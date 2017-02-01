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
		static private string[] menuPrincipal = {"Lancer le jeu", "Options", "Quitter"};

		/// <summary>
		/// Menu affiché lorsque le joueur a sélectionné "Lancer le jeu" dans le menu principal.
		/// </summary>
		static private string[] choixDuNiveau = {"Nouvelle Partie", "Mot de Passe", "Retour"};

		/// <summary>
		/// Variable qui contient 
		/// </summary>
		static private int choixMenuPrincipal;

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
				return menuPrincipal;
			}

			set
			{
				menuPrincipal = value;
			}
		}

		/// <summary>
		/// Les différentes options affichées après le choix de l'option "Lancer le jeu" dans le Menu Principal
		/// </summary>
		public static string[] ChoixDuNiveau
		{
			get
			{
				return choixDuNiveau;
			}

			set
			{
				choixDuNiveau = value;
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
	}
}
