using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    public class AlarmEventConsumer
    {
        private string name;

        public AlarmEventConsumer(string name)
        {
            this.name = name;
        }
        public void AlarmRang(object sender, AlarmEventArgs e)
        {
            Console.WriteLine(name+ " was called with "+e.Text);
        }
    }
}
