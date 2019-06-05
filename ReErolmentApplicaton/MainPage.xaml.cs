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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ReErolmentApplicaton
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
        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {

            //Simple If statement tha checks if radio button Year Two is checked if so it moves the corresponding Page depending on the year selected.
            if (RadYearTwo.IsChecked == false)
            {
                //Moves through the navigation to the next page.
                this.Frame.Navigate(typeof(PreviouslyPassedYear3));
            }
            else
            {
                //Moves through the navigation to the next page.
                this.Frame.Navigate(typeof(PreviouslyPassedYear2));
            }

        }
    }
}
