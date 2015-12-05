using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace FreeCell_Project.Model
{
    class BatteryController
    {
        public static PowerLineStatus Online = System.Windows.Forms.PowerLineStatus.Online;
        public static PowerLineStatus Offline = System.Windows.Forms.PowerLineStatus.Offline;

        private static PowerStatus getPowerStatus()
        {
            return SystemInformation.PowerStatus;
        }

        public static Boolean isMorePerc(int num)
        {
            int perc = (int)(getPowerStatus().BatteryLifePercent * 100);
            return perc >= num;
        }

        public static Boolean isLessPerc(int num)
        {
            int perc = (int)(getPowerStatus().BatteryLifePercent * 100);
            return perc < num;
        }

        public static Boolean is100Perc()
        {
            int perc = (int)(getPowerStatus().BatteryLifePercent * 100);
            return perc == 100;
        }

        public static int getBatteryPercent()
        {
            return (int)(getPowerStatus().BatteryLifePercent * 100);
        }

        public static PowerLineStatus getBatteryStatus()
        {
            return getPowerStatus().PowerLineStatus;
        }

        public static Boolean isBatteryConnected()
        {
            System.Management.ObjectQuery query = new ObjectQuery("Select * FROM Win32_Battery");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

            ManagementObjectCollection collection = searcher.Get();

            return collection.Count != 0;
        }
    }
}
