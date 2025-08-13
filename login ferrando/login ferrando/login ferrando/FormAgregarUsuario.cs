using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static login_ferrando.AdministradorUsuarios;

namespace login_ferrando
{
    public partial class FormAgregarUsuario : Form
    {
        public string Nombre_Usuario => txtNombreUsuario.Text;
        public string Contraseña => txtContraseña.Text;
        public string Nombre => txtNombre.Text;
        public string Localidad => txtLocalidad.Text;
        public string Genero => cmbGenero.Text;
        public string TipoDocumento => cmbTipoDocumento.Text;
        public string Telefono => txtTelefono.Text;
        public string Rol => cmbRol.Text;
        public FormAgregarUsuario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InicializarCombos();
        }

        private void InicializarCombos()
        {
            cmbGenero.Items.Clear();
            cmbGenero.Items.AddRange(new string[] { "Masculino", "Femenino", "Otro" });
            cmbTipoDocumento.Items.Clear();
            cmbTipoDocumento.Items.AddRange(new string[] { "DNI", "Pasaporte", "Carnet de Identidad", "Cédula", "Otro" });
            cmbRol.Items.Clear();
            cmbRol.Items.AddRange(new string[] { "Administrador", "Usuario" });
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar Nombre_Usuario
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text) || txtNombreUsuario.Text.Trim().Length < 3)
            {
                MessageBox.Show("Debe ingresar un nombre de usuario válido (mínimo 3 caracteres).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreUsuario.Focus();
                return;
            }

            // Validar Contraseña
            string pass = txtContraseña.Text;
            if (string.IsNullOrWhiteSpace(pass) || pass.Length < 6 ||
                !pass.Any(char.IsUpper) || !pass.Any(char.IsDigit))
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres, una mayúscula y un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
                return;
            }

            // Validar Nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            // Validar Localidad
            if (string.IsNullOrWhiteSpace(txtLocalidad.Text))
            {
                MessageBox.Show("Debe ingresar una localidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocalidad.Focus();
                return;
            }

            // Validar Género
            if (string.IsNullOrWhiteSpace(cmbGenero.Text) ||
                !cmbGenero.Items.Cast<string>().Contains(cmbGenero.Text))
            {
                MessageBox.Show("Debe seleccionar un género válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGenero.Focus();
                return;
            }

            // Validar Tipo de Documento
            if (string.IsNullOrWhiteSpace(cmbTipoDocumento.Text) ||
                !cmbTipoDocumento.Items.Cast<string>().Contains(cmbTipoDocumento.Text))
            {
                MessageBox.Show("Debe seleccionar un tipo de documento válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipoDocumento.Focus();
                return;
            }

            // Validar Teléfono (solo números, puede empezar con +, mínimo 8 dígitos sin contar el +)
            string tel = txtTelefono.Text;
            string telSinMas = tel.StartsWith("+") ? tel.Substring(1) : tel;
            if (string.IsNullOrWhiteSpace(tel) ||
                telSinMas.Length < 8 ||
                !Regex.IsMatch(tel, @"^\+?\d+$"))
            {
                MessageBox.Show("El teléfono debe contener solo números y puede comenzar con '+'. Debe tener al menos 8 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return;
            }

            // Validar Rol
            if (string.IsNullOrWhiteSpace(cmbRol.Text) ||
                !cmbRol.Items.Cast<string>().Contains(cmbRol.Text))
            {
                MessageBox.Show("Debe seleccionar un rol válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRol.Focus();
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public void CargarDatosUsuario(Usuario usuario)
        {
            txtNombreUsuario.Text = usuario.Nombre_Usuario;
            txtContraseña.Text = usuario.Contraseña;
            txtNombre.Text = usuario.Nombre;
            txtLocalidad.Text = usuario.Localidad;
            cmbGenero.Text = usuario.Genero;
            cmbTipoDocumento.Text = usuario.Tipo_Documento;
            txtTelefono.Text = usuario.Telefono;
            cmbRol.Text = usuario.Rol;
        }
    }
}
