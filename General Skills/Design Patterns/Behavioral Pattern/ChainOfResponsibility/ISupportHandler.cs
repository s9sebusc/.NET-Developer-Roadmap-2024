using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	public interface ISupportHandler
	{
		void SelectNextStep(ISupportHandler successor);

		void HandleTicket(Ticket ticket);
	}
}
