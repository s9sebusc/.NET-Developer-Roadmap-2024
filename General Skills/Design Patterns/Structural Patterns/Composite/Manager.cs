using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite
{
	internal class Manager : IEmployee
	{
		private readonly IList<IEmployee> _employees = new List<IEmployee>();

		public Manager(string name, string position)
		{
			this.Name = name;
			this.Position = position;
		}

		public string Name { get; set; }
		public string Position { get; set; }
		public void Display(int indent = 0)
		{
			Console.WriteLine(new String(' ', indent) + Name + " (" + Position + ")");
			foreach (var employee in _employees)
			{
				employee.Display(indent + 2);
			}
		}

		public void Add(IEmployee employee)
		{
			_employees.Add(employee);
		}

		public void Remove(IEmployee employee)
		{
			_employees.Remove(employee);
		}
	}
}
