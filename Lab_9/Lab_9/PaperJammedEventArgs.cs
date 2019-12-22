using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9
{
    public class PaperJammedEventArgs : PrinterEventArgs
    {
        public PaperJammedEventArgs(int page) : base(page)
        {
        }

        public int Page { get; set; }
    }
}
