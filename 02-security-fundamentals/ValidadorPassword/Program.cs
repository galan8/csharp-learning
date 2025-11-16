using System;

namespace ValidadorPassword
 {
    class Program
     {
        static void Main(string[] args) 
        {   
            Console.WriteLine("Ingrese una contrasena: ");
            string password = Console.ReadLine();

            //validar longitud 
            if (password.Length < 8 || password.Length > 64) 
            {
                Console.WriteLine("La contrasena debe tener entre 8 y 64 caracteres");
                return;

            }
                    //valida si tiene numeros
            bool tieneNumero=false;

            foreach(char c in password) 
            {
                if (c>= '0' && c <= '9')
                {
                    tieneNumero = true;
                    break; 
                    }
            }
            
            if (tieneNumero)
            {
                Console.WriteLine("Contrasena VALIDA");
            }
            else
            {
                Console.WriteLine("Falta incluir numeros");
            }
                
        }
     }
 }

