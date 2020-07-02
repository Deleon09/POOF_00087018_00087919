using System.ComponentModel;

namespace ParcialFinalPOO
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEmpleadoInformacion = new System.Windows.Forms.TabPage();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.tabVigilanteRegistro = new System.Windows.Forms.TabPage();
            this.radSalida = new System.Windows.Forms.RadioButton();
            this.radEntrada = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFechaHora = new System.Windows.Forms.TextBox();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarRegistro = new System.Windows.Forms.Button();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.tabAddORDrop = new System.Windows.Forms.TabPage();
            this.grpDROP = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.grpADD = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabResumen = new System.Windows.Forms.TabPage();
            this.dgvDatosEmpleados = new System.Windows.Forms.DataGridView();
            this.btnCargardatosEmpleado = new System.Windows.Forms.Button();
            this.tabTOP3 = new System.Windows.Forms.TabPage();
            this.dgvTop3 = new System.Windows.Forms.DataGridView();
            this.btnTop3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabEmpleadoInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvEmpleado)).BeginInit();
            this.tabVigilanteRegistro.SuspendLayout();
            this.tabAddORDrop.SuspendLayout();
            this.grpDROP.SuspendLayout();
            this.grpADD.SuspendLayout();
            this.tabResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDatosEmpleados)).BeginInit();
            this.tabTOP3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvTop3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEmpleadoInformacion);
            this.tabControl1.Controls.Add(this.tabVigilanteRegistro);
            this.tabControl1.Controls.Add(this.tabAddORDrop);
            this.tabControl1.Controls.Add(this.tabResumen);
            this.tabControl1.Controls.Add(this.tabTOP3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(655, 497);
            this.tabControl1.TabIndex = 0;
            // 
            // tabEmpleadoInformacion
            // 
            this.tabEmpleadoInformacion.Controls.Add(this.dgvEmpleado);
            this.tabEmpleadoInformacion.Controls.Add(this.btnCargarDatos);
            this.tabEmpleadoInformacion.Location = new System.Drawing.Point(4, 24);
            this.tabEmpleadoInformacion.Name = "tabEmpleadoInformacion";
            this.tabEmpleadoInformacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmpleadoInformacion.Size = new System.Drawing.Size(647, 469);
            this.tabEmpleadoInformacion.TabIndex = 0;
            this.tabEmpleadoInformacion.Text = "Informacion";
            this.tabEmpleadoInformacion.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.AllowUserToAddRows = false;
            this.dgvEmpleado.AllowUserToDeleteRows = false;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEmpleado.Location = new System.Drawing.Point(3, 75);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.ReadOnly = true;
            this.dgvEmpleado.Size = new System.Drawing.Size(641, 391);
            this.dgvEmpleado.TabIndex = 1;
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(224, 6);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(232, 52);
            this.btnCargarDatos.TabIndex = 0;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            // 
            // tabVigilanteRegistro
            // 
            this.tabVigilanteRegistro.Controls.Add(this.radSalida);
            this.tabVigilanteRegistro.Controls.Add(this.radEntrada);
            this.tabVigilanteRegistro.Controls.Add(this.label4);
            this.tabVigilanteRegistro.Controls.Add(this.label3);
            this.tabVigilanteRegistro.Controls.Add(this.txtFechaHora);
            this.tabVigilanteRegistro.Controls.Add(this.txtTemperatura);
            this.tabVigilanteRegistro.Controls.Add(this.label2);
            this.tabVigilanteRegistro.Controls.Add(this.label1);
            this.tabVigilanteRegistro.Controls.Add(this.btnAgregarRegistro);
            this.tabVigilanteRegistro.Controls.Add(this.cmbUsuario);
            this.tabVigilanteRegistro.Location = new System.Drawing.Point(4, 24);
            this.tabVigilanteRegistro.Name = "tabVigilanteRegistro";
            this.tabVigilanteRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabVigilanteRegistro.Size = new System.Drawing.Size(647, 469);
            this.tabVigilanteRegistro.TabIndex = 1;
            this.tabVigilanteRegistro.Text = "Registro";
            this.tabVigilanteRegistro.UseVisualStyleBackColor = true;
            // 
            // radSalida
            // 
            this.radSalida.Location = new System.Drawing.Point(59, 252);
            this.radSalida.Name = "radSalida";
            this.radSalida.Size = new System.Drawing.Size(100, 33);
            this.radSalida.TabIndex = 9;
            this.radSalida.TabStop = true;
            this.radSalida.Text = "Salida";
            this.radSalida.UseVisualStyleBackColor = true;
            // 
            // radEntrada
            // 
            this.radEntrada.Location = new System.Drawing.Point(59, 220);
            this.radEntrada.Name = "radEntrada";
            this.radEntrada.Size = new System.Drawing.Size(103, 27);
            this.radEntrada.TabIndex = 8;
            this.radEntrada.TabStop = true;
            this.radEntrada.Text = "Entrada";
            this.radEntrada.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(101, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha y Hora:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(59, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Entrada/Salida";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFechaHora
            // 
            this.txtFechaHora.Location = new System.Drawing.Point(185, 130);
            this.txtFechaHora.Name = "txtFechaHora";
            this.txtFechaHora.Size = new System.Drawing.Size(343, 23);
            this.txtFechaHora.TabIndex = 5;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(185, 89);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(343, 23);
            this.txtTemperatura.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(37, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperatura:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(59, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.Location = new System.Drawing.Point(199, 323);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Size = new System.Drawing.Size(226, 46);
            this.btnAgregarRegistro.TabIndex = 1;
            this.btnAgregarRegistro.Text = "Agregar Registro";
            this.btnAgregarRegistro.UseVisualStyleBackColor = true;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(185, 42);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(343, 23);
            this.cmbUsuario.TabIndex = 0;
            // 
            // tabAddORDrop
            // 
            this.tabAddORDrop.Controls.Add(this.grpDROP);
            this.tabAddORDrop.Controls.Add(this.grpADD);
            this.tabAddORDrop.Location = new System.Drawing.Point(4, 24);
            this.tabAddORDrop.Name = "tabAddORDrop";
            this.tabAddORDrop.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddORDrop.Size = new System.Drawing.Size(647, 469);
            this.tabAddORDrop.TabIndex = 2;
            this.tabAddORDrop.Text = "Agregar y Eliminar";
            this.tabAddORDrop.UseVisualStyleBackColor = true;
            // 
            // grpDROP
            // 
            this.grpDROP.Controls.Add(this.btnEliminar);
            this.grpDROP.Controls.Add(this.comboBox2);
            this.grpDROP.Location = new System.Drawing.Point(31, 276);
            this.grpDROP.Name = "grpDROP";
            this.grpDROP.Size = new System.Drawing.Size(567, 179);
            this.grpDROP.TabIndex = 8;
            this.grpDROP.TabStop = false;
            this.grpDROP.Text = "Eliminar empleado:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(394, 55);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(142, 78);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(108, 72);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(142, 23);
            this.comboBox2.TabIndex = 13;
            // 
            // grpADD
            // 
            this.grpADD.Controls.Add(this.btnAgregar);
            this.grpADD.Controls.Add(this.textBox5);
            this.grpADD.Controls.Add(this.textBox4);
            this.grpADD.Controls.Add(this.textBox3);
            this.grpADD.Controls.Add(this.textBox2);
            this.grpADD.Controls.Add(this.textBox1);
            this.grpADD.Controls.Add(this.label10);
            this.grpADD.Controls.Add(this.label9);
            this.grpADD.Controls.Add(this.cmbDepartamento);
            this.grpADD.Controls.Add(this.label8);
            this.grpADD.Controls.Add(this.label5);
            this.grpADD.Controls.Add(this.label7);
            this.grpADD.Controls.Add(this.label6);
            this.grpADD.Location = new System.Drawing.Point(31, 16);
            this.grpADD.Name = "grpADD";
            this.grpADD.Size = new System.Drawing.Size(568, 248);
            this.grpADD.TabIndex = 7;
            this.grpADD.TabStop = false;
            this.grpADD.Text = "Agregar empleado:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Red;
            this.btnAgregar.Location = new System.Drawing.Point(394, 85);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(142, 78);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(153, 215);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(130, 23);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(153, 178);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(130, 23);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(153, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 23);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 23);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 23);
            this.textBox1.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(7, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 23);
            this.label10.TabIndex = 6;
            this.label10.Text = "Fecha de nacimiento:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(59, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "Contrasena:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(141, 35);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(142, 23);
            this.cmbDepartamento.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(94, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "dui:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(28, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "idDepartamento:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(71, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Apellido:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(61, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabResumen
            // 
            this.tabResumen.Controls.Add(this.dgvDatosEmpleados);
            this.tabResumen.Controls.Add(this.btnCargardatosEmpleado);
            this.tabResumen.Location = new System.Drawing.Point(4, 22);
            this.tabResumen.Name = "tabResumen";
            this.tabResumen.Padding = new System.Windows.Forms.Padding(3);
            this.tabResumen.Size = new System.Drawing.Size(646, 469);
            this.tabResumen.TabIndex = 3;
            this.tabResumen.Text = "Informacion de Empleados";
            this.tabResumen.UseVisualStyleBackColor = true;
            // 
            // dgvDatosEmpleados
            // 
            this.dgvDatosEmpleados.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosEmpleados.Location = new System.Drawing.Point(17, 117);
            this.dgvDatosEmpleados.Name = "dgvDatosEmpleados";
            this.dgvDatosEmpleados.Size = new System.Drawing.Size(608, 332);
            this.dgvDatosEmpleados.TabIndex = 1;
            // 
            // btnCargardatosEmpleado
            // 
            this.btnCargardatosEmpleado.Location = new System.Drawing.Point(212, 18);
            this.btnCargardatosEmpleado.Name = "btnCargardatosEmpleado";
            this.btnCargardatosEmpleado.Size = new System.Drawing.Size(230, 57);
            this.btnCargardatosEmpleado.TabIndex = 0;
            this.btnCargardatosEmpleado.Text = "Cargar datos empleados";
            this.btnCargardatosEmpleado.UseVisualStyleBackColor = true;
            // 
            // tabTOP3
            // 
            this.tabTOP3.Controls.Add(this.dgvTop3);
            this.tabTOP3.Controls.Add(this.btnTop3);
            this.tabTOP3.Location = new System.Drawing.Point(4, 22);
            this.tabTOP3.Name = "tabTOP3";
            this.tabTOP3.Padding = new System.Windows.Forms.Padding(3);
            this.tabTOP3.Size = new System.Drawing.Size(646, 469);
            this.tabTOP3.TabIndex = 4;
            this.tabTOP3.Text = "Top 3 Departamento";
            this.tabTOP3.UseVisualStyleBackColor = true;
            // 
            // dgvTop3
            // 
            this.dgvTop3.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTop3.Location = new System.Drawing.Point(20, 126);
            this.dgvTop3.Name = "dgvTop3";
            this.dgvTop3.Size = new System.Drawing.Size(610, 327);
            this.dgvTop3.TabIndex = 1;
            // 
            // btnTop3
            // 
            this.btnTop3.Location = new System.Drawing.Point(227, 45);
            this.btnTop3.Name = "btnTop3";
            this.btnTop3.Size = new System.Drawing.Size(206, 58);
            this.btnTop3.TabIndex = 0;
            this.btnTop3.Text = "Cargar datos Top3:";
            this.btnTop3.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 497);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabEmpleadoInformacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvEmpleado)).EndInit();
            this.tabVigilanteRegistro.ResumeLayout(false);
            this.tabVigilanteRegistro.PerformLayout();
            this.tabAddORDrop.ResumeLayout(false);
            this.grpDROP.ResumeLayout(false);
            this.grpADD.ResumeLayout(false);
            this.grpADD.PerformLayout();
            this.tabResumen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvDatosEmpleados)).EndInit();
            this.tabTOP3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvTop3)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVigilanteRegistro;
        private System.Windows.Forms.TabPage tabEmpleadoInformacion;
        private System.Windows.Forms.TabPage tabAddORDrop;
        private System.Windows.Forms.TabPage tabResumen;
        private System.Windows.Forms.TabPage tabTOP3;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radSalida;
        private System.Windows.Forms.RadioButton radEntrada;
        private System.Windows.Forms.Button btnAgregarRegistro;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.TextBox txtFechaHora;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox grpADD;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox grpDROP;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCargardatosEmpleado;
        private System.Windows.Forms.Button btnTop3;
        private System.Windows.Forms.DataGridView dgvDatosEmpleados;
        private System.Windows.Forms.DataGridView dgvTop3;
        private System.Windows.Forms.ComboBox cmbDepartamento;
    }
}