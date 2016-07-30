using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XFMCSample.Views
{
    public partial class FirstPage : ContentPage
    {
        private int c;
        public FirstPage()
        {
            InitializeComponent();
            this.Button1.Clicked += Button1_ClickedEvent;
        }

        private void Button1_ClickedEvent(object sender, EventArgs e)
        {
            this.CountLabel.Text = $"Button is clicked [{++c}]!!!!";
        }
    }
}
