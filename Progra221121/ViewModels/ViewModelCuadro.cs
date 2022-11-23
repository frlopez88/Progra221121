using Progra221121.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Progra221121.ViewModels
{
    public class ViewModelCuadro : INotifyPropertyChanged
    {

        public ViewModelCuadro() {

            crearCuadro = new Command(

                    () => {

                        // Rutina de cuando se ejecute el comando de crearCuadro

                        Cuadro c1 = new Cuadro() {
                            ladoA = this.ladoA, 
                            ladoB = this.ladoB
                        };

                        c1.calcularArea();
                        c1.calcularPerimetro();

                        Resultado = c1.toString();
                    }

                );

        }


        double ladoB;

        public double LadoB {
            get => ladoB;
            set {

                ladoB = value;
                var args = new PropertyChangedEventArgs(nameof(LadoB)); // La Variable public 
                // La linea de codigo previa, declara una variable de argumentos, cuando un objeto 
                // dentro de un front end, percible un cambio por medio de un evento (Clic, Drag, Input)
                PropertyChanged?.Invoke(this, args);

            }
        }
        
        
        double ladoA;

        public double LadoA {
            get => ladoA;
            set {

                ladoA = value;
                var args = new PropertyChangedEventArgs(nameof(LadoA)); // La Variable public 
                // La linea de codigo previa, declara una variable de argumentos, cuando un objeto 
                // dentro de un front end, percible un cambio por medio de un evento (Clic, Drag, Input)
                PropertyChanged?.Invoke(this, args);

            }
        }

        string resultado;

        public string Resultado
        {
            get => resultado;

            set
            {

                resultado = value;
                var args = new PropertyChangedEventArgs(nameof(Resultado));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public Command crearCuadro { get; }
        
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
