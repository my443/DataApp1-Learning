using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DataApp1
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        List <String> listBoxList = new List <String> ();

        public MainWindow()
        {
            this.InitializeComponent();
            populate_listbox(25);
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            // myButton.Content = "Clicked";
            // Populate the current item in the textbox.
            if (ListOfDataTables.SelectedIndex >= 0) { 
                ListItemTextbox.Text = ListOfDataTables.SelectedValue.ToString();
            }
            listBoxList[0] = "something else";

        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedItem = ListOfDataTables.SelectedIndex;
            listBoxList[selectedItem] = ListOfDataTables.SelectedValue.ToString();

        }

        private void populate_listbox(int numberOfRows) {
            for (int i = 0; i < numberOfRows; i++)
            {
                listBoxList.Add("Something_with_bind" + i.ToString());               // This adds the items to the list. The Listbox in the UI is bound to the list.
                // ListOfDataTables.Items.Add("Something_"+i.ToString());   // This puts the item directly into the listbox in the UI
            }
        
        }
    }
}
