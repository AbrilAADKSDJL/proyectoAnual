namespace login_ferrando
{
    partial class FormAgregarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            label6 = new Label();
            cmbRol = new ComboBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            cmbTipoDocumento = new ComboBox();
            label3 = new Label();
            cmbGenero = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txtLocalidad = new TextBox();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtNombreUsuario = new TextBox();
            txtContraseña = new TextBox();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(199, 374);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 27;
            label6.Text = "Rol";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(267, 371);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(100, 23);
            cmbRol.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(188, 338);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 25;
            label5.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(267, 335);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(163, 298);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 23;
            label4.Text = "Tipo: documento";
            // 
            // cmbTipoDocumento
            // 
            cmbTipoDocumento.FormattingEnabled = true;
            cmbTipoDocumento.Location = new Point(267, 295);
            cmbTipoDocumento.Name = "cmbTipoDocumento";
            cmbTipoDocumento.Size = new Size(100, 23);
            cmbTipoDocumento.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 259);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 21;
            label3.Text = "Genero";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(267, 256);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(100, 23);
            cmbGenero.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 214);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 19;
            label2.Text = "Localidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 172);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 18;
            label1.Text = "Nombre";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(267, 214);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(100, 23);
            txtLocalidad.TabIndex = 17;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(267, 169);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 16;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(172, 419);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(84, 23);
            btnGuardar.TabIndex = 28;
            btnGuardar.Text = "Agregar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(283, 419);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 23);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(267, 92);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(100, 23);
            txtNombreUsuario.TabIndex = 30;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(267, 130);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(180, 133);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 32;
            label7.Text = "Contraseña";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(152, 95);
            label8.Name = "label8";
            label8.Size = new Size(109, 15);
            label8.TabIndex = 33;
            label8.Text = "Nombre de usuario";
            // 
            // FormAgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 492);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label6);
            Controls.Add(cmbRol);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(cmbTipoDocumento);
            Controls.Add(label3);
            Controls.Add(cmbGenero);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLocalidad);
            Controls.Add(txtNombre);
            Name = "FormAgregarUsuario";
            Text = "FormAgregarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private ComboBox cmbRol;
        private Label label5;
        private TextBox txtTelefono;
        private Label label4;
        private ComboBox cmbTipoDocumento;
        private Label label3;
        private ComboBox cmbGenero;
        private Label label2;
        private Label label1;
        private TextBox txtLocalidad;
        private TextBox txtNombre;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtNombreUsuario;
        private TextBox txtContraseña;
        private Label label7;
        private Label label8;
    }
}