using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Management;
using FreeCell_Project.View;
using FreeCell_Project.DB;

namespace FreeCell_Project.Model
{
    class AppController
    {
        //Atributes
        private App main;

        private MainWindow mainWindow;
        private SystemTrayController stCon;

        private NotificationsDB notifDB;

        private Notification a100;
        private Notification a80;
        private Notification a40;

        private Boolean avis80;
        private Boolean avis40;
        private DateTime time100;

        //Contructors
        public AppController(App main)
        {
            this.main = main;

            this.mainWindow = new MainWindow();
            this.mainWindow.AppCon = this;

            this.stCon = new SystemTrayController(this);

            this.notifDB = new NotificationsDB();

            this.avis80 = false;
            this.avis40 = false;
            this.time100 = new DateTime(2000, 1, 1, 20, 0, 0);

            this.refreshNotifications();

            //Extableixo valors per la primera execucio del programa
            if (a100 == null)
            {
                a100 = new Notification("notif100", true, 5);
                notifDB.save(a100);
            }
            if (a80 == null)
            {
                a80 = new Notification("notif80", true, 0);
                notifDB.save(a80);
            }
            if (a40 == null) 
            {
                a40 = new Notification("notif40", true, 0);
                notifDB.save(a40);
            }

            EasyTimer.setInterval(batteryNotifications, 5 * 1000);

            mainWindow.Show();
        }

        //Metodes
        public void refreshNotifications()
        {
            this.a100 = notifDB.find(new Notification("notif100"));
            this.a80 = notifDB.find(new Notification("notif80"));
            this.a40 = notifDB.find(new Notification("notif40"));
        }

        public void batteryNotifications()
        {
            //Si hi ha una bateria conectada
            if (BatteryController.isBatteryConnected())
            {
                if (this.a100.Active && 
                    BatteryController.is100Perc() &&
                    BatteryController.getBatteryStatus() == BatteryController.Online && 
                    ((DateTime.Now.Subtract(this.time100)).TotalMinutes) > a100.Interval)
                {
                    stCon.showWarningNotification(0, "Bateria Cargada Completamente", "Para alargar la vida util de su bateria le recomendamos retirar inmediatamente el cargador al alcanzar 100% de la carga.");

                    this.time100 = DateTime.Now;
                    this.avis80 = true;
                }
                else if (this.a80.Active && 
                    BatteryController.isMorePerc(80) &&
                    BatteryController.getBatteryStatus() == BatteryController.Online && 
                    !this.avis80 && !BatteryController.is100Perc())
                {
                    stCon.showWarningNotification(0, "Bateria Cargada", "Para alargar la vida util de su bateria le recomendamos retirar el cargador al alcanzar el 80% de la carga.");
                        
                    this.avis80 = true;
                }
                else if (this.a40.Active && 
                    BatteryController.isLessPerc(40) &&
                    BatteryController.getBatteryStatus() == BatteryController.Offline && 
                    !this.avis40)
                {
                    stCon.showWarningNotification(0, "Conecte el cargador", "Para alargar la vida util de su bateria le recomendamos conectar el cargador al alcanzar una carga menor al 40%.");
                        
                    this.avis40 = true;
                }

                //Reestabliment de valors
                if (BatteryController.isMorePerc(40))
                {
                    this.avis40 = false;
                }

                if (BatteryController.isLessPerc(80))
                {
                    this.avis80 = false;
                }
            }

        }

        public void createNotificationWindow()
        {
            NotificationWindow notifWIndow = new NotificationWindow();
            notifWIndow.AppCon = this;
            notifWIndow.refreshData();
            notifWIndow.ShowDialog();
        }

        public void closeApplication()
        {
            notifDB.closeDBConnection();

            this.main.stopApplication();
        }

        //Getters && Setters
        internal Notification A100
        {
            get { return a100; }
            set { a100 = value; }
        }

        internal Notification A80
        {
            get { return a80; }
            set { a80 = value; }
        }

        internal Notification A40
        {
            get { return a40; }
            set { a40 = value; }
        }
        internal NotificationsDB NotifDB
        {
            get { return notifDB; }
            set { notifDB = value; }
        }

        public MainWindow MainWindow
        {
            get { return mainWindow; }
            set { mainWindow = value; }
        }
        
    }
}
