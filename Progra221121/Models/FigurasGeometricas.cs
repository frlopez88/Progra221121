﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Progra221121.Models
{
    public class FigurasGeometricas
    {

        public double area { get; set; }

        public double perimetro { get; set; }

        public void calcularArea() { 
            
        }

        public void calcularPerimetro() { 
        
        }

        public string toString() {

            return "Figura Geometrica con Area :" + this.area + " Perimetro: " + this.perimetro;
        }

    }
}
