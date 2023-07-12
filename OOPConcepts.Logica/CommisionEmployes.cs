using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logica
{
    public class CommisionEmployes : Employes
    {
        private float _commisionPercentaje;
        private decimal _sales;

        public decimal Sales
        {
            get => _sales;
            set => _sales = ValidateSales(value);
        }

        public float CommisionPercentaje
        {
            get => _commisionPercentaje;
            set => _commisionPercentaje = ValidateCommisionPercentaje(value);
        }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommisionPercentaje; //implementar si factura o no
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                   $"Commision Percentaje......{CommisionPercentaje,20:P2}\n\t" +
                   $"Working Value.............{Sales, 20}\n\t" +
                   $"Rol.......................{GetValueToPay(),20:C2}\n\n";
        }

        private float ValidateCommisionPercentaje(float value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Porcentaje no es valido");
            }
            return value;
        }

        private decimal ValidateSales(decimal value)
        {
            if (value >= 0)
            {
                return value;
            }
            throw new ArgumentException("Sales no es valido");

        }
    }
}
