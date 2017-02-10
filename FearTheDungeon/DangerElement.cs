using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	/// <summary>
	/// Contient la position des cases
	/// </summary>
	class DangerElement : MapElement
	{

		public new char Symbole = 'D';

		public DangerElement() : base()
		{
			
		}

		public DangerElement(int positionX, int positionY) : base()
		{
			PositionElement[0] = positionX;
			PositionElement[1] = positionY;
		}
	}
}
