using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMediaR.MediatRServices
{
	public class StudentCreateCommand:IRequest<int>
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public string Address { get; set; }

	}
}
