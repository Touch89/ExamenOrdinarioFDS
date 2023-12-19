using ExamenOrdinarioDS_Campos_Kuuk_Yupit;
using System;
using System.Collections.Generic;

namespace ExamenOrdinarioDS_Campos_Kuuk_Yupit
{
    public class Persona : IPersona   //Clase para el objeto persona
    {
        private int identificador;  
        private string nombre;
        private List<Mascota> = new list <mascotas>; //Creacion lista mascota 

        public int Identificador { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Persona(int identificador, string nombre)
        {
            this.identificador = identificador;
            this.nombre = nombre;
            this.mascotas = new List<Mascota>();
        }

        public int ObtenerIdentificador()   //Funcion para obtener el identificador de la mascota
        {
            return this.identificador;
        }

        public string ObtenerNombre()   //Funcion para obtener el nombre de la mascota
        {
            return this.nombre;
        }

        public List<Mascota> ObtenerMascotas()  //Funcion para obtener las mascotas
        {
            return this.mascotas;
        }

        public Mascota ObtenerMascotaPorIdentificador(int identificador)
        {
            foreach (var mascota in this.mascotas)
            {
                if (mascota.ObtenerIdentificador() == identificador)
                {
                    return mascota;
                }
            }

            return null;
        }

        public void AcariciarMascota(Mascota mascota)
        {
            Console.WriteLine($"{this.nombre} acaricia a {mascota.nombre}");
        }


        public void Acariciar()
        {
            string ResponderACaricia = Console.ReadLine();
            if (ResponderACaricia == "Si")
            {
                foreach (var mascota in this.mascotas)
                {
                    if (mascota.IsAcariciable())
                    {
                        Console.WriteLine($"{this.nombre} acaricia a {mascota.nombre}");
                    }
                    else
                    {
                        Console.WriteLine($"{this.nombre} no puede acariciar a {mascota.nombre}");
                    }
                }
            }
            else
            {
                Console.WriteLine($"{this.nombre} no acaricia a ninguna mascota");
            }
        }

        public void AgregarMascota(Mascota mascota)
        {
            this.mascotas.Add(mascota);
        }

        public void ObtenerMascotas(List<Persona> personas)
        {
            throw new NotImplementedException();
        }

        public void ObtenerMascotasIdentificador(int identificador)
        {
            throw new NotImplementedException();
        }
    }
}

