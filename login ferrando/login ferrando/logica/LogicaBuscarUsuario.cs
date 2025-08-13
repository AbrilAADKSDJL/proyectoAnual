using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;

namespace logica
{
    internal class LogicaBuscarUsuario
    {
        private int ID;
        private string NombreUsuario;
        private string Contraseña;

        public string id
        {
            get { return id; }
        }

        public string Usuario
        {
            get { return NombreUsuario; }
        }

        public string contraseña
        {
            get { return Contraseña; }
        }


        public void BuscarCuenta(int nro)
        {
            BuscarUsuario Buscar = new BuscarUsuario();
            var cliente = Buscar.Buscar(nro);
            ID = cliente.ID;
            NombreUsuario = cliente.NombreUsuario;
            Contraseña = cliente.Contraseña;
        }
    }
}
