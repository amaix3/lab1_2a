using System; 

namespace Lab_9
{
    public class OutOfInkEventArgs : PrinterEventArgs
    {
        public OutOfInkEventArgs(string inkColor, int page) : base(page)
        {
            InkColor = inkColor;
            
        }

        public string InkColor { get; set; }
        public int Page { get; set; }
    }
}