using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DependencyInjection_Test.Services
{
	internal interface IMessageBoxService
	{
		void ShowInfoMessageBox(string caption, string message);
	}
}
