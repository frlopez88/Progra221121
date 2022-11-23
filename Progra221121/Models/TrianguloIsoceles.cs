using System;
using System.Collections.Generic;
using System.Text;

namespace Progra221121.Models
{
    public class TrianguloIsoceles : FigurasGeometricas
    {
        public double ladoA { get; set; }
        public double ladoB { get; set; }
        double altura;

        private void calcularAltura() {
            double tmp = Math.Pow(ladoA, 2) + (Math.Pow(ladoB, 2) / 4.00);
            altura = Math.Sqrt(tmp);
        }

        public new void calcularArea() {
            calcularAltura();

            area = (ladoB * altura) / 2.00;

        }

        public new void calcularPerimetro() {

            perimetro = (ladoA * 2.00) + ladoB;
        }

    }
}
