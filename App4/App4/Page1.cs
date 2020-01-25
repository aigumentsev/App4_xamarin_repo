using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App4
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            Content = new StackLayout
            {
                //Orientation = StackOrientation.Horizontal,
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" },

                }
            };
            Content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms! down" },
                    new Label { Text = "Welcome to Xamarin.Forms! down" },
                    new Entry {Keyboard=Keyboard.Telephone, HorizontalOptions=LayoutOptions.Fill},
                    new Editor {Placeholder="placeh", PlaceholderColor = Color.AliceBlue }

                }
            };
            }
    }
}