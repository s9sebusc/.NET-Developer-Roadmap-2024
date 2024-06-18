using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
	public class BMWMirror : IMirror
	{
        public BMWMirror()
        {
			Console.WriteLine("Create mirrors for BMW");
		}
    }
}
