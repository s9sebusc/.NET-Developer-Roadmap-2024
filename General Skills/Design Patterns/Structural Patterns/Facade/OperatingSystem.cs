using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
	public class OperatingSystem
	{
		public void Start(string userName)
		{
			Console.WriteLine($"Starting OS for user {userName}...");
		}

	}
}
