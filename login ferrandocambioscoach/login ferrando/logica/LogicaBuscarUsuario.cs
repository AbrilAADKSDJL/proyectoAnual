using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;

namespace logica
{
    public class LogicaBuscarUsuario
    {
        // Propiedades con nombres consistentes y tipos adecuados
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public void BuscarCuenta(int nro)
        {
            BuscarUsuario buscar = new BuscarUsuario();
            var cliente = buscar.Buscar(nro);

            if (cliente != null)
            {
                Id = cliente.ID;
                Usuario = cliente.NombreUsuario;
                Contraseña = cliente.Contraseña;
            }
            else
            {
                // Manejo de error si no se encuentra el usuario
                throw new Exception("Usuario no encontrado.");
            }
        }
    } 
}

