using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    public class Ejercicio04
    {
        public int[] CalcularBilletes(int cantidad, int[] billetes)
        {
            int[] resultado = new int[billetes.Length];

            for (int i = 0; i < billetes.Length; i++)
            {
                int cantidadDeBilletes = cantidad / billetes[i];

                resultado[i] = cantidadDeBilletes;

                cantidad -= cantidadDeBilletes * billetes[i];
            }


            return resultado;
           
        }
    }
}
