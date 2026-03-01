using MoleculAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MoleculSimFacade
{
    /// <summary>
    /// Логика взаимодействия для LogWindow.xaml
    /// </summary>
    public partial class LogWindow : Window
    {
        public LogWindow()
        {
            InitializeComponent();
        }

        private void SendLog(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient() {BaseAddress = new("http://localhost:59324") };
            LogDTO log = new LogDTO();
            //lock
            log.LogText = LogBox.Text;
            client.PostAsync("api/Log", JsonContent.Create(log));
            this.Close();
        }
    }
}
