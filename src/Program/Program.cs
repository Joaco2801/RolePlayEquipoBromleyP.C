using System;

class Program
{
    static void Main(string[] args)
    {
        // --- 1. Creación de Objetos ---
        // Se instancian los personajes, elementos y hechizos.
        Console.WriteLine("--- Creando personajes y elementos de la Tierra Media ---");

        var mago = new Mago("Gandalf");
        var elfo = new Elfo("Legolas");
        var enano = new Enano("Gimli");

        var bastonMagico = new Elemento("Bastón Mágico", ataque: 25, defensa: 10);
        var tunica = new Elemento("Túnica Élfica", ataque: 0, defensa: 15);
        var hacha = new Elemento("Hacha de Enano", ataque: 40, defensa: 5);
        
        var hechizoFuego = new Hechizo("Bola de Fuego", ataque: 20, defensa: 0);
        var libroHechizos = new LibroHechizos("Libro de la Magia Antigua");
        libroHechizos.AgregarHechizo(hechizoFuego);

        // --- 2. Asignación de Items ---
        // Los personajes reciben sus elementos.
        mago.EquiparItem(bastonMagico);
        mago.EquiparItem(libroHechizos);
        elfo.EquiparItem(tunica);
        enano.EquiparItem(hacha);

        // --- 3. Demostración de Comportamiento ---
        // Se invocan los métodos de los objetos para mostrar sus funcionalidades.
        Console.WriteLine("\n--- Mostrando las estadísticas de los personajes ---");
        MostrarEstadisticas(mago);
        MostrarEstadisticas(elfo);
        MostrarEstadisticas(enano);

        Console.WriteLine("\n--- Gimli ataca a Gandalf ---");
        enano.Atacar(mago); // Llama al método Atacar del objeto enano.
        Console.WriteLine($"Vida de {mago.Nombre} después del ataque: {mago.VidaActual}");

        Console.WriteLine("\n--- Gandalf se cura ---");
        mago.Curar(); // Llama al método Curar del objeto mago.
        Console.WriteLine($"Vida de {mago.Nombre} después de curarse: {mago.VidaActual}");
    }

    /// <summary>
    /// Muestra las estadísticas de un personaje.
    /// </summary>
    /// <param name="personaje">El personaje a inspeccionar.</param>
    private static void MostrarEstadisticas(IPersonaje personaje)
    {
        // Se utilizan los métodos de la interfaz para obtener los valores.
        Console.WriteLine($"\nPersonaje: {personaje.Nombre}");
        Console.WriteLine($"- Vida: {personaje.VidaActual}/{personaje.VidaInicial}");
        Console.WriteLine($"- Ataque Total: {personaje.ObtenerAtaqueTotal()}");
        Console.WriteLine($"- Defensa Total: {personaje.ObtenerDefensaTotal()}");
    }
}