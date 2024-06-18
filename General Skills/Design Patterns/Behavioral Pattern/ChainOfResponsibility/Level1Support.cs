using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	internal class Level1Support : ISupportHandler
	{
		private ISupportHandler nextHandler;

		public void SelectNextStep(ISupportHandler supportHandler)
		{
			this.nextHandler = supportHandler;
		}

		public void HandleTicket(Ticket ticket)
		{
			if (ticket.Priority is Priority.Low or Priority.Medium)
			{
				Console.WriteLine($"Level 1 Support: Handled ticket #{ticket.Id} " +
				                  $"({ticket.Priority} priority)");
			}
			else
			{
				this.nextHandler.HandleTicket(ticket); // Call next handler
			}

		}
	}
}
