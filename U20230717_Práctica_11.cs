using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("\nMenú de Opciones:");
                Console.WriteLine("1. Ingresar números");
                Console.WriteLine("2. Calcular suma de números");
                Console.WriteLine("3. Buscar número");
                Console.WriteLine("4. Ordenar números");
                Console.WriteLine("5. Salir");
                Console.WriteLine("\nSelecciona una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

            } while (opcion != 5);

            switch (opcion)
            {
                case 1:
                    IngresarNumero();
                    Console.ReadKey();
                    break;

                case 2:
                    int suma = CalcularSuma();
                    Console.WriteLine("\nLa suma de los números es: " + suma);
                    Console.ReadKey();
                    break;

                case 3:
                    BuscarNumero();
                    Console.ReadKey();
                    break;

                case 4:
                    OrdenarNumeros();
                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine("\n¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("\nOpción no válida. Inténtalo de nuevo.");
                    break;
            }
        }

        static int[] numeros = new int[5]; // Arreglo para almacenar números

        static int cantidadNumeros = 0; // Contador para rastrear la cantidad de números ingresados

        static void IngresarNumero()
        {
            Console.WriteLine("\nIngresa hasta 5 números (ingresa -1 para finalizar):");
            cantidadNumeros = 0;

            while (cantidadNumeros < numeros.Length)
            {
                Console.Write("Número #{0}: ", cantidadNumeros + 1);
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero == -1)
                    break;

                numeros[cantidadNumeros] = numero;
                cantidadNumeros++;
            }
        }

        static int CalcularSuma()
        {
            int suma = 0;
            for (int i = 0; i < cantidadNumeros; i++)
            {
                suma += numeros[i];
            }
            return suma;
        }

        static void BuscarNumero()
        {
            Console.Write("\nIngresa el número que deseas buscar: ");
            int numeroBuscado = Convert.ToInt32(Console.ReadLine());
            bool encontrado = false;

            for (int i = 0; i < cantidadNumeros; i++)
            {
                if (numeros[i] == numeroBuscado)
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
                Console.WriteLine("\nEl número fue encontrado en el arreglo.");
            else
                Console.WriteLine("\nEl número no fue encontrado en el arreglo.");
        }

        static void OrdenarNumeros()
        {
            Array.Sort(numeros, 0, cantidadNumeros);
            Console.WriteLine("\nNúmeros ordenados de manera ascendente:");
            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}