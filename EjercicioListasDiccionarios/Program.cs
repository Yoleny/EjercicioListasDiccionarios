using System;
using System.Collections.Generic;

namespace EjercicioListasDiccionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear la lista de productos
            List<string> productos = new List<string>() { "Tenis", "Televisor", "Computadora", "Smartphone",
                                                          "Butaca", "Mesa", "Silla", "Lámpara", 
                                                          "Zapatos", "Camisa" };

            // Agregar un nuevo producto en el índice 3
            productos.Insert(3, "NuevoProducto");

            // Remover el último elemento de la lista
            productos.RemoveAt(productos.Count - 1);

            // Mostrar la lista en la consola
            Console.WriteLine("Lista de productos:");
            foreach (string producto in productos)
            {
                Console.WriteLine(producto);
            }
            Console.WriteLine();

            // Crear el diccionario de departamentos
            Dictionary<string, string> departamento1 = new Dictionary<string, string>()
            {
                { "nombre", "Cortés" },
                { "cabecera", "San Pedro Sula" },
                { "superficie", "3,923 km²" },
                { "población", "1 876 658 " }
            };

            Dictionary<string, string> departamento2 = new Dictionary<string, string>()
            {
                { "nombre", "Santa Bárbara" },
                { "cabecera", "Santa Bárbara" },
                { "superficie", "5,024 km²" },
                { "población", "488 040 " }
            };

            // Agregar los departamentos al diccionario
            Dictionary<string, Dictionary<string, string>> departamentos = new Dictionary<string, Dictionary<string, string>>();
            departamentos.Add(departamento1["nombre"], departamento1);
            departamentos.Add(departamento2["nombre"], departamento2);

            // Mostrar el diccionario en la consola
            Console.WriteLine("Diccionario de departamentos:");
            foreach (KeyValuePair<string, Dictionary<string, string>> departamento in departamentos)
            {
                Console.WriteLine("Departamento: " + departamento.Key);
                foreach (KeyValuePair<string, string> dato in departamento.Value)
                {
                    Console.WriteLine(dato.Key + ": " + dato.Value);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}