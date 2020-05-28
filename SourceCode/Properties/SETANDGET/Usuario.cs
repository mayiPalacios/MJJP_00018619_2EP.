namespace SourceCode
{
    public class Usuario
    
    {
        public int idUser { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool userType { get; set; }

        public Usuario()
        {
            this.idUser = 0;
            this.fullname = " ";
            this.username = " ";
            this.password = " ";
            this.userType = false;
        }

        
    }
}