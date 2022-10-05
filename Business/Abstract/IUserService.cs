using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IUserService
    {
        void Add(RegisterAuthDto dto);
        
        List<User> GetList();

        User GetByEmail(string email);
    }
}
