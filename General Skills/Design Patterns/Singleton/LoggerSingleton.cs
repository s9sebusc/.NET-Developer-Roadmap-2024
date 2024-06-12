using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	public class LoggerSingleton
	{
        private static LoggerSingleton instance;

        private LoggerSingleton()
        {
            // Instantiation not possible
        }

        public static LoggerSingleton GetInstance()
        {
            if(instance == null)
            {
                instance = new LoggerSingleton();
                return instance;
            }

            return instance;
        }
    }
}
