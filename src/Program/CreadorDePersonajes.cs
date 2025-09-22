
using System;
namespace Program;
public abstract class CreadorDePersonajes
{
    public string Nombre { get; set; } // su identidad0
    public int Vida { get; set; } // su resiliencia
    public int vidaMaxima {get; set;}
    public int Ataque { get; set; } // su fuerza
    public int Defensa { get; set; } // su resistencItems
    //inventario
    private List<Objetos> Inventario = new List<Objetos>();

    
    
//todos los tipos de estadisticas necesarias para un personajeas
    public CreadorDePersonajes(string nombre, int  vidaMaxima, int ataque,int defensa)
    {
        this.Nombre = nombre;
        this.Vida = vidaMaxima;
        this.vidaMaxima = vidaMaxima;
        this.Ataque = ataque; 
        this.Defensa = defensa;
        this.Inventario = {};
    }

    public void AgregarAlInventario(Objetos objeto)
        {
            
            this.Inventario.add(objeto);
            Console.WriteLine($"{objeto.TipodeObjeto} se guardó en el inventario.");
        }

    public void QuitarDelInventario(string nombre)
        {
            var objeto = objetos.Find(o => o.TipodeObjeto == nombre);
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
        this.vida = this.vidaMaxima;
        Console.WriteLine($"Te curaste a {this.vidaMaxima} hp");
    }

    public void usarObjeto(Objeto objeto){
        if (objeto.Categoria = Pociones){
            this.vida = this.vida + objeto.stat;
        }
        else if(objeto.Categoria = Armaduras){
            this.Defensa = this.Defensa + objeto.stat;
        }
        else if(objeto.Categoria = Armas){
            this.Ataque = this.Ataque + objeto.stat;  
        }
        
    }

    public void atacar(CreadorDePersonajes personaje){

    }



    public abstract void BreveDescripcion();
}
