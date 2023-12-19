using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Emilio
namespace ExamenOrdinarioDS_Campos_Kuuk_Yupit
{
    //elementos de la interfaz
    public interface IMascota
    {

        int Id { get; set; }
        string Nombre { get; set; }
        Persona Persona { get;}

        void HacerRuido();
        void CambiarDuenio(string nombre);
    }
}
