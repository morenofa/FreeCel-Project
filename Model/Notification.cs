using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Db4objects.Db4o;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeCell_Project.Model
{
    class Notification
    {
        //Atributes
        private String name;
        private Boolean active;
        private int interval;

        //Contructors
        public Notification(String name)
        {
            this.name = name;
        }

        public Notification(String name, Boolean active, int interval)
        {
            this.name = name;
            this.active = active;
            this.interval = interval;
        }

        //Getters && Setters
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public Boolean Active
        {
            get { return active; }
            set { active = value; }
        }

        public int Interval
        {
            get { return interval; }
            set { interval = value; }
        }
    }
}
