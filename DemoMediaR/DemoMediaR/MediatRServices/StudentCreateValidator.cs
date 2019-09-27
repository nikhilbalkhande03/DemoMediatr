using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMediaR.MediatRServices
{
	public class StudentCreateValidator:AbstractValidator<StudentCreateCommand>
	{
		public StudentCreateValidator()
		{
			RuleFor(m => m.FirstName).NotEmpty().WithMessage("Needs first name..!");
			RuleFor(m => m.LastName).NotNull().WithMessage("no null").NotEmpty().WithMessage("needs last name");
			RuleFor(m => m.Address).NotNull().WithMessage("no null").NotEmpty().WithMessage("needs address");
		}
	}
}
