namespace Program
{
    public class Combate
    {
        private List<CreadorDePersonajes> jugadores;
        private List<CreadorDePersonajes> enemigos;

        public Combate(List<CreadorDePersonajes> jugadores, List<CreadorDePersonajes> enemigos)
        {
            this.jugadores = jugadores;
            this.enemigos = enemigos;
        }

        public void Iniciar()
        {
            Console.WriteLine("Hora de acabar con esos tres pobrecitos");

            // Mientras haya personajes vivos en ambos bandos
            while (jugadores.Any(j => j.Vida > 0) && enemigos.Any(e => e.Vida > 0))
            {
                // Turno de los jugadores
                foreach (var jugador in jugadores.Where(j => j.Vida > 0))
                {
                    var objetivo = enemigos.FirstOrDefault(e => e.Vida > 0);
                    if (objetivo != null)
                    {
                        Atacar(jugador, objetivo);
                    }
                }

                // Turno de los enemigos
                foreach (var enemigo in enemigos.Where(e => e.Vida > 0))
                {
                    var objetivo = jugadores.FirstOrDefault(j => j.Vida > 0);
                    if (objetivo != null)
                    {
                        Atacar(enemigo, objetivo);
                    }
                }
            }

            // Resultado
            if (jugadores.Any(j => j.Vida > 0))
                Console.WriteLine("No celebren mucho por ganar");
            else
                Console.WriteLine("Creí que durarían más... que más da");
        }

        private void Atacar(CreadorDePersonajes atacante, CreadorDePersonajes defensor)
        {
            int daño = Math.Max(1, atacante.Ataque - defensor.Defensa);
            defensor.Vida -= daño;

            Console.WriteLine($"{atacante.Nombre} atacó a {defensor.Nombre} causando {daño} de daño. ");

            if (defensor.Vida <= 0)
            {
                Console.WriteLine($"Oh no... derrotaron a {defensor.Nombre}, que pena :)");
            }
        }
    }
}