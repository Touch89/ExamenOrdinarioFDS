using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinarioDS_Campos_Kuuk_Yupit
{
    public interface IPersona    //Creación de la interfaz persona
    {
        int Identificador { get; set; }
        string Nombre { get; set; }
        void ObtenerMascotas(List<Persona> personas);
        void ObtenerMascotasIdentificador(int identificador);
        void AcariciarMascota(Mascota mascota);
        void Acariciar();
        void AgregarMascota(Mascota mascota);
    }
}
