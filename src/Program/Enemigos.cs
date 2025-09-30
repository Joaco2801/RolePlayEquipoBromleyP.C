using Program;
 //enemigos genericos con descripciones inspiradas en el juego de Roll Dungeos and Dragons
public class Goblin : CreadorDePersonajes
{
    public Goblin(string nombre)
        : base(nombre, 15, 4, 3, 1, 0, 15)
    {
    }

    public override void BreveDescripcion()
    {
        Console.WriteLine("Los Goblin son pequeñas criaturas temerosas que solo representan una amenaza en manadas de docenas ante aventureros experimentados... ¿¡quien les dió cuchillos!?.");
    }
}

public class AltoGoblin : CreadorDePersonajes
{
    public AltoGoblin(string nombre)
        : base(nombre, 25, 8, 6, 4, 3, 13)
    {
    }

    public override void BreveDescripcion()
    {
        Console.WriteLine("Los Altos Goblin son los tipicos padres que son direcctamente responsables de la incompetencia de la siguiente generación y aun así los castigan a ellos... que nostalgia");
    }
}

public class Orcos : CreadorDePersonajes
{
    public Orcos(string nombre)
        : base(nombre, 65, 18, 2, 0, 0, 17)
    {
    }

    public override void BreveDescripcion()
    {
        Console.WriteLine("La definición de peso pesado, tonto pero fuerte, muy resiliente, pero muy poco resistente, cuidado con su garrote... jeje");
    }
}

public class Observador : CreadorDePersonajes
{
    public Observador(string nombre)
        : base(nombre, 200, 15, 12, 30, 12, 12)
    {
        
    }

    public override void BreveDescripcion()
    {
        Console.WriteLine("¿Creiste que te iba a dar una descripción de mi mismo?... Te estoy viendo.");
