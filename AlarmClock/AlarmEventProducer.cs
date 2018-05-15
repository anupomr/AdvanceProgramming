using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    public class AlarmEventProducer
    {
        public event AlarmEventHandler Alarm;

        protected virtual void OnAlarm(AlarmEventArgs e)
        {
            //the following it not needed, it just focuses on the name of the delegate
            AlarmEventHandler handler = Alarm;

            //only invoke the handler if it is initialize
            if (handler != null)
                handler(this, e);


        }
        public void RunAlarm()
        {
            int count = 1;
            while (count <= 12)
            {
                System.Threading.Thread.Sleep(1000);
                //this raises the event
                OnAlarm(new AlarmEventArgs(count++.ToString() + " o'clock"));
            }

        }
    }
}
