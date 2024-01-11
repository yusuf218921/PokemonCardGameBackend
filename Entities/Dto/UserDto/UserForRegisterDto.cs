using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.UserDto
{
    public class UserForRegisterDto
    {
        public String Email { get; set; } = null!;
        public String Username { get; set; } = null!;
        public String Password { get; set; } = null!;
    }
}
