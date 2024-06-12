using BenchmarkDotNet.Attributes;

namespace Test_Project_BenchmarkDotNet
{
	[Config(typeof(DummyCustomConfig))]
	public class DummyClass
	{
		[Benchmark()]
		public void Slow() => Thread.Sleep(100);

		[Benchmark]
		public void Fast() => Thread.Sleep(25);
	}
}
