using System;
using System.Collections.Generic;
using System.Data;

namespace ParcialFinalPOO
{
    public class CProxyDepartamento
    {
        
        public interface ISujeto
        {
            List<departamento> Peticion(int Popcion);
        }
        
        public class ProxySencillo : ISujeto
        {
            private departamentoDAO dep = new departamentoDAO();
            List<departamento> lista = new List<departamento>();

            public List<departamento> Peticion(int pOpcion)
            {
                
                if (pOpcion == 1)
                    lista = dep.getLista();
                    return lista;
            }
        }
        
        // Esta es la clase que estamos protegiendo con el proxy
        private class departamentoDAO
        {
            public List<departamento> getLista()
                    {
                        string sql = "select * from departamento";
            
                        DataTable dt = ConnectionDB.ExecuteQuery(sql);
            
                        List<departamento> lista = new List<departamento>();
                        foreach (DataRow fila in dt.Rows)
                        {
                            departamento u = new departamento();
                            u.id_departamento = Convert.ToInt32(fila[0].ToString());
                            u.nombre = fila[1].ToString();
                            u.ubicacion = fila[2].ToString();

                            lista.Add(u);
                        }
                        return lista;
                    }
        }
    }
}