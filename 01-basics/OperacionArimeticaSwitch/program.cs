using System;
using System.Collections.Generic;
using System.Text;

namespace OpArimetica
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables necesarias
            float a  = 0.0f;
            float b  = 0.0f;
            float resultado = 0.0f;
            string valor = "";
        
        //Mostramos el menu 

        Console.WriteLine("1- Suma");
        Console.WriteLine("2- Resta");  
        Console.WriteLine("3- Multiplicacion");
        Console.WriteLine("4- Division");
        Console.Write("Selecciona una operacion (1-4): ");
        valor = Console.ReadLine();
        int opcion = Convert.ToInt32(valor);

        //Pedimos el primer numero
        Console.Write("Dame el primer numero: ");
        valor = Console.ReadLine();
        a = Convert.ToSingle(valor);

        //Pedimos el segundo numero
        Console.Write("Dame el segundo numero: ");
        valor = Console.ReadLine();
        b = Convert.ToSingle(valor);
        
        //Realizamos la operacion segun la opcion
        
        switch (opcion)
        {
            case 1:
                resultado = a + b;
                Console.WriteLine("El resultado de la suma es: {0}", resultado);
                break;
            case 2:
                resultado = a - b;
                Console.WriteLine("El resultado de la resta es: {0}", resultado);
                break;
            case 3:
                resultado = a * b;
                Console.WriteLine("El resultado de la multiplicacion es: {0}", resultado);
                break;
            case 4:
                if (b != 0.0f)
                {
                    resultado = a / b;
                    Console.WriteLine("El resultado de la division es: {0}", resultado);
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir por cero");
                }
                break;
            default:
                Console.WriteLine("Opcion no valida.");
                break;
        }
    }
}
}