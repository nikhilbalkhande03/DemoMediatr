using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMediaR.Models
{
	public class Student
	{
		
			public int Id { get; set; }

			[Required]
			[StringLength(50)]
			[Display(Name = "Last Name")]
			public string LastName { get; set; }
			[Required]
			[StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
			[Column("FirstName")]
			[Display(Name = "First Name")]
			public string FirstName { get; set; }
		[Required]
		[StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
		[Column("Address")]
		[Display(Name = "Address")]
		public string Address { get; set; }
		
		}
	}
