using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Csharp_OO_FS_Net.Demos
{
    public class Personne
    {
        public Personne(string firstName, string lastName,DateTime birthDate) 
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual string Manger()
        {
            return $"{FirstName} mange";
        }
        public override string ToString()
        {
            return $"Je m'appelle {LastName} {FirstName} et je suis ne le {BirthDate}.";
        }
    }
    public class Employe : Personne
    {
        public Employe(string firstName, string lastName, DateTime birthDate) : base(firstName, lastName, birthDate)
        {
        }
        public int Salaire { get; set; }

        public override string Manger()
        {
            return $"{FirstName} {LastName} mange";
        }
        public string Manger(string aliment)
        {
            return Manger() + $" {aliment}";
        }
    }
}
