namespace Program;

public class Weapons : Item
{
    public Weapons(string nombre, int AgregadoAtaque)
        : base(nombre, 64, 64)
    {
        AgregadoAtaque = AgregadoAtaque;
    }
    public int AgregadoAtaque { get; set; }
}