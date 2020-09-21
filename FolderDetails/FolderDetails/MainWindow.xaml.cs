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
using System.Windows.Forms;
using System.IO;

namespace FolderDetails
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool ViewDocking = false;

        private Obj rootObj;
        public MainWindow()
        {
            InitializeComponent();
        }

        #region MenuItems_Click
        private void OpenFolder_Click(object sender, RoutedEventArgs e)
        {
            FolderSelect();
            rootObj.SubDirectories();
        }

        private void ViewDocking_Click(object sender, RoutedEventArgs e)
        {
            if (!ViewDocking)
            {
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
            else
            {
                MenuPanel.Background = Brushes.White;
                StatusLinePanel.Background = Brushes.White;
                TreeViewContainer.Background = Brushes.White;
                ItemContentPanel.Background = Brushes.White;
                lblItemContentTitle.Background = Brushes.White;
                lblItemContentName.Background = Brushes.White;
                lblItemContentExtensionTitle.Background = Brushes.White;
                lblItemContentExtension.Background = Brushes.White;
                lblItemContentCreatedTitle.Background = Brushes.White;
                lblItemContentCreated.Background = Brushes.White;
                lblItemContentLastModifiedTitle.Background = Brushes.White;
                lblItemContentLastModified.Background = Brushes.White;
            }
            ViewDocking ^= true;
        }
        #endregion

        private void FolderSelect()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result.ToString() == "OK")
                {
                    rootObj = new Obj(System.IO.Path.GetFileName(fbd.SelectedPath), fbd.SelectedPath);
                }
            }
        }
    }
}
