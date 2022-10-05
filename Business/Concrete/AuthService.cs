using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Hashing;
using Entities.Dtos;

namespace Business.Concrete
{
    public class AuthService : IAuthService
    {
        private readonly IUserService _userService;

        public AuthService(IUserService userService)
        {
            _userService = userService;
        }

        public void Register(RegisterAuthDto dto)
        {
            throw new NotImplementedException();
        }

        public void Login(LoginAuthDto dto)
        {
            var user = _userService.GetByEmail(dto.Email);
            var result = HashingHelper.VerifyPasswordHash(dto.Password, user.PasswordHash, user.PasswordSalt);
        }
    }
}
