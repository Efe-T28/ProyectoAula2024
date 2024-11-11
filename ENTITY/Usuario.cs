using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Usuario
    {
        public Usuario(int id, string nombre, string email, string contrasena)
        {

            Id = id;
            Nombre = nombre;
            Email = email;
            Contrasena = contrasena;

        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
    }
}
