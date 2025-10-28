namespace Program;
public abstract class EnemyCreator
{
    public string Nombre { get; set; }
    public int VidaActual { get; set; } 
    public int VidaMaxima {get; set;} 
    public int Ataque { get; set; } 
    public int Defensa { get; set; } 
    

    public List<Item> Inventario = new List<Item>();
    
    public EnemyCreator(string nombre, int  vidamaxima, int ataque,int defensa)
    {
        this.Nombre = nombre;
        this.VidaActual = vidamaxima;
        this.VidaMaxima = vidamaxima;
        this.Ataque = ataque; 
        this.Defensa = defensa;
        this.Inventario = new List<Item>();
    }
    public void AgregarAlInventario(Item objeto)
        {
            this.Inventario.Add(objeto);
        }
    public void QuitarDelInventario(string nombre)
        {
            var objeto = Inventario.Find(o => o.nombre == nombre);
            if (objeto != null)
            {
                this.Inventario.Remove(objeto);
            }
            else
            {
                Console.WriteLine($"No tienes {nombre} en el inventario.");
            }
        }
    
    public void heal()
    {
        this.VidaActual = this.VidaMaxima;
        Console.WriteLine($"{this.Nombre} se curó a {this.VidaMaxima} hp");
    }
    public void atacar(CharacterCreator objetivo)
    {
        Console.WriteLine($"{this.Nombre} ataca a {objetivo.Nombre} con {this.Ataque} de ataque.");
        objetivo.Damages(this.Ataque);
    }
    public void Damages(int Hurts)
    {
        int Damaje = Hurts - this.Defensa;

        if (Damaje < 0)
        {
            Damaje = 0; 
        }

        this.VidaActual -= Damaje;

        if (this.VidaActual < 0)
        {
            this.VidaActual = 0;
        }

        Console.WriteLine($"{this.Nombre} recibió {Damaje} de daño. Vida restante: {this.VidaActual}/{this.VidaMaxima}");
    }
}
