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
using System.Windows.Shapes;

namespace WPF_MóduloControlClientes
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
                //Determines the character used in the maximize/restore button.
        private char _maximized = '1';
        
        private void CommandBinding_CanExecute_1(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        //Closes the window when the close window button is clicked.
        private void CommandBinding_CloseWindow(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }
        //Minimizes the window when the minimize window button is clicked.
        private void CommandBinding_MinimizeWindow(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }
        //Maximizes or Restores the window when the maximize/restore window button is clicked.
        private void CommandBinding_MaximizeRestoreWindow(object sender, ExecutedRoutedEventArgs e)
        {
            maximizeRestore();
        }
        //Maximizes/Restores the window when the title bar is double clicked.
        private void titleBar_mouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && e.ClickCount == 2)
            {
                maximizeRestore();
            }
        }
        //Maximizes/Restores the window and changes the button character accordingly.
        private void maximizeRestore()
        {
            if (WindowState == WindowState.Maximized)
            {
                SystemCommands.RestoreWindow(this);
                btn_maximizeRestore.Content = "1";
            }
            else
            {
                SystemCommands.MaximizeWindow(this);
                btn_maximizeRestore.Content = "2";
            }
        }
        //Drags the window around the screen when the mouse is clicked and held.
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }
    }
}
