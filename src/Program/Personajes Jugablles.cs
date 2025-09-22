using System;
namespace Program
{
    public class Magos : CreadorDePersonajes // parametros del mago
    {
        public Magos(string nombre) 
            : base(nombre, 80, 10, 8, 25, 15, 10) { }

        public override void BreveDescripcion()
        {
            Console.WriteLine($"{Nombre} lanza poderosos hechizos desde un misterioso libro con distintas runas...  Está un poco flaco.");
        }
    }

    public class Elfos : CreadorDePersonajes //parametros del elfo
    {
        public Elfos(string nombre) 
            : base(nombre, 100, 20, 12, 12, 10, 18) { }

        public override void BreveDescripcion()
        {
            Console.WriteLine($"{Nombre}, normalmente con arcos, normalmente con cuchillos, ayuda al equipo de diferentes formas... No es muy amistoso.");
        }
    }

    public class Enanos : CreadorDePersonajes // parametros del Enano
    {
        public Enanos(string nombre) 
            : base(nombre, 150, 18, 15, 10, 8, 16) { }

        public override void BreveDescripcion()
        {
            Console.WriteLine($"{Nombre} tiene un hacha y ¿¡Una olla!? Gran cocinero y mejor persona... Es la voz de la experiencia.");
        }
    }
}