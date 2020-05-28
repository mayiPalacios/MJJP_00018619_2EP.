using System;
using System.Collections.Generic;
using System.Data;
using SourceCode.Properties.BD;
namespace SourceCode.Clases
{
    public class ConsultaBUSINESS
    {
        public static List<BUSINESS> getLista()
        {
            string sql = "select * from business";

            DataTable dt = ConexionBD.ExecuteQuery(sql);

            List<BUSINESS> lista = new List<BUSINESS>();
            foreach (DataRow fila in dt.Rows)
            {
                BUSINESS u = new BUSINESS();
                u.idBussiness = Convert.ToInt32(fila[0].ToString());
                u.name = fila[1].ToString();
                u.description = fila[2].ToString();

                lista.Add(u);
            }
            return lista;
        }
        
        
        public static void crearNuevo(string name, string description)
        {
            string sql = String.Format(
                "insert into business(name, description) " +
                "values('{0}', '{1}');",
                name, description);
            
            ConexionBD.ExecuteNonQuery(sql);
        }
        
        public static void eliminar(int idbusiness)
        {
            string sql = String.Format(
                "delete from product where idbusiness ={0}; " +
                "delete from business where idbusiness={0};",
                idbusiness);
            
            ConexionBD.ExecuteNonQuery(sql);
        }
    }
}