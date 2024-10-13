using Datos_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Logica_
{
    public class UsuarioService
    {
        /// <summary>
        /// se crea un metodo del tipo UsuarioMaster y verifica sus valores
        /// </summary>
        /// <param name="usuario">recibe el parametro usuario del formulario</param>
        /// <exception cref="ArgumentException">muestra errores de validadicion</exception>
        public void RegistrarUsuario(UsuarioMaster usuario)
        { 

                List<string> errores = ValidarUsuario(usuario);

                if (errores.Count > 0)
                {
                    // Lanzamos una excepción con los errores encontrados
                    throw new ArgumentException(string.Join(",\n ", errores));
                }
 
        }
        /// <summary>
        /// Valida el tipo de Usuariomaster
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>errores</returns>
        private List<string> ValidarUsuario(UsuarioMaster usuario)
        {
            List<string> errores = new List<string>();

            // Validamos que el nombre de usuario no esté vacío
            if (string.IsNullOrWhiteSpace(usuario.Usuario) && string.IsNullOrWhiteSpace(usuario.Contraseña))
            {
                errores.Add("El nombre de usuario y/o contraseñas estan vacios.");
            }
             else if (!usuario.Usuario.Equals("antioquia") || !usuario.Contraseña.Equals("1234") )
            {
                errores.Add("Usuario y/o contraseña invalido");
            }

            return errores;
        }



    }
}
