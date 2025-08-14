using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica;

namespace login_ferrando
{
    public partial class vista : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            // Crear instancia de la lógica
            LogicaBuscarUsuario logicaBuscar = new LogicaBuscarUsuario();

            // Obtener datos del formulario
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor, complete ambos campos.");
                return;
            }

            // Buscar usuario por algún criterio (por ejemplo, ID o nombre)
            // Aquí deberías tener una forma de obtener el ID, o modificar BuscarCuenta para buscar por nombre
            try
            {
                ObtenerId obtener = new ObtenerId();
                int id = obtener.ObtenerIdUs(usuario);
                logicaBuscar.BuscarCuenta(id);

                // Verificar si las credenciales coinciden
                if (logicaBuscar.Usuario == usuario && logicaBuscar.Contraseña == contraseña)
                {
                    MessageBox.Show("Inicio de sesión exitoso.");
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el usuario: " + ex.Message);
            }
        }

        private void vista_Load(object sender, EventArgs e)
        {

        }
    }
}
