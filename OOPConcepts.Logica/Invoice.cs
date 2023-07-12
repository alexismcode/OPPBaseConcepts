using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logica
{
    public class Invoice : iPay
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public decimal Precio { get; set; }
        public float Quantity { get; set; }

        public decimal GetValueToPay()
        {
            return (decimal)Quantity * Precio;
        }
        public override string ToString()
        {
            return $"{Id}\t{Description}\n\t" +
                   $"Quantity..................{Quantity,20:N2}\n\t" +
                   $"Precio....................{Precio,20:C2}\n\t" +
                   $"Valor a pagar.............{GetValueToPay(),20:N2}\n\t";
        }
    }
}
