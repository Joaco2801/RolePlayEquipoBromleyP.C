namespace Program;

public class Potions : Item
{
    public Potions(string nombre, int AgregadoVida)
        : base(nombre, 1, 1)
    {
        this.AgregadoVida = AgregadoVida;
    }
    public int AgregadoVida { get; set; }

    public Potions PocionVida1 = new Potions("pocion Pequeña de vida", 25);
    public Potions PocionVida2 = new Potions("pocion Media de vida", 50);
    public Potions PocionVida3 = new Potions("pocion Grande de vida", 100);
}