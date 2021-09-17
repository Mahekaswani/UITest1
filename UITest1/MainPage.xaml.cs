using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace UITest1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void PhoneNumberValidate(System.Object sender, System.EventArgs e)
        {
            string phoneNumberRegax = "^[0-9]{10}$";

            if (!string.IsNullOrWhiteSpace(entryPhoneNumber.Text))
            {
                if (Regex.IsMatch(entryPhoneNumber.Text, phoneNumberRegax,
                     RegexOptions.IgnoreCase))
                {
                    lblResult.Text = "Valid";
                }
                else
                    lblResult.Text = "Not Valid";
            }
            else
                lblResult.Text = "Not Valid";

        }
        

       
        
    }
}
