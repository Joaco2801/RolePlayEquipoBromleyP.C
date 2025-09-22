using Program;
using System;
using System.Collections.Generic;
namespace Program
{
    public class InventarioPersonajes
    {
        private List<Objeto> objetos = new List<Objeto>();

        // Agregar un objeto al inventario
        public void AgregarAlInventario(Objeto objeto)
        {
            objetos.Add(objeto);
            Console.WriteLine($"{objeto.TipodeObjeto} se guardó en el inventario.");
        }

        // Quitar un objeto del inventario por nombre
        public void QuitarDelInventario(string nombre)
        {
            var objeto = objetos.Find(o => o.TipodeObjeto == nombre);
            if (objeto != null)
            {
                objetos.Remove(objeto);
                Console.WriteLine($"Tiraste {nombre} del inventario.");
            }
            else
            {
                Console.WriteLine($"No tienes {nombre} en el inventario.");
            }
        }

        // Mostrar todos los objetos del inventario
        public void HacerElInventario()
        {
            if (objetos.Count == 0)
            {
                Console.WriteLine("No hay nada en el inventario, jaja, pobre.");
                return;
            }

            Console.WriteLine("Este es tu inventario:");
            foreach (var objeto in objetos)
            {
                Console.WriteLine($"- {objeto.TipodeObjeto}: {objeto.DescripcionDelObjeto}");
            }
        }
    }
}