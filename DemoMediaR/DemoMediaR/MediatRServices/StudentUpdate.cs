using AutoMapper;
using AutoMapper.QueryableExtensions;
using DemoMediaR.Data;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DemoMediaR.MediatRServices
{
	public class StudentUpdate
	{
		public class Query : IRequest<Command>
		{
			public int? Id { get; set; }
		}
		public class QueryValidator : AbstractValidator<Query>
		{
			public QueryValidator()
			{
				RuleFor(m => m.Id).NotNull();
			}
		}

		public class Command : IRequest
		{
			public int ID { get; set; }
			public string FirstName { get; set; }
			public string LastName { get; set; }

			public string Address { get; set; }
		}

		public class Validator : AbstractValidator<Command>
		{
			public Validator()
			{
				RuleFor(m => m.LastName).NotNull().Length(1, 50);
				RuleFor(m => m.FirstName).NotNull().Length(1, 50);
				RuleFor(m => m.Address).NotNull();
			}
		}
		
		
	}
}
