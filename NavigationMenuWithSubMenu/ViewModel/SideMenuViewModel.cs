using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace MenuWithSubMenu
{
    class SideMenuViewModel
    {

        //Our Source List for Menu Items
        public List<MenuItemsData> MenuList
        {
            get
            {
                return new List<MenuItemsData>
                {
                    //MainMenu without SubMenu Button 
                    new MenuItemsData(){ MenuText="Dashboard", SubMenuList=null},
                 
                    //MainMenu Button
                    new MenuItemsData(){ MenuText="User management"
                    
                    //SubMenu Button
                    , SubMenuList=new List<SubMenuItemsData>{
                    new SubMenuItemsData(){ SubMenuText="Edit user" },
                    new SubMenuItemsData(){ SubMenuText="Delete user" }}
                    },

                    //MainMenu Button
                    new MenuItemsData(){ MenuText="Book management"

                    //SubMenu Button
                    , SubMenuList=new List<SubMenuItemsData>{
                    new SubMenuItemsData(){ SubMenuText="Add book" },
                    new SubMenuItemsData(){  SubMenuText="Edit book" },
                    new SubMenuItemsData(){ SubMenuText="Delete book" }}},

                    //MainMenu Button
                    new MenuItemsData(){ MenuText="Author management"

                    //SubMenu Button
                    , SubMenuList=new List<SubMenuItemsData>{
                    new SubMenuItemsData(){ SubMenuText="Add author" },
                    new SubMenuItemsData(){ SubMenuText="Edit author" },
                    new SubMenuItemsData(){ SubMenuText="Delete author" }}},

                    //MainMenu Button
                    new MenuItemsData(){ MenuText="Language management"

                    //SubMenu Button
                    , SubMenuList=new List<SubMenuItemsData>{
                    new SubMenuItemsData(){ SubMenuText="Add language" },
                    new SubMenuItemsData(){ SubMenuText="Edit language" },
                    new SubMenuItemsData(){ SubMenuText="Delete language" }}},

                    //MainMenu Button
                    new MenuItemsData(){ MenuText="Genre management"

                    //SubMenu Button
                    , SubMenuList=new List<SubMenuItemsData>{
                    new SubMenuItemsData(){ SubMenuText="Add genre" },
                    new SubMenuItemsData(){ SubMenuText="Edit genre" },
                    new SubMenuItemsData(){ SubMenuText="Delete genre" }}},

                    //MainMenu Button
                    new MenuItemsData(){ MenuText="Publisher management"

                    //SubMenu Button
                    , SubMenuList=new List<SubMenuItemsData>{
                    new SubMenuItemsData(){ SubMenuText="Add publisher" },
                    new SubMenuItemsData(){ SubMenuText="Edit publisher" },
                    new SubMenuItemsData(){ SubMenuText="Delete publisher" }}},

                    //MainMenu Button
                    new MenuItemsData(){ MenuText="Data management"

                    //SubMenu Button
                    , SubMenuList=new List<SubMenuItemsData>{
                    new SubMenuItemsData(){ SubMenuText="Add data" },
                    new SubMenuItemsData(){ SubMenuText="Edit data" },
                    new SubMenuItemsData(){ SubMenuText="Delete data" }}},
                };
            }
        }
    }

    public class MenuItemsData
    {
        //Icon Data
        public string MenuText { get; set; }
        public List<SubMenuItemsData> SubMenuList { get; set; }

        //To Add click event to our Buttons we will use ICommand here to switch pages when specific button is clicked
        public MenuItemsData()
        {
            Command = new CommandViewModel(Execute);
        }

        public ICommand Command { get; }

        private void Execute()
        {
            //our logic comes here
            string MT = MenuText.Replace(" ", string.Empty);
            if (!string.IsNullOrEmpty(MT))
                navigateToPage(MT);
        }

        private void navigateToPage(string Menu)
        {
            //We will search for our Main Window in open windows and then will access the frame inside it to set the navigation to desired page..
            //lets see how... ;)
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).MainWindowFrame.Navigate(new Uri(string.Format("{0}{1}{2}", "Pages/", Menu, ".xaml"), UriKind.RelativeOrAbsolute));
                }
            }
        }
    }
    public class SubMenuItemsData
    {
        public string SubMenuText { get; set; }

        //To Add click event to our Buttons we will use ICommand here to switch pages when specific button is clicked
        public SubMenuItemsData()
        {
            SubMenuCommand = new CommandViewModel(Execute);
        }

        public ICommand SubMenuCommand { get; }

        private void Execute()
        {
            //our logic comes here
            string SMT = SubMenuText.Replace(" ", string.Empty);
            if (!string.IsNullOrEmpty(SMT))
                navigateToPage(SMT);
        }

        private void navigateToPage(string Menu)
        {
            //We will search for our Main Window in open windows and then will access the frame inside it to set the navigation to desired page..
            //lets see how... ;)
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).MainWindowFrame.Navigate(new Uri(string.Format("{0}{1}{2}", "Pages/", Menu, ".xaml"), UriKind.RelativeOrAbsolute));
                }
            }
        }
    }
}