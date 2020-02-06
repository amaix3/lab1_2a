using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_nr2_v1
{
    public class Panel
    {
        public event EventHandler UP;
        public event EventHandler DOWN;
        public event EventHandler LEFT;
        public event EventHandler RIGHT;

        static void c_ThresholdReached(object UP, EventArgs e)
        {
            
        }
    }
}
