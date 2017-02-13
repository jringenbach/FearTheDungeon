using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	/// <summary>
	/// Case sur laquelle le joueur ne peut aller
	/// </summary>
	class Mur : MapElement
	{
		// *******************************
		//          CONSTRUCTEURS
		// *******************************

		/// <summary>
		/// Constructeur de la classe Mur
		/// </summary>
		public Mur() : base()
		{
			Symbole = 'X';
		}

		/// <summary>
		/// Constructeur de la classe Mur
		/// </summary>
		/// <param name="positionX"></param>
		/// <param name="positionY"></param>
		public Mur(int positionX, int positionY) : base()
		{
			Symbole = 'X';
			PositionElement[0] = positionX;
			PositionElement[1] = positionY;
		}

		/// <summary>
		/// Constructeur de la classe Mur
		/// </summary>
		/// <param name="positionElement"></param>
		public Mur(int[] positionElement) : base(positionElement)
		{
			PositionElement = positionElement;
			Symbole = 'X';
		}

		/// <summary>
		/// Constructeur de la classe Mur
		/// </summary>
		/// <param name="seDeplace"></param>
		/// <param name="positionElement"></param>
		/// <param name="symbole"></param>
		public Mur(bool seDeplace, int[] positionElement, char symbole) : base(seDeplace, positionElement, symbole)
		{
			seDeplace = false;
			Symbole = 'X';

		}

		// *******************************
		//			METHODES
		// *******************************

		public void InitialisationElement(int positionX, int positionY)
		{
			this.PositionElement[0] = positionX;
			this.PositionElement[1] = positionY;
		}
	}
}
