using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	class DonneesNiveau
	{
		private static Map carteNiveau1 = new Map(5, 5);
		public static Niveau niveau1 = new Niveau(carteNiveau1, "Niveau 1", 1, "AEX171", true);

		/// <summary>
		/// Contient tous les niveaux du jeu
		/// </summary>
		public static Niveau[] tableauNiveaux = { niveau1 };
	}
}
