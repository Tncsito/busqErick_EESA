
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busqErick_EESA.Datos
{
    public class Datos
    {
        public void Ejercicio1()
        {
            int[] numeros = { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };

            Console.Write("Ingrese un número a buscar: ");
            int numeroABuscar = int.Parse(Console.ReadLine());

            bool encontrado = false;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroABuscar)
                {
                    Console.WriteLine($"El número {numeroABuscar} se encuentra en la posición {i}.");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"El número {numeroABuscar} no se encuentra en la lista.");
            }
        }
        public void Ejercicio2()
        {
            string[] cadenas = { "manzana", "banana", "cereza", "uva", "pera" };

            Console.Write("Ingrese una cadena a buscar: ");
            string cadenaABuscar = Console.ReadLine();

            bool encontrado = false;
            for (int i = 0; i < cadenas.Length; i++)
            {
                if (cadenas[i] == cadenaABuscar)
                {
                    Console.WriteLine($"La cadena '{cadenaABuscar}' se encuentra en la posición {i}.");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"La cadena '{cadenaABuscar}' no se encuentra en el arreglo.");
            }
        }
        public void Ejercicios3()
        {
            int[] numeros = { 3, 7, 5, 9, 12, 15, 10, 21 };

            int indice = -1;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    indice = i;
                    break;
                }
            }

            if (indice != -1)
            {
                Console.WriteLine($"El primer número par se encuentra en la posición {indice}.");
            }
            else
            {
                Console.WriteLine("No se encontraron números pares en la matriz.");
            }
        }
        public void Ejercicios4()
        {
            int[] numeros = { 3, 7, 4, 9, 12, 15, 10, 21 };

            Console.WriteLine("Posiciones de números pares en la matriz:");

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.WriteLine($"Número par en la posición {i}");
                }
            }
        }
        static int BusquedaBinaria(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                    return mid;

                if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }

        public void Ejercicios5()
        {
            int[] numeros = { 2, 4, 6, 8, 10, 12, 14, 16 };

            Console.Write("Ingrese un número a buscar: ");
            int numeroABuscar = int.Parse(Console.ReadLine());

            int indice = BusquedaBinaria(numeros, numeroABuscar);

            if (indice != -1)
            {
                Console.WriteLine($"El número {numeroABuscar} se encuentra en la posición {indice}.");
            }
            else
            {
                Console.WriteLine($"El número {numeroABuscar} no está en el arreglo.");
            }
        }
        static int BusquedaBinaria(string[] arr, string target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int comparison = string.Compare(arr[mid], target, StringComparison.Ordinal);

                if (comparison == 0)
                    return mid;

                if (comparison < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }

        public void Ejercicios6()
        {
            string[] cadenas = { "Manzana", "Banana", "Naranja", "Pera", "Uva" };

            Console.Write("Ingrese una cadena a buscar: ");
            string cadenaABuscar = Console.ReadLine();

            int indice = BusquedaBinaria(cadenas, cadenaABuscar);

            if (indice != -1)
            {
                Console.WriteLine($"La cadena '{cadenaABuscar}' se encuentra en la posición {indice}.");
            }
            else
            {
                Console.WriteLine($"La cadena '{cadenaABuscar}' no está en el arreglo.");
            }
        }
        static int Primerevento(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] % 2 == 0)
                {
                    if (mid == 0 || arr[mid - 1] % 2 != 0)
                        return mid;
                    else
                        right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }

        public void Ejercicios7()
        {
            int[] numeros = { 1, 3, 4, 5, 6, 8, 9, 10, 12, 14, 16 };

            int indice = Primerevento(numeros);

            if (indice != -1)
            {
                Console.WriteLine($"El primer número par se encuentra en la posición {indice}.");
            }
            else
            {
                Console.WriteLine("No se encontraron números pares en el arreglo.");
            }
        }
    }
}
