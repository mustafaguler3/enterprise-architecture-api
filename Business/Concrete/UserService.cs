using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities;
using Entities.Abstract;
using Entities.Dtos;

namespace Business.Concrete
{
    public class UserService : IUserService
    {

        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Add(RegisterAuthDto dto)
        {
            _userRepository.Add(dto);
        }
    }
}
