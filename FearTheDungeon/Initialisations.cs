using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	abstract class Initialisations
	{
		/// <summary>
		/// Initialise les données du niveau 1
		/// </summary>
		public static void InitialisationNiveau1()
		{
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.message1Niveau1);
			DonneesNiveau.niveau1.AjoutMapElement(DonneesNiveau.message2Niveau1);
		}

		/// <summary>
		/// Initialise les données du niveau 2
		/// </summary>
		public static void InitialisationNiveau2()
		{

		}

		/// <summary>
		/// Initialise les données du niveau 3
		/// </summary>
		public static void InitialisationNiveau3()
		{

		}
	}
}
