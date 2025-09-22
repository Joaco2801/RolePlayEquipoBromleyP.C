public class ObjetoEquipable
{
    public string NombreObjeto { get; set; }
    public int PoderDeAtaque { get; set; }
    public int PoderDeDefensa { get; set; }

    public ObjetoEquipable(string nombre, int ataque, int defensa)
    {
        NombreObjeto = nombre;
        PoderDeAtaque = ataque;
        PoderDeDefensa = defensa;
    }
}