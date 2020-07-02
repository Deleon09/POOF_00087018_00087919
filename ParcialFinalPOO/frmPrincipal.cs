using System;
using System.Windows.Forms;

namespace ParcialFinalPOO
{
    public partial class frmPrincipal : Form
    {
        private departamento nombre;
        public frmPrincipal(departamento dep)
        {
            InitializeComponent();
            nombre = dep;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }
} 