using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    public delegate void AlarmEventHandler(object sender, AlarmEventArgs e);
    class Program
    {
        static void Main(string[] args)
        {
            //the event source/producer
            AlarmEventProducer producer = new AlarmEventProducer();

            //event listener/consumer
            AlarmEventConsumer naren = new AlarmEventConsumer("Narendra");
            AlarmEventConsumer arben = new AlarmEventConsumer("Arben");
            AlarmEventConsumer ilia = new AlarmEventConsumer("Ilia");

            //wire up the listener
            producer.Alarm += new AlarmEventHandler(naren.AlarmRang);
            producer.Alarm += new AlarmEventHandler(arben.AlarmRang);
            producer.Alarm += new AlarmEventHandler(ilia.AlarmRang);
            //uses an anonymous Consumer object
            producer.Alarm += new AlarmEventHandler(new AlarmEventConsumer("Yin Li").AlarmRang);

            //uses a lambda expression
            producer.Alarm += new AlarmEventHandler((sender, e) => Console.WriteLine("Lamdba expression was called with " + e.Text));

            //start the clock
            producer.RunAlarm();

        }
    }
}
