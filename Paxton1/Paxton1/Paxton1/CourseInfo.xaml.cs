using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Paxton1
{
    public partial class CourseInfo : ContentPage
    {
        public CourseInfo()
        {
            Content = new StackLayout
            {
                Children =
                {
                    new StackLayout
                    {
                        Children =
                        {
                            new Label {
                                Text ="Kyle Paxton",
                                TextColor = Color.Black,
                                FontSize = Device.GetNamedSize(NamedSize.Micro, this)
                            },
                            new Label {
                                Text ="CSC 492 - Mobile Apps",
                                TextColor = Color.Black,
                                FontSize = Device.GetNamedSize(NamedSize.Micro, this)
                            },

                            new Label {
                                Text ="Assignment 1",
                                TextColor = Color.Black,
                                FontSize = Device.GetNamedSize(NamedSize.Micro, this)
                            },
                            new Label {
                                Text ="Gamradt",
                                TextColor = Color.Black,
                                FontSize = Device.GetNamedSize(NamedSize.Micro, this)
                            },
                            new Label {
                                Text ="02/28/18",
                                TextColor = Color.Black,
                                FontSize = Device.GetNamedSize(NamedSize.Micro, this)
                            }

                        }
                    }
                }
            };
        }
    }
}