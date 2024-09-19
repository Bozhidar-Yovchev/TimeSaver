using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArriveTime
{
    class Program
    {
        static string Arrive(int hour, int minutes, int arrivehour, int arriveminutes)
        {
            if (hour == arrivehour)
            {
                if (minutes == arriveminutes)
                {
                    return "On time";
                }
            }
            if (hour <= arrivehour)
            {

                if (arrivehour - hour == 0)
                {
                    if (arriveminutes - minutes > 0)
                    {
                        return $"Late. {arriveminutes - minutes} minutes after the start";
                    }
                    else { return $"Late. {arrivehour - hour} hour and {arriveminutes - minutes} minutes after the start"; }

                }
                else { return $"Late. {arrivehour - hour} hour and {arriveminutes - minutes} minutes after the start"; }
            }
            if (hour > arrivehour)
            {

                return $"Early. {hour - arrivehour} hour and {minutes - arriveminutes} minutes before the start";
            }
            return default;
        }
        static void Main(string[] args)
        {

            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int arrivehour = int.Parse(Console.ReadLine());
            int arriveminutes = int.Parse(Console.ReadLine());

            Console.WriteLine(Arrive(hour, minutes, arrivehour, arriveminutes));


        }
    }
}
