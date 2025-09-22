public enum TipoHechizo
{
    Ofensivo,
    Curativo
}

public class Hechizo
{
    public string Nombre { get; set; }
    public int Poder { get; set; }
    public TipoHechizo Tipo { get; set; }

    public Hechizo(string nombre, int poder, TipoHechizo tipo)
    {
        Nombre = nombre;
        Poder = poder;
        Tipo = tipo;
    }
}