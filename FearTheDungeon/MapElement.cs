﻿using System;
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

		/// <summary>
		/// Affiche l'élément à cette position dans le niveau
		/// </summary>
		private int[] _positionElement = new int[2];

		/// <summary>
		/// Symbole qui sera affiché sur la map pour cet élément
		/// </summary>
		private char _symbole;

		// *******************************
		//          CONSTRUCTEURS
		// *******************************

		public MapElement()
		{

		}

		public MapElement(bool seDeplace, int[] positionElement)
		{
			this._seDeplace = seDeplace;
			this.PositionElement = positionElement;
		}

		public MapElement(bool seDeplace, int[] positionElement, char symbole)
		{
			this._seDeplace = seDeplace;
			this.PositionElement = positionElement;
			this.Symbole = symbole;
		}

		public MapElement(bool seDeplace, char symbole)
		{
			this._seDeplace = seDeplace;
			this.Symbole = symbole;
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

		/// <summary>
		/// Indique les coordonnées en x et y de l'élément 
		/// </summary>
		public int[] PositionElement
		{
			get
			{
				return _positionElement;
			}

			set
			{
				_positionElement = value;
			}
		}

		/// <summary>
		/// Symbole qui sera affiché sur la map pour cet élément
		/// </summary>
		public char Symbole
		{
			get
			{
				return _symbole;
			}

			set
			{
				_symbole = value;
			}
		}

	}
}
