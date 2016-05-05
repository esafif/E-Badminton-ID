using System;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace E_Badminton_ID
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TeknikBadminton : Page
    {
        public TeknikBadminton()
        {
            this.InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (forehandservice.IsSelected)
            {
                Layout.Navigate(typeof(Forehandservice));
                
            }
            else if(footwork.IsSelected){
                Layout.Navigate(typeof(Footwork));
            }
            else if (backhandservice.IsSelected)
            {
                Layout.Navigate(typeof(Backhandservice));
            }
            else if (forehand.IsSelected)
            {
                Layout.Navigate(typeof(Forehand));
            }
            else if (backhand.IsSelected)
            {
                Layout.Navigate(typeof(backhand));
            }
            else if (lop.IsSelected)
            {
                Layout.Navigate(typeof(lob));
            }
            else if (netting.IsSelected)
            {
                Layout.Navigate(typeof(netting));
            }
            else if (drive.IsSelected)
            {
                Layout.Navigate(typeof(drive));
            }
            else if (dropshot.IsSelected)
            {
                Layout.Navigate(typeof(Dropshot));
            }
            else if (smash.IsSelected)
            {
                Layout.Navigate(typeof(smash));
            }
        }
    }
}
