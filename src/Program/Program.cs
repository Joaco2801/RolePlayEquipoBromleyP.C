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
            Console.WriteLine("Quieres torturar a algino de tus esclavos?");
            string PreguntaDeTortura = Console.ReadLine();
            
            if (PreguntaDeTortura == "si")
            {
                Console.WriteLine("¿A quién quieres lastimar? (Procura escribir el nombre exactamente igual)");
    
                foreach (var personaje in personajes)
                {
                    Console.WriteLine($"¿{personaje.Nombre}?");
                }

                string torturado = Console.ReadLine()?.ToLower();
                CreadorDePersonajes objetivo = personajes.FirstOrDefault(p => p.Nombre.ToLower() == torturado);

                if (objetivo != null)
                {
                    Console.WriteLine("¿Cuánto daño quieres hacerle?");
                    if (int.TryParse(Console.ReadLine(), out int Hurts))
                    {
                        objetivo.Damages(Hurts);
                    }
                    else
                    {
                        Console.WriteLine("No ingresaste un número válido.");
                    }
                }
                else
                {
                    Console.WriteLine("No le pusiste así a ninguno de ellos.");
                }
            }
            //Curar a un personaje si es que está herido//
            string objetivoCuracion = Console.ReadLine()?.ToLower();
                        
            CreadorDePersonajes personajeACurar = personajes.FirstOrDefault(p => p.Nombre.ToLower() == objetivoCuracion);
            
            if (personajeACurar != null)
            {
                Console.WriteLine($"¿Cuánta vida quieres restaurarle a {personajeACurar.Nombre}?");
                if (int.TryParse(Console.ReadLine(), out int cantidadDeCura))
                {
                    var pocion = new Curas(cantidadDeCura);
                    pocion.Curar(personajeACurar); 
                }
                else { Console.WriteLine("No ingresaste una cantidad válida de vida para curar.");
                }
            }
            else
            {
                Console.WriteLine("No le pusiste así a ninguno de ellos.");
            } 
            
            
            Console.WriteLine("Ya puedes irte.");
            Console.ReadKey();
        }
    }
}
