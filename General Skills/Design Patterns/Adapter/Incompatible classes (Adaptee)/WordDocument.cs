using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	internal class WordDocument
	{
		public void EditWord()
		{
		}

		public string ReadWord(string filePath)
		{
			return "Content of word document";
		}
	}
}
