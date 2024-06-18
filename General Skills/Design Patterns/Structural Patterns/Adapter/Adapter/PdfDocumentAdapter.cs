using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Target;

namespace Adapter.Adapter
{
    internal class PdfDocumentAdapter : IDocument
    {
        private readonly PdfDocument wordDocument;

        public PdfDocumentAdapter()
        {
            wordDocument = new PdfDocument();
        }

        public void EditDocument()
        {
            wordDocument.EditPdf();
        }

        public string ReadDocument(string filePath)
        {
            return wordDocument.ReadPdf(filePath);
        }
    }
}
