using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	class DonneesNiveau
	{
		//Cartes des niveaux
		private static Map carteNiveau1 = new Map(5, 5);
		private static Map carteNiveau2 = new Map(5, 5);
		private static Map carteNiveau3 = new Map(5, 5);

		//Element des niveaux
		MapElement personnagePrincipal = new MapElement();

		//Les niveaux
		public static Niveau niveau1 = new Niveau(carteNiveau1, "La grandeur des petits débuts", 1, "AEX171", true);
		public static Niveau niveau2 = new Niveau(carteNiveau2, "Sans effort, pas de gloire", 2, "BGF211", false);
		public static Niveau niveau3 = new Niveau(carteNiveau3, "Niveau 3", 3, "HDE841", false);

		/// <summary>
		/// Contient tous les niveaux du jeu
		/// </summary>
		public static Niveau[] tableauNiveaux = { niveau1, niveau2, niveau3};
	}
}
