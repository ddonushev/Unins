using System.Windows;
using System.Windows.Controls;

namespace StudentInfoSystem
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

        private void DisableBtn_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in UpperGrid.Children)
            {
                var control = item as Control;
                control.IsEnabled = false;
            }

            foreach (var item in LowerGrid.Children)
            {
                var control = item as Control;
                //Moga li prosto da izmestq butonite v nov grid kato horata? Da 
                //Shte trqbva li da gi namestvam otnovo? Da 
                //ei toz if statement togava #BigBrainTime 🤠
                if (!(control is Button))
                    control.IsEnabled = false;
            }
        }

        private void EnableBtn_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in UpperGrid.Children)
            {
                var control = item as Control;
                control.IsEnabled = true;
            }

            foreach (var item in LowerGrid.Children)
            {
                var control = item as Control;
                control.IsEnabled = true;
            }
        }

        private void OutputBtn_Click(object sender, RoutedEventArgs e)
        {
            FirstNameBox.Text = StudentData.TestStudents[0].Name;
            MiddleNameBox.Text = StudentData.TestStudents[0].MiddleName;
            LastNameBox.Text = StudentData.TestStudents[0].LastName;
            FacultyBox.Text = StudentData.TestStudents[0].Faculty;
            FacNumBox.Text = StudentData.TestStudents[0].FakNo;
            CourseBox.Text = "nqma";
            StatusBox.Text = StudentData.TestStudents[0].StudentStatus;
            OKSBox.Text = StudentData.TestStudents[0].OKS;
            YearBox.Text = StudentData.TestStudents[0].Kurs;
            PotokBox.Text = StudentData.TestStudents[0].Potok;
            GroupBox.Text = StudentData.TestStudents[0].Grupa;
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in UpperGrid.Children)
                if (item is TextBox)
                {
                    var textBox = item as TextBox;
                    textBox.Text = "";
                }

            foreach (var item in LowerGrid.Children)
                if (item is TextBox)
                {
                    var textBox = item as TextBox;
                    textBox.Text = "";
                }
        }
    }
}