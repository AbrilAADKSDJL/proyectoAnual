namespace login_ferrando
{
    partial class AdministradorUsuarios
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
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            dgvUsuarios = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NombreUsuario = new DataGridViewTextBoxColumn();
            Contraseña = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Localidad = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(48, 80);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(48, 118);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(48, 157);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { ID, NombreUsuario, Contraseña, Nombre, Localidad, Genero, TipoDocumento, Telefono, Rol });
            dgvUsuarios.Location = new Point(160, 52);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(442, 150);
            dgvUsuarios.TabIndex = 4;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // NombreUsuario
            // 
            NombreUsuario.DataPropertyName = "Nombre_Usuario";
            NombreUsuario.HeaderText = "Nombre_Usuario";
            NombreUsuario.Name = "NombreUsuario";
            // 
            // Contraseña
            // 
            Contraseña.DataPropertyName = "Contraseña";
            Contraseña.HeaderText = "Contraseña";
            Contraseña.Name = "Contraseña";
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Localidad
            // 
            Localidad.DataPropertyName = "Localidad";
            Localidad.HeaderText = "Localidad";
            Localidad.Name = "Localidad";
            // 
            // Genero
            // 
            Genero.DataPropertyName = "Genero";
            Genero.HeaderText = "Genero";
            Genero.Name = "Genero";
            // 
            // TipoDocumento
            // 
            TipoDocumento.DataPropertyName = "Tipo_Documento";
            TipoDocumento.HeaderText = "Tipo_Documento";
            TipoDocumento.Name = "TipoDocumento";
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "Telefono";
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // Rol
            // 
            Rol.DataPropertyName = "Rol";
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            // 
            // AdministradorUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 260);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Name = "AdministradorUsuarios";
            RightToLeftLayout = true;
            Text = "DBÑ";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NombreUsuario;
        private DataGridViewTextBoxColumn Contraseña;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Localidad;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Rol;
    }
}