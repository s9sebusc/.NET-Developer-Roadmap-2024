using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Target;

namespace Adapter.Adapter
{
    internal class WordDocumentAdapter : IDocument
    {
        private readonly WordDocument wordDocument;

        public WordDocumentAdapter()
        {
            wordDocument = new WordDocument();
        }

        public void EditDocument()
        {
            wordDocument.EditWord();
        }

        public string ReadDocument(string filePath)
        {
            return wordDocument.ReadWord(filePath);
        }
    }
}
