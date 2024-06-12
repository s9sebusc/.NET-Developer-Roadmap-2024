// See https://aka.ms/new-console-template for more information

using NLog;

Logger log = LogManager.GetCurrentClassLogger();
log.Info("This is a debug level message");

Logger consoleLogger = LogManager.GetLogger("MyConsoleLogger");
consoleLogger.Debug("Test log writte by console logger");

Logger logFileLogger = LogManager.GetLogger("MyLogfileLogger");
logFileLogger.Info("Test log written by log file logger");
logFileLogger.Error("Error log written by log file logger");

Console.ReadKey();
