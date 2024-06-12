using Microsoft.Extensions.Configuration;
using Serilog.Settings.Configuration;
using Serilog;
using Serilog.Core;
using Test_Project_SeriLog;
using System.Diagnostics;

Serilog.Debugging.SelfLog.Enable(x => Debug.WriteLine(x)); // Enable self-logging

Logger fileLogger = new LoggerConfiguration()
	.MinimumLevel.Debug()
	.WriteTo.File(@"D:\serilog.log")
	.CreateLogger();

fileLogger.Debug("This is a test log by Serilog "); // Default Level is already INFO!
fileLogger.Debug($"Today is {DateTime.Now.Date}");


string defaultOutputTemplate = "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}";
Logger consoleLogger = new LoggerConfiguration()
	.MinimumLevel.Debug()
	.WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3} Version:{Version}] {Message:lj}{NewLine}{Exception}") // Version added as part of message
	.Enrich.WithProperty("Version", "1.2.3") // Add custom properties
	.CreateLogger();
	
consoleLogger.Debug("Test console log");

Logger loggerConfiguredByJsonFile = new LoggerConfiguration().ReadFrom.Configuration(UseJsonConfiguration()).CreateLogger();
loggerConfiguredByJsonFile.Information("Test log for json configuration");

//Logger loggerConfiguredByIniFile = new LoggerConfiguration()
//	.ReadFrom.Configuration(UseIniConfiguration())
//	.CreateLogger();
//loggerConfiguredByIniFile.Information("Test log for ini configuration");


//Logger loggerConfiguredByYamlFile = new LoggerConfiguration()
//	.ReadFrom.Configuration(UseYamlConfiguration())
//	.CreateLogger();
//loggerConfiguredByYamlFile.Debug("Test log for yaml configuration");

Logger loggerConfiguredByXmlFile = new LoggerConfiguration().ReadFrom.Configuration(UseXmlConfiguration()).CreateLogger();
loggerConfiguredByXmlFile.Information("Test log for xml configuration"); // No logs :((

Log.CloseAndFlush();


//// Configuraton by config file
static IConfigurationRoot UseJsonConfiguration()
{
	IConfigurationRoot configuration = new ConfigurationBuilder()
		.SetBasePath(Directory.GetCurrentDirectory())
		.AddJsonFile("serilog_configuration.json")
		.Build();

	return configuration;
}

static IConfigurationRoot UseIniConfiguration()
{
	IConfigurationRoot configuration = new ConfigurationBuilder()
		.AddIniFile("serilog_configuration.ini")
		.Build();

	return configuration;
}

static IConfigurationRoot UseYamlConfiguration()
{
	IConfigurationRoot configuration = new ConfigurationBuilder()
		.SetBasePath(Directory.GetCurrentDirectory())
		.AddYamlFile("serilog_configuration.yaml")
		.Build();

	return configuration;
}

static IConfigurationRoot UseXmlConfiguration()
{
	IConfigurationRoot configuration = new ConfigurationBuilder()
		.SetBasePath(Directory.GetCurrentDirectory())
		.AddXmlFile("serilog_configuration.xml")
		.Build();

	return configuration;
}