using System;
using System.Collections.Generic;
using System.Text;
using NLog;
using Persistance.DatabaseContext;

namespace Persistance.Repository
{
    public interface IUsuario
    {
        Usuario GetById(Usuario usuario);
    }
    class UsuarioRepository : IUsuario
    {
        public Usuario GetById(Usuario usuario)
        {
            try
            {

            }
            catch (Exception ex)
            {

                

            }
            return null;
        }
    }
}
