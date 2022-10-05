using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Dtos;
using FluentValidation;

namespace Business.ValidationRules.FluentValidator
{
    public class UserValidator : AbstractValidator<RegisterAuthDto>
    {
        public UserValidator()
        {
            RuleFor(i => i.Name).NotEmpty().WithMessage("Username must not be empty");
            RuleFor(i => i.Password).NotEmpty().WithMessage("Password must not be empty");
            RuleFor(i => i.Email).NotEmpty().WithMessage("Email must not be empty");
        }
    }
}
