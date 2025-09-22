namespace Program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hora de empezar otra vez... Elige el nombre de tus tres esclavos, Maestro de los sádicos");

            var personajes = new List<CreadorDePersonajes>();

            Console.Clear();
            Console.Write("Elige el nombre de este pobre estudioso (Mago): ");
            string nombreMago = Console.ReadLine();
            personajes.Add(new Magos(nombreMago));

            Console.Clear();
            Console.Write("Este tiene las orejas largas y cara de pocos amigos (Elfo): ");
            string nombreElfo = Console.ReadLine();
            personajes.Add(new Elfos(nombreElfo));

            Console.Clear();
            Console.Write("Y por último, este pequeñín con barba y con ojos de plato... ¿tiene una olla en la espalda? (Enano): ");
            string nombreEnano = Console.ReadLine();
            personajes.Add(new Enanos(nombreEnano));

            Console.Clear();
            Console.WriteLine("Muy bien, ahora a te diré como es cada uno de tus esclavos:");
            foreach (var personaje in personajes)
            {
                personaje.BreveDescripcion();
            }

            // Mostrar los pisos uno a uno
            for (int i = 1; i <= 4; i++)
            {
                var piso = new Pisos(i);
                piso.MostrarPisos();
            }

            Console.WriteLine("Ya puedes irte.");
            Console.ReadKey();
        }
    }
}
