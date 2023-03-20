using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Csharp_OO_FS_Net.Models
{
    public delegate void PassageEnNegatifDelegate(Compte compte);
    public abstract class Compte : IBanker, ICustomer
    {
        public event PassageEnNegatifDelegate PassageEnNegatifEvent;
        public Compte(string numero, Personne titulaire)
        {
            Numero = numero;
            Titulaire = titulaire;
        }
        public Compte(string numero, Personne titulaire, double solde) : this(numero, titulaire)
        {
            Solde = solde;
        }


        #region Props

        public string Numero { get; private set; }

        public double Solde { get; private set; } // Lecture Seule

        public Personne Titulaire { get; private set; }


        #endregion



        public static double operator +(double solde, Compte compte2)
        {

            // Equivalent du premier ternaire ci dessous

            //double valeur;

            //if (compte1.Solde > 0)
            //{
            //    valeur= compte1.Solde;
            //}
            //else
            //{
            //    valeur = 0;
            //}




            double valeur2 = compte2.Solde > 0 ? compte2.Solde : 0;
            return solde + valeur2;
        }


        #region Methodes
        public virtual void Retrait(double montant)
        {
            Retrait(montant, 0);
        }
        public void Retrait(double montant, double ligneDeCredit)
        {
            if (montant < 0)
                throw new ArgumentOutOfRangeException("Le montant doit etre positif");
            if (Solde - montant < -ligneDeCredit)
                throw new SoldeInsuffisantException();
            Solde -= montant;
        }

        public void Depot(double montant)
        {
            if (montant < 0)
                throw new ArgumentOutOfRangeException("Le montant doit etre positif");
            Solde += montant;
        }

        protected abstract double CalculInteret();
        public void AppliquerInteret()
        {
            Solde += CalculInteret();
        }

        protected void DeclencherPassageEnNegatif()
        {
            PassageEnNegatifEvent?.Invoke(this);
        }

        #endregion
    }
}
