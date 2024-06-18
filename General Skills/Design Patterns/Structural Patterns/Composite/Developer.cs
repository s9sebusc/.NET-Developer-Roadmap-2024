namespace Composite
{
	internal class Developer : IEmployee
	{
		public Developer(string name, string position)
		{
			this.Name = name;
			this.Position = position;
		}

		public string Name { get; set; }

		public string Position { get; set; }

		public void Display(int indent = 0)
		{
			Console.WriteLine(new String(' ', indent) + Name + " (" + Position + ")");
		}

	}
}
