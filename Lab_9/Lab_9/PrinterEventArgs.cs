using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9
{
    public abstract class PrinterEventArgs :EventArgs
    {
        public PrinterEventArgs(int page)
        {
            page = page;
        }
    }
}
