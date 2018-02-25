using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Paxton1
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            var layout = new StackLayout {};
            this.Content = layout;

            Frame topFrame = new Frame();
            topFrame.OutlineColor = Color.Red;
            topFrame.HorizontalOptions = LayoutOptions.Fill;
            topFrame.VerticalOptions = LayoutOptions.Start;
            topFrame.Content = new CourseInfo().Content;
            
            Frame midFrame = new Frame();
            midFrame.OutlineColor = Color.Red;
            midFrame.HorizontalOptions = LayoutOptions.Center;
            midFrame.VerticalOptions = LayoutOptions.Center;
            midFrame.Content = new Colors().Content;

            Frame botFrame = new Frame();
            botFrame.OutlineColor = Color.Red;
            botFrame.HorizontalOptions = LayoutOptions.End;
            botFrame.VerticalOptions = LayoutOptions.End;
            botFrame.Content = new Lyrics().Content;

            layout.Children.Add(topFrame);
            layout.Children.Add(midFrame);
            layout.Children.Add(botFrame);
        }
    }
}
