using System;
using System.Collections.Generic;
using System.Data;
using SourceCode.Properties.BD;

namespace SourceCode.Clases
{
    public class ConsultaAPPORDER
    {
        public static List<APPORDER> getLista()
        {
            string sql = "select * from apporder";

            DataTable dt = ConexionBD.ExecuteQuery(sql);

            List<APPORDER> lista = new List<APPORDER>();
            foreach (DataRow fila in dt.Rows)
            {
                APPORDER u = new APPORDER();
                u.idorder = Convert.ToInt32(fila[0].ToString());
                u.createdate = fila[1].ToString();
                u.idproduct = Convert.ToInt32(fila[2].ToString());
                u.idaddress = Convert.ToInt32(fila[3].ToString());

                lista.Add(u);
            }
            return lista;
        }
        
        
        public static void crearUsuario(string createdate, int idproduct, int idaddress)
        {
            string sql = String.Format(
                "insert into apporder(createdate, idproduct, idaddress) " +
                "values('{0}', {1}, {2});",
                createdate, idproduct, idaddress);
            
            ConexionBD.ExecuteNonQuery(sql);
        }
        
        public static void eliminar(int idorder)
        {
            string sql = String.Format(
                "delete from apporder where idorder={0};",
                idorder);
            
            ConexionBD.ExecuteNonQuery(sql);
        }
    }
}