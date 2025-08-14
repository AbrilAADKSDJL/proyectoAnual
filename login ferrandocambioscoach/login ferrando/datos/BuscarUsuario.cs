using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class BuscarUsuario
    {
        public UsuariosDTO Buscar(int cuenta)
        {
            var cliente = DatosUsuarios.UsuarioC
                .FirstOrDefault(c => c.ID == cuenta);

            if (cliente == null)
                throw new FileNotFoundException("Número de cuenta inexistente.");


            return new UsuariosDTO
            {
                ID = cliente.ID,
                NombreUsuario = cliente.NombreUsuario,
                Contraseña = cliente.Contraseña
                
            };
        }
    }
}
