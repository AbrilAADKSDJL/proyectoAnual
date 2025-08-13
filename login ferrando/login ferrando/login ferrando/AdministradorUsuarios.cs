using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_ferrando
{
    public partial class AdministradorUsuarios : Form
    {
        public AdministradorUsuarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ActualizarListaUsuarios();
        }

        // Clase interna para representar un usuario
        public class Usuario
        {
            public int ID { get; set; }
            public string Nombre_Usuario { get; set; }
            public string Contraseña { get; set; }
            public string Nombre { get; set; }
            public string Localidad { get; set; }
            public string Genero { get; set; }
            public string Tipo_Documento { get; set; }
            public string Telefono { get; set; }
            public string Rol { get; set; }
        }

        // Lista de usuarios simulada en memoria
        private List<Usuario> usuarios = new List<Usuario>();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var formAgregar = new FormAgregarUsuario())
            {
                if (formAgregar.ShowDialog() == DialogResult.OK)
                {
                    int nuevoId = (usuarios.Count > 0) ? usuarios.Max(u => u.ID) + 1 : 1;
                    usuarios.Add(new Usuario
                    {
                        ID = nuevoId,
                        Nombre_Usuario = formAgregar.Nombre_Usuario,
                        Contraseña = formAgregar.Contraseña,
                        Nombre = formAgregar.Nombre,
                        Localidad = formAgregar.Localidad,
                        Genero = formAgregar.Genero,
                        Tipo_Documento = formAgregar.TipoDocumento,
                        Telefono = formAgregar.Telefono,
                        Rol = formAgregar.Rol
                    });
                    ActualizarListaUsuarios();
                }
            }
        }

        private void ActualizarListaUsuarios()
        {
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = usuarios;
            dgvUsuarios.ClearSelection();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            // Validar que haya al menos una fila seleccionada
            if (dgvUsuarios.SelectedRows.Count == 0 || dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = dgvUsuarios.SelectedRows[0];

            // Validar que la fila no sea una nueva fila vacía
            if (row.IsNewRow)
            {
                MessageBox.Show("No se puede editar una fila vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var usuarioSeleccionado = row.DataBoundItem as Usuario;

            if (usuarioSeleccionado == null)
            {
                MessageBox.Show("No se pudo obtener el usuario seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var formEditar = new FormAgregarUsuario())
            {
                formEditar.CargarDatosUsuario(usuarioSeleccionado);

                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    usuarioSeleccionado.Nombre_Usuario = formEditar.Nombre_Usuario;
                    usuarioSeleccionado.Contraseña = formEditar.Contraseña;
                    usuarioSeleccionado.Nombre = formEditar.Nombre;
                    usuarioSeleccionado.Localidad = formEditar.Localidad;
                    usuarioSeleccionado.Genero = formEditar.Genero;
                    usuarioSeleccionado.Tipo_Documento = formEditar.TipoDocumento;
                    usuarioSeleccionado.Telefono = formEditar.Telefono;
                    usuarioSeleccionado.Rol = formEditar.Rol;

                    ActualizarListaUsuarios();
                }
            }
        }
    }
}
