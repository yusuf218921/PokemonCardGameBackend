using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.UserDto
{
    public class UserForLoginDto
    {
        public String Username { get; set; } = null!;
        public String Password { get; set; } = null!;
    }
}
