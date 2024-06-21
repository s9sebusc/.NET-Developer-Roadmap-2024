using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
	public interface IChatRoom
	{
		public void ShowMessage(IUser user, string message);

		public void RegisterUser(IUser user);	
	}
}
