using System;
using System.Collections.Generic;
using System.Data;

namespace ParcialFinalPOO
{
    public class CProxyUsuario
    {
        public interface ISujeto
        {
            List<usuario> Peticionlista();
            void Peticionmetodo(int pOpcion, int id_departamento, string nombre, string apellido, string contrasena,
                string dui, string fechanacimiento, int iduser);
        }
        
        public class ProxySencillo : ISujeto
        {
            private usuarioDAO usuar = new usuarioDAO();
            List<usuario> lista = new List<usuario>();
            
            public List<usuario> Peticionlista(){
                
                lista = usuar.getLista();
                return lista;
            }
            
            public void Peticionmetodo(int pOpcion, int id_departamento, string nombre, string apellido, string contrasena,
                string dui, string fechanacimiento, int iduser)
            {
                if (pOpcion == 1)
                    usuar.crearNuevo(id_departamento, nombre, apellido, contrasena, dui, fechanacimiento);
                if (pOpcion == 2)
                    usuar.eliminar(nombre, iduser);
            }
        }
        
        // Esta es la clase que estamos protegiendo con el proxy
        private class usuarioDAO
        {
            public List<usuario> getLista()
            {
                string sql = "select * from usuario";
            
                DataTable dt = ConnectionDB.ExecuteQuery(sql);
            
                List<usuario> lista = new List<usuario>();
                foreach (DataRow fila in dt.Rows)
                {
                    usuario u = new usuario();
                    u.id_usuario = Convert.ToInt32(fila[0].ToString());
                    u.id_departamento = Convert.ToInt32(fila[1].ToString());
                    u.contrasena = fila[2].ToString();
                    u.nombre = fila[3].ToString();
                    u.apellido = fila[4].ToString();
                    u.dui = fila[5].ToString();
                    u.fechanacimiento = fila[6].ToString();

                    lista.Add(u);
                }
                return lista;
            }
            
            public void crearNuevo(int id_departamento, string nombre, string apellido, string contrasena,
            string dui, string fechanacimiento)
            {
                string sql = String.Format(
                    "insert into usuario(id_departamento, contrasena, nombre, apellido, dui, fechanacimiento) " +
                    "values({0}, '{1}', '{2}', '{3}', '{4}', '{5}');",
                    id_departamento, contrasena, nombre, apellido, dui, fechanacimiento);
            
                ConnectionDB.ExecuteNonQuery(sql);
            }
        
            public void eliminar(string nombre, int iduser)
            {
                string sql1 = String.Format(
                    "delete from registro where id_usuario = {0}; ",
                    iduser);
                
                string sql2 = String.Format(
                    "delete from usuario where nombre = '{0}'; ",
                    nombre);
            
                ConnectionDB.ExecuteNonQuery(sql1);
                ConnectionDB.ExecuteNonQuery(sql2);
            }
        }
    }
}