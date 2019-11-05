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

namespace CloneSkyPE.Views
{
    /// <summary>
    /// MainPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void lbDetailInfo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://support.skype.com/en/faq/FA34814/why-are-my-skype-contacts-or-credit-missing?lang=ko-KR&p=1433&v=8.53.0.85&e=Desktop&sso=true&intsrc=client-_-windows-_-8.53.0.85-_-.&tcg=e54463bb-902b-4a3a-9d2c-9d30fbf6e91d");
        }

  
        private void txtUserToday_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtUserToday.Text.Trim() == "친구에게 자신의 근황을 알려주세요.")
            {
                txtUserToday.Clear();
            }
        }

        private void txtUserToday_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtUserToday.Text.Trim() == string.Empty)
            {
                txtUserToday.Text = "친구에게 자신의 근황을 알려주세요.";
            }
        }
    }
}
