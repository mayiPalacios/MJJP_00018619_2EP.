using System;
using System.Collections.Generic;
using System.Data;
using SourceCode.Properties.BD;

namespace SourceCode.Clases
{
    public class ConsultaUsuario
    {
        private static Usuario us = new Usuario();
        public static List<Usuario> getLista()
        {
            string sql = "select * from  appuser";

            DataTable dt = ConexionBD.ExecuteQuery(sql);

            List<Usuario> lista = new List<Usuario>();
            foreach (DataRow fila in dt.Rows)
            {
                Usuario u = new Usuario();
                 u.idUser = Convert.ToInt32(fila[0].ToString());
                                u.fullname = fila[1].ToString();
                                u.username = fila[2].ToString();
                                u.password = fila[3].ToString();
                                u.userType = Convert.ToBoolean(fila[4].ToString());

                lista.Add(u);
            }
            return lista;
        }
       /* public static void actualizarContra(string usuario, string nuevaContra)
        {
           /* var sq = String.Format("UPDATE APPUSER SET password = '{0}' WHERE idUser = '{1}';", nuevaContra, usuario);*/
           /*var sql = $"UPDATE APPUSER SET password = '{0}' WHERE idUser = '{1}';";
            ConexionBD.ExecuteNonQuery(sql);
        }*/
        public static void actualizarContra(string usuario, string nuevaContra)
        {
            string sql = String.Format(
                "update appuser set password='{0}' where username='{1}';",
                nuevaContra, usuario);
            
            ConexionBD.ExecuteNonQuery(sql);
        }
        
        public static void crearNuevo(string fullname, string username, bool usertype)
        {
            string sql = String.Format(
                "insert into appuser(fullname, username, password, usertype) " +
                "values('{0}', '{1}', '{1}', {2});",
                fullname, username, usertype ? "true" : "false");
            
            ConexionBD.ExecuteNonQuery(sql);
        }
        
        public static void eliminar(int iduser)
        {
            string sql = String.Format(
                "delete from address where iduser ={0}; " +
                "delete from appuser where iduser={0};",
                iduser);
            
            ConexionBD.ExecuteNonQuery(sql);
        }

       
        
        
        
        
    }
}