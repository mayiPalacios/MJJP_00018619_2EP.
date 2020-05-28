namespace SourceCode
{
    public class Inventario
    {
        public int idProduct { get; set; }
        public int idbusiness { get; set; }
        public string name { get; set; }

        public Inventario()
        {
            idProduct = 0;
            idbusiness = 0;
            name = "";
        }
    }
}