using System;
using System.Collections.Generic;
namespace Program;
public abstract class CreadorDePersonajes
{
    public string Nombre { get; set; } // su identidad0
    public int Vida { get; set; } // su resiliencia
    public int Ataque { get; set; } // su fuerza
    public int Defensa { get; set; } // su resistencia
    //inventario 
    public InventarioPersonajes Inventario { get; private set; } = new InventarioPersonajes();
    
//todos los tipos de estadisticas necesarias para un personaje
    public CreadorDePersonajes(string nombre, int  vida, int ataque,int defensa)
    {
        this.Nombre = nombre;
        this.Vida = vida;
        this.Ataque = ataque;
        this.Defensa = defensa;
    }

    public abstract void BreveDescripcion();
}
