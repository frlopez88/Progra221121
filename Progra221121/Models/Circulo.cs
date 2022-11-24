using System;


namespace Progra221121.Models
{
    [Serializable]
    public class Circulo : FigurasGeometricas
    {

        public double radio { get; set; }

        public new void calcularArea() {

            //area = Math.PI * (radio * radio);
            area = Math.PI * Math.Pow(radio, 2);
        
        }

        public new void calcularPerimetro()
        {

            perimetro = 2.00 * Math.PI * radio;

        }

    }
}
