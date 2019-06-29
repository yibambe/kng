using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistance.DatabaseContext;
using System.Linq;
namespace Persistance.KRepository
{
    public interface IUsuario
    {
        Usuario GetById(Usuario usuario);
    }
    class UsuarioRepository : IUsuario
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public Usuario GetById(Usuario usuario)
        {
            Usuario usuarioResponse = new Usuario();
            try
            {
                using (KonexusModel context = new KonexusModel())
                {
                    usuarioResponse = context.Usuarios.Where(x => x.Numero_persona == usuario.Numero_persona && x.Contraseña == usuario.Contraseña).FirstOrDefault<Usuario>();
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, " 3rr0r");
            }
            return usuarioResponse;
        }
    }
}
