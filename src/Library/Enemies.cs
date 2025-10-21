using Program;
 //enemigos genericos con descripciones inspiradas en el juego de Roll Dungeos and Dragons
public class Goblin : CharacterCreator
{
    public Goblin(string nombre)
        : base(nombre,15,15,5) 
    {
    }

    public override void BreveDescripcion()
    {
        Console.WriteLine("Los Goblin son pequeñas criaturas temerosas que solo representan una amenaza en manadas de docenas ante aventureros experimentados... ¿¡quien les dió cuchillos!?.");
    }
}

public class AltoGoblin : CharacterCreator
{
    public AltoGoblin(string nombre)
        : base(nombre, 25, 8, 6)
    {
    }

    public override void BreveDescripcion()
    {
        Console.WriteLine("Los Altos Goblin son los tipicos padres que son direcctamente responsables de la incompetencia de la siguiente generación y aun así los castigan a ellos... que nostalgia");
    }
}

public class Orcos : CharacterCreator
{
    public Orcos(string nombre)
        : base(nombre, 65, 18, 2)
    {
    }

    public override void BreveDescripcion()
    {
        Console.WriteLine("La definición de peso pesado, tonto pero fuerte, muy resiliente, pero muy poco resistente, cuidado con su garrote... jeje");
    }
}

public class Observador : CharacterCreator
{
    public Observador(string nombre)
        : base(nombre, 200, 15, 12)
    {

    }
    public override void BreveDescripcion()
    {
        Console.WriteLine("¿Creiste que te iba a dar una descripción de mi mismo?... Te estoy viendo.");
    }
}
