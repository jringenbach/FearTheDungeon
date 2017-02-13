using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
	class Manivelle : MapElement
	{
		// *******************************
		//          ATTRIBUTS
		// *******************************

		/// <summary>
		/// Vaut true si la manivelle a été actionnée, false sinon.
		/// </summary>
		private bool _actionnee;

		/// <summary>
		/// Etat de la manivelle en début de niveau
		/// </summary>
		private bool _actionneeInitiale;

		// *******************************
		//          CONSTRUCTEURS
		// *******************************

		/// <summary>
		/// CONSTRUCTEUR DE MANIVELLE
		/// </summary>
		public Manivelle() : base()
		{
			Symbole = 'm';
			Actionnee = false;
		}

		/// <summary>
		/// CONSTRUCTEUR DE MANIVELLE
		/// </summary>
		/// <param name="positionX">Position en X de la manivelle</param>
		/// <param name="positionY">Position en Y de la manivelle</param>
		public Manivelle(int positionX, int positionY) : base()
		{
			PositionElement[0] = positionX;
			PositionElement[1] = positionY;
			Symbole = 'm';
			Actionnee = false;
		}

		// ***************************************
		//          ACCESSEURS ET MUTATEURS
		// ***************************************

		/// <summary>
		/// Vaut true si la manivelle a été actionnée. False sinon.
		/// </summary>
		public bool Actionnee
		{
			get
			{
				return _actionnee;
			}

			set
			{
				_actionnee = value;
			}
		}

		/// <summary>
		/// Etat de la manivelle en début de niveau
		/// </summary>
		public bool ActionneeInitiale
		{
			get
			{
				return _actionneeInitiale;
			}

			set
			{
				_actionneeInitiale = value;
			}
		}

		// ***************************************
		//				 METHODE
		// ***************************************

		/// <summary>
		/// Fonction qui va permettre d'appeler les fonctions de changement de configuration du niveau suite au changement d'état de la manivelle
		/// </summary>
		/// <param name="niveau">Niveau du jeu</param>
		public void ChangementInherentALActivationDeLaManivelle(Niveau niveau)
		{
			switch (niveau.Numero)
			{

				case 9:
					Initialisations.InitialisationNouvelleConfigurationDuNiveau9();
					break;

				default:
					break;
			}
		}
	}
}
