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
            //preguntar el ataque de los personajes//
            Console.WriteLine("¿Quieres saber el ataque de los esclavos?");
            string pregunta_de_daño = Console.ReadLine();
            pregunta_de_daño = pregunta_de_daño.ToLower();
            
            while (pregunta_de_daño != "si" && pregunta_de_daño != "no")
            {
                Console.WriteLine("No me estás respondiendo la pregunta bien, dime si o no");
                Console.WriteLine("¿Quieres saber el ataque de los esclavos?");
                pregunta_de_daño = Console.ReadLine();
            }
            if (pregunta_de_daño == "si")
            {
                foreach (var personaje in personajes)
                {
                    Console.WriteLine($"{personaje.Nombre} tiene: {personaje.Ataque} puntos de daño");
                }
            }
            else if (pregunta_de_daño == "no")
            {
                Console.WriteLine("okay, señor experto, tu eres el jefe");
            }
            
            //preguntar la defensa de un personaje//
            
            Console.WriteLine("¿Quieres saber la defensa de los esclavos?");
            string pregunta_de_defensa = Console.ReadLine();
            pregunta_de_defensa = pregunta_de_defensa.ToLower();
            
            while (pregunta_de_defensa != "si" && pregunta_de_defensa != "no")
            {
                Console.WriteLine("No me estás respondiendo la pregunta bien, dime si o no");
                Console.WriteLine("¿Quieres saber el ataque de los esclavos?");
                pregunta_de_defensa = Console.ReadLine();
            }
            if (pregunta_de_defensa == "si")
            {
                foreach (var personaje in personajes)
                {
                    Console.WriteLine($"{personaje.Nombre} tiene: {personaje.Defensa} puntos de daño");
                }
            }
            else if (pregunta_de_defensa == "no")
            {
                Console.WriteLine("okay, señor experto, tu eres el jefe");
            }
            
            
            //atacar a un personaje//
            
            
            
            //Curar a un personaje si es que está herido//
            
            
            
            
            Console.WriteLine("Ya puedes irte.");
            Console.ReadKey();
        }
    }
}
