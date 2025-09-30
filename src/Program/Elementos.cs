namespace Program
{
    public enum CategoriaDeObjetos
    {
        Pociones,
        Armas,
        Armaduras
    }

    public class Objeto
    {
        public string TipodeObjeto { get; set; }
        public string DescripcionDelObjeto { get; set; }
        
        public int Stat { get; set; }
        public CategoriaDeObjetos Categoria { get; set; }

        public Objeto(string tipodeObjeto, string descripcionDelObjeto, CategoriaDeObjetos categoria)
        {
            TipodeObjeto = tipodeObjeto;
            DescripcionDelObjeto = descripcionDelObjeto;
            Categoria = categoria;
        }

        public override string ToString()
        {
            return $"{TipodeObjeto} ({Categoria}): {DescripcionDelObjeto}";
        }
    }

    public static class PruebaObjetos
    {
        public static List<Objeto> InventarioInicial()
        {
            var objetos = new List<Objeto>
            {
                new Objeto("Poción de Vida", "Restaura toda la salud", CategoriaDeObjetos.Pociones),
                new Objeto("Espada Larga", "Aumenta ataque en 5", CategoriaDeObjetos.Armas),
                new Objeto("Armadura de Cuero", "Aumenta defensa en 5", CategoriaDeObjetos.Armaduras)
            };

            Console.WriteLine("=== Inventario Inicial Disponible ===");
            foreach (var obj in objetos)
                Console.WriteLine(obj);

            Console.WriteLine();
            return objetos;
        }
    }
}