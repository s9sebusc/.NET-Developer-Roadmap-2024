namespace Bridge
{
	public class SmartphoneControl : IControl
	{
		public void TurnOn(string deviceType)
		{
			Console.WriteLine($"The {deviceType} enabled by Smartphone Control.");
		}

		public void TurnOff(string deviceType)
		{
			Console.WriteLine($"The {deviceType} disabled by Smartphone Control.");
		}
	}
}
