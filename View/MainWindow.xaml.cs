using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Management;
using System.ComponentModel;
using System.ComponentModel;
using FreeCell_Project.Model;

namespace FreeCell_Project
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Atributes
        private AppController appCon;
        private Boolean isConected;

        //Contructor
        public MainWindow()
        {
            InitializeComponent();

            this.Closing += new CancelEventHandler(MainWindow_Closing);

            this.isConected = BatteryController.isBatteryConnected();
            refreshWindow(null, null);

            System.Windows.Forms.Timer MyTimer = new System.Windows.Forms.Timer();
            MyTimer.Interval = (5 * 1000);
            MyTimer.Tick += new EventHandler(refreshWindow);
            MyTimer.Start();
        }

        //Methods
        private void refreshWindow(object sender, EventArgs e)
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += bw_DoWork;
            bw.RunWorkerAsync();

            //Si no hi ha una bateria conectada
            if (!this.isConected)
            {
                pbrCharge.Value = 0;
                lblCarga.Content = 0 + "%";
                lblEstado.Content = "Sin bateria";
            }
            else
            {
                pbrCharge.Value = BatteryController.getBatteryPercent();
                lblCarga.Content = BatteryController.getBatteryPercent() + "%";

                switch (BatteryController.getBatteryStatus())
                {
                    case System.Windows.Forms.PowerLineStatus.Online:
                        lblEstado.Content = "Cargando...";
                        break;
                    case System.Windows.Forms.PowerLineStatus.Offline:
                        lblEstado.Content = "Descargando...";
                        break;
                    default:
                        lblEstado.Content = "Desconocido";
                        break;
                }
            }
        }

        public void setVisible(Boolean action)
        {
            if (action) this.Show();
            else this.Hide();

        }

        public void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            this.isConected = BatteryController.isBatteryConnected();
        }

        //Listeners
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;

            this.setVisible(false);
        }

        private void Button_Click(object sender, RoutedEventArgs e) 
        {
            appCon.createNotificationWindow();
        }

        //Getters && Setters
        internal AppController AppCon
        {
            get { return appCon; }
            set { appCon = value; }
        }

    }

}
