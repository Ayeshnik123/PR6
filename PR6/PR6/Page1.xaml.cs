using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PR6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        bool alive = true;
        public Page1()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1), chasi);
        }

        private bool chasi()
        {
            Chasi.Text = DateTime.Now.ToString("T");
            return alive;
        }

        private void chasi(object sender, EventArgs e)
        {
        }
    }
}