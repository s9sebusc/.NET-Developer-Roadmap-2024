using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	internal class Level2Support : ISupportHandler
	{
		private ISupportHandler nextHandler;

		public void SelectNextStep(ISupportHandler nextHandler)
		{
			this.nextHandler = nextHandler;
		}

		public void HandleTicket(Ticket ticket)
		{
			if (ticket.Priority is Priority.High)
			{
				Console.WriteLine($"Level 2 Support: Handled ticket #{ticket.Id} ({ticket.Priority} priority)");
			}
			else
			{
				this.nextHandler.HandleTicket(ticket); // Call next handler
			}

		}
	}
}
