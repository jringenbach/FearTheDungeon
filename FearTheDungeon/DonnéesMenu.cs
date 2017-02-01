using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	abstract class DonnéesMenu
	{
		/// <summary>
		/// Options du menu principal
		/// </summary>
		static private string[] menuPrincipal = {"Lancer le jeu", "Options", "Quitter"};
		static private string[] choixDuNiveau = {"Nouvelle Partie", "Mot de Passe", "Retour"};

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
	}
}
