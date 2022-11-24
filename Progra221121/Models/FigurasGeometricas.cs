using System;
using System.Collections.Generic;
using System.Text;

namespace Progra221121.Models
{
    [Serializable]
    // Si una clase es serilable significa que se puede almacenar
    public class FigurasGeometricas
    {

        public double area { get; set; }

        public double perimetro { get; set; }

        public void calcularArea() { 
            
        }

        public void calcularPerimetro() { 
        
        }

        public string toString() {

            return "Figura Geometrica con Area :" + Math.Round(this.area,2) 
                    + " Perimetro: " + Math.Round(this.perimetro,2);
        }

    }
}
