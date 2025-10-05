namespace Program;
public abstract class CreadorDePersonajes
{
    public string Nombre { get; set; } // su identidad0
    public int VidaActual { get; set; } // su resiliencia
    public int VidaMaxima {get; set;}
    public int Ataque { get; set; } // su fuerza
    public int Defensa { get; set; } // su resistencItems
    //inventario
    private List<Objeto> Inventario = new List<Objeto>();

    
    
//todos los tipos de estadisticas necesarias para un personajeas
    public CreadorDePersonajes(string nombre, int  vidamaxima, int ataque,int defensa)
    {
        this.Nombre = nombre;
        this.VidaActual = vidamaxima;
        this.VidaMaxima = vidamaxima;
        this.Ataque = ataque; 
        this.Defensa = defensa;
        this.Inventario = new List<Objeto>();
    }

    public void AgregarAlInventario(Objeto objeto)
        {
            
            this.Inventario.Add(objeto);
            Console.WriteLine($"{objeto.TipodeObjeto} se guardó en el inventario.");
        }

    public void QuitarDelInventario(string nombre)
        {
            var objeto = Inventario.Find(o => o.TipodeObjeto == nombre);
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

    public void usarObjeto(Objeto objeto){
        if (objeto.Categoria == CategoriaDeObjetos.Pociones){
            this.VidaActual = this.VidaActual + objeto.Stat;
        }
        else if(objeto.Categoria == CategoriaDeObjetos.Armaduras){
            this.Defensa = this.Defensa + objeto.Stat;
        }
        else if(objeto.Categoria == CategoriaDeObjetos.Armas){
            this.Ataque = this.Ataque + objeto.Stat;  
        }
        
    }

    public void atacar(CreadorDePersonajes objetivo)
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
