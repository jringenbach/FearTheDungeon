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
		/// Permet de savoir si le niveau a été débloqué ou non
		/// </summary>
		private bool _debloque;

		/// <summary>
		/// Affiche le nom du niveau
		/// </summary>
		private string _nom;

		/// <summary>
		/// Numéro du niveau
		/// </summary>
		private short _numero;

		/// <summary>
		/// Mot de passe pour accéder au niveau
		/// </summary>
		private string _password;

		/// <summary>
		/// Tableau contenant toutes les portes du niveau
		/// </summary>
		private Porte[] tableauDePortes;

		/// <summary>
		/// Stocke tous les éléments présents dans le niveau
		/// </summary>
		public MapElement[] elementsDuNiveau;


        // *******************************
        //          CONSTRUCTEURS
        // *******************************

        /// <summary>
        /// CONSTRUCTEURS
        /// </summary>
        public Niveau()
        {

        }

		public Niveau(Map carte, string nom, short numero, string password, bool debloque)
		{
			this._carteDuNiveau = carte;
			this._nom = nom;
			this._numero = numero;
			this._password = password;
			this._debloque = debloque;
			elementsDuNiveau = new MapElement[1];
			TableauDePortes = new Porte[1];

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

		/// <summary>
		/// Mot de passe du niveau
		/// </summary>
		public string Password
		{
			get
			{
				return _password;
			}

			set
			{
				_password = value;
			}
		}

		/// <summary>
		/// Permet de savoir si le niveau a été débloque (true) ou non (false)
		/// </summary>
		public bool Debloque
		{
			get
			{
				return _debloque;
			}

			set
			{
				_debloque = value;
			}
		}

		/// <summary>
		/// Permet d'accéder à tous les éléments du niveau
		/// </summary>
		public MapElement[] ElementsDuNiveau
		{
			get
			{
				return elementsDuNiveau;
			}

			set
			{
				elementsDuNiveau = value;
			}
		}

		/// <summary>
		/// Tableau contenant toutes les portes du niveau
		/// </summary>
		public Porte[] TableauDePortes
		{
			get
			{
				return tableauDePortes;
			}

			set
			{
				tableauDePortes = value;
			}
		}

		// ***************************************
		//				METHODES
		// ***************************************

		/// <summary>
		/// Permet d'ajouter des éléments dans le niveau lors de sa création
		/// </summary>
		public void AjoutMapElement(MapElement element)
		{
			if(elementsDuNiveau.Length == 1)
			{
				elementsDuNiveau[0] = element;
				Array.Resize(ref this.elementsDuNiveau, this.elementsDuNiveau.Length + 1);
			}

			else
			{
				this.elementsDuNiveau[this.elementsDuNiveau.Length - 1] = element;
				Array.Resize(ref this.elementsDuNiveau, this.elementsDuNiveau.Length + 1);
			}

		}

		/// <summary>
		/// Permet d'ajouter des éléments "Porte" dans le tableau de portes
		/// </summary>
		/// <param name="porte"></param>
		public void AjoutPorte(Porte porte)
		{
			if (TableauDePortes.Length == 1)
			{
				tableauDePortes[0] = porte;
				Array.Resize(ref this.tableauDePortes, this.tableauDePortes.Length + 1);
			}

			else
			{
				this.elementsDuNiveau[this.tableauDePortes.Length - 1] = porte;
				Array.Resize(ref this.tableauDePortes, this.tableauDePortes.Length + 1);
			}
		}

		/// <summary>
		/// Vide le tableau des éléments du niveau et le tableau de portes
		/// </summary>
		public void ResetNiveau()
		{
			Array.Resize(ref this.elementsDuNiveau, 1);

			//Si on a au moins une porte, on la reset
			if(this.TableauDePortes != null)
			{
				Array.Resize(ref this.tableauDePortes, 1);
			}
		}
	}
}
