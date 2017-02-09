using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	/// <summary>
	/// Il peut être activé par la présence du joueur ou d'un bloc. Il déclenchera alors une action sur la map
	/// </summary>
	class Bouton : MapElement
	{
		/// <summary>
		/// Porte que le bouton va ouvrir quand il sera déclenché
		/// </summary>
		private Porte _porteQueJouvre;

		// *******************************
		//          CONSTRUCTEURS
		// *******************************

		/// <summary>
		/// CONSTRUCTEUR SANS PARAMETRE DE BOUTON
		/// </summary>
		public Bouton() : base()
		{
			Symbole = 'b';
		}

		/// <summary>
		/// CONSTRUCTEUR DE LA CLASSE BOUTON
		/// </summary>
		/// <param name="positionElement"></param>
		public Bouton (int[] positionElement) : base(positionElement)
		{
			this.PositionElement = positionElement;
			this.Symbole = 'b';
		}

		/// <summary>
		/// CONSTRUCTEUR DE LA CLASSE BOUTON
		/// </summary>
		/// <param name="positionX">Numéro de la ligne</param>
		/// <param name="positionY">Numéro de la colonne</param>
		public Bouton (int positionX, int positionY) : base()
		{
			PositionElement[0] = positionX;
			PositionElement[1] = positionY;
			this.Symbole = 'b';
		}

		/// <summary>
		/// CONSTRUCTEUR DE LA CLASSE BOUTON
		/// </summary>
		/// <param name="positionX">Numéro de la ligne</param>
		/// <param name="positionY">Numéro de la colonne</param>
		public Bouton(int positionX, int positionY, Porte porteQueJouvre) : base()
		{
			PositionElement[0] = positionX;
			PositionElement[1] = positionY;
			PorteQueJouvre = porteQueJouvre;
			this.Symbole = 'b';
		}

		public Porte PorteQueJouvre
		{
			get
			{
				return _porteQueJouvre;
			}

			set
			{
				_porteQueJouvre = value;
			}
		}
	}
}
