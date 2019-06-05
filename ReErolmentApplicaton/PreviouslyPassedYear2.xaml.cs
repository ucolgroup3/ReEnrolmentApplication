using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ReErolmentApplicaton
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PreviouslyPassedYear2 : Page
    {
        public Brush BackColor { get; set; } = new SolidColorBrush(Windows.UI.Colors.Red);

        public PreviouslyPassedYear2()
        {
            this.InitializeComponent();
        }
        // If next button is clicked this runs and goes through if statements to make sure Textboxs are not null.
        private void BtnNextPreviouslyPassedPapers_Click(object sender, RoutedEventArgs e)
        {
            // If statement to make sure the text box (ID) is not null.
            // Adds Data from the text box to the database.
            if (TxtID != null && !string.IsNullOrWhiteSpace(TxtFirstName.Text))
            {
                // If statement to make sure the text box (First Name) is not null.
                // Adds Data from the text box to the database.
                if (TxtFirstName != null && !string.IsNullOrWhiteSpace(TxtFirstName.Text))
                {
                    // If statement to make sure the text box (surname) is not null.
                    // Adds Data from the text box to the database.
                    if (TxtSurname != null && !string.IsNullOrWhiteSpace(TxtSurname.Text))
                    {
                        // If statement to make sure the text box (Email) is not null.
                        // Adds Data from the text box to the database.
                        if (TxtEmail != null && !string.IsNullOrWhiteSpace(TxtEmail.Text))
                        {
                            //If statement making sure one of the Radio buttons are check if Februrary Intake isnt checked it moves to the else statement.
                            // Adds Data from the text box to the database.
                            if (FebIntake.IsChecked == true)

                            {
                                // moves you to the next pivot (Previosly passed papers).
                                rootPivot.SelectedIndex += 1;
                            }
                            //This is to check if the July Intake radio button is check if not a dialog box is shown if so.
                            //Data is sent to the Database.
                            else
                            {
                                // moves you to the next pivot (Previosly passed papers).
                                if (JulyIntake.IsChecked == true)
                                {
                                    rootPivot.SelectedIndex += 1;
                                }
                                else
                                {
                                    //Display Error Message as dialog box.
                                    DisplayNoSelectedRadio();
                                }
                            }
                        }
                        else
                        {
                            //Display Error Message as dialog box.
                            DisplayNoEmail();
                        }
                    }
                    else
                    {
                        //Display Error Message as dialog box.
                        DisplayNoSurname();
                    }

                }
                else
                {
                    //Display Error Message as dialog box.
                    DisplayNoFirstName();
                }
            }
            else
            {
                //Display Error Message as dialog box.
                DisplayNoId();
            }
        }
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            //cancel removes everything from the form and takes you back to the start.
            this.Frame.Navigate(typeof(MainPage));
        }
        //Simple on click radio button calls that make the text bold and on selection will add it to the database.
        private void D101Check(object sender, RoutedEventArgs e)
        {
            ChkD101.FontWeight = Windows.UI.Text.FontWeights.ExtraBlack;
        }
        //on unclick radio button calls that make the text bold and on selection will remove it to the database. 
        // code below is the same for all of the other check boxes.
        private void D101UnCheck(object sender, RoutedEventArgs e)
        {
            ChkD101.FontWeight = Windows.UI.Text.FontWeights.Normal;
        }
        //Repeted Code.
        private void D111Check(object sender, RoutedEventArgs e)
        {
            ChkD111.FontWeight = Windows.UI.Text.FontWeights.ExtraBlack;
        }
        private void D111UnCheck(object sender, RoutedEventArgs e)
        {
            ChkD111.FontWeight = Windows.UI.Text.FontWeights.Normal;
        }
        //Repeted Code.
        private void I101Check(object sender, RoutedEventArgs e)
        {
            ChkI101.FontWeight = Windows.UI.Text.FontWeights.ExtraBlack;
        }
        private void I101UnCheck(object sender, RoutedEventArgs e)
        {
            ChkI101.FontWeight = Windows.UI.Text.FontWeights.Normal;
        }
        //Repeted Code.
        private void I102Check(object sender, RoutedEventArgs e)
        {
            ChkI102.FontWeight = Windows.UI.Text.FontWeights.ExtraBlack;
        }
        private void I102UnCheck(object sender, RoutedEventArgs e)
        {
            ChkI102.FontWeight = Windows.UI.Text.FontWeights.Normal;
        }
        //Repeted Code.
        private void T101Check(object sender, RoutedEventArgs e)
        {
            ChkT101.FontWeight = Windows.UI.Text.FontWeights.ExtraBlack;
        }
        private void T101UnCheck(object sender, RoutedEventArgs e)
        {
            ChkT101.FontWeight = Windows.UI.Text.FontWeights.Normal;
        }
        //Repeted Code.
        private void T111Check(object sender, RoutedEventArgs e)
        {
            ChkT111.FontWeight = Windows.UI.Text.FontWeights.ExtraBlack;
        }
        private void T111UnCheck(object sender, RoutedEventArgs e)
        {
            ChkT111.FontWeight = Windows.UI.Text.FontWeights.Normal;
        }
        //Repeted Code.
        private void I111Check(object sender, RoutedEventArgs e)
        {
            ChkI111.FontWeight = Windows.UI.Text.FontWeights.ExtraBlack;
        }
        private void I111UnCheck(object sender, RoutedEventArgs e)
        {
            ChkI111.FontWeight = Windows.UI.Text.FontWeights.Normal;
        }
        //Repeted Code.
        private void I121Check(object sender, RoutedEventArgs e)
        {
            ChkI121.FontWeight = Windows.UI.Text.FontWeights.ExtraBlack;
        }
        private void I121UnCheck(object sender, RoutedEventArgs e)
        {
            ChkI121.FontWeight = Windows.UI.Text.FontWeights.Normal;
        }



        private void BtnSelect_UnClick(object sender, RoutedEventArgs e)
        {
            //Select button which changes all checkboxes below.
            ChkD101.IsChecked = true;
            ChkD111.IsChecked = true;
            ChkI101.IsChecked = true;
            ChkI102.IsChecked = true;
            ChkI111.IsChecked = true;
            ChkI121.IsChecked = true;
            ChkD101.IsChecked = true;
            ChkT101.IsChecked = true;
            ChkT111.IsChecked = true;
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            //Unselected button which changes all checkboxes below.
            ChkD101.IsChecked = false;
            ChkD111.IsChecked = false;
            ChkI101.IsChecked = false;
            ChkI102.IsChecked = false;
            ChkI111.IsChecked = false;
            ChkI121.IsChecked = false;
            ChkD101.IsChecked = false;
            ChkT101.IsChecked = false;
            ChkT111.IsChecked = false;
        }
        private void BtnNextMajor_Click(object sender, RoutedEventArgs e)
        {
            //Button call with an if statement to move the pivot accros to the next page or pivot point
            if (rootPivot.SelectedIndex < rootPivot.Items.Count - 1)
                {
                    // If not at the last item, go to the next one.
                    rootPivot.SelectedIndex += 1;
                }
                else
                {
                    // The last PivotItem is selected, so loop around to the first item.
                    rootPivot.SelectedIndex = 0;
                }
            }         
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            //takes you back to the main page but also saves everything to  the database for  next time.
            this.Frame.Navigate(typeof(MainPage));
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void BtnUnendorsed_Click(object sender, RoutedEventArgs e)
        {
            //Unendorsed does the same as the next button but will add Unendorsed to the database.
            //Button call with an if statement to move the pivot accros to the next page or pivot point
            if (rootPivot.SelectedIndex < rootPivot.Items.Count - 1)
            {
                // If not at the last item, go to the next one.
                rootPivot.SelectedIndex += 1;
            }
            else
            {
                // The last PivotItem is selected, so loop around to the first item.
                rootPivot.SelectedIndex = 0;
            }
        }

        private void BtnNextEnrolment_Click(object sender, RoutedEventArgs e)
        {
            //Button call with an if statement to move the pivot accros to the next page or pivot point
            if (rootPivot.SelectedIndex < rootPivot.Items.Count - 1)
            {
                // If not at the last item, go to the next one.
                rootPivot.SelectedIndex += 1;
            }
            else
            {
                // The last PivotItem is selected, so loop around to the first item.
                rootPivot.SelectedIndex = 0;
            }
        }


        //Simple Dialong box to display When you have not enter in anything for the ID field.
        private async void DisplayNoId()
        {
            ContentDialog NoIdDialog = new ContentDialog
            {
                //Explaintion of the content in the dialog box, these can be changed based on needs.
                Title = "No Student ID",
                Content = "Check And Enter Your ID.",
                CloseButtonText = "Close"
            };
            //Displays The Dialog box above
            ContentDialogResult result = await NoIdDialog.ShowAsync();
        }
        //Simple Dialong box to display When you have not enter in anything for the Surname field.
        private async void DisplayNoSurname()
        {
            ContentDialog NoSurnameDialog = new ContentDialog
            {
                //Explaintion of the content in the dialog box, these can be changed based on needs.
                Title = "No Surname",
                Content = "Check And Enter Your Last Name.",
                CloseButtonText = "Close"
            };
            //Displays The Dialog box above
            ContentDialogResult result = await NoSurnameDialog.ShowAsync();
        }
        //Simple Dialong box to display When you have not enter in anything for the First Name field.
        private async void DisplayNoFirstName()
        {
            ContentDialog NoFirstNameDialog = new ContentDialog
            {
                //Explaintion of the content in the dialog box, these can be changed based on needs.
                Title = "No First Name",
                Content = "Check And Enter Your Name.",
                CloseButtonText = "Close"
            }; 
            //Displays The Dialog box above
            ContentDialogResult result = await NoFirstNameDialog.ShowAsync();
        }
        //Simple Dialong box to display When you have not enter in anything for the Email field.
        private async void DisplayNoEmail()
        {
            //Explaintion of the content in the dialog box, these can be changed based on needs.
            ContentDialog NoEmailDialog = new ContentDialog
            {
                Title = "No Email",
                Content = "Check And Enter Your Email.",
                CloseButtonText = "Close"
            };
            //Displays The Dialog box above
            ContentDialogResult result = await NoEmailDialog.ShowAsync();
        }
        //Simple Dialong box to display When you have not Select a radio button.
        private async void DisplayNoSelectedRadio()
        {
            ContentDialog NoSelectedRadioDialog = new ContentDialog
            {
                //Explaintion of the content in the dialog box, these can be changed based on needs.
                Title = "No Year Intake Selection",
                Content = "Check And Select Your Year Intake.",
                CloseButtonText = "Close"
            };
            //Displays The Dialog box above
            ContentDialogResult result = await NoSelectedRadioDialog.ShowAsync();
        }


    }
}

