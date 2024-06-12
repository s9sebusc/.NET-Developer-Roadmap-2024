
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Logging.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;

ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
configurationBuilder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
IConfigurationRoot configuration = configurationBuilder.Build();

using ILoggerFactory loggerFactory = LoggerFactory.Create(x =>
{
	x.AddConfiguration(configuration.GetSection("Logging"));
	x.AddConsole();
});


ILogger logger = loggerFactory.CreateLogger("My_MS_Logger");
logger.LogInformation("Hello World!");
logger.LogInformation("Logs contain timestamp and log level.");
logger.LogInformation("Each log message is fit in a single line.");
logger.LogError("Error");
logger.LogDebug("Debug");
logger.LogWarning("Warning");
logger.LogCritical("Critical");

///// Output. The [0] is the event ID
//14:48:19 info: My_MS_Logger[0] Hello World!
//14:48:19 info: My_MS_Logger[0] Logs contain timestamp and log level.
//14:48:19 info: My_MS_Logger[0] Each log message is fit in a single line.
//14:48:19 fail: My_MS_Logger[0] Error
//14:48:19 dbug: My_MS_Logger[0] Debug
//14:48:19 warn: My_MS_Logger[0] Warning
//14:48:19 crit: My_MS_Logger[0] Critical


////// direct configuration without json config file
//Action<SimpleConsoleFormatterOptions> consoleOptions = options =>
//{
//	options.IncludeScopes = true;
//	options.SingleLine = true;
//	options.TimestampFormat = "HH:mm:ss ";
//	options.ColorBehavior = LoggerColorBehavior.Enabled;
//};
