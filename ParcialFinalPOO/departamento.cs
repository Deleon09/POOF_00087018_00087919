namespace ParcialFinalPOO
{
    public class departamento
    {
        public int id_departamento { get; set; }
        public string nombre { get; set; }
        public string ubicacion { get; set; }

        public departamento()
        {
            id_departamento = 0;
            nombre = "";
            ubicacion = "";
        }
    }
}