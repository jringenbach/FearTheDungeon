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
			Menu menuPrincipal = new Menu(DonnéesMenu.MenuPrincipal);
			Menu choixDuNiveau = new Menu(DonnéesMenu.MenuPrincipal);
			
			Affichage.TitreDuJeu();
			Affichage.AffichageMenu(menuPrincipal);
		}
	}
}
