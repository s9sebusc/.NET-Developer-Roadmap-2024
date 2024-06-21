using Mediator;

IChatRoom chatRoom = new ChatRoom();

IUser alex = new User("Alex", chatRoom);
IUser jenny = new User("Jenny", chatRoom);
chatRoom.RegisterUser(alex);
chatRoom.RegisterUser(jenny);

alex.SendMessage("Hi Jenny");
jenny.SendMessage("Hi Alex");

