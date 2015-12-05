using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using FreeCell_Project.Model;

namespace FreeCell_Project
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        private AppController aCon;

        private void startApplication(object sender, StartupEventArgs e)
        {
            this.aCon = new AppController(this);
        }

        public void stopApplication()
        {
            Application.Current.Shutdown();
        }

    }
}
