using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logica
{
    public class HourEmployes : Employes
    {
        private decimal _hourValue;
        private float _workingHours;

        public decimal HourValue
        {
            get => _hourValue;
            set => _hourValue = ValidateHourValue(value);
        }

        public float WorkingValue
        {
            get => _workingHours;
            set => _workingHours = ValidateWorkingHour(value);
        }

        public override decimal GetValueToPay()
        {
            //double v1 = 3.5;
            //decimal v2 = 3.5m;
            //decimal Res = 0;
            //Res = 7.89m * v2;
            float iva = 0.88f;
            return (decimal)WorkingValue * HourValue * (decimal)iva;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                   $"Hour Value................{HourValue, 20:C2}\n\t" +
                   $"Working Value.............{WorkingValue,20}\n\t" +
                   $"Rol.......................{GetValueToPay(), 20:C2}\n\n";
        }

        private decimal ValidateHourValue(decimal value)
        {
            //Tenologo gana 7
            // Ingeniero gana 8
            // Magister gana 10
            // 
            
            if (value < 7 || value > 15)
            {
                throw new ArgumentException("Valor no valido");
            }
            return value;
        }

        private float ValidateWorkingHour(float value)
        {
            if (value < 0 || value > 40)
            {
                throw new ArgumentException("Las horas no trabajadas no son validas");
            }
            return value;
        }
    }
}
