namespace ParcialFinalPOO
{
    public class registro
    {
        public int id_registro { get; set; }
        public int id_usuario { get; set; }
        public bool entrada { get; set; }
        public string fecha_hora { get; set; }
        public int temperatura { get; set; }

        public registro()
        {
            id_registro = 0;
            id_usuario = 0;
            entrada = false;
            fecha_hora = "";
            temperatura = 0;
        }
    }
}