namespace Bridge
{
	public abstract class HomeDevice
	{
		public IControl Control { get; set; }

		public HomeDevice(IControl control)
		{
			this.Control = control;
		}

		public abstract void TurnOn();

		public abstract void TurnOff();
	}
}
