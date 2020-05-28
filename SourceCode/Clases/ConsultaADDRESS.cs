using System;
using System.Collections.Generic;
using System.Data;
using SourceCode.Properties.BD;

namespace SourceCode.Clases
{
    public class ConsultaADDRESS
    {
        public static List<ADDRESS> getLista()
        {
            string sql = "select * from ADDRESS";

            DataTable dt = ConexionBD.ExecuteQuery(sql);

            List<ADDRESS> lista = new List<ADDRESS>();
            foreach (DataRow fila in dt.Rows)
            {
                ADDRESS u = new ADDRESS();
                u.idaddress = Convert.ToInt32(fila[0].ToString());
                u.iduser = Convert.ToInt32(fila[1].ToString());
                u.address = fila[2].ToString();

                lista.Add(u);
            }
            return lista;
        }
        public static List<ADDRESS> GetListaDAd(int iduser)
        {
            string sql = String.Format(
                "select * from address where iduser= {0};",
                iduser);

            DataTable dt = ConexionBD.ExecuteQuery(sql);

            List<ADDRESS> lista = new List<ADDRESS>();                                  
            foreach (DataRow fila in dt.Rows)
            {
                ADDRESS u = new ADDRESS();
                u.idaddress = Convert.ToInt32(fila[0].ToString());
                u.iduser = Convert.ToInt32(fila[1].ToString());
                u.address = fila[2].ToString();

                lista.Add(u);
            }
            return lista;
        }
        
        public static void crearNuevoADDRESS(int iduser, string Aaddress)
        {
            string sql = String.Format(
                "insert into address(iduser, address) " +
                "values({0}, '{1}');",
                iduser, Aaddress);
            
            ConexionBD.ExecuteNonQuery(sql);
        }
        
        public static void eliminar(int idaddress)
        {
            string sql = String.Format(
                "delete from apporder where idaddress ={0}; " +
                "delete from address where idaddress={0};",
                idaddress);
            
            ConexionBD.ExecuteNonQuery(sql);
        }
        
        public static void actualizarinfo(string newaddress, int idaddress)
        {
            string sql = String.Format(
                "update address set address='{0}' where idaddress= {1};",
                newaddress, idaddress);
            
            ConexionBD.ExecuteNonQuery(sql);
        }
        
    }
}