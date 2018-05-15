using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    public class AlarmEventArgs
    {
        public string Text { get; private set; }
        public AlarmEventArgs(string text)
        {
            Text = text;
        }
    }
}
