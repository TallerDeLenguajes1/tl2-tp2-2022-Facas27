using NLog;
namespace Tp2
{
    class Program
    {
        static void Main(string[] args){
            var Log = LogManager.GetCurrentClassLogger();
            int num = 0, dni, curso, id;
            string[] clase = { "Atletismo", "Voley", "Futbol" };
            string nombre, apell ;
            Console.WriteLine("Ingrese la cantidad de alumnos a cargar /n");
            num = Cont.NumerosControl();
            for (int i = 0; i < num; i++)
            {

                Console.WriteLine("Ingrese el ID del Alumno");
                id = Cont.NumerosControl();
                Console.WriteLine("Ingrese el DNI del Alumno");
                dni = Cont.NumerosControl();
                Console.WriteLine("Ingrese el Nombre del Alumno");
                nombre = Cont.PalabrasControl();
                Console.WriteLine("Ingrese el Apellido del Alumno");
                apell = Cont.PalabrasControl();
                Console.WriteLine("Ingrese el Curso del Alumno (0: Atletismo, 1: Voley, 2: Futbol) ");
                curso = Cont.SpecialControl();
                Alumno al = new Alumno(id,nombre,apell,dni,curso);
                Log.Info("Alumno Cargado");
                HelperDeArchivos.Guardar(clase[al.Curso], al);
                Log.Debug("Guardado en el csv");


            }
            Console.WriteLine("Desea borrar algun csv? (1:SI , 2:NO)");
            int opc = Cont.Decision();
            if (opc == 1)
            {
                Console.WriteLine("Cual desea eliminar (0: Atletismo, 1: Voley, 2: Futbol)");
                 curso = Cont.SpecialControl();
                 HelperDeArchivos.Limpiar(clase[curso]);

            }


            
        }
    }
    
    
}
