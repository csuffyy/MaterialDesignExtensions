﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using MaterialDesignExtensions.Model;

namespace MaterialDesignExtensionsDemo.Controls
{
    public partial class NavigationControl : UserControl
    {
        public NavigationControl()
        {
            InitializeComponent();

            Loaded += NavigationControl_Loaded;
            Unloaded += NavigationControl_Unloaded;
        }

        private void NavigationControl_Loaded(object sender, RoutedEventArgs args)
        {
            navigation1.WillSelectNavigationItemCallbackAsync = WillSelectNavigationItemCallbackAsync;
            navigation2.WillSelectNavigationItemCallbackAsync = WillSelectNavigationItemCallbackAsync;
            navigation3.WillSelectNavigationItemCallbackAsync = WillSelectNavigationItemCallbackAsync;
        }

        private void NavigationControl_Unloaded(object sender, RoutedEventArgs args)
        {
            navigation1.WillSelectNavigationItemCallbackAsync = null;
            navigation2.WillSelectNavigationItemCallbackAsync = null;
            navigation3.WillSelectNavigationItemCallbackAsync = null;
        }

        public async Task<bool> WillSelectNavigationItemCallbackAsync(INavigationItem currentNavigationItem, INavigationItem navigationItemToSelect)
        {
            // do some async stuff here
            //     return true to cancel the navigation
            return await Task.Run(() => false);
        }
    }
}
