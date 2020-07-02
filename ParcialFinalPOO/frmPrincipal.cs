﻿using System;
using System.Windows.Forms;

namespace ParcialFinalPOO
{
    public partial class frmPrincipal : Form
    {
        private int depa;
        private usuario user;
        
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

        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            
            /*try
            {
                var dt = ConnectionDB.ExecuteQuery("SELECT * FROM appuser");

                dgvEmpleado.DataSource = dt;
                MessageBox.Show("Datos obtenidos correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un problema");
            }*/
        }
    }
} 