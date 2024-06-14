using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DependencyInjection_Test.Services
{
	internal class MessageBoxService : IMessageBoxService
	{
		public void ShowInfoMessageBox(string caption, string message)
		{
			MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
