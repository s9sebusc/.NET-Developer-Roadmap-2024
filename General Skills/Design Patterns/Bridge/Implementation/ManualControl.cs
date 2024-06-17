namespace Bridge
{
	public class ManualControl : IControl
	{
		public void TurnOn(string deviceType)
		{
			Console.WriteLine($"The {deviceType} enabled manually.");
		}

		public void TurnOff(string deviceType)
		{
			Console.WriteLine($"The {deviceType} disabled manually.");
		}
	}
}
