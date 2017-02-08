using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	class Bloc : MapElement
	{
		// *******************************
		//			CONSTRUCTEUR
		// *******************************

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
		}
	}
}
