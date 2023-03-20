using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Csharp_OO_FS_Net.Models
{
    public class Epargne : Compte
    {
        public Epargne(string numero, Personne titulaire) : base(numero, titulaire)
        {
        }
        public Epargne(string numero, Personne titulaire, double solde) : base(numero, titulaire, solde)
        {
        }
        #region Props

        public DateTime DateDernierRetrait { get; private set; }


        #endregion


        #region Methodes

        void Retrait(double montant)
        {
            double soldePrecedent = Solde;
            base.Retrait(montant);
            if (soldePrecedent > Solde)
                DateDernierRetrait = DateTime.Now;
        }
        protected override double CalculInteret()
        {
            return Solde * .045;
        }

        #endregion
    }
}
