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
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GCSampleWinUI
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            var list = new test_component_base.HierarchyA().GetList();
            var count = 0;
            foreach (var element in list)
            {
                count += (int)element;
            }
            myTextBlock.Text = "Sum of vector elements: " + count;
        }

        private void myButton2_Click(object sender, RoutedEventArgs e)
        {
            var list = new test_component_base.HierarchyA().GetXamlList();
            var count = 0;
            foreach (var element in list)
            {
                count += (int)element;
            }
            myTextBlock.Text = "Sum of observablevector elements: " + count;
        }
    }
}
