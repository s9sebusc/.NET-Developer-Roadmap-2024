using Adapter.Adapter;
using Adapter.Target;

// Using Word adapter
IDocument wordDocumentAdapter = new WordDocumentAdapter();
wordDocumentAdapter.ReadDocument(@"C:\test.doc");
wordDocumentAdapter.EditDocument();

// Using PDF adapter
IDocument pdfDocumentAdapter = new PdfDocumentAdapter();
pdfDocumentAdapter.ReadDocument(@"C:\test.pdf");
pdfDocumentAdapter.EditDocument();

