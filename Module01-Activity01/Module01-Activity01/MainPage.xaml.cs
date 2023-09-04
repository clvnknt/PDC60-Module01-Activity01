using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module01_Activity01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OpenPage1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
        private async void OpenPage2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        private async void OpenPage3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }

        private bool isDarkMode = false;

        private void ChangeButtonColor(object sender, EventArgs e)
        {
            if (isDarkMode)
            {
                // Change text colors to their original values (light mode)
                WelcomeLabel.TextColor = Color.Black;
                StartLabel.TextColor = Color.Black;
                InstructionsLabel.TextColor = Color.Black;
                LinkLabel.TextColor = Color.Black;
                ColorChangeButton.BackgroundColor = Color.FromHex("#2196F3");
                ColorChangeButton.TextColor = Color.White;
                this.BackgroundColor = Color.White; // Change the ContentPage background color to white
            }
            else
            {
                // Change text colors to dark mode values
                WelcomeLabel.TextColor = Color.White;
                StartLabel.TextColor = Color.White;
                InstructionsLabel.TextColor = Color.White;
                LinkLabel.TextColor = Color.White;
                ColorChangeButton.BackgroundColor = Color.White;
                ColorChangeButton.TextColor = Color.Black;
                this.BackgroundColor = Color.Black; // Change the ContentPage background color to black
            }

            isDarkMode = !isDarkMode; // Toggle the dark mode state
        }

    }
}