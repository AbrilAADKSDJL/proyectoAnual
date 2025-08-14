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

            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AutoGenerateColumns = true;

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
        private BindingList<Usuario> usuarios = new BindingList<Usuario>();

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
                }
            }
        }

        private void ActualizarListaUsuarios()
        {
            if (dgvUsuarios.DataSource == null)
                dgvUsuarios.DataSource = usuarios;
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar_Click(sender, e);
        }
        private Usuario ObtenerUsuarioSeleccionado()
        {
            if (dgvUsuarios.CurrentRow == null)
                return null;

            var usuario = dgvUsuarios.CurrentRow.DataBoundItem as Usuario;
            return usuario;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var usuario = ObtenerUsuarioSeleccionado();
            if (usuario == null)
            {
                MessageBox.Show("No hay ningún usuario seleccionado.");
                return;
            }

            var confirm = MessageBox.Show($"¿Desea eliminar al usuario {usuario.Nombre_Usuario}?",
                                          "Confirmar eliminación",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                usuarios.Remove(usuario);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var usuario = ObtenerUsuarioSeleccionado();
            if (usuario == null)
            {
                MessageBox.Show("No hay ningún usuario seleccionado.");
                return;
            }

            using (var formEditar = new FormAgregarUsuario())
            {
                formEditar.CargarDatosUsuario(usuario);
                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    usuario.Nombre_Usuario = formEditar.Nombre_Usuario;
                    usuario.Contraseña = formEditar.Contraseña;
                    usuario.Nombre = formEditar.Nombre;
                    usuario.Localidad = formEditar.Localidad;
                    usuario.Genero = formEditar.Genero;
                    usuario.Tipo_Documento = formEditar.TipoDocumento;
                    usuario.Telefono = formEditar.Telefono;
                    usuario.Rol = formEditar.Rol;
                }
            }
        }
    }
}
