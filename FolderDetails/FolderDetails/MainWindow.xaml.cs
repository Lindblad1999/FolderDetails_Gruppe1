using System;
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

namespace FolderDetails
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool ViewDocking = false, 
            DarkThemeEnabled = false;
        public MainWindow() => InitializeComponent();

        #region MenuItems_Click
        private void OpenFolder_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ChangeAppearance()
        {
            if (ViewDocking)
            {
                MenuButton.Background = Brushes.White;
                MenuPanel.Background = Brushes.Red;
                StatusLinePanel.Background = Brushes.Chocolate;
                TreeViewContainer.Background = Brushes.Orange;
                ItemContentPanel.Background = Brushes.Yellow;
                lblItemContentTitle.Background = Brushes.Lime;
                lblItemContentName.Background = Brushes.Green;
                lblItemContentExtensionTitle.Background = Brushes.DodgerBlue;
                lblItemContentExtension.Background = Brushes.Blue;
                lblItemContentCreatedTitle.Background = Brushes.Magenta;
                lblItemContentCreated.Background = Brushes.DarkMagenta;
                lblItemContentLastModifiedTitle.Background = Brushes.LightGray;
                lblItemContentLastModified.Background = Brushes.Gray;
            }
            else if (!DarkThemeEnabled)
            {
                MenuButton.Background = Brushes.White;
                MenuButton.Foreground = Brushes.Black;
                MenuPanel.Background = Brushes.White;

                foreach (var item in MenuButton.ItemContainerGenerator.Items)
                {
                    ((MenuItem)item).Background = Brushes.White;
                    ((MenuItem)item).Foreground = Brushes.Black;
                }

                StatusLinePanel.Background = Brushes.White;
                lblStatusLine.Foreground = Brushes.Black;
                TreeViewContainer.Background = Brushes.White;
                TreeViewContainer.Foreground = Brushes.Black;
                ItemContentPanel.Background = Brushes.White;
                lblItemContentTitle.Background = Brushes.White;
                lblItemContentTitle.Foreground = Brushes.Black;
                lblItemContentName.Background = Brushes.White;
                lblItemContentName.Foreground = Brushes.Black;
                lblItemContentExtensionTitle.Background = Brushes.White;
                lblItemContentExtensionTitle.Foreground = Brushes.Black;
                lblItemContentExtension.Background = Brushes.White;
                lblItemContentExtension.Foreground = Brushes.Black;
                lblItemContentCreatedTitle.Background = Brushes.White;
                lblItemContentCreatedTitle.Foreground = Brushes.Black;
                lblItemContentCreated.Background = Brushes.White;
                lblItemContentCreated.Foreground = Brushes.Black;
                lblItemContentLastModifiedTitle.Background = Brushes.White;
                lblItemContentLastModifiedTitle.Foreground = Brushes.Black;
                lblItemContentLastModified.Background = Brushes.White;
                lblItemContentLastModified.Foreground = Brushes.Black;
            }
            else
            {
                var DarkOne = new SolidColorBrush(Color.FromRgb(34, 34, 34));
                var DarkTwo = new SolidColorBrush(Color.FromRgb(51, 51, 51)); ;
                var DarkThree = new SolidColorBrush(Color.FromRgb(69, 69, 69));

                foreach (var item in MenuButton.ItemContainerGenerator.Items)
                {
                    ((MenuItem)item).Background = DarkTwo;
                    ((MenuItem)item).Foreground = Brushes.White;
                }

                MenuButton.Background = Brushes.Black;
                MenuButton.Foreground = Brushes.White;

                lblStatusLine.Foreground = Brushes.White;
                MenuPanel.Background = DarkOne;
                StatusLinePanel.Background = DarkOne;

                TreeViewContainer.Background = DarkTwo;
                TreeViewContainer.Foreground = Brushes.White;
                ItemContentPanel.Background = DarkThree;

                lblItemContentTitle.Background = DarkThree;
                lblItemContentTitle.Foreground = Brushes.White;

                lblItemContentName.Background = DarkThree;
                lblItemContentName.Foreground = Brushes.White;

                lblItemContentExtensionTitle.Background = DarkThree;
                lblItemContentExtensionTitle.Foreground = Brushes.White;

                lblItemContentExtension.Background = DarkThree;
                lblItemContentExtension.Foreground = Brushes.White;

                lblItemContentCreatedTitle.Background = DarkThree;
                lblItemContentCreatedTitle.Foreground = Brushes.White;

                lblItemContentCreated.Background = DarkThree;
                lblItemContentCreated.Foreground = Brushes.White;

                lblItemContentLastModifiedTitle.Background = DarkThree;
                lblItemContentLastModifiedTitle.Foreground = Brushes.White;

                lblItemContentLastModified.Background = DarkThree;
                lblItemContentLastModified.Foreground = Brushes.White;
            }
        }
        private void ViewDocking_Click(object sender, RoutedEventArgs e)
        {
            ViewDocking ^= true;
            ChangeAppearance();
        }
        private void ToggleDarkmode_Click(object sender, RoutedEventArgs e)
        {
            DarkThemeEnabled ^= true;
            ChangeAppearance();
        }
        #endregion
    }
}
