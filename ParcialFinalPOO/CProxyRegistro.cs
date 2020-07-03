using System;
using System.Collections.Generic;
using System.Data;

namespace ParcialFinalPOO
{
    public class CProxyRegistro
    {
        public interface ISujeto
        {
            void Peticion(int Popcion, int id_usuario, bool entrada, string fecha_hora, int temperatura);
            List<registro> Peticionlista();
            List<registro> Peticionlistaunica(int nombre);
        }
        
        public class ProxySencillo : ISujeto
        {
            private registroDAO register = new registroDAO();
            List<registro> lista = new List<registro>();

            public List<registro> Peticionlista()
            {
                lista = register.getLista();
                return lista;
            }
            
            public void Peticion(int pOpcion, int id_usuario, bool entrada, string fecha_hora, int temperatura)
            {
                if (pOpcion == 1)
                    register.crearNuevoRegistro(id_usuario, entrada, fecha_hora, temperatura);
            }

            public List<registro> Peticionlistaunica(int nombre)
            {
                lista = register.getListaespecifica(nombre);
                return lista;
            }
            
        }
        
        // Esta es la clase que estamos protegiendo con el proxy
        private class registroDAO
        {
            public List<registro> getLista()
            {
                string sql = "select * from registro";

                DataTable dt = ConnectionDB.ExecuteQuery(sql);

                List<registro> lista = new List<registro>();
                foreach (DataRow fila in dt.Rows)
                {
                    registro u = new registro();
                    u.id_registro = Convert.ToInt32(fila[0].ToString());
                    u.id_usuario = Convert.ToInt32(fila[1].ToString());
                    u.entrada = Convert.ToBoolean(fila[2].ToString());
                    u.fecha_hora = fila[3].ToString();
                    u.temperatura = Convert.ToInt32(fila[4].ToString());

                    lista.Add(u);
                }
                return lista;
            }
            
            public List<registro> getListaespecifica(int name)
            {
                string sql = $"select * from registro where id_usuario = {name}";

                DataTable dt = ConnectionDB.ExecuteQuery(sql);

                List<registro> lista = new List<registro>();
                foreach (DataRow fila in dt.Rows)
                {
                    registro u = new registro();
                    u.id_registro = Convert.ToInt32(fila[0].ToString());
                    u.id_usuario = Convert.ToInt32(fila[1].ToString());
                    u.entrada = Convert.ToBoolean(fila[2].ToString());
                    u.fecha_hora = fila[3].ToString();
                    u.temperatura = Convert.ToInt32(fila[4].ToString());

                    lista.Add(u);
                }
                return lista;
            }
            
            public void crearNuevoRegistro(int id_usuario, bool entrada, string fecha_hora, int temperatura)
            {
                string sql = String.Format(
                    "insert into registro(id_usuario, entrada, fecha_hora, temperatura) " +
                    "values({0}, {1}, '{2}', {3});",
                    id_usuario, entrada, fecha_hora, temperatura);
            
                ConnectionDB.ExecuteNonQuery(sql);
            }
        }
        
    }
}