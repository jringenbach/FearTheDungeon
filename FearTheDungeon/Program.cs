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

			Console.SetBufferSize(80, 55);
			Console.SetWindowSize(80, 55);
			Affichage.JoueurChoisitUneOptionDansLeMenu(DonnéesMenu.MenuPrincipal);
			
		}
	}
}
