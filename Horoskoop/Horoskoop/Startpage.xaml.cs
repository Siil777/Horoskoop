using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Horoskoop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Startpage : ContentPage
    {
        public Startpage()
        {
            Button Ent_btn = new Button
            {
                Text = "Horoskop",
                BackgroundColor = Color.Azure
            };
            



            StackLayout st = new StackLayout
            {
                //all elements on the page pictures, buttons...call them from the structure above Button Ent_btn=new Button, Button Time_btn = new Button
                Children = { Ent_btn },
                BackgroundColor = Color.Beige


            };
            //in contect we call elements from stackLayot and button
            Content = st;
            Ent_btn.Clicked += Ent_btn_Clicked;






        }

        private async void Ent_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HoroskopPage());
        }
    }
}
