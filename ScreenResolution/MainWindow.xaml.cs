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
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Controls.Primitives;

namespace ScreenResolution
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            Window myWindow = new Window();

            InitializeComponent();

            XSize = System.Windows.SystemParameters.PrimaryScreenWidth;
            YSize = System.Windows.SystemParameters.PrimaryScreenHeight;

            //XSize = System.Windows.SystemParameters.VirtualScreenWidth;
            //YSize = System.Windows.SystemParameters.VirtualScreenHeight;

        }

        public static readonly DependencyProperty XpositionProperty =
        DependencyProperty.Register("Xposition", typeof(double), typeof(Window), new PropertyMetadata(null));

        public double Xposition
        {
            get { return (double)GetValue(XpositionProperty); }
            set { SetValue(XpositionProperty, value); }
        }


        public static readonly DependencyProperty YpositionProperty =
        DependencyProperty.Register("Yposition", typeof(double), typeof(Window), new PropertyMetadata(null));

        public double Yposition
        {
            get { return (double)GetValue(YpositionProperty); }
            set { SetValue(YpositionProperty, value); }
        }


        public static readonly DependencyProperty XSizeProperty =
        DependencyProperty.Register("XSize", typeof(double), typeof(Window), new PropertyMetadata(null));

        public double XSize
        {
            get { return (double)GetValue(XSizeProperty); }
            set { SetValue(XSizeProperty, value); }
        }


        public static readonly DependencyProperty YSizeProperty =
        DependencyProperty.Register("YSize", typeof(double), typeof(Window), new PropertyMetadata(null));

        public double YSize
        {
            get { return (double)GetValue(YSizeProperty); }
            set { SetValue(YSizeProperty, value); }
        }

        private void HandleUnChecked(object sender, RoutedEventArgs e)
        {
            ToggleButton toggle = sender as ToggleButton;
            toggle.Content = "Unlocked";
        }

        private void HandleChecked(object sender, RoutedEventArgs e)
        {
            ToggleButton toggle = sender as ToggleButton;
            toggle.Content = "LOCKED";
        }

        private void CurrentWindow_LocationChanged(object sender, EventArgs e)
        {
            Xposition = System.Windows.Application.Current.MainWindow.Left;
            Yposition = System.Windows.Application.Current.MainWindow.Top;

            if ((bool)LockButton.IsChecked)
            {
                if (Xposition < 0)
                {
                    System.Windows.Application.Current.MainWindow.Left = 0;
                }
                else if (Xposition > XSize - System.Windows.Application.Current.MainWindow.Width)
                {
                    System.Windows.Application.Current.MainWindow.Left = XSize - System.Windows.Application.Current.MainWindow.Width;
                }
                else if (Yposition > YSize - System.Windows.Application.Current.MainWindow.Height)
                {
                    System.Windows.Application.Current.MainWindow.Top = YSize - System.Windows.Application.Current.MainWindow.Height;
                }
            }
        }
    }
}
