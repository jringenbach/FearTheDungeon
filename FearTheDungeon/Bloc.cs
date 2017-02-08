using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	class Bloc : MapElement
	{

		private int[] positionInitiale = new int[2];

		// *******************************
		//			CONSTRUCTEUR
		// *******************************

		public Bloc() : base()
		{
			Symbole = 'B';
		}

		/// <summary>
		/// CONSTRUCTEUR DE BLOC
		/// </summary>
		/// <param name="positionElement"></param>
		public Bloc(int[] positionElement) : base(positionElement)
		{
			Symbole = 'B';
		}

		public Bloc(int positionX, int positionY) : base()
		{
			Symbole = 'B';
			PositionElement[0] = positionX;
			PositionElement[1] = positionY;
			PositionInitiale[0] = positionX;
			PositionInitiale[1] = positionY;
		}

		public int[] PositionInitiale
		{
			get
			{
				return positionInitiale;
			}

			set
			{
				positionInitiale = value;
			}
		}
	}
}
