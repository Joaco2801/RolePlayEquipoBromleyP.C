using System;
namespace Program
{
    public class Magos : CharacterCreator // parametros del mago
    {
        public Magos(string nombre)
            : base(nombre, 80, 10, 5) { }
        public override void BreveDescripcion()
        {
            Console.WriteLine($"{Nombre} lanza poderosos hechizos desde un misterioso libro con distintas runas...  Está un poco flaco.");
        }
    }

    public class Elfos : CharacterCreator //parametros del elfo
    {
        public Elfos(string nombre) 
            : base(nombre, 100, 8, 12) { }
        public override void BreveDescripcion()
        {
            Console.WriteLine($"{Nombre}, normalmente con arcos, normalmente con cuchillos, ayuda al equipo de diferentes formas... No es muy amistoso.");
        }
    }

    public class Enanos : CharacterCreator // parametros del Enano
    {
        public Enanos(string nombre) 
            : base(nombre, 150, 15, 13) { }
        public override void BreveDescripcion()
        {
            Console.WriteLine($"{Nombre} tiene un hacha y ¿¡Una olla!? Gran cocinero y mejor persona... Es la voz de la experiencia.");
        }
    }
}
