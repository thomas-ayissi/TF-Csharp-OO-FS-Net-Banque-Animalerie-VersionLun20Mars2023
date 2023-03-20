using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Csharp_OO_FS_Net.Models
{
    public class Courant : Compte
    {

        #region Props

        private double _ligneDeCredit;
        public Courant(string numero, Personne titulaire) : base(numero, titulaire)
        {
        }
        public Courant(double ligneDeCredit, string numero, Personne titulaire) : base(numero, titulaire)
        {
            LigneDeCredit = ligneDeCredit;
        }
        public Courant(string numero, Personne titulaire, double solde) : base(numero, titulaire, solde)
        {
        }

        public double LigneDeCredit
        {
            get { return _ligneDeCredit; }
            private set
            {
                if (value < 0)
                    throw new InvalidOperationException("Ligne de credit doit etre positive");
                _ligneDeCredit = value;

            }
        }


        #endregion

        #region Methodes

        public override void Retrait(double montant)
        {
            if(Solde < montant)
            {
                DeclencherPassageEnNegatif();
            }
            base.Retrait(montant, LigneDeCredit);
        }
        protected override double CalculInteret()
        {
            return Solde >= 0 ? Solde * .03 : Solde * .0975;
        }

        #endregion

    }
}
