public class PersonajeMago : PersonajeBase
{
    public List<HechizoMagico> ListaDeHechizos { get; } = new();

    public PersonajeMago(string nombre) : base(nombre) { }

    public override int ObtenerPoderDeAtaque()
    {
        int ataquePorObjetos = Inventario.Sum(obj => obj.PoderDeAtaque);
        int ataquePorHechizos = ListaDeHechizos.Sum(h => h.Potencia);
        return ataquePorObjetos + ataquePorHechizos;
    }

    public override int ObtenerPoderDeDefensa()
    {
        return Inventario.Sum(obj => obj.PoderDeDefensa);
    }

    public void UsarHechizo(PersonajeBase objetivo, HechizoMagico hechizo)
    {
        if (hechizo.Tipo == TipoDeHechizo.Ofensivo)
            objetivo.AplicarDanio(hechizo.Potencia);
        else if (hechizo.Tipo == TipoDeHechizo.Curativo)
            objetivo.AplicarCuracion(hechizo.Potencia);
    }
}