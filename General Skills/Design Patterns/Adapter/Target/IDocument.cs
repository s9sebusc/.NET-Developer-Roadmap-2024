using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Target
{
    internal interface IDocument
    {
        string ReadDocument(string filePath);

        void EditDocument();
    }
}
