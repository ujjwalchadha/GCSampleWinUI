using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GCSampleUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
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
