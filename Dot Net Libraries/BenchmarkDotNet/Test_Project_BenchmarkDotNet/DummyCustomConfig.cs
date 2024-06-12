using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Loggers;

namespace Test_Project_BenchmarkDotNet
{
	public class DummyCustomConfig : ManualConfig
	{
		public DummyCustomConfig()
		{
			AddDiagnoser(MemoryDiagnoser.Default);

			// Column in results table
			AddColumn(StatisticColumn.Min);
			AddColumn(StatisticColumn.Max);
			AddColumn(StatisticColumn.Iterations);
			AddColumn(StatisticColumn.OperationsPerSecond);

			AddJob(Job.Default.WithPlatform(Platform.X64));

			AddDiagnoser(MemoryDiagnoser.Default);
			AddDiagnoser(ThreadingDiagnoser.Default);

			AddLogger(ConsoleLogger.Default);

			//  CsvExporter: Exports benchmark results to a CSV file.
			//	HtmlExporter: Exports benchmark results to an HTML file.
			//	JsonExporter: Exports benchmark results to a JSON file.
			//	MarkdownExporter: Exports benchmark results to a Markdown file.
			//	RPlotExporter: Exports benchmark results as an R script containing a ggplot2 plot of the results.
			//	XmlExporter: Exports benchmark results to an XML file.
		}
	}
}
