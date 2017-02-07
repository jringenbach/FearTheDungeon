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
		//			ATTRIBUTS
		//**********************************

		/// <summary>
		/// Affiche le message contenu dans l'élément
		/// </summary>
		string _message;

		//**********************************
		//			CONSTRUCTEURS
		//**********************************

		/// <summary>
		/// Constructeur de la classe MessageElement
		/// </summary>
		public MessageElement() : base()
		{

		}

		/// <summary>
		/// Constructeur de la classe MessageElement
		/// </summary>
		/// <param name="seDeplace"></param>
		/// <param name="positionElement"></param>
		/// <param name="message"></param>
		public MessageElement(bool seDeplace, int[] positionElement, string message) : base(seDeplace, positionElement)
		{
			Symbole = 'M';
			SeDeplace = seDeplace;
			PositionElement = positionElement;
			this.Message = message;
		}

		/// <summary>
		/// Constructeur de la classe MessageElement
		/// </summary>
		/// <param name="seDeplace"></param>
		/// <param name="positionElement"></param>
		/// <param name="symbole"></param>
		/// <param name="message"></param>
		public MessageElement(bool seDeplace, int[] positionElement, char symbole, string message) : base(seDeplace, positionElement, symbole)
		{
			Symbole = symbole;
			SeDeplace = seDeplace;
			PositionElement = positionElement;
			this.Message = message;
		}

		//*******************************************
		//			ACCESSEURS ET MUTATEURS
		//*******************************************

		/// <summary>
		/// Permet d'obtenir le contenu du message et de le modifier
		/// </summary>
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
