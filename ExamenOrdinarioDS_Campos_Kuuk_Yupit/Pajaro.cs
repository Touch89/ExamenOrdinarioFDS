﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenOrdinarioDS_Campos_Kuuk_Yupit.Properties;

//Emilio
namespace ExamenOrdinarioDS_Campos_Kuuk_Yupit
{
    //Clase para crear un pájaro
    public class Pajaro : IMascota, IBailar
    {

        public int Id
        {
            get;
            set;
        }
        private static int lastIdAdded = 0;
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("El nombre de la mascota no puede estar vacío");
                }
                _nombre = value;
            }
        }
        private int _edad;
        public int Edad
        {
            get { return _edad; }
            set
            {
                if (value < 0 || value > 8)
                {
                    throw new Exception("Ingrese una edad realista");
                }
                _edad = value;
            }
        }
        public enum TemperamentoEnum
        {
            amable,
            nervioso,
            agresivo,
        }

        private TemperamentoEnum _temperamento;
        public TemperamentoEnum Temperamento
        {
            get { return _temperamento; }
            set
            {
                if (!Enum.IsDefined(typeof(TemperamentoEnum), value))
                {
                    throw new Exception("Ingrese un temperamento válido");
                }
                _temperamento = value;
            }
        }
        public Persona Persona { get; set; }
        private List<Persona> _personas;

        public void HacerRuido()
        {
            Console.WriteLine("pio pio");
        }

        //Metodo para cambiar de dueño
        public void CambiarDuenio(string nombre)
        {
            foreach (var duenio in _personas)
            {
                if (duenio.Nombre == nombre)
                {
                    this.Persona = duenio;
                    Console.WriteLine($"El Perro {this.Nombre} ha cambiado de dueño");
                    return;
                }
                throw new Exception("No se encontró a la persona");
            }
        }
        //Metodos para comportamientos
        public void ResponderACaricia()
        {
            Console.WriteLine("*Lo acaricia*");
        }
        //Constructor
        public Gato(string nombre, int edad, TemperamentoEnum temperamento, Persona persona)
        {
            this.Id = lastIdAdded + 1;
            this.Nombre = nombre;
            this.Edad = edad;
            this.Temperamento = temperamento;
            this.Persona = persona;

            lastIdAdded++;
        }

        public void Aletear()
        {
            Console.WriteLine("*Aletea Aletea*");
        }

        void IBailar.Bailar()
        {
            Console.WriteLine($"{this.Nombre}  esta agitando las plumas.");
        }
    }
}
