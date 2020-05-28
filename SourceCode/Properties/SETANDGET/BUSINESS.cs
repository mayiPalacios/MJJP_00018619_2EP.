namespace SourceCode
{
    public class BUSINESS
    {
        public int idBussiness { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public BUSINESS()
        {
        }

        public BUSINESS(int idBussiness, string name, string description)
        {
            this.idBussiness = idBussiness;
            this.name = name;
            this.description = description;
        }
    }
}