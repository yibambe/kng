using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Common.DTO;
using Persistance.KRepository;
using Persistance.DatabaseContext;
using AutoMapper;
using System.Web.Http.Cors;
namespace Service.Controllers
{
    //[EnableCors(origins:"*",headers:"*",methods:"*")]
    public class UsuarioController : ApiController
    {
        private IUsuario _usuario;
        public UsuarioController(IUsuario usuario)
        {
            _usuario = usuario;
        }

        [HttpPost]
        ///[ResponseType(typeof(UsuarioDTO))]
        [Route("api/usuario/login")]
        public IHttpActionResult Login([FromBody] UsuarioDTO usuarioDTO)
        {
            Usuario tmpUsuario = Mapper.Map<Usuario>(usuarioDTO);
            var result =  _usuario.GetById(tmpUsuario);

            if (result == null)
            {
                return NotFound();
            }
            else
            {
                UsuarioDTO tmpUsuarioDTO = Mapper.Map<UsuarioDTO>(result);
                return Ok(tmpUsuarioDTO);
            }
        }
        //public UsuarioDTO Login(UsuarioDTO usuarioDTO)
        //{
        //    UsuarioDTO usuarioDTORequest = new UsuarioDTO()
        //    {
        //        PersonNumber = 1,
        //        Password = "develop3r"

        //    };

        //  //   return Ok(usuarioDTORequest);

        //}
        // GET: api/Usuario
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Usuario/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Usuario
        public void Post([FromBody]string value)
        {
            Console.WriteLine("test");
        }

        // PUT: api/Usuario/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
        }
    }
}
