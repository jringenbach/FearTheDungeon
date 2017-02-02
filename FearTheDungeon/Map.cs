using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FearTheDungeon
{
    /// <summary>
    /// Permet de créer une carte pour un niveau
    /// </summary>
    class Map
    {

        // *******************************
        //          ATTRIBUTS
        // *******************************

        /// <summary>
        /// Nombre de lignes composant la carte d'un niveau
        /// </summary>
        private int _nombreLignes;

        /// <summary>
        /// Nombre de colonnes composant la carte d'un niveau
        /// </summary>
        private int _nombreColonnes;

		/// <summary>
		/// Carte composée de lignes et de colonnes
		/// </summary>
		private MapElement[,] _carte;

		// *******************************
		//          CONSTRUCTEURS
		// *******************************

		public Map()
        {

        }

        /// <summary>
        /// Permet de créer la carte en indiquant le nombre de lignes et de colonnes qu'elle possèdera
        /// </summary>
        /// <param name="lignes"></param>
        /// <param name="colonnes"></param>
        public Map(int lignes, int colonnes)
        {
			this._nombreLignes = lignes;
			this._nombreColonnes = colonnes;
			_carte = new MapElement[_nombreLignes, _nombreColonnes];
        }

		// ***************************************
		//          ACCESSEURS ET MUTATEURS
		// ***************************************

		/// <summary>
		/// Le nombre de lignes qui composent la carte du niveau
		/// </summary>
		public int NombreLignes
		{
			get
			{
				return _nombreLignes;
			}

			set
			{
				_nombreLignes = value;
			}
		}

		/// <summary>
		/// Le nombre de colonnes qui composent la carte du niveau
		/// </summary>
		public int NombreColonnes
		{
			get
			{
				return _nombreColonnes;
			}

			set
			{
				_nombreColonnes = value;
			}
		}

	}
}
