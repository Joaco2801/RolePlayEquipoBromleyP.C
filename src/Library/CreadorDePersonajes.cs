namespace Program;
public abstract class CharacterCreator
{
    public string Nombre { get; set; } // su identidad0
    public int VidaActual { get; set; } 
    public int VidaMaxima {get; set;} // su resiliencia
    public int Ataque { get; set; } // su fuerza
    public int Defensa { get; set; } // su resistencItems
    
    //inventario
    public List<Item> Inventario = new List<Item>();

    
//todos los tipos de estadisticas necesarias para un personajeas
    public CharacterCreator(string nombre, int  vidamaxima, int ataque,int defensa)
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
            Console.WriteLine($"{objeto.nombre} se guardó en el inventario.");
        }

    public void QuitarDelInventario(string nombre)
        {
            var objeto = Inventario.Find(o => o.nombre == nombre);
            if (objeto != null)
            {
                this.Inventario.Remove(objeto);
                Console.WriteLine($"Tiraste {nombre} del inventario.");
            }
            else
            {
                Console.WriteLine($"No tienes {nombre} en el inventario.");
            }
        }
    
    public void heal(){
        this.VidaActual = this.VidaMaxima;
        Console.WriteLine($"Te curaste a {this.VidaMaxima} hp");
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
            Damaje = 0; // No se puede curar con daño negativo
        }

        this.VidaActual -= Damaje;

        if (this.VidaActual < 0)
        {
            this.VidaActual = 0; // Vida no puede ser negativa
        }

        Console.WriteLine($"{this.Nombre} recibió {Damaje} de daño. Vida restante: {this.VidaActual}/{this.VidaMaxima}");
    }
    public abstract void BreveDescripcion();
}
