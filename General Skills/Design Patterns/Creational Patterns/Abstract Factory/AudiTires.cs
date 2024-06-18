using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
	public class AudiTires : ITires
	{
        public AudiTires()
        {
			Console.WriteLine("Create tires for AUDI");
		}
    }
}
