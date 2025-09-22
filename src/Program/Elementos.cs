namespace Program
{
    public enum CategoriaDeObjetos
    {
        Pociones,
        Armas,
        Armaduras
    }

    public class Objeto
    {
        public string DescripcionDelObjeto { get; set; }
        public CategoriaDeObjetos Categoria { get; set; }
        public int stat {get; set; }

        public Objeto(string descripcionDelObjeto, CategoriaDeObjetos categoria, int stat)
        {
            this.DescripcionDelObjeto = descripcionDelObjeto;
            this.Categoria = categoria;
            this.stat = stat;
        }

        public override string ToString()
        {
            return $"{TipodeObjeto} ({Categoria}): {DescripcionDelObjeto}";
        }
    }

}
