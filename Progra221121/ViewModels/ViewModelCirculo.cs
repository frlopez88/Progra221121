using Progra221121.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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

                listaCirculo.Add(c1);

                Resultado = c1.toString();

                Resultado = "";
                foreach ( Circulo tmp in listaCirculo ) {

                    Resultado += tmp.toString() + "\r\n" ;
              }


                //Rutina para guardar la Lista en el telefono
                BinaryFormatter formatter = new BinaryFormatter();
                string ruta = Path.Combine( System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) , 
                    "Ciculos.aut");
                Stream archivo = new FileStream( ruta, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(archivo, listaCirculo);
                archivo.Close();

                

            });



            AbrirLista = new Command( ()=> {

                BinaryFormatter formatter = new BinaryFormatter();
                string ruta = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),
                    "Ciculos.aut");
                Stream archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read, FileShare.None);

                listaCirculo = (ObservableCollection<Circulo>)formatter.Deserialize(archivo);
                archivo.Close();

                Resultado = "";

                foreach (Circulo tmp in listaCirculo)
                {

                    Resultado += tmp.toString() + "\r\n";

                }


            });
        
        }


        ObservableCollection<Circulo> listaCirculo = new ObservableCollection<Circulo>();

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

        public Command AbrirLista { get; }
        
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
