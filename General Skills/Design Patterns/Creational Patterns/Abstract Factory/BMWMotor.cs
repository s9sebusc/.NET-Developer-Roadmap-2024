using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
	public class BMWMotor : IMotor
	{
        public BMWMotor()
        {
			Console.WriteLine("Create motor for BMW");
		}
    }
}
