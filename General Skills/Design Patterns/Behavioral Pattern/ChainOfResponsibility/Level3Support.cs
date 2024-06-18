using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	internal class Level3Support : ISupportHandler
	{
		private ISupportHandler nextHandler;

		public void SelectNextStep(ISupportHandler nextHandler)
		{
			this.nextHandler = nextHandler;
		}

		public void HandleTicket(Ticket ticket)
		{
			if (ticket.Priority is Priority.Critical)
			{
				Console.WriteLine($"Level 3 Support: Handled ticket #{ticket.Id} ({ticket.Priority} priority)");
			}
			else
			{
				Console.WriteLine($"Level 3 Support: Can't handled ticket #{ticket.Id} ({ticket.Priority} priority)");
			}

		}
	}
}
