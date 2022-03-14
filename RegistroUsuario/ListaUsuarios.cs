﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroUsuario
{
    public class ListaUsuarios
    {
        public List<Usuario> Usuarios { set; get; }

        public ListaUsuarios()
        {
            Usuarios = new List<Usuario>();
        }

        public void AgregarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        public List<Usuario> BuscarApellido(string apellido)
        {
            List<Usuario> aux = new List<Usuario>();
            foreach (Usuario usuario in Usuarios)
            {
                if (usuario.Apellido.Equals(apellido))
                {
                    aux.Add(usuario);
                }
            }
            return aux;
        }

        public List<Usuario> BuscarCedula(string id)
        {
            List<Usuario> aux = new List<Usuario>();
            foreach (Usuario usuario in Usuarios)
            {
                if (usuario.Cedula.Equals(id))
                {
                    aux.Add(usuario);
                }
            }
            return aux;
        }
    }
}
