using Program;
 //enemigos genericos con descripciones inspiradas en el juego de Roll Dungeos and Dragons
public class EnemigoComún : EnemyCreator
{
    public EnemigoComún(string nombre)
        : base(nombre,15,15,5) 
    {
    }

    public override void BreveDescripcion()
    {
    }

}
