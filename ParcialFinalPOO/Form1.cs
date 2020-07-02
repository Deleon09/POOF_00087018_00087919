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
            cmbUsuario.DataSource = miProxyS.Peticionlista();
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
                    string query2 = $"SELECT id_departamento FROM usuario WHERE nombre ='{cmbUsuario.Text}'";
                    var dt2 = ConnectionDB.ExecuteQuery(query2);
                    var dr2 = dt2.Rows[0];
                    var departamento = Convert.ToInt32(dr2[0].ToString());
                    
                    u.nombre =  cmbUsuario.Text;
                    frmPrincipal ventana = new frmPrincipal(departamento, u);
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