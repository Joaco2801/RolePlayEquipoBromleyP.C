public abstract class PersonajeBase
{
    public string NombrePersonaje { get; set; }
    public int PuntosDeVida { get; private set; } = 100;
    public List<ObjetoEquipable> Inventario { get; } = new();

    public PersonajeBase(string nombre)
    {
        NombrePersonaje = nombre;
    }

    public virtual void AplicarDanio(int cantidad)
    {
        PuntosDeVida = Math.Max(PuntosDeVida - cantidad, 0);
    }

    public virtual void AplicarCuracion(int cantidad)
    {
        PuntosDeVida = Math.Min(PuntosDeVida + cantidad, 100);
    }

    public abstract int ObtenerPoderDeAtaque();
    public abstract int ObtenerPoderDeDefensa();
}