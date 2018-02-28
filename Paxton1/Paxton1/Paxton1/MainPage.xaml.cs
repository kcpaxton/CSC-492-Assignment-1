/*****************************************************
***** Student: Kyle Paxton                       *****
***** Class: Csc 492 Mobile Apps                 *****
***** Instructor: Gamradt                        *****
***** Assignment: 1                              *****
***** Due Date:02-28-18                          *****
******************************************************
*****  Description: This program seperates three *****
*****  Seperate pieces of content into one page  *****
*****  A list of labels containing the course    *****
*****  info will be on the top of the page. A    *****
*****  Color wheel will be in the middle of the  *****
*****  page and the lyrics to the song "Turn on  *****
*****  me" by the shins will be on the bottom    *****
*****  of the page. Each section is contained in *****
*****  its own frame and colored a unique color. *****
******************************************************/
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
            topFrame.OutlineColor = Color.Coral;
            topFrame.BackgroundColor = Color.LightSkyBlue;
            topFrame.HorizontalOptions = LayoutOptions.Fill;
            topFrame.VerticalOptions = LayoutOptions.Start;
            topFrame.Content = new CourseInfo().Content;
            
            Frame midFrame = new Frame();
            midFrame.OutlineColor = Color.Yellow;
            midFrame.HorizontalOptions = LayoutOptions.Fill;
            midFrame.VerticalOptions = LayoutOptions.Center;
            midFrame.Content = new Colors().Content;
            midFrame.BackgroundColor = Color.LightSteelBlue;

            Frame botFrame = new Frame();
            botFrame.OutlineColor = Color.Red;
            botFrame.HorizontalOptions = LayoutOptions.Fill;
            botFrame.VerticalOptions = LayoutOptions.End;
            botFrame.Content = new Lyrics().Content;
            botFrame.BackgroundColor = Color.LightSeaGreen;

            layout.Children.Add(topFrame);
            layout.Children.Add(midFrame);
            layout.Children.Add(botFrame);
        }
    }
}
