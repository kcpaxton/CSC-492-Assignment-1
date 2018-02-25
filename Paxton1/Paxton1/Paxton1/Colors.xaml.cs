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

	public partial class Colors : ContentPage
	{
		public Colors ()
		{
            StackLayout stackLayout = new StackLayout();
            foreach(FieldInfo info in typeof(Color).GetRuntimeFields())
            {

                if(info.GetCustomAttribute<ObsoleteAttribute>() != null)
                {
                    continue;
                }
                if (info.IsPublic && info.IsStatic && info.FieldType == typeof(Color))
                {
                    stackLayout.Children.Add(
                        CreateColorView((Color)info.GetValue(null), info.Name));
                }

               
            }

            foreach (PropertyInfo info in typeof(Color).GetRuntimeProperties())
            {

                MethodInfo methodInfo = info.GetMethod;
                if(methodInfo.IsPublic && methodInfo.IsStatic && methodInfo.ReturnType == typeof(Color))
                {
                    stackLayout.Children.Add(
                        CreateColorView((Color)info.GetValue(null), info.Name));

                }
            }
            double top = 5;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS: top = 20; break;
                case Device.Android:
                case Device.UWP:
                default: top = 5; break;
            };
            Padding = new Thickness(5, top, 5, 5);
            Content = new ScrollView
            {
                Content = stackLayout
            };
		}

    View CreateColorView(Color color, string name)
        {
            return new Frame
            {
                OutlineColor = Color.Accent,
                Padding = new Thickness(5),
                Content = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 15,
                    Children =
                    {
                        new BoxView
                        {
                            Color = color
                        },
                        new Label
                        {
                            Text = name, WidthRequest = 60, // sets the maximum width of text before truncating it.
                            FontSize = Device.GetNamedSize(NamedSize.Default, typeof(Label)),
                            FontAttributes = FontAttributes.Bold,
                            VerticalOptions = LayoutOptions.Center,
                            HorizontalOptions = LayoutOptions.StartAndExpand,
                            LineBreakMode = LineBreakMode.TailTruncation //adds the ellipses to the text if its over width of 60.
                        },
                        new StackLayout
                        {
                            Children =
                            {
                                new Label
                                {
                                    Text = String.Format("{0:X2}-{1:X2}-{2:X2}",
                                                         (int)(255 * color.R),
                                                         (int)(255 * color.G),
                                                         (int)(255 * color.B)),
                                    VerticalOptions = LayoutOptions.CenterAndExpand,
                                    IsVisible = color != Color.Default
                                },
                                new Label
                                {
                                    Text = String.Format("{0:F2}, {1:F2}, {2:F2}",
                                                         color.Hue,
                                                         color.Saturation,
                                                         color.Luminosity),
                                    VerticalOptions = LayoutOptions.CenterAndExpand,
                                    IsVisible = color != Color.Default
                                }
                            },
                            HorizontalOptions = LayoutOptions.End
                        }
                    }
                }
            };
        }
    }
}