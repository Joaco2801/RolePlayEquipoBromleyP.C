public enum TipoDeHechizo
{
    Ofensivo,
    Curativo
}

public class HechizoMagico
{
    public string NombreHechizo { get; set; }
    public int Potencia { get; set; }
    public TipoDeHechizo Tipo { get; set; }

    public HechizoMagico(string nombre, int potencia, TipoDeHechizo tipo)
    {
        NombreHechizo = nombre;
        Potencia = potencia;
        Tipo = tipo;
    }
}