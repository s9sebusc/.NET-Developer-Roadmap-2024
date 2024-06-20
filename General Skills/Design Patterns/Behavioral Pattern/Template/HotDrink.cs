using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
	public abstract class HotDrink
	{
		public void Prepare()
		{
			BoilWater();
			Brew();
			PourInCup();
			AddExtras();
		}

		private void BoilWater()
		{
			Console.WriteLine("Boiling water...");
		}

		private void PourInCup()
		{
			Console.WriteLine("Pouring hot drink into the cup...");
		}

		protected abstract void Brew();

		protected abstract void AddExtras();
	}
}
