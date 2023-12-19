using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinarioDS_Campos_Kuuk_Yupit
{
    public class Perro : IMascota, IAcariciable
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("El Id no puede ser menor o igual a 0");
                    _id = value;
                }
            }
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
                if (value < 0 || value > 25)
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
            Console.WriteLine("guau guau");
        }

        public void CambiarDuenio(string nombre)
        {
            foreach (var duenio in _personas)
            {
                if (duenio.Nombre == nombre)
                {
                    this.Persona = duenio;
                    return;
                }
                throw new Exception("No se encontró a la persona");
            }
        }

        public void ResponderACaricia()
        {
            Console.WriteLine("*Lo acaricia*");
        }


    }
}
