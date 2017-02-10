using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
    abstract class DonneesPubliques
    {
		/// <summary>
		/// Cette variable contient le niveau de difficulté du jeu
		/// </summary>
        public static string difficulte = "normal";

		/// <summary>
		/// Langue du jeu
		/// </summary>
        public static string langue = "Français";

		/// <summary>
		/// Indique le dernier niveau débloqué (tous les niveaux le précédant sont débloqués)
		/// </summary>
		public static int niveauDebloque = 0;

		/// <summary>
		/// Contient tous les mots de passe non liés aux niveaux du jeu
		/// </summary>
		public static string[] motDePasseSecret = {"879121"};

		/// <summary>
		/// Phrases affichées quand on tape le mode de passe "879121"
		/// </summary>
		public static string[] phrasesDuMdp879121 = {"J'ai l'intime sensation...",
													 "... que la suite ...",
													 "... ne va pas te plaire ...",
													 "... Aurevoir ! ..."};
    }
}
