using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project_Repository_Pattern
{
	internal class BookTO
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public BookTO(string name)
		{
			Id = Guid.NewGuid();
			Name = name;
		}
	}
}
