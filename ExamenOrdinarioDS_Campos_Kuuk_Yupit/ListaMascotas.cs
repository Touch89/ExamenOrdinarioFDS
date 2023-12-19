using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Emilio
namespace ExamenOrdinarioDS_Campos_Kuuk_Yupit
{
    public class ListaMascotas
    {

        private List<Mascota> _mascotas;

        public ListaMascotas()
        {
            _mascotas = new List<Mascota>();
        }

        //Metodo para mostrar las mascotas
        public void Mostrarascotas()
        {
            Console.WriteLine("Estas son las mascotas");
            foreach (var mascota in _mascotas)
            {
                Console.WriteLine($" Id: {mascota.Id} - Nombre: {mascota.Nombre} - Dueño:{mascota.Duenio}");
            }
        }

        //Metodo para agregaar una mascota
        public void AgregarMascotas(string nombre, int edad, enum temperamento, Persona persona )
        {
            _mascotas.Add(new Mascota(nombre, edad, temperamento, persona ));
        }
    //Metodo para Obtener una mascota
    public Mascota ObtenerMascota(int id)
    {
        foreach (var mascota in _mascotas)
        {
            if (mascota.Id == id)
            {
                return mascota;
            }
        }

        return null;
    }
}

