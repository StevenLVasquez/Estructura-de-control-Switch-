// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using static System.Math;
namespace estructuraswitch

{
    class Program
    {
       static void Main(string[] args)

       {

 

        Console.WriteLine("Ingrese un valor entre 1 y 5");
        int estructura = int.Parse(Console.ReadLine());

            do
                switch (estructura)

                {


                    case 1:
                        Console.WriteLine("Hola mundo");

                        switch (estructura)
                        {
                            case 1:
                                Console.WriteLine("Hola mundo");
                                Console.WriteLine("Seleccione una operación:");
                                Console.WriteLine("1 - Suma");
                                Console.WriteLine("2 - Resta");
                                Console.WriteLine("3 - Multiplicación");
                                Console.WriteLine("4 - División");
                                int operacion = int.Parse(Console.ReadLine());

                                switch (operacion)
                                {
                                    case 1:
                                        Console.WriteLine("Ingrese dos números para sumar:");
                                        double num1 = double.Parse(Console.ReadLine());
                                        double num2 = double.Parse(Console.ReadLine());
                                        double suma = num1 + num2;
                                        Console.WriteLine($"Resultado: {suma}");
                                        break;
                                    case 2:
                                        Console.WriteLine("Ingrese dos números para restar:");
                                        num1 = double.Parse(Console.ReadLine());
                                        num2 = double.Parse(Console.ReadLine());
                                        double resta = num1 - num2;
                                        Console.WriteLine($"Resultado: {resta}");
                                        break;
                                    case 3:
                                        Console.WriteLine("Ingrese dos números para multiplicar:");
                                        num1 = double.Parse(Console.ReadLine());
                                        num2 = double.Parse(Console.ReadLine());
                                        double multiplicacion = num1 * num2;
                                        Console.WriteLine($"Resultado: {multiplicacion}");
                                        break;
                                    case 4:
                                        Console.WriteLine("Ingrese dos números para dividir:");
                                        num1 = double.Parse(Console.ReadLine());
                                        num2 = double.Parse(Console.ReadLine());

                                        if (num2 != 0)
                                        {
                                            double division = num1 / num2;
                                            Console.WriteLine($"Resultado: {division}");
                                        }
                                        else
                                        {
                                            Console.WriteLine("No se puede dividir por cero.");
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Operación no válida.");
                                        break;
                                }
                                break;
                        }
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

                    case 5:
                        Console.WriteLine("Cerrar programa");
                        break;



                    default:
                        Console.WriteLine("esta opción no existe");

                        break;
                }

            while (estructura != 5);
            

        }
        //hola soy steven , steven hizp este codigo 

    }

}
        