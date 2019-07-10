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
                    // context.Usuarios.Include(fk=> Persona)
                    usuarioResponse = context.Usuarios.Include("Persona").Where(x => x.Numero_persona == usuario.Numero_persona && x.Contraseña == usuario.Contraseña).FirstOrDefault();
                    // Console.WriteLine(tmpusuarioResponse);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                Logger.Error(ex.InnerException.Message);
            }
            return usuarioResponse;
        }
    }
}
