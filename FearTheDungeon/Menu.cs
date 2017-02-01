using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	/// <summary>
	/// Instancie un menu possédant plusieurs options sélectionnables par l'utilisateur
	/// </summary>
	class Menu
	{
		/// <summary>
		/// Tableau des différentes options du menu
		/// </summary>
		string[] optionsDuMenu;

												// *****************************
												//        CONSTRUCTEURS
												// *****************************

		/// <summary>
		/// Constructeur du Menu qui prend en paramètre un tableau contenant les différentes options de ce menu
		/// </summary>
		/// <param name="options"></param>
		public Menu(string[] options)
		{
			OptionsDuMenu = options;
		}

												// **************************************
												//        ACCESSEURS ET MUTATEURS
												// **************************************

		/// <summary>
		/// Accède au tableau contenant les différentes options d'un menu
		/// </summary>
		public string[] OptionsDuMenu
		{
			get
			{
				return optionsDuMenu;
			}

			set
			{
				optionsDuMenu = value;
			}
		}

												// **************************************
												//               METHODES
												// **************************************
		
		/// <summary>
		/// Renvoie la taille de la chaîne de caractère la plus longue dans un tableau
		/// </summary>
		public int LongueurChaineMax()
		{
			int longueurMax = this.OptionsDuMenu[0].Length;

			for(int i = 1; i < this.OptionsDuMenu.Length; i++)
			{
				if(this.OptionsDuMenu[i].Length > longueurMax) longueurMax = OptionsDuMenu[i].Length;
			}

			return longueurMax;
		}


	}
}
