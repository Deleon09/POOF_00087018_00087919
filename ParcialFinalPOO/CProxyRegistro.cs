using System;
using System.Collections.Generic;
using System.Data;

namespace ParcialFinalPOO
{
    public class CProxyRegistro
    {
        public interface ISujeto
        {
            void Peticion(int Popcion);
        }
        
        public class ProxySencillo : ISujeto
        {
            private registroDAO register;

            public void Peticion(int pOpcion)
            {
                register = new registroDAO();
                

                if (pOpcion == 1)
                    register.getLista();
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
        }
        
    }
}