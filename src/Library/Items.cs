namespace Program
{
    public abstract class Item
    {
        public string nombre { get; set; }
        public int DurabilidadMaxima { get; set; }
        public int DurabilidadActual { get; set; }
        public Item(string nombre,  int DurabilidadMaxima, int DurabilidadActual)
        {
            this.nombre = nombre;
            this.DurabilidadMaxima = DurabilidadMaxima;
            this.DurabilidadActual = DurabilidadActual;
        }
    }
}