using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	class MessageElement : MapElement
	{
		//**********************************
		//			CONSTRUCTEURS
		//**********************************

		/// <summary>
		/// Affiche le message contenu dans l'élément
		/// </summary>
		string _message;

		//**********************************
		//			CONSTRUCTEURS
		//**********************************

		public MessageElement() : base()
		{

		}

		public MessageElement(bool seDeplace, int[] positionElement, char symbole, string message) : base(seDeplace, positionElement, symbole)
		{
			Symbole = 'M';
			SeDeplace = seDeplace;
			PositionElement = positionElement;
			this.Message = message;
		}

		//*******************************************
		//			ACCESSEURS ET MUTATEURS
		//*******************************************

		public string Message
		{
			get
			{
				return _message;
			}

			set
			{
				_message = value;
			}
		}
	}
}
