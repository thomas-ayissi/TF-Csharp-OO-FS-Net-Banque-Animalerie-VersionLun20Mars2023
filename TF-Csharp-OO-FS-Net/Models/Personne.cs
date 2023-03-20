﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Csharp_OO_FS_Net.Models
{
    public class Personne
    {
        public Personne(string nom, string prenom, DateTime dateNaiss)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaiss = dateNaiss;
        }

        public string Nom { get; private set; }

        public string Prenom { get; private set; }

        public DateTime DateNaiss { get; private set; }
    }
}
