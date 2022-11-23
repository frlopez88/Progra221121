using System;
using System.Collections.Generic;
using System.Text;

namespace Progra221121.Models
{
    public class Cuadro : FigurasGeometricas
    {

        public double ladoA { get; set; }
        public double ladoB { get; set; }

        public new void calcularPerimetro() {
            perimetro = (ladoA * 2.00) + (ladoB * 2.00);
        }

        public new void calcularArea() {
            area = ladoA * ladoB;
        }

    }
}
