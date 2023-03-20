using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Csharp_OO_FS_Net.Models
{
    public class SoldeInsuffisantException : Exception
    {
        public SoldeInsuffisantException() : base("Solde insuffisant"){}

        public SoldeInsuffisantException(string message) : base(message) { }
    }
}
