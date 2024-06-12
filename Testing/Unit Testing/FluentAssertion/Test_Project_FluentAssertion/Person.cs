using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project_FluentAssertion
{
	internal class Person
	{
		public string? FirstName { get; set; }
		public string? LastName { get; set; }

		public string? FullName { get; set; }

		public Person(string? fullName)
		{
			this.FullName = fullName;
			SplitFullName();
		}

		private void SplitFullName()
		{
			if (FullName == null)
			{
				return;
			}
			string[] names = FullName.Split(' ');
			FirstName = names[0];
			LastName = names[1];
		}


	}
}
