namespace Program;

public class Armor : Item
{
    public Armor(string nombre, int AgregadoArmadura)
        : base(nombre, 64, 64)
    {
        AgregadoArmadura = AgregadoArmadura;
    } 
    public int AgregadoArmadura { get; set; }

    public Armor Casco = new Armor("Casco", 4);
}