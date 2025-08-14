using datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class ObtenerId
    {
        public int ObtenerIdUs(string nombreUsuario)
        {
            BuscarUsuario buscar = new BuscarUsuario();
            var usuarioEncontrado = DatosUsuarios.UsuarioC
                .FirstOrDefault(u => u.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase));

            if (usuarioEncontrado != null)
                return usuarioEncontrado.ID;
            else
                throw new Exception("Usuario no encontrado.");
        }

    }
}
