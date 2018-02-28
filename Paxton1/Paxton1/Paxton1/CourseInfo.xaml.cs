/*****************************************************
***** Student: Kyle Paxton                       *****
***** Class: Csc 492 Mobile Apps                 *****
***** Instructor: Gamradt                        *****
***** Assignment: 1                              *****
***** Due Date:02-28-18                          *****
******************************************************
*****  Description: CourseInfo.xaml.cs simply    *****
*****  creates labels that display the course    *****
*****  information including my name, the        *****
*****  instructor's name, the course name,       *****
*****  current assignment, and the due date.     *****
******************************************************/
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
                                TextColor = Color.Blue,
                                FontSize = Device.GetNamedSize(NamedSize.Micro, this)
                            },
                            new Label {
                                Text ="CSC 492 - Mobile Apps",
                                TextColor = Color.Navy,
                                FontSize = Device.GetNamedSize(NamedSize.Micro, this)
                            },

                            new Label {
                                Text ="Assignment 1",
                                TextColor = Color.DarkBlue,
                                FontSize = Device.GetNamedSize(NamedSize.Micro, this)
                            },
                            new Label {
                                Text ="Gamradt",
                                TextColor = Color.DarkCyan,
                                FontSize = Device.GetNamedSize(NamedSize.Micro, this)
                            },
                            new Label {
                                Text ="02/28/18",
                                TextColor = Color.Purple,
                                FontSize = Device.GetNamedSize(NamedSize.Micro, this)
                            }

                        }
                    }
                }
            };
        }
    }
}