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
        public string TipodeObjeto { get; set; }
        public string DescripcionDelObjeto { get; set; }
        public CategoriaDeObjetos Categoria { get; set; }

        public Objeto(string tipodeObjeto, string descripcionDelObjeto, CategoriaDeObjetos categoria)
        {
            TipodeObjeto = tipodeObjeto;
            DescripcionDelObjeto = descripcionDelObjeto;
            Categoria = categoria;
        }

        public override string ToString()
        {
            return $"{TipodeObjeto} ({Categoria}): {DescripcionDelObjeto}";
        }
    }
}