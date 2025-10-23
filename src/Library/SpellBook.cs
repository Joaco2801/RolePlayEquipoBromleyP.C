namespace Program;

public class SpelBook : Item
{
    public List<Spel>  spells { get; set; }
    public SpelBook(string nombre)
        : base(nombre, 100000, 100000)
    {
        this.spells = new List<Spel>();;
    }

    public void AgregarHechizos(Spel NewSpel)
    {
        this.spells.Add(NewSpel);
    }
    
    new SpelBook Grimoar =  new SpelBook("Grimoar");
}
