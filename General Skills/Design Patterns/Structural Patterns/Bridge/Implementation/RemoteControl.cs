namespace Bridge
{
	public class RemoteControl : IControl
	{
		public void TurnOn(string deviceType)
		{
			Console.WriteLine($"The {deviceType} enabled by Remote Control.");
		}

		public void TurnOff(string deviceType)
		{
			Console.WriteLine($"The {deviceType} disabled by Remote Control.");
		}
	}
}
