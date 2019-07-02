using Persistance.DatabaseContext;
using System;
using System.Linq;
namespace Persistance.KRepository
{
    public interface IUsuario
    {
        Usuario GetById(Usuario usuario);
    }
    public class UsuarioRepository : IUsuario
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public Usuario GetById(Usuario usuario)
        {
            Usuario usuarioResponse = new Usuario();
            try
            {
                using (KonexusModel context = new KonexusModel())
                {
                    usuarioResponse = context.Usuarios.Where(x => x.Numero_persona == usuario.Numero_persona && x.Contraseña == usuario.Contraseña).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, " 3rr0r");
            }
            return usuarioResponse;
        }
    }
}
