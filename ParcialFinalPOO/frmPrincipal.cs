using System;
using System.Windows.Forms;

namespace ParcialFinalPOO
{
    public partial class frmPrincipal : Form
    {
        private int depa;
        private usuario user;
        private delegate void MyDelegate();
        private static MyDelegate md;
        
        public frmPrincipal(int dep, usuario use)
        {
            InitializeComponent();
            depa = dep;
            user = use;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido/a");
            try
            {
                string query = $"SELECT nombre FROM departamento WHERE id_departamento ={depa}";
                var dt = ConnectionDB.ExecuteQuery(query);
                var dr = dt.Rows[0];
                var tipodeusuario = Convert.ToString(dr[0].ToString());

                if (tipodeusuario.Equals("Administrativo"))
                {
                    tabContenedor.TabPages[0].Parent = null;
                    tabContenedor.TabPages[0].Parent = null;
                }
                else if(tipodeusuario.Equals("Vigilancia"))
                {
                    tabContenedor.TabPages[0].Parent = null;
                    tabContenedor.TabPages[1].Parent = null;
                    tabContenedor.TabPages[2].Parent = null;
                }
                else
                {
                    tabContenedor.TabPages[1].Parent = null;
                    tabContenedor.TabPages[1].Parent = null;
                    tabContenedor.TabPages[1].Parent = null;
                    tabContenedor.TabPages[1].Parent = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            md = ActualizaCMBusuario;
            md += ActualizaCMBdepartamento;
            md += ActualizarcmbEliminar;
            md.Invoke();
        }
        
        public void ActualizaCMBusuario()
        {
            CProxyUsuario.ISujeto miProxyS = new CProxyUsuario.ProxySencillo();
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "id_usuario";
            cmbUsuario.DisplayMember = "nombre";
            cmbUsuario.DataSource = miProxyS.Peticionlista();
        }

        public void ActualizarcmbEliminar()
        {
            CProxyUsuario.ISujeto miProxyS = new CProxyUsuario.ProxySencillo();
            cmbEliminar.DataSource = null;
            cmbEliminar.ValueMember = "id_usuario";
            cmbEliminar.DisplayMember = "nombre";
            cmbEliminar.DataSource = miProxyS.Peticionlista();
        }
        
        public void ActualizaCMBdepartamento()
        {
            CProxyDepartamento.ISujeto miProxyS = new CProxyDepartamento.ProxySencillo();
            cmbDepartamento.DataSource = null;
            cmbDepartamento.ValueMember = "id_departamento";
            cmbDepartamento.DisplayMember = "nombre";
            cmbDepartamento.DataSource = miProxyS.Peticion(1);
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                CProxyRegistro.ISujeto miProxyS = new CProxyRegistro.ProxySencillo();
                dgvEmpleado.DataSource = null;
                dgvEmpleado.DataSource = miProxyS.Peticionlistaunica(user.id_usuario);
            }
            catch (Exception)
            {
                MessageBox.Show("Error no existe ningun valor");
            }
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            if (txtTemperatura.Text.Equals("") ||
                txtFechaHora.Text.Equals("") ||
                radEntrada.Checked.Equals(false) &&
                radSalida.Checked.Equals(false))
            {
                MessageBox.Show("Error hay campos vacios");
            }
            else
            {
                try
                {
                    int temperatura = Convert.ToInt32(txtTemperatura.Text);
                    
                    CProxyRegistro.ISujeto miProxyS = new CProxyRegistro.ProxySencillo();
                    miProxyS.Peticion(1, (int)cmbUsuario.SelectedValue, radEntrada.Checked, txtFechaHora.Text,
                    temperatura);

                    MessageBox.Show("Usuario registrado exitosamente.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals("") ||
                textBox3.Text.Equals("") ||
                textBox4.Text.Equals("") ||
                textBox5.Text.Equals(""))
            {
                MessageBox.Show("Error hay campos vacios");
            }
            else
            {
                try
                {
                    CProxyUsuario.ISujeto miProxyS = new CProxyUsuario.ProxySencillo();
                    miProxyS.Peticionmetodo(1,(int) cmbDepartamento.SelectedValue, textBox1.Text, 
                        textBox3.Text, textBox4.Text, textBox2.Text, 
                        textBox5.Text, 0);
                    md.Invoke();

                    MessageBox.Show("Usuario agregado exitosamente.");
                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                
                string query2 = $"SELECT id_usuario FROM usuario WHERE nombre ='{cmbEliminar.Text}'";
                var dt2 = ConnectionDB.ExecuteQuery(query2);
                var dr2 = dt2.Rows[0];
                var iduser = Convert.ToInt32(dr2[0].ToString());
                
                CProxyUsuario.ISujeto miProxyS = new CProxyUsuario.ProxySencillo();
                miProxyS.Peticionmetodo(2,(int) cmbDepartamento.SelectedValue, cmbEliminar.Text, 
                    textBox3.Text, textBox4.Text, textBox2.Text, 
                    textBox5.Text, iduser);
                md.Invoke();

                MessageBox.Show("Usuario eliminado exitosamente.");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void btnCargardatosEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                CProxyRegistro.ISujeto miProxyS = new CProxyRegistro.ProxySencillo();
                dgvDatosEmpleados.DataSource = null;
                dgvDatosEmpleados.DataSource = miProxyS.Peticionlista();
            }
            catch (Exception)
            {
                MessageBox.Show("Error no existe ningun valor");
            }
        }

        private void btnTop3_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = ConnectionDB.ExecuteQuery(
                    $"SELECT d.nombre, count(u.id_departamento) as frecuencia " + 
                    "FROM registro r, departamento d, usuario u "+ 
                    "WHERE r.id_usuario = u.id_usuario AND d.id_departamento = u.id_departamento "+
                    "GROUP BY d.id_departamento "+
                    "ORDER BY frecuencia DESC LIMIT 1");

                dgvTop3.DataSource = dt;
                MessageBox.Show("Datos obtenidos correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un problema");
            }
        }
    }
} 