using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinarioDS_Campos_Kuuk_Yupit
{
    class Program
    {
        static void Main(string[] args)
        {

            //Menu principal que se le muestra al usuario
            Console.WriteLine("Bienvenido a CaninCenter");
            Console.WriteLine("Seleecione una opcion");
            Console.WriteLine("1) Administracion del centro");
            Console.WriteLine("2) Administracion de adopciones");
            Console.WriteLine("3) Adinistracion de binestar animal");
            Console.WriteLine("4) Simulacion de interacciones");
            Console.WriteLine("5) Finalizar programa");

            var opcionDelMenu = Console.ReadLine();

            switch (opcionDelMenu)
            {
                case "1":


                    AdministracionDelCentro();

                    break;
                case "2":

                    AdministracionDeAdopciones();



                    break;
                case "3":


                    AdministracionDeBienestarAnimal();



                    break;
                case "4":
                    SimulacionDeInteracciones();



                    break;

                case "5":

                    SalirDelPrograma();

                    break;
                default:
                    Console.WriteLine("Opción inválida. Porfavor ingresa una de las opciones validas");
                    break;
            }




        }
        static void AdministracionDelCentro()
        {


            //menu al seleccionar administracion del centro 
            Console.WriteLine("Selecciona una opcion");
            Console.WriteLine("1) Administracion de personas");
            Console.WriteLine("2) Administracion de mascotas");
            Console.WriteLine("3) Regresar a menu anterior");
            var opcionDelMenu1 = Console.ReadLine();


            switch (opcionDelMenu1)
            {
                case "1":
                    //menu administracion de personas 
                    Console.WriteLine("Selecciona una opcion");
                    Console.WriteLine("1) Mostrar las personas registradas");
                    Console.WriteLine("2) Registrar personas nuevas");
                    Console.WriteLine("3) Buscar personas por nombre");
                    Console.WriteLine("4) Examinar persona");
                    Console.WriteLine("5) Regresar al menu anterior");
                    var opcionDelMenu1_1 = Console.ReadLine();

                    switch (opcionDelMenu1_1)
                    {
                        case "1":


                            break;
                        case "2":

                            break;

                        case "3":

                            break;
                        case "4":

                            break;
                        case "5":

                            break;
                        default:
                            Console.WriteLine("Opción inválida. Porfavor ingresa una de las opciones validas");
                            break;

                    }
                    break;

                case "2":
                    //menu administracion de mascotas 
                    Console.WriteLine("Selecciona una opcion");
                    Console.WriteLine("1) Mostrar las mascotas registradas");
                    Console.WriteLine("2) Registrar nueva mascota");
                    Console.WriteLine("3) Buscar mascota por especie");
                    Console.WriteLine("4) Buscar mascota por nombre");
                    Console.WriteLine("4) Examinar mascota");
                    Console.WriteLine("5) Regresar al menu anterior");
                    var opcionDelMenu1_2 = Console.ReadLine();

                    switch (opcionDelMenu1_2)
                    {
                        case "1":


                            break;
                        case "2":

                            break;

                        case "3":

                            break;
                        case "4":

                            break;
                        case "5":

                            break;
                        default:
                            Console.WriteLine("Opción inválida. Porfavor ingresa una de las opciones validas");
                            break;


                    }
                    break;

                case "3":

                    return;


            }

        }

        static void AdministracionDeAdopciones()
        {
            //menu al seleccionar administracion de adopciones 
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("1) Ver mascotas disponibles para adoptar");
            Console.WriteLine("2) Adoptar mascota");
            Console.WriteLine("3) Regresar al menu anterior");
            var opcionDelMenu2 = Console.ReadLine();
            switch (opcionDelMenu2)
            {
                case "1":

                    break;

                case "2":

                    break;

                case "3":

                    break;
                default:
                    Console.WriteLine("Opción inválida. Porfavor ingresa una de las opciones validas");
                    break;

            }
        }
        static void AdministracionDeBienestarAnimal()
        {
            //menu al seleccionar administracion de binestar animal 
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("1) Servicio de SPA");
            Console.WriteLine("2) Corte de pelo");
            Console.WriteLine("3) Discoteca Animal");
            Console.WriteLine("4) Regresar al menu anterior");
            var opcionDelMenu3 = Console.ReadLine();
            switch (opcionDelMenu3)
            {
                case "1":

                    break;

                case "2":

                    break;

                case "3":

                    break;

                case "4":

                    break;
                default:
                    Console.WriteLine("Opción inválida. Porfavor ingresa una de las opciones validas");
                    break;



            }


        }

        static void SalirDelPrograma()
        {
            Console.WriteLine("Saliendo del sistema, vuelva pronto, adios!");
        }

        static void SimulacionDeInteracciones()
        {
            Console.WriteLine("Escribe el ID que deseas buscar");
            Console.ReadLine();

        }
    }
}
