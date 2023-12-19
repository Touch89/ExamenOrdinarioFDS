using System;
using System.Collections.Generic;

namespace ExamenOrdinarioDS_Campos_Kuuk_Yupit
{
    public class Persona : IPersona   //Clase para el objeto persona
    {
        this.Identificador = Identificador;
        this.Nombre = Nombre;
        this.Mascotas = new List<Mascota>();

        public int Identificador { get; set; }
        {
            
        }

        public string Nombre { get; set; }



        void ObtenerMascotas()
        {
            return this.Mascotas;
        }

        void ObtenerMascotasIdentificador()  //Obtener mascotas por medio del identificador numérico
        {

        }

        void AcariciarMascota()
        {
            //Es lo mismo que en el acariciar solo que a todas las mascotas que posea en la lista MascotaS
        }

        void Acariciar()
        {
             string ResponderAcaricia = Console.ReadLine();
             if(condicion de acariceable = Si) {
                return Console.WriteLine($"{Persona} acaricia a {Mascota}");
            } else {
                return Console.WriteLine($"{Persona} no puede acariciar a {Mascota}");
            }
        }

        void AgregarMascota()
        {
            return Mascotas.Add;
        }
    }
}
