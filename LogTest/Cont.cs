using NLog;
namespace Tp2
{
    class Cont
    {
         static public int NumerosControl(){
            var Log = LogManager.GetCurrentClassLogger();
            bool error = true;
            int num = 0;

            while(error){
                try
                {
                    num = Int32.Parse(Console.ReadLine());
                    if ( num < 0 )
                    {
                        throw new Exception("El numero que usted ingreso es invalido \n"); 
                    }else
                    {
                        error = false;
                    }    
                }
                catch (System.Exception ex)
                {
                    Log.Error(ex);
                    Console.WriteLine(ex.Message);
                }
            }
            return num;
            
         }
         static public string PalabrasControl(){
            var Log = LogManager.GetCurrentClassLogger();
            string  palabra = "";
            bool error = true;

            while (error)
            {
                try
                {
                    palabra = Console.ReadLine();
                    if (string.IsNullOrEmpty(palabra) || palabra.Any(char.IsDigit))
                    {
                        throw new Exception("Ingrese un nombre valido segun las politicas de la Rae \n");
                        
                    }

                }
                catch (System.Exception ex)
                {
                    
                    Log.Error(ex);
                    Console.WriteLine(ex.Message);
                }
                
            }



            return palabra;
         }

         static public  int SpecialControl(){
            var Log = LogManager.GetCurrentClassLogger();
            bool error = true;
            int num = 0;

            while(error){
                try
                {
                    num = Int32.Parse(Console.ReadLine());
                    if ( num < 0 || num > 2)
                    {
                        throw new Exception("El numero que usted ingreso es invalido \n"); 
                    }else
                    {
                        error = false;
                    }    
                }
                catch (System.Exception ex)
                {
                    Log.Error(ex);
                    Console.WriteLine(ex.Message);
                }
            }
            return num;

         }
         static public  int Decision(){
            var Log = LogManager.GetCurrentClassLogger();
            bool error = true;
            int num = 0;

            while(error){
                try
                {
                    num = Int32.Parse(Console.ReadLine());
                    if ( num <= 0 || num > 2)
                    {
                        throw new Exception("El numero que usted ingreso es invalido \n"); 
                    }else
                    {
                        error = false;
                    }    
                }
                catch (System.Exception ex)
                {
                    Log.Error(ex);
                    Console.WriteLine(ex.Message);
                }
            }
            return num;

         }
        
    }
    
}