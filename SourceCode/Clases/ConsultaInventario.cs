using System;
using System.Collections.Generic;
using System.Data;
using SourceCode.Properties.BD;

namespace SourceCode.Clases
{
    public class ConsultaInventario
    {
        public static List<Inventario> getLista()
        {
            string sql = "select * from product";

            DataTable dt = ConexionBD.ExecuteQuery(sql);

            List<Inventario> lista = new List<Inventario>();
            foreach (DataRow fila in dt.Rows)
            {
                Inventario u = new Inventario();
                u.idProduct = Convert.ToInt32(fila[0].ToString());
                u.idbusiness = Convert.ToInt32(fila[1].ToString());
                u.name = fila[2].ToString();

                lista.Add(u);
            }
            return lista;
        }
        
        public static void crearNuevo(int idbusiness, string name)
        {
            string sql = String.Format(
                "insert into product(idbusiness, name) " +
                "values({0}, '{1}');",
                idbusiness, name);
            
            ConexionBD.ExecuteNonQuery(sql);
        }
        
        public static void eliminar(int idProduct)
        {
            string sql = String.Format(
                "delete from apporder where idproduct ={0}; " +
                "delete from product where idproduct={0};",
                idProduct);
            
            ConexionBD.ExecuteNonQuery(sql);
        }
    }
}