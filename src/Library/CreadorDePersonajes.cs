namespace Program;
public abstract class CreadorDePersonajes
{
    public string Nombre { get; set; } // su identidad0
    public int VidaActual { get; set; } // su resiliencia
    public int VidaMaxima {get; set;}
    public int Ataque { get; set; } // su fuerza
    public int Defensa { get; set; } // su resistencItems
    public Item Armadura {get; set; }
    public Item Arma {get; set; }



    
    //inventario
    public List<Items> Inventario = new List<Items>();
    public int capacidadInventario = 10; 

    
//todos los tipos de estadisticas necesarias para un personajeas
    public CreadorDePersonajes(string nombre, int  vidamaxima, int ataque,int defensa, Item armadura, Item arma)
    {
        this.Nombre = nombre;
        this.VidaActual = vidamaxima;
        this.VidaMaxima = vidamaxima;
        this.Ataque = ataque; 
        this.Defensa = defensa;
        this.Inventario = new List<Item>();
        this.Armadura = armadura;
        this.Arma = arma; 
    }

    public void AgregarAlInventario(Item objeto)
    {
        if (this.Inventario.Count == this.capacidadInventario)
        {
            Console.WriteLine("El inventario esta lleno!");
        } 
        else 
        {
            this.Inventario.Add(objeto);
            Console.WriteLine($"{objeto.nombre} se guardó en el inventario.");

        }
    }

    public void QuitarDelInventario(string nombre)
    {
        foreach (var objeto in Inventario){
            if (objeto.nombre == nombre){
                Inventario.Remove(objeto);
                Console.WriteLine($"Tiraste {nombre} del nombre");
                return;
            }
        }   
        Console.WriteLine($"No tienes {nombre} en tu inventario");
    }
    
    public void heal(Item objeto){
        if (objeto is Potion pocion){
            
            if (this.VidaActual + objeto.AgregadoVida < this.VidaMaxima){
           
                this.VidaActual += pocion.AgregadoVida;
                Console.WriteLine($"Tu vida actual es {this.VidaActual}");
        
            }
            else
            {
                this.VidaActual = this.VidaMaxima;
                Console.WriteLine($"Te curaste a {this.VidaMaxima} hp");
            }
        }
        else{
            Console.WriteLine("Este item no te puede curar!");
        }

    }

    public void EquiparObjeto(Item objeto){
        if (objeto is Potion pocion){
            Console.WriteLine("No podes equiparte una poción");
        }
        else if(objeto is Armor armadura){
            this.Armadura = armadura;
            this.Defensa += armadura.AgregadoArmadura;
        }
        else if(objeto is Weapon arma) {
            this.Arma = arma;
            this.Ataque += arma.AgregadoAtaque;  
        }
        else if (objeto is Spellbook libro){
            this.Arma = libro;
            this.Ataque += libro.AgregadoAtaque;
        }
        else{
            Console.WriteLine("No puedes equiparte esto!");
        }
        
    }

    public void atacar(CreadorDePersonajes objetivo)
    {
        Console.WriteLine($"{this.Nombre} ataca a {objetivo.Nombre} con {this.Arma} y le hizo {this.Ataque} de daño");
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
