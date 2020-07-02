using System;
using System.Windows.Forms;

namespace ParcialFinalPOO
{
    public partial class frmPrincipal : Form
    {
        private int depa;
        public frmPrincipal(int dep)
        {
            InitializeComponent();
            depa = dep;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido/a");
            try
            {
                string query = $"SELECT nombre FROM departamento WHERE id_departamento ='{depa}'";
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
                    tabContenedor.TabPages[1].Parent = null;
                    tabContenedor.TabPages[1].Parent = null;
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

        }
    }
} 