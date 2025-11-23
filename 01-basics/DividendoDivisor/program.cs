using System;
using System.Collections.Generic;
using System.Text;  

namespace DividendoDivisor
{
    class Program  //  Agregada la clase
    {
        static void Main(string[] args)
        {
            //Variables para pedir datos
            float dividendo = 0.0f;
            float divisor = 1.0f;
            float resultado = 0.0f;    
            string valor = "";
            
            //Pedimos el dividendo 
            Console.Write("Dame el dividendo: ");
            valor = Console.ReadLine();
            dividendo = Convert.ToSingle(valor);  //  
        
            //Pedimos el divisor
            Console.Write("Dame el divisor: ");
            valor = Console.ReadLine();
            divisor = Convert.ToSingle(valor); 
            
            //Si el divisor es valido, entonces hacemos la division 
            if (divisor != 0.0f)
            {
                //Hacemos la operacion 
                resultado = dividendo / divisor;
        
                //Mostramos el resultado 
                Console.WriteLine("El resultado de la division es {0:F2}", resultado);
            }
            else
            {
                Console.WriteLine("❌ Error: No se puede dividir por cero");
            }
        }
    }
}