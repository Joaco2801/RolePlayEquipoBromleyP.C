public interface IPersonaje
{
    string Nombre { get; }
    int AtaqueTotal();
    int DefensaTotal();
    void Atacar(IPersonaje objetivo);
    void Curar(IPersonaje aliado);
}