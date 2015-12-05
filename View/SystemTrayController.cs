using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using FreeCell_Project.Model;

namespace FreeCell_Project.View
{
    class SystemTrayController
    {
        private AppController appCon;

        private IContainer components;
        private NotifyIcon notifyIcon1;
        private ContextMenu contextMenu1;
        private MenuItem menuItem1;
        private MenuItem menuItem2;
        private MenuItem menuItem3;

        public SystemTrayController(AppController appCon)
        {
            this.appCon = appCon;

            CreateNotifyicon();
        }

        private void CreateNotifyicon()
        {
            this.components = new Container();
            this.contextMenu1 = new ContextMenu();
            

            // Initialize menuItem1
            this.menuItem1 = new MenuItem();
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "FreeCell Project";
            this.menuItem1.Click += new EventHandler(this.showMainWindow);

            // Initialize menuItem2 (Show notification)
            this.menuItem2 = new MenuItem();
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Notificationes";
            this.menuItem2.Click += new EventHandler(this.showNotifications);

            // Initialize menuItem3 (Close)
            this.menuItem3 = new MenuItem();
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "Salir";
            this.menuItem3.Click += new EventHandler(this.exitApplication);

            // Initialize contextMenu1
            this.contextMenu1.MenuItems.AddRange(new MenuItem[] { this.menuItem1 });
            this.contextMenu1.MenuItems.Add("-");
            this.contextMenu1.MenuItems.AddRange(new MenuItem[] { this.menuItem2 });
            this.contextMenu1.MenuItems.AddRange(new MenuItem[] { this.menuItem3 });

            // Create the NotifyIcon.
            this.notifyIcon1 = new NotifyIcon(this.components);

            // The Icon property sets the icon that will appear
            // in the systray for this application.
            notifyIcon1.Icon = new Icon("favicon.ico");

            // The ContextMenu property sets the menu that will
            // appear when the systray icon is right clicked.
            notifyIcon1.ContextMenu = this.contextMenu1;

            // The Text property sets the text that will be displayed,
            // in a tooltip, when the mouse hovers over the systray icon.
            notifyIcon1.Text = "FreeCell Project";
            notifyIcon1.Visible = true;

            // Handle the Click event to activate the form.
            notifyIcon1.Click += new System.EventHandler(this.showMainWindow);

        }

        //Mthods
        public void showNotification(int time, String title, String mess, ToolTipIcon icon)
        {
            notifyIcon1.ShowBalloonTip(time, title, mess, icon);
        }

        public void showWarningNotification(int time, String title, String mess)
        {
            notifyIcon1.ShowBalloonTip(time, title, mess, ToolTipIcon.Warning);
        }

        public void showErrorNotification(int time, String title, String mess)
        {
            notifyIcon1.ShowBalloonTip(time, title, mess, ToolTipIcon.Error);
        }

        //Listeners
        private void showMainWindow(object Sender, EventArgs e)
        {
            appCon.MainWindow.setVisible(true);
        }

        private void showNotifications(object Sender, EventArgs e)
        {
            this.appCon.createNotificationWindow();
        }

        private void exitApplication(object Sender, EventArgs e)
        {
            this.appCon.closeApplication();
        }
    }
}
