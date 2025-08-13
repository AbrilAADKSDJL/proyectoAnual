using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{

    public static class DatosUsuarios
    {
        public static List<CrearUsuario> UsuarioC = new List<CrearUsuario>();

        public static void InicializarLista()
        {

            UsuarioC.AddRange(new List<CrearUsuario>
            {
                new CrearUsuario { ID = 001, NombreUsuario = "enzo", Contraseña = "Feos2022"},
                });
        }

    }
}
