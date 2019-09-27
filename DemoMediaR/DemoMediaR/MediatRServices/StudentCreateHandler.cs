using AutoMapper;
using DemoMediaR.Data;
using DemoMediaR.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DemoMediaR.MediatRServices
{
	public class StudentCreateHandler : IRequestHandler<StudentCreateCommand, int>
	{
		private readonly SchoolContext _db;
		private readonly IMapper _mapper;
		public StudentCreateHandler(SchoolContext db, IMapper mapper)
		{
			_db = db;
			_mapper = mapper;
		}
		public async  Task<int> Handle(StudentCreateCommand studentCreateCommand, CancellationToken cancellationToken)
		{
			
			var students = _mapper.Map<StudentCreateCommand, Student>(studentCreateCommand);
			_db.Students.Add(students);
			 await _db.SaveChangesAsync();

			return students.Id;
		}
	}
}
