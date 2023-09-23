// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
namespace estructuraswitch

{
    class Program
    {
       static void Main(string[] args)

       {



        Console.WriteLine("Ingrese un valor entre 1 y 4");
        int estructura = int.Parse(Console.ReadLine());


        switch (estructura)

        {


            case 1:
                Console.WriteLine("Hola mundo");
                break;
            case 2:
                Console.WriteLine("Bienvenido al sistema");
                break;
            case 3:
                Console.WriteLine("somos libres");
                break;
            case 4:
                Console.WriteLine("logramos arregarlo");
                break;

            default:
                Console.WriteLine("esta opción no existe");
                    
                break;
        }

       }


    }

}
        