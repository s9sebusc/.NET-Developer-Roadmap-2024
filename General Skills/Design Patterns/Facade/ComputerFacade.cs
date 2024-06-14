using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
	public class ComputerFacade
	{
		private readonly Cpu cpu;
		private readonly Ram ram;
		private readonly HardDrive hardDrive;
		private readonly OperatingSystem os;

		public ComputerFacade()
		{
			this.cpu = new Cpu();
			this.ram = new Ram();
			this.hardDrive = new HardDrive();
			this.os = new OperatingSystem();
		}

		public void StartComputer(string userName)
		{
			Console.WriteLine("Starting computer...");

			this.cpu.Run();
			this.ram.Load();
			byte[] data = this.hardDrive.Read();
			this.os.Start(userName);

			Console.WriteLine("Computer has been successfully started!");
		}
	}
}
