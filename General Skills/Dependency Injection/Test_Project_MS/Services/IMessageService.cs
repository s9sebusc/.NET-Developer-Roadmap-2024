using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_Test
{
	internal interface IMessageService
	{
		void WriteMessage(string text);
	}
}
