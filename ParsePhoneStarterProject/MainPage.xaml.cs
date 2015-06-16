using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Parse;
using ParsePhoneStarterProject.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using ParsePhoneStarterProject.Dal;
using ParsePhoneStarterProject.Model;

namespace ParsePhoneStarterProject {
  public partial class MainPage : PhoneApplicationPage {
        // Constructor
        List<MagicLists> mLists;

        public MainPage() {
      InitializeComponent();

      // Sample code to localize the ApplicationBar
      //BuildLocalizedApplicationBar();
         
        }

        public async void populatelist()
        {
            try
            {
                MagicListsDal _db = new MagicListsDal();


                mLists = await _db.GetListsAync();

            //    lstView.ItemsSource = mLists;
                
                listView.ItemsSource = mLists;
            }
            catch (Exception ex)
            {
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            populatelist();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            populatelist();
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}