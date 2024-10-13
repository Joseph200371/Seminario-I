using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_
{
    /// <summary>
    /// Se crea la clase UsuarioMaster con parametro para general un login
    /// </summary>
    public class UsuarioMaster
    {
        string usuario;
        string contraseña;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
    }
}
