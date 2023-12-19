using System;

namespace ExamenOrdinarioDS_Campos_Kuuk_Yupit
{
    public class Persona : IPersona   //Clase para el objeto persona
    {
        public string Nombre() 
        {
            
        }

        public int Identificador { get; set; }
        {

        }

        public string Nombre { get; set; }



        void ObtenerMascotas()
        {

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
            /*
             if(condicion de acariceable = true) {
                Console.WriteLine($"{Persona} acaricia a {Mascota}");
            } else {
                Console.WriteLine($"{Persona} no puede acariciar a {Mascota}");
            }
             */
        }

        void AgregarMascota()
        {
            Mascotas.Add;
        }
    }
}
