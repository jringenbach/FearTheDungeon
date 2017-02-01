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
        Map carteDuNiveau = new Map();

        // *******************************
        //          CONSTRUCTEURS
        // *******************************

        /// <summary>
        /// CONSTRUCTEURS
        /// </summary>
        public Niveau()
        {

        }

        // ***************************************
        //          ACCESSEURS ET MUTATEURS
        // ***************************************

        public Map CarteDuNiveau
        {
            get
            {
                return carteDuNiveau;
            }

            set
            {
                carteDuNiveau = value;
            }
        }
    }
}
