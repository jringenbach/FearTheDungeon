using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
    class Niveau
    {

        // *******************************
        //          ATTRIBUTS
        // *******************************

        /// <summary>
        /// Contient les données relatives à la carte du niveau
        /// </summary>
        private Map _carteDuNiveau = new Map();

		/// <summary>
		/// Affiche le nom du niveau
		/// </summary>
		private string _nom;

		/// <summary>
		/// Numéro du niveau
		/// </summary>
		private short _numero;

        // *******************************
        //          CONSTRUCTEURS
        // *******************************

        /// <summary>
        /// CONSTRUCTEURS
        /// </summary>
        public Niveau()
        {

        }

		public Niveau(Map carte, string nom, short numero)
		{
			this._carteDuNiveau = carte;
			this._nom = nom;
			this._numero = numero;

		}

        // ***************************************
        //          ACCESSEURS ET MUTATEURS
        // ***************************************

		/// <summary>
		/// La carte du niveau
		/// </summary>
        public Map CarteDuNiveau
        {
            get
            {
                return _carteDuNiveau;
            }

            set
            {
                _carteDuNiveau = value;
            }
        }

		/// <summary>
		/// Permet de récupérer le nom du niveau
		/// </summary>
		public string Nom
		{
			get
			{
				return _nom;
			}

			set
			{
				_nom = value;
			}
		}

		/// <summary>
		/// Le numéro du niveau
		/// </summary>
		public short Numero
		{
			get
			{
				return _numero;
			}

			set
			{
				_numero = value;
			}
		}
	}
}
