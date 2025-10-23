namespace Program;

public class Curas
{
    public int PocionDeVida { get; set; }

    public Curas(int cantidad)
    {
        this.PocionDeVida = cantidad;
    }

    public void Curar(CharacterCreator personaje)
    {
        if (personaje == null) return;

        int vidaAntes = personaje.VidaActual;

        personaje.VidaActual += this.PocionDeVida;

        if (personaje.VidaActual > personaje.VidaMaxima)
        {
            personaje.VidaActual = personaje.VidaMaxima;
        }

        int vidaCurada = personaje.VidaActual - vidaAntes;

        Console.WriteLine($"{personaje.Nombre} se curó {vidaCurada} puntos de vida. Vida actual: {personaje.VidaActual}/{personaje.VidaMaxima}");
    }
}