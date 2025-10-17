namespace Program
{
    public abstract class Items
    {
        public string nombre { get; set; }
        public int DurabilidadMaxima { get; set; }
        public int DurabilidadActual { get; set; }
        public Items(string nombre,  int DurabilidadMaxima, int DurabilidadActual)
        {
            
        }
    }
}