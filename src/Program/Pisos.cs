namespace Program;

public class Pisos
{
    public int NumeroDePiso { get; private set; }
    public List<CreadorDePersonajes> Enemigos { get; private set; }

    public Pisos(int numeroDePiso)
    {
        NumeroDePiso = numeroDePiso; // ✅ ahora funciona
        Enemigos = new List<CreadorDePersonajes>();

        GenerarEnemigos();
    }

    private void GenerarEnemigos()
    {
        switch (NumeroDePiso)
        {
            case 1:
                Enemigos.Add(new Goblin("Gob"));
                Enemigos.Add(new Goblin("Glob"));
                Enemigos.Add(new Goblin("Goble"));
                Enemigos.Add(new Goblin("Goblegob"));
                Enemigos.Add(new Goblin("Gabriel"));
                break;
            case 2:
                Enemigos.Add(new AltoGoblin("El Padre de Gabriel"));
                Enemigos.Add(new Goblin("Bogrd"));
                Enemigos.Add(new Goblin("Moss"));
                break;
            case 3:
                Enemigos.Add(new Orcos("El Abuelo de Gabriel"));
                break;
            case 4:
                Enemigos.Add(new Observador("Yo"));
                break;
            default:
                Console.WriteLine("Veo que te estás acercando");
                break;
        }
    }

    public void MostrarPisos()
    {
        Console.WriteLine($"Estas en el piso {NumeroDePiso } ");
        Console.WriteLine("En este piso los enemigos son:");
        foreach (var enemigo in Enemigos)
        {
            Console.Write($"- {enemigo.Nombre}: ");
            Console.Write("   ");
            Console.ReadKey( );
        }
    }
}
