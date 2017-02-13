using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	public class Program
	{
		static void Main(string[] args)
		{
			// ***************************************************
			//        DECLARATION DES VARIABLES DU PROGRAMME
			// ***************************************************


			// ***************************************************
			//				DEROULEMENT DU PROGRAMME
			// ***************************************************

			//On règle la taille de l'écran de la console
			Console.SetBufferSize(80, 55);
			Console.SetWindowSize(80, 55);

			DonneesNiveau.ChargementDesMurs(DonneesNiveau.tableauDeMurs);
			DonneesNiveau.ChargementDesDangers(DonneesNiveau.tableauDeDangers);

			Affichage.JoueurChoisitUneOptionDansLeMenu(DonnéesMenu.MenuPrincipal);
			
		}
	}
}
