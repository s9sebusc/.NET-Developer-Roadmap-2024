namespace Bridge
{
	public interface IControl
	{
		void TurnOn(string deviceType);

		void TurnOff(string deviceType);
	}
}
