using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
	public class AudiMotor : IMotor
	{
        public AudiMotor()
        {
			Console.WriteLine("Create motor for AUDI");
		}
    }
}
