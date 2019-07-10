using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{
    public class UsuarioDTO
    {
        public int PersonNumber{ get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
        public string FullName { get; set; }
        public int CompanyNumber { get; set; }
        public string Email { get; set; }

    }
}
