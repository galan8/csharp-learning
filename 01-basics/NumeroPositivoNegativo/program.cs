using System;
using System.Collections.Generic;
using System.Text;

namespace NumeroPositivosNegativos
{
    
    class program
    {
   /*Esta es la funcion principal del programa. Aqui inicia la aplicacion. */    
    static void Main(string[] args)
        {
            
    int numero  = 0; // donde guardamos el numero
    string valor = ""; // Para guardar la cadena  dada por el usuario
    //pedimos el numero 
    Console.Write("Dame un numero entero: ");
    valor = Console.ReadLine();
    numero = Convert.ToInt32(valor); //Convertimos la cadena a entero
//Hacemos uso de if con la expresion para el caso de los positivos 
if (numero > 0) 
{
Console.WriteLine("El numero {0} es positivo", numero); 
}
//Hacemos uso de else if para el caso de los negativos
else if (numero < 0)
{ 
Console.WriteLine("El numero {0} es negativo", numero); //se ejecuta si se cumple numero <0
}
else{
Console.WriteLine("El numero es 0 (ni positivo ni negativo)", numero); //se ejecuta si se cumple numero <0
}
        }

    }

}
