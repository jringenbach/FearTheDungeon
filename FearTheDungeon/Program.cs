using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	class Program
	{
		static void Main(string[] args)
		{
			// ***************************************************
			//        DECLARATION DES VARIABLES DU PROGRAMME
			// ***************************************************


			// ***************************************************
			//				DEROULEMENT DU PROGRAMME
			// ***************************************************

			Initialisations.InitialisationNiveau1();
			Affichage.JoueurChoisitUneOptionDansLeMenu(DonnéesMenu.MenuPrincipal);
			
		}
	}
}
