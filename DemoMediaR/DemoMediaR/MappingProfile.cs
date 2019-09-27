using AutoMapper;
using DemoMediaR.MediatRServices;
using DemoMediaR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMediaR
{
	public class MappingProfile:Profile
	{
		public MappingProfile()
		{
			CreateMap<StudentCreateCommand, Student>();
		}
	}
}
