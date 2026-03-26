namespace Ejercicio_Diccionario;

class Program
{
    static void Main(string[] args)
    {
        
      
        do
            {
                Console.Clear();
                menu.mostrarMenu(list + "CURSO DEL COLEGIO");

                opcion = menu.pedirOpcion(list.Count);

                switch (opcion)
                {
                    case 1:
                        agregarAlumno(curso);
                        break;

                    case 2:
                        buscarAlumno(curso);
                        break;

                    case 3:
                        agregarFalta(curso);
                        break;

                    case 4:
                        mostrarAlumnos(curso);
                        break;

                    case 5:
                        alumnosLibres(curso);
                        break;

                    case 6:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;



                }
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            } while (opcion != list.Count);

      
    }
}
