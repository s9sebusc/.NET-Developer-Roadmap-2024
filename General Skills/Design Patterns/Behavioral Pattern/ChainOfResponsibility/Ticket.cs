using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	public class Ticket
	{
		public int Id { get; }
		public Priority Priority { get; }

		public Ticket(int id, Priority priority)
		{
			Id = id;
			Priority = priority;
		}
	}
}
