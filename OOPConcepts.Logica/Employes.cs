using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logica
{
    public abstract class Employes : iPay
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public Date? BornDate { get; set; }
        public Date? HireDate { get; set; }
        public bool IsActive { get; set; }

        public override string ToString()
        {
            return $"{Id}\t{FirstName} {LastName}\n\t" +
                   $"HireDate..................[{HireDate}]\t";
        }

        public abstract decimal GetValueToPay();
    }
}
