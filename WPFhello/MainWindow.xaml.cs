using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace WPFhello
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var s = "";
            foreach (var item in innerGrid.Children)
                if (item is TextBox)
                {
                    s = s + ((TextBox) item).Text;
                    s = s + '\n';
                }

            MessageBox.Show("Здрасти!!! Това е твоята първа програма на Visual Studio 2019! // Rider \n" + s);
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            var result = MessageBox.Show("Наистина ли искате да затворите прозореца?", "Внимание!",
                MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes) e.Cancel = false;
        }
    }
}