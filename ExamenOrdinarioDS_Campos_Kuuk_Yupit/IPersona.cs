using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinarioDS_Campos_Kuuk_Yupit
{
    public interface IPersona    //Creación de la interfaz persona
    {
        int id { get; set; }    //Con id se refiere a un identificador numérico
        string name { get; set; }
        void ObtenerMascotas();
        void ObtenerMascotasId();   //Obtener mascotas por medio del identificador numérico
        void AcariciarMascota();
        void Acariciar(); 
        void AgregarMascota();

    }
}
