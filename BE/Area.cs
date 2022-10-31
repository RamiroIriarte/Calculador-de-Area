using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Area
    {
        public static decimal calcularAreaCuadrado(decimal lado)
        {
            
            decimal area = lado * lado;
            return area;
        }
        public static decimal calcularAreaRectangulo(decimal ancho, decimal altura)
        {
            decimal area = ancho * altura;
            return area;
        }
        public static decimal calcularAreaTriangulo(decimal ancho, decimal altura)
        {
            decimal area = ancho * altura / 2;
            return area;
        }
        public static decimal calcularAreaCirculo(decimal radio)
        {

            decimal area = Convert.ToDecimal(Math.PI) * radio * radio;
            return area;
        }
    }
}
