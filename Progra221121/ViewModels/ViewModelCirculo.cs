using Progra221121.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Progra221121.ViewModels
{
    public class ViewModelCirculo : INotifyPropertyChanged
    {
        public ViewModelCirculo() {

         
            CrearCirculo = new Command(() =>
            {
                Circulo c1 = new Circulo() {
                    radio = this.radio
                };

                c1.calcularArea();
                c1.calcularPerimetro();


                Resultado = c1.toString();

            });
        
        }


        int radio;

        public int Radio {
            get => radio;

            set {

                radio = value;
                var args = new PropertyChangedEventArgs(nameof(Radio));
                PropertyChanged?.Invoke(this, args);

            }
        }

        string resultado;

        public string Resultado {
            get => resultado;

            set {

                resultado = value;
                var args = new PropertyChangedEventArgs(nameof(Resultado));
                PropertyChanged?.Invoke(this, args);
            }
        }
        
        public Command CrearCirculo { get; }
        
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
