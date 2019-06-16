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
    public sealed partial class PreviouslyPassedYear3 : Page



    {
        public PreviouslyPassedYear3()
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
                            else
                            {
                                //This is to check if the July Intake radio button is check if not a dialog box is shown if so.
                                //Data is sent to the Database.
                                if (JulyIntake.IsChecked == true)
                                {
                                    // moves you to the next pivot (Previosly passed papers).
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

        private void I202Check(object sender, RoutedEventArgs e)
        {
            //Simple on click radio button calls that make the text bold and on selection will add it to the database.
            ChkI202.FontWeight = Windows.UI.Text.FontWeights.ExtraBold;
        }

        private void I202UnCheck(object sender, RoutedEventArgs e)
        //on unclick radio button calls that make the text bold and on selection will remove it to the database. 
        // code below is the same for all of the other check boxes.
        {
            ChkI202.FontWeight = Windows.UI.Text.FontWeights.Normal;
        }
        //Repeted Code.
        private void I203Check(object sender, RoutedEventArgs e)
        {
            ChkI203.FontWeight = Windows.UI.Text.FontWeights.ExtraBold;
        }

        private void I203UnCheck(object sender, RoutedEventArgs e)
        {
            ChkI203.FontWeight = Windows.UI.Text.FontWeights.Normal;
        }
        //Repeted Code.
        private void I221Check(object sender, RoutedEventArgs e)
        {
            ChkI221.FontWeight = Windows.UI.Text.FontWeights.ExtraBold;
        }

        private void I221UnCheck(object sender, RoutedEventArgs e)
        {
            ChkI221.FontWeight = Windows.UI.Text.FontWeights.Normal;
        }
        //Repeted Code.
        private void I209Check(object sender, RoutedEventArgs e)
        {
            ChkI209.FontWeight = Windows.UI.Text.FontWeights.ExtraBold;
        }

        private void I209UnCheck(object sender, RoutedEventArgs e)
        {
            ChkI209.FontWeight = Windows.UI.Text.FontWeights.Normal;
        }
        //Repeted Code.
        private void D211Check(object sender, RoutedEventArgs e)
        {
            ChkD211.FontWeight = Windows.UI.Text.FontWeights.ExtraBold;
        }

        private void D211UnCheck(object sender, RoutedEventArgs e)
        {
            ChkD211.FontWeight = Windows.UI.Text.FontWeights.Normal;
        }
        //Repeted Code.
        private void I212Check(object sender, RoutedEventArgs e)
        {
            ChkI212.FontWeight = Windows.UI.Text.FontWeights.ExtraBold;
        }

        private void I212UnCheck(object sender, RoutedEventArgs e)
        {
            ChkI212.FontWeight = Windows.UI.Text.FontWeights.Normal;
        }
        //Repeted Code.
        private void I263Check(object sender, RoutedEventArgs e)
        {
            ChkI263.FontWeight = Windows.UI.Text.FontWeights.ExtraBold;
        }

        private void I263UnCheck(object sender, RoutedEventArgs e)
        {
            ChkI263.FontWeight = Windows.UI.Text.FontWeights.Normal;
        }
        //Repeted Code.
        private void I213Check(object sender, RoutedEventArgs e)
        {
            ChkI213.FontWeight = Windows.UI.Text.FontWeights.ExtraBold;
        }

        private void I213UnCheck(object sender, RoutedEventArgs e)
        {
            ChkI213.FontWeight = Windows.UI.Text.FontWeights.Normal;
        }
        //Repeted Code.
        private void T201Check(object sender, RoutedEventArgs e)
        {
            ChkT201.FontWeight = Windows.UI.Text.FontWeights.ExtraBold;
        }

        private void T201UnCheck(object sender, RoutedEventArgs e)
        {
            ChkT201.FontWeight = Windows.UI.Text.FontWeights.Normal;
        }
        //Repeted Code.
        private void T206Check(object sender, RoutedEventArgs e)
        {
            ChkT206.FontWeight = Windows.UI.Text.FontWeights.ExtraBold;
        }

        private void T206UnCheck(object sender, RoutedEventArgs e)
        {
            ChkT206.FontWeight = Windows.UI.Text.FontWeights.Normal;
        }
        //Repeted Code.
        private void T211Check(object sender, RoutedEventArgs e)
        {
            ChkT211.FontWeight = Windows.UI.Text.FontWeights.ExtraBold;
        }

        private void T211UnCheck(object sender, RoutedEventArgs e)
        {
            ChkT211.FontWeight = Windows.UI.Text.FontWeights.Normal;
        }
        //Repeted Code.
        private void D201Check(object sender, RoutedEventArgs e)
        {
            ChkD201.FontWeight = Windows.UI.Text.FontWeights.ExtraBold;
        }

        private void D201UnCheck(object sender, RoutedEventArgs e)
        {
            ChkD201.FontWeight = Windows.UI.Text.FontWeights.Normal;
        }

        private void BtnSelect_UnClick(object sender, RoutedEventArgs e)
        {
            //Selected button which changes all checkboxes below.
            ChkD201.IsChecked = true;
            ChkI209.IsChecked = true;
            ChkD211.IsChecked = true;
            ChkI203.IsChecked = true;
            ChkI202.IsChecked = true;
            ChkI212.IsChecked = true;
            ChkI213.IsChecked = true;
            ChkI221.IsChecked = true;
            ChkD201.IsChecked = true;
            ChkT201.IsChecked = true;
            ChkT206.IsChecked = true;
            ChkT211.IsChecked = true;
            ChkI263.IsChecked = true;
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            //Unselected button which changes all checkboxes below.
            ChkD201.IsChecked = false;
            ChkI209.IsChecked = false;
            ChkD211.IsChecked = false;
            ChkI203.IsChecked = false;
            ChkI212.IsChecked = false;
            ChkI213.IsChecked = false;
            ChkI221.IsChecked = false;
            ChkD201.IsChecked = false;
            ChkT201.IsChecked = false;
            ChkT206.IsChecked = false;
            ChkT211.IsChecked = false;
            ChkI263.IsChecked = false;
        }

        private void BtnSelectPreviousYear_Click(object sender, RoutedEventArgs e)
        {
            //Button call with an if statement to move the pivot accros to the next page or pivot point
            if (rootPivot.SelectedIndex < rootPivot.Items.Count - 1)
            {
                // If not at the last item, go to the next one.
                rootPivot.SelectedIndex -= 2;
            }
            else
            {
                // The last PivotItem is selected, so loop around to the first item.
                rootPivot.SelectedIndex = 0;
            }
        }

        private void BtnReMajor_Click(object sender, RoutedEventArgs e)
        {
            //Button call with an if statement to move the pivot accros to the next page or pivot point
            if (rootPivot.SelectedIndex < rootPivot.Items.Count - 1)
            {
                // If not at the last item, go to the next one.
                rootPivot.SelectedIndex -= 1;
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
        //Simple Dialong box to display When you have not Select a radio button.
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
        //Simple Dialong box to display When you have not Select a radio button.
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
        //Simple Dialong box to display When you have not Select a radio button.
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
        //Simple Dialong box to display When you have not Select a radio button.
        private async void DisplayNoEmail()
        {
            ContentDialog NoEmailDialog = new ContentDialog
            {
                //Explaintion of the content in the dialog box, these can be changed based on needs.
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

        private void BtnUnendorsed_Click_1(object sender, RoutedEventArgs e)
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

    }
}
