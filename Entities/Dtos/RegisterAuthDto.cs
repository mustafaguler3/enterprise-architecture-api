using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class RegisterAuthDto
    {
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
