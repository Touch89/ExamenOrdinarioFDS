using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinarioDS_Campos_Kuuk_Yupit
{
    public class ListaMascotas
    {
        private List<Mascota> _mascotas;

        public ListaMascotas()
        {
            _mascotas = new List<Mascota>();
        }


        public void Mostrarascotas()
        {
            Console.WriteLine("Estas son las mascotas");
            foreach (var mascota in _mascotas)
            {
                Console.WriteLine($" Id: {mascota.Id} - Nombre: {mascota.Nombre} - Dueño:{mascota.Duenio}");
            }
        }

        public void AgregarMascotas(string nombre, int edad, enum temperamento, Persona persona )
        {
            _mascotas.Add(new Mascota(nombre, edad, temperamento, persona ));
        }

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
<<<<<<< HEAD
<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
=======
}
>>>>>>> 6d69c11f20485047ecf87699c925b0e0c3e72f60
