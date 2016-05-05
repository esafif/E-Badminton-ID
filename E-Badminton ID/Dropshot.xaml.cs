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
    public sealed partial class Dropshot : Page
    {
        public Dropshot()
        {
            this.InitializeComponent();
            mymedia.Source = new Uri("ms-appx:///Assets/Tutorials/Dropshot.mp4", UriKind.RelativeOrAbsolute);
        }

        private void ls_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (backtotraining.IsSelected)
            {
                this.Frame.Navigate(typeof(TeknikBadminton));
            }
        }
    }
}
