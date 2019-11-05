using CloneSkyPE.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace CloneSkyPE
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void linkSupport_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://support.skype.com/en/faq/FA10038/troubleshooting-problems-signing-into-skype?setlang=ko-KR&lang=ko&p=1433&v=8.53.0.85&e=Desktop");
        }

        private void linkLicense_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://www.microsoft.com/ko-kr/servicesagreement/");
        }

        private void linkcookie_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://privacy.microsoft.com/ko-kr/privacysupplement");
        }

        private void spUserName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Hide();

            MasterWindow master = new MasterWindow();
            master.Show();
        }
    }
}
