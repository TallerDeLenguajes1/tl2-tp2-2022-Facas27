namespace Tp2
{
    class HelperDeArchivos
    {
        
        static public void Guardar(string clase , Alumno al){
            string path = clase + ".csv";
            if (!File.Exists(path))
            {
                
                
            }else
            {
                    File.AppendAllText(path, al.Cadena());
            }

        }
        static public void Limpiar(string clase){
            string path = clase + ".csv";
            File.WriteAllText(path,"ID;DNI;Nombre;Apellido\n");
        }
        
        
    }
    
}