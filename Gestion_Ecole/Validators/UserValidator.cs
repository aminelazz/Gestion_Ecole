using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Gestion_Ecole;

namespace JGR.Validators
{
    class UserValidator : AbstractValidator<Authentication>
    {
        public UserValidator()
        {
            // Validate Username
            RuleFor(u => u.Username)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Username is empty.")
                .Length(3, 20).WithMessage("Username's length is invalid.");

            // Validate First name
            RuleFor(u => u.First_Name)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("First name is empty.")
                .Length(3, 20).WithMessage("First name's length is invalid.");

            // Validate Last name
            RuleFor(u => u.Last_Name)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Last name name is empty.")
                .Length(3, 20).WithMessage("Last name's length is invalid.");

            // Validate Password
            RuleFor(u => u.Password)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Password is empty.")
                .Length(5, 20).WithMessage("Password must be between 5 and 20 characters.");
        }
    }
}
