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
    public partial class Page2 : ContentPage
    {
        int second= 0;
        bool timer_run = true;
        public Page2()
        {
            InitializeComponent();
        }

        public bool Start_Second()
        {
         
            timer_run = true;
            Device.StartTimer(TimeSpan.FromSeconds(1),Start_Second);
            Label l1 = new Label();
            TimeSpan t1 = TimeSpan.FromSeconds(second);
            l1.Text = String.Format("{0,2:00}: {1,2:00}", t1.Minutes, t1.Seconds);
            second++;
            Second.Text = t1.ToString();
            return timer_run;
        }

        private void Start_Second(object sender, EventArgs e)
        {
            Start_Second();
        }
    }
}