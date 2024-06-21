namespace Mediator
{
	public class ChatRoom : IChatRoom
	{
		IList<IUser> chatUsers;

        public ChatRoom()
        {
            chatUsers = new List<IUser>();
        }

        public void RegisterUser(IUser user)
		{
			if(!chatUsers.Contains(user)) { chatUsers.Add(user); };
			Console.WriteLine($"{user.GetName()} has joined the room.");
		}

		public void ShowMessage(IUser user, string message)
		{
			if(chatUsers.Contains(user))
			{
				Console.WriteLine($"[{user.GetName()}]: {message}");
			}
			
		}
	}
}
