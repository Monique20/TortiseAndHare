using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    public class TortiseAndHareRace
    {
        public string StartRace(int speed1, int speed2, int distance, int sleep, int getup)
        {
            var fallAsleepTime = GetFallAsleepTime(speed1, sleep);
            var wakeUpTime = GetWakeUpTime(speed2, distance, getup);
            int totalSleepTime = GetTotalSleepTime(fallAsleepTime, wakeUpTime);

            int tortoiseRunTime = GetTortiseRunTime(speed2, distance);
            int hareRunTime = GetHareRunTime(speed1, distance, totalSleepTime);

            if (TortiseRunTimeGreaterThanHareRunTime(tortoiseRunTime, hareRunTime))
            {
                return "The hare won the race. The hare is sleeping for " + totalSleepTime + " minutes.";
            }
            if (HareRunTimeGreaterThanTortiseRunTime(tortoiseRunTime, hareRunTime))
            {
                return "The tortoise won the race. The hare is sleeping for " + totalSleepTime + " minutes.";
            }
            return "The hare and the tortoise tied. The hare is sleeping for " + totalSleepTime + " minutes.";
        }

        private static bool HareRunTimeGreaterThanTortiseRunTime(int tortoiseRunTime, int hareRunTime)
        {
            return hareRunTime > tortoiseRunTime;
        }

        private static bool TortiseRunTimeGreaterThanHareRunTime(int tortoiseRanTime, int hareRanTime)
        {
            return tortoiseRanTime > hareRanTime;
        }

        private static int GetHareRunTime(int speed1, int distance, int totalSleepTime)
        {
            return (distance / speed1) + totalSleepTime;
        }

        private static int GetTortiseRunTime(int speed2, int distance)
        {
            return distance / speed2;
        }

        private static int GetTotalSleepTime(int fallAsleepTime, int wakeUpTime)
        {
            return wakeUpTime - fallAsleepTime;
        }

        private static int GetWakeUpTime(int speed2, int distance, int getup)
        {
            return (distance - getup) / speed2;
        }

        private static int GetFallAsleepTime(int speed1, int sleep)
        {
            return sleep / speed1;
        }
    }
}
