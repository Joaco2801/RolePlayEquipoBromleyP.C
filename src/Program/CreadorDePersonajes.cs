namespace Program;
using System;
public abstract class Personajes
{
    public string Nombre { get; set; } // su identidad0
    public int vida { get; set; } // su resiliencia
    public int ataque { get; set; } // su fuerza
    public int defensa { get; set; } // su resistencia
    public int inteligencia { get; set; } // su proeza en la magia 
    public int defensamagica { get; set; } // su fortitud mental ante la magia
    public int velocidad { get; set; } // su agilidad
    
//todos los tipos de estadisticas necesarias para un personaje
    public Personajes(string nombre, int  vida, int ataque,int defensa, int inteligencia, int defensamagica, int velocidad)
    {
        nombre = nombre;
        vida = vida;
        ataque = ataque;
        defensa = defensa;
        inteligencia = inteligencia;
        defensamagica = defensamagica;
        velocidad = velocidad;
    }

    public abstract void TipoDeAtaque();
}