using honeypot.data.shared.Services;
using honeypot.mobile.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace honeypot.mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            using (var context = new Database())
            {
                Debug.WriteLine($"Database found {context.Users.Count()} entries");
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var ret = await UsersService.Get();

            using (var context = new Database())
            {
                foreach(var u in ret)
                {
                    context.Users.Add(u);
                }

                Debug.WriteLine($"Saving {ret.Count()} entries");

                await context.SaveChangesAsync();
            }
        }
    }
}
