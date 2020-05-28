namespace SourceCode
{
    public class APPORDER
    {
        public int idorder { get; set; }
        public string createdate { get; set; }
        public int idproduct { get; set; }
        public int idaddress { get; set; }


        public APPORDER()
        {
        }

        public APPORDER(int idorder, string createdate, int idproduct, int idaddress)
        {
            this.idorder = idorder;
            this.createdate = createdate;
            this.idproduct = idproduct;
            this.idaddress = idaddress;
        }
    }
}