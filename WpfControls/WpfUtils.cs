﻿// © 2009 Rick Strahl. All rights reserved. 
// See http://wpflocalization.codeplex.com for related whitepaper and updates
// See http://wpfclientguidance.codeplex.com for other WPF resources

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Westwind.Wpf
{

    public class WpfUtils
    {

        /// <summary>
        /// Retrieves the root element from a particular element by walking
        /// the tree of parents up backwards.
        /// 
        /// Note: fails on some elements that don't have parent elements like
        /// context menus.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static DependencyObject GetRootVisual(DependencyObject d)
        {
            if (d == null)
                return null;

            if (d is FrameworkElement)
            {
                FrameworkElement el = d as FrameworkElement;
                while (el.Parent != null)
                {
                    el = el.Parent as FrameworkElement;
                }
                return el;
            }
            else if (d is FrameworkContentElement)
            {
                FrameworkContentElement fce = d as FrameworkContentElement;
                while (fce.Parent != null)
                {
                    DependencyObject dnew = fce.Parent;
                    if (dnew is FrameworkElement)
                        return GetRootVisual(dnew);
                }
                return fce;
            }
            return null;
        }
    }
}
