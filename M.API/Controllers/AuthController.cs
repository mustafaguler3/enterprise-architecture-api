using Business.Abstract;
using Business.ValidationRules.FluentValidator;
using Core.CrossCuttingConcerns.Validation;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace M.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("register")]
        public IActionResult Register(RegisterAuthDto dto)
        {
            var validation = new UserValidator();
            ValidationTool.Validate(validation,dto);
            
            _authService.Register(dto);
            return Ok();
        }
    }
}
