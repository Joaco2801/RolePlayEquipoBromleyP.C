namespace Program;

public class Curas
{
    public int PocionDeVida { get; set; }
    public void curación(int PocionDeVida)
    {
        PocionDeVida = PocionDeVida;
    }

    public void curar(CreadorDePersonajes personaje)
    {
        if (personaje == null) return;
        
        personaje.VidaActual += PocionDeVida;

        if (personaje.VidaActual > personaje.VidaMaxima) return;
        {
            personaje.VidaActual = personaje.VidaMaxima;
        }
        Console.WriteLine($"{personaje.Nombre} se curó {PocionDeVida} puntos de vida, está al maximo");
    }
}