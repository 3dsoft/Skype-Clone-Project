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
using System.Windows.Shapes;

namespace CloneSkyPE.Views
{
    /// <summary>
    /// MasterWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MasterWindow : Window
    {
        public MasterWindow()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void menu0_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new MainPage());
        }

        private void menu1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            menuFrame.Navigate(new menuChat());
        }

        private void menu2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            menuFrame.Navigate(new menuCall());
        }

        private void menu3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            menuFrame.Navigate(new menuDictionary());
        }

        private void menu4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            menuFrame.Navigate(new menuAlarm());
        }

        
    }
}
