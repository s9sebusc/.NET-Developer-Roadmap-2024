using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
	public class User : IUser
	{
		private string name;
		private IChatRoom chatRoom;

		public User(string name, IChatRoom chatRoom)
		{
			this.name = name;
			this.chatRoom = chatRoom;
		}

		public string GetName()
		{
			return name;
		}

		public void SendMessage(string message)
		{
			chatRoom.ShowMessage(this, message);
		}
	}
}
