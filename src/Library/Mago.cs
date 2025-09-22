public class Mago : IPersonaje
{
    public override int AtaqueTotal() => Items.Sum(i => i.Ataque);
    public override int DefensaTotal() => Items.Sum(i => i.Defensa);

    public override void Atacar(IPersonaje objetivo)
    {
        // lógica de ataque mágico
    }

    public override void Curar(IPersonaje aliado)
    {
        // lógica de curación
    }
}