namespace SourceCode
{
    public class ADDRESS
    {
        public int idaddress { get; set; }
        public int iduser { get; set; }
        public string address { get; set; }

        public ADDRESS()
        {
        }

        public ADDRESS(int idaddress, int iduser, string aaddress)
        {
            this.idaddress = idaddress;
            this.iduser = iduser;
            address = aaddress;
        }
    }
}