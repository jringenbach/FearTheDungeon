using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	/// <summary>
	/// Bloque le passage au joueur, mais peut être ouverte grâce à un déclencheur particulier
	/// </summary>
	class Porte : MapElement
	{

		// *******************************
		//          ATTRIBUTS
		// *******************************

		private bool _ouverte;
		private bool _ouverteInitiale;
		private char _symboleInitial;

		// *******************************
		//          CONSTRUCTEURS
		// *******************************

		/// <summary>
		/// CONSTRUCTEUR SANS PARAMETRE DE LA CLASSE PORTE
		/// </summary>
		public Porte() : base()
		{
			Symbole = 'P';
			SymboleInitial = 'P';
			Nom = "Porte";
		}

		/// <summary>
		/// CONSTRUCTEUR DE LA CLASSE PORTE
		/// </summary>
		/// <param name="positionElement">La case 0 contient le numéro de ligne et la case 1 contient le numéro de colonne</param>
		public Porte(int[] positionElement) : base(positionElement)
		{
			this.PositionElement = positionElement;
			this.Symbole = 'P';
			SymboleInitial = 'P';
			Nom = "Porte";
		}

		/// <summary>
		/// CONSTRUCTEUR DE LA CLASSE PORTE
		/// </summary>
		/// <param name="positionX">Numéro de la ligne</param>
		/// <param name="positionY">Numéro de la colonne</param>
		public Porte(int positionX, int positionY) : base()
		{
			PositionElement[0] = positionX;
			PositionElement[1] = positionY;
			this.Symbole = 'P';
			SymboleInitial = 'P';
			Nom = "Porte";
		}

		/// <summary>
		/// CONSTRUCTEUR DE LA CLASSE PORTE
		/// </summary>
		/// <param name="positionX">Numéro de la ligne</param>
		/// <param name="positionY">Numéro de la colonne</param>
		public Porte(int positionX, int positionY, bool ouverte) : base()
		{
			PositionElement[0] = positionX;
			PositionElement[1] = positionY;
			Ouverte = ouverte;
			this.Symbole = 'P';
			SymboleInitial = 'P';
			Nom = "Porte";
			OuverteInitiale = ouverte;
	}

		// ***************************************
		//          ACCESSEURS ET MUTATEURS
		// ***************************************

		/// <summary>
		/// Vaut true si la porte est ouverte, false sinon.
		/// </summary>
		public bool Ouverte
		{
			get
			{
				return _ouverte;
			}

			set
			{
				_ouverte = value;
			}
		}

		/// <summary>
		/// Garde en mémoire si la porte était ouverte initialement ou non
		/// </summary>
		public bool OuverteInitiale
		{
			get
			{
				return _ouverteInitiale;
			}

			set
			{
				_ouverteInitiale = value;
			}
		}

		/// <summary>
		/// Garde en mémoire le symbole Initial au symbole de la classe Porte
		/// </summary>
		public char SymboleInitial
		{
			get
			{
				return _symboleInitial;
			}

			set
			{
				_symboleInitial = value;
			}
		}

		// ***************************************
		//          METHODE
		// ***************************************

		/// <summary>
		/// 
		/// </summary>
		public void EtatInitial()
		{
			this.Symbole = SymboleInitial;
			this.Ouverte = OuverteInitiale;
		}
	}
}
