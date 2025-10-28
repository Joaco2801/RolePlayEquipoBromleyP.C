namespace Program;

public class PeleaMoment
{
    private List<CharacterCreator> esclavos;
    private List<EnemyCreator> enemigos;

    public PeleaMoment(List<CharacterCreator> heroes, List<EnemyCreator> enemigos)
    {
        this.esclavos = heroes;
        this.enemigos = enemigos;
    }

    public void Mostrar()
    {
        Console.WriteLine("Esclavos \t\t\t Enemigos"); // \t para hacer un espacio

        for (int i = 0; i < esclavos.Count; i++)
        {
            string heroeHealth = esclavos[i].EstaVivo
                ? $"{esclavos[i].Nombre} ({esclavos[i].VidaActual} HP)"
                : $"{esclavos[i].Nombre} [X]";

            string enemieHealth= enemigos[i].EstaVivo
                ? $"{enemigos[i].Nombre} ({enemigos[i].VidaActual} HP)"
                : $"{enemigos[i].Nombre} [X]";

            Console.WriteLine($"{heroeHealth,-25} VS {enemieHealth}");
        }
    }
}