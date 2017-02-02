using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	class MapElement
	{
		// *******************************
		//          ATTRIBUTS
		// *******************************

		/// <summary>
		/// Booléen indiquant si l'élément peut se déplacer ou non
		/// </summary>
		private bool _seDeplace;

		// *******************************
		//          CONSTRUCTEURS
		// *******************************

		public MapElement()
		{

		}

		public MapElement(bool seDeplace)
		{
			this._seDeplace = seDeplace;
		}


		// ***************************************
		//          ACCESSEURS ET MUTATEURS
		// ***************************************

		/// <summary>
		/// Booléen indiquant si l'élément peut se déplacer ou non
		/// </summary>
		public bool SeDeplace
		{
			get
			{
				return _seDeplace;
			}

			set
			{
				_seDeplace = value;
			}
		}
	}
}
