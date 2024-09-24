using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace psss
{
    internal class Program
    {           
           
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Ingrese la operacion a la cual quiere usar ");
                Console.WriteLine("1. Numero mayor o menor");
                Console.WriteLine("2. Numeros primos");
                Console.WriteLine("3. Numero mayor de una lista");
                Console.WriteLine("4. Salir");
                int oper = Convert.ToInt32(Console.ReadLine());

                switch (oper)
                {
                    case 1:
                        Console.WriteLine("1");
                        Numero_mayor_O_menor();
                        break;

                    case 2:
                        Console.WriteLine("2");
                        Console.WriteLine("Dame un numero");

                        int N = 0;
                        Console.WriteLine("dame el primer numero");
                        N = Convert.ToInt32(Console.ReadLine());

                        Numeros_primo(N);
                        Console.ReadLine();

                        break;

                    case 3:
                        Console.WriteLine("3");
                        Console.WriteLine("Numeros de la lista");
                        MayorDeUnaLista();
                        
                        break;

                    case 4:
                        Console.WriteLine("3");
                        Console.WriteLine("Saliendo del programa");
                        break;

                    default:
                        Console.WriteLine("no hay nada");
                        break;
                }
                if (continuar) 
                {
                    Console.WriteLine("\n¿Deseas realizar otra operación? (S/N)");
                    char respuesta = Char.ToUpper(Console.ReadKey().KeyChar);

                    if (respuesta != 'S')
                    {
                        continuar = false;
                        Console.WriteLine("\nSaliendo del programa...");
                    }
                    else
                    {
                        Console.Clear(); // Limpia la consola para empezar de nuevo
                    }
                }
                Console.WriteLine();
            }


        
        }
        private static void Numero_mayor_O_menor() 
        {
            Console.WriteLine("1");

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Saber cual numero es mayor\n");
            Console.WriteLine("Dame un numero");

            Console.WriteLine("dame el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dame el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dame el tercer numero");
            num3 = Convert.ToInt32(Console.ReadLine());
            NumeroMayor(num1, num2, num3);
            Console.ReadLine();

            Console.WriteLine("Saber que numero es menor\n");
            Console.WriteLine("Dame un numero");

            Console.WriteLine("dame el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dame el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dame el tercer numero");
            num3 = Convert.ToInt32(Console.ReadLine());
            NumeroMenor(num1, num2, num3);
            Console.ReadLine();
        }
        private static void NumeroMayor(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("El primer número es el mayor.");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("El segundo número es el mayor.");
            }
            else
            {
                Console.WriteLine("El tercer número es el mayor.");
            }
        }
        private static void NumeroMenor(int num1, int num2, int num3)
        {
            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine("El primer número es el menor.");
            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine("El segundo número es el menor.");
            }
            else
            {
                Console.WriteLine("El tercer número es el menor.");
            }
        }

        private static void Numeros_primo( int N) 
        {

            if (N == 0)
            {
                // 1) Mostrar mensaje número inválido
                Console.WriteLine("Número inválido.");
            }
            // 3) Si N == 1
            else if (N == 1)
            {
                // 1) Mostrar mensaje número primo
                Console.WriteLine("Número no primo.");
            }
            // 4) Si N % 2 == 0
            else if (N % 2 == 0)
            {
                // 1) Mostrar mensaje número no es primo
                Console.WriteLine("Número no es primo.");
            }
            // 5) Si no
            else
            {
                // 1) Iniciar un for con M = 1 hasta N
                for (int M = 1; M <= N; M++)
                {
                    // 2) Iniciar un for en i = M - 1 hasta 2
                    for (int i = M - 1; i >= 2; i--)
                    {
                        // 3) Si M % i == 0
                        if (M % i == 0)
                        {
                            // 1) Break
                            break;
                        }
                        // 4) Si i == 2
                        if (i == 2)
                        {
                            // 1) Mostrar mensaje número primo
                            Console.WriteLine($"{M} es un número primo.");
                        }
                    }
                    // 5) termina for de i
                }
            }
        }
        
        private static void MayorDeUnaLista() 
        {
            List<int> lista = new List<int>();
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Escribe un numero");
                int numero = Convert.ToInt32(Console.ReadLine());
                lista.Add(numero);
                Console.WriteLine("quieres agrega otro numero");
                Console.WriteLine("S- Si");
                Console.WriteLine("N- No");
                continuar = char.ToUpper(Console.ReadKey().KeyChar) == 'S';
                Console.Clear();
            }
            int mayor = lista[0];
            //bool esMayor = false;
            for (int i = 0; i < lista.Count; i++) //for 1
            {
                if (lista[i] > mayor) // Si encontramos un número mayor, lo actualizamos
                {
                    mayor = lista[i];
                }
                /**int N= lista[i]; //obtener numero de lista
                for (int j = 0; j < lista.Count; j++) //for 2
                {
                    int M=lista[j];
                    if (N < M)
                    {
                        esMayor = false;
                        break;
                    }
                    else if (N == M || N > M) 
                    {
                        if (j==lista.Count-1) 
                        {
                            mayor =N;
                            esMayor = true;
                        }
                    }  
                } 
             if (!esMayor) { break; }//si no se encuentra aun el mayor pasa a la siguiente interacion
            **/
            }
            Console.WriteLine($"El numero mayor es igua: {mayor}");


        }
    }
}
