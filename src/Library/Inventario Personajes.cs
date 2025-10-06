namespace Program
{
    public class InventarioPersonajes
    {
        private List<Objeto> objetos = new List<Objeto>();
        private const int CAPACIDAD_MAXIMA = 10; // Capacidad máxima del inventario

        // Agregar un objeto al inventario
        public bool AgregarAlInventario(Objeto objeto)
        {
            if (objetos.Count >= CAPACIDAD_MAXIMA)
            {
                Console.WriteLine("¡El inventario está lleno! No puedes agregar más objetos.");
                return false;
            }

            objetos.Add(objeto);
            Console.WriteLine($"{objeto.TipodeObjeto} se guardó en el inventario.");
            return true;
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
            Console.WriteLine($"Espacio disponible: {CAPACIDAD_MAXIMA - objetos.Count} slots");
        }

        // Buscar un objeto específico en el inventario
        public Objeto BuscarObjeto(string nombre)
        {
            return objetos.Find(o => o.TipodeObjeto.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }

        // Verificar si existe un objeto en el inventario
        public bool TieneObjeto(string nombre)
        {
            return objetos.Any(o => o.TipodeObjeto.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }

        // Obtener la cantidad de objetos en el inventario
        public int CantidadDeObjetos()
        {
            return objetos.Count;
        }

        // Limpiar todo el inventario
        public void VaciarInventario()
        {
            objetos.Clear();
            Console.WriteLine("Has vaciado tu inventario completamente.");
        }

        // Obtener lista de objetos (útil para otras clases)
        public List<Objeto> ObtenerObjetos()
        {
            return new List<Objeto>(objetos); // Devuelve una copia de la lista para mantener el encapsulamiento
        }
    }
}
