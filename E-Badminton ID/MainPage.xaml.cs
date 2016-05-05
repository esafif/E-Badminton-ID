using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace E_Badminton_ID
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Home.IsSelected)
            {
                this.Frame.Navigate(typeof(MainPage));

            }
            else if (About.IsSelected)
            {
                Layout.Navigate(typeof(AboutPage));
                TitleTextBlock.Text = "About";
            }
            else if (Exit.IsSelected)
            {
                Application.Current.Exit();
            }
        }
        
  
        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (menu1.IsSelected)
            {
                Layout.Navigate(typeof(Sejarah));
                TitleTextBlock.Text = "Pengertian Dan Sejarah";
            }
            else if (menu2.IsSelected)
            {
                Layout.Navigate(typeof(Peraturan));
                TitleTextBlock.Text = "Peraturan";
            }
            else if (menu3.IsSelected)
            {
                Layout.Navigate(typeof(Pelengkapan));
                TitleTextBlock.Text = "Perlengkapan Badminton";
            }
            else if (menu4.IsSelected)
            {
                Layout.Navigate(typeof(TeknikBadminton));
                TitleTextBlock.Text = "Teknik Dasar Badminton";
            }
        }
    }
}
