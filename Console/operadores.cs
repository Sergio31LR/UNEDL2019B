using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            char ope;
            float a = 0, b = 0, resultado = 0;
            int x = 0;
            Console.Write("Ingrese el primer numero ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero ");
            b = int.Parse(Console.ReadLine());

            while (x == 0)
            {
                Console.Write("Ingrese algun operador para realizar una accion ó Ingrese 0 para cerrar el programa ");
                // = char.Parse(Console.ReadLine());
                String capturado = null;
                capturado = Console.ReadLine();

                switch (capturado)
                {
                    case "+":
                        resultado = a + b;
                        Console.WriteLine("la suma de " + a + " + " + b + "=" + resultado);
                        Console.WriteLine();
                                   break;
                    case "-":
                        resultado = a - b;
                        Console.WriteLine("la resta de " + a + " - " + b + "=" + resultado);
                        Console.WriteLine();
                        break;
                    case "*":
                        resultado = a * b;
                        Console.WriteLine("la multiplicacion de " + a + " * " + b + "=" + resultado);
                        Console.WriteLine();
                        break;
                    case "/":
                        resultado = a / b;
                        Console.WriteLine("la division de " + a + " / " + b + "=" + resultado);
                        Console.WriteLine();
                        break;

                    case "%":
                        resultado = a % b;
                        Console.WriteLine("el resto de la division de " + a + " % " + b + "=" + resultado);
                        Console.WriteLine();
                        break;
                    case ">":
                        if (a > b)
                        {
                            Console.WriteLine("El primer digito es mayor que el segundo digito ");
                        }
                        else
                        {
                            Console.WriteLine("El primer digito no es mayor que el segundo");
                        }
                        Console.WriteLine();
                        break;
                    case "<":
                        if (a < b)
                        {
                            Console.WriteLine("el primer digito es menor que el segundo digito ");
                        }
                        else
                        {
                            Console.WriteLine("el primer digito no es menor que el segundo");
                        }
                        Console.WriteLine();
                        break;
                    case "=":
                        if (a == b)
                        {
                            Console.WriteLine("Los digitos ingresados son iguales");
                        }
                        else
                        {
                            Console.WriteLine("los digitos no son iguales");
                        }
                        Console.WriteLine();
                        break;
                    case "!=":
                        if (a != b)
                        {
                            Console.WriteLine("los digitos ingresados son distinto");
                        }
                        Console.WriteLine();
                        break;
                    case "0":
                        System.Environment.Exit(0);
                        break;
                }
                Console.ReadKey();
            }
        }
        

    }
}
