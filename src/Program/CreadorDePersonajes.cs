
using System;
using System.Collections.Generic;
namespace Program;
public abstract class CreadorDePersonajes
{
    public string Nombre { get; set; } // su identidad0
    public int Vida { get; set; } // su resiliencia
    public int vidaMaxima {get; set;}
    public int Ataque { get; set; } // su fuerza
    public int Defensa { get; set; } // su resistencItems
    //inventario
    private List<Items> objetos = new List<Items>();

    
    
//todos los tipos de estadisticas necesarias para un personajeas
    public CreadorDePersonajes(string nombre, int  vidaMaxima, int ataque,int defensa)
    {
        this.Nombre = nombre;
        this.Vida = vidaMaxima;
        this.vidaMaxima = vidaMaxima;
        this.Ataque = ataque; 
        this.Defensa = defensa;
        thisObjetos = {};
    }

    public abstract void BreveDescripcion();
}
