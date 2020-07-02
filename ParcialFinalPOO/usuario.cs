namespace ParcialFinalPOO
{
    public class usuario
    {
        public int id_usuario { get; set; }
        public int id_departamento { get; set; }
        public string contrasena { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dui { get; set; }
        public string fechanacimiento { get; set; }

        public usuario()
        {
            id_usuario = 0;
            id_departamento = 0;
            contrasena = "";
            nombre = "";
            apellido = "";
            dui = "";
            fechanacimiento = "";
        }
    }
}