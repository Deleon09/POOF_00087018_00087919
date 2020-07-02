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
            this.tabVigilanteRegistro = new System.Windows.Forms.TabPage();
            this.tabAddORDrop = new System.Windows.Forms.TabPage();
            this.tabResumen = new System.Windows.Forms.TabPage();
            this.tabTOP3 = new System.Windows.Forms.TabPage();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.btnAgregarRegistro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.txtFechaHora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radEntrada = new System.Windows.Forms.RadioButton();
            this.radSalida = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabEmpleadoInformacion.SuspendLayout();
            this.tabVigilanteRegistro.SuspendLayout();
            this.tabAddORDrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvEmpleado)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(655, 486);
            this.tabControl1.TabIndex = 0;
            // 
            // tabEmpleadoInformacion
            // 
            this.tabEmpleadoInformacion.Controls.Add(this.dgvEmpleado);
            this.tabEmpleadoInformacion.Controls.Add(this.btnCargarDatos);
            this.tabEmpleadoInformacion.Location = new System.Drawing.Point(4, 24);
            this.tabEmpleadoInformacion.Name = "tabEmpleadoInformacion";
            this.tabEmpleadoInformacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmpleadoInformacion.Size = new System.Drawing.Size(647, 458);
            this.tabEmpleadoInformacion.TabIndex = 0;
            this.tabEmpleadoInformacion.Text = "Informacion";
            this.tabEmpleadoInformacion.UseVisualStyleBackColor = true;
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
            this.tabVigilanteRegistro.Size = new System.Drawing.Size(647, 458);
            this.tabVigilanteRegistro.TabIndex = 1;
            this.tabVigilanteRegistro.Text = "Registro";
            this.tabVigilanteRegistro.UseVisualStyleBackColor = true;
            // 
            // tabAddORDrop
            // 
            this.tabAddORDrop.Controls.Add(this.radioButton3);
            this.tabAddORDrop.Controls.Add(this.radioButton2);
            this.tabAddORDrop.Controls.Add(this.radioButton1);
            this.tabAddORDrop.Controls.Add(this.label9);
            this.tabAddORDrop.Controls.Add(this.label8);
            this.tabAddORDrop.Controls.Add(this.label7);
            this.tabAddORDrop.Controls.Add(this.label6);
            this.tabAddORDrop.Controls.Add(this.label5);
            this.tabAddORDrop.Location = new System.Drawing.Point(4, 24);
            this.tabAddORDrop.Name = "tabAddORDrop";
            this.tabAddORDrop.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddORDrop.Size = new System.Drawing.Size(647, 458);
            this.tabAddORDrop.TabIndex = 2;
            this.tabAddORDrop.Text = "Agregar y Eliminar";
            this.tabAddORDrop.UseVisualStyleBackColor = true;
            // 
            // tabResumen
            // 
            this.tabResumen.Location = new System.Drawing.Point(4, 24);
            this.tabResumen.Name = "tabResumen";
            this.tabResumen.Padding = new System.Windows.Forms.Padding(3);
            this.tabResumen.Size = new System.Drawing.Size(647, 458);
            this.tabResumen.TabIndex = 3;
            this.tabResumen.Text = "Informacion de Empleados";
            this.tabResumen.UseVisualStyleBackColor = true;
            // 
            // tabTOP3
            // 
            this.tabTOP3.Location = new System.Drawing.Point(4, 24);
            this.tabTOP3.Name = "tabTOP3";
            this.tabTOP3.Padding = new System.Windows.Forms.Padding(3);
            this.tabTOP3.Size = new System.Drawing.Size(647, 458);
            this.tabTOP3.TabIndex = 4;
            this.tabTOP3.Text = "Top 3 Departamento";
            this.tabTOP3.UseVisualStyleBackColor = true;
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(183, 6);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(232, 52);
            this.btnCargarDatos.TabIndex = 0;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.AllowUserToAddRows = false;
            this.dgvEmpleado.AllowUserToDeleteRows = false;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEmpleado.Location = new System.Drawing.Point(3, 64);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.ReadOnly = true;
            this.dgvEmpleado.Size = new System.Drawing.Size(641, 391);
            this.dgvEmpleado.TabIndex = 1;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(186, 42);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(344, 23);
            this.cmbUsuario.TabIndex = 0;
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.Location = new System.Drawing.Point(200, 323);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Size = new System.Drawing.Size(226, 46);
            this.btnAgregarRegistro.TabIndex = 1;
            this.btnAgregarRegistro.Text = "Agregar Registro";
            this.btnAgregarRegistro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(60, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(186, 89);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(344, 23);
            this.txtTemperatura.TabIndex = 4;
            // 
            // txtFechaHora
            // 
            this.txtFechaHora.Location = new System.Drawing.Point(186, 130);
            this.txtFechaHora.Name = "txtFechaHora";
            this.txtFechaHora.Size = new System.Drawing.Size(344, 23);
            this.txtFechaHora.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(60, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Entrada/Salida";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(101, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha y Hora:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // radEntrada
            // 
            this.radEntrada.Location = new System.Drawing.Point(60, 220);
            this.radEntrada.Name = "radEntrada";
            this.radEntrada.Size = new System.Drawing.Size(103, 26);
            this.radEntrada.TabIndex = 8;
            this.radEntrada.TabStop = true;
            this.radEntrada.Text = "Entrada";
            this.radEntrada.UseVisualStyleBackColor = true;
            // 
            // radSalida
            // 
            this.radSalida.Location = new System.Drawing.Point(60, 252);
            this.radSalida.Name = "radSalida";
            this.radSalida.Size = new System.Drawing.Size(100, 33);
            this.radSalida.TabIndex = 9;
            this.radSalida.TabStop = true;
            this.radSalida.Text = "Salida";
            this.radSalida.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(118, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(109, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(109, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(96, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(96, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "label9";
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(414, 49);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(125, 21);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(400, 80);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(125, 21);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(400, 118);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(125, 27);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 486);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.tabControl1.ResumeLayout(false);
            this.tabEmpleadoInformacion.ResumeLayout(false);
            this.tabVigilanteRegistro.ResumeLayout(false);
            this.tabVigilanteRegistro.PerformLayout();
            this.tabAddORDrop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvEmpleado)).EndInit();
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}