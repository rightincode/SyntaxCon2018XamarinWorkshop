﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Foundation;
using tipcalc.iOS.Effects;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

//[assembly: ResolutionGroupName("MyCompany")]
//[assembly: ExportEffect(typeof(FocusEffect), "FocusEffect")]
namespace tipcalc.iOS.Effects
{
    //public class FocusEffect : PlatformEffect
    //{
    //    UIColor backgroundColor;

    //    protected override void OnAttached()
    //    {
    //        try
    //        {
    //            Control.BackgroundColor = backgroundColor = UIColor.FromRGB(204, 153, 255);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
    //        }
    //    }

    //    protected override void OnDetached()
    //    {
    //    }

    //    protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
    //    {
    //        base.OnElementPropertyChanged(args);

    //        try
    //        {
    //            if (args.PropertyName == "IsFocused")
    //            {
    //                if (Control.BackgroundColor == backgroundColor)
    //                {
    //                    Control.BackgroundColor = UIColor.White;
    //                }
    //                else
    //                {
    //                    Control.BackgroundColor = backgroundColor;
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
    //        }
    //    }
    //}
}