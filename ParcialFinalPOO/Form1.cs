using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialFinalPOO
{
    public partial class Form1 : Form
    {
        usuario u = new usuario();
        public Form1()
        {
            InitializeComponent();
        }

        private void frmInicioDeSesion_Load(object sender, EventArgs e)
        {
            CProxyUsuario.ISujeto miProxyS = new CProxyUsuario.ProxySencillo();
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "id_usuario";
            cmbUsuario.DisplayMember = "nombre";
            cmbUsuario.DataSource = miProxyS.Peticion(1,1,
                "Beto","Leon","beto","895623","28/02/2000");
            u = (usuario)cmbUsuario.SelectedItem;

            /*string query = "select nombre from usuario";
            var users = ConnectionDB.ExecuteQuery(query);
            var usersCombo = new List<string>();

            foreach (DataRow dr in users.Rows)
            {
                usersCombo.Add(dr[0].ToString());
            }

            cmbUsuario.DataSource = usersCombo;*/
            // CProxyUsuario.ISujeto miProxyS = new CProxyUsuario.ProxySencillo();
            //miProxyS.Peticion();
        }

        private void btnIniciaSesion_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"SELECT contrasena FROM usuario WHERE nombre ='{cmbUsuario.Text}'";
                var dt = ConnectionDB.ExecuteQuery(query);
                var dr = dt.Rows[0];
                var contrasena = Convert.ToString(dr[0].ToString());

                if (txtContrasena.Text.Equals(contrasena))
                {
                    u.nombre =  cmbUsuario.Text;
                    frmPrincipal ventana = new frmPrincipal(u.id_departamento);
                    ventana.Show();
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }   
        }
    }
}