using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FreeCell_Project.Model;

namespace FreeCell_Project
{
    public partial class NotificationWindow : Form
    {
        //Attributes
        private AppController appCon;

        //Contructors
        public NotificationWindow()
        {
            InitializeComponent();
        }

        //Metods
        public void refreshData()
        {
            cbx100.Checked = this.appCon.A100.Active;
            cbx80.Checked = this.appCon.A80.Active;
            cbx40.Checked = this.appCon.A40.Active;
            spnMinutes.Value = this.appCon.A100.Interval;
        }

        //Listeners
        private void button1_Click(object sender, EventArgs e)
        {
            Notification notif100 = new Notification("notif100", cbx100.Checked, (int)spnMinutes.Value);
            Notification notif80 = new Notification("notif80", cbx80.Checked, 0);
            Notification notif40 = new Notification("notif40", cbx40.Checked, 0);

            appCon.NotifDB.save(notif100);
            appCon.NotifDB.save(notif80);
            appCon.NotifDB.save(notif40);

            appCon.NotifDB.reload();

            appCon.refreshNotifications();

            this.Close();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Getters && Setters
        internal AppController AppCon
        {
            get { return appCon; }
            set { appCon = value; }
        }

    }
}