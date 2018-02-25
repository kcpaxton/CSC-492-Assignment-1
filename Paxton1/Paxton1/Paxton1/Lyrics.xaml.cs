using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Paxton1
{
	public partial class Lyrics : ContentPage
	{
		public Lyrics ()
		{
            StackLayout mainStack = new StackLayout();
            StackLayout textStack = new StackLayout
            {
                Padding = new Thickness(3),
                Spacing = 3
            };
            Assembly assembly = GetType().GetTypeInfo().Assembly;
            string resource = "Paxton1.Texts.TheShinsTurnOnMe.txt";

            using (Stream stream = assembly.GetManifestResourceStream(resource))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    bool gotTitle = false;
                    string line;

                    while(null !=(line = reader.ReadLine()))
                    {
                        Label label = new Label()
                        {
                            Text = line,
                            TextColor = Color.Black
                        };
                        if (!gotTitle)
                        {
                            label.HorizontalOptions = LayoutOptions.Center;
                            label.FontSize = Device.GetNamedSize(NamedSize.Default, label);
                            label.FontAttributes = FontAttributes.Bold;
                            mainStack.Children.Add(label);
                            gotTitle = true;
                        }
                        else{
                            textStack.Children.Add(label);
                        }
                    }
                }

            }

            ScrollView scrollView = new ScrollView
            {
                Content = textStack,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Padding = new Thickness(5, 0)
            };

            mainStack.Children.Add(scrollView);
            Content = mainStack;
            BackgroundColor = Color.White;
            double top = 5;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS: top = 20; break;
                case Device.Android:
                case Device.UWP:
                default: top = 0; break;
            };
            Padding = new Thickness(0, top, 0, 0);
        }
	}
}