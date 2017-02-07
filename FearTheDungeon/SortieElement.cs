using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	class SortieElement : MapElement
	{

		/// <summary>
		/// CONSTRUCTEUR de la classe SortieElement
		/// </summary>
		public SortieElement() : base()
		{

		}

		/// <summary>
		/// CONSTRUCTEUR de la classe SortieElement
		/// </summary>
		/// <param name="seDeplace"></param>
		/// <param name="positionElement"></param>
		/// <param name="symbole"></param>
		public SortieElement(bool seDeplace, int[] positionElement) : base(seDeplace, positionElement)
		{
			Symbole = 'S';
			SeDeplace = seDeplace;
			PositionElement = positionElement;
		}
	}
}
