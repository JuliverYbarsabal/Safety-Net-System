using System.Windows;


namespace Assignment2App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CollaboratorSignUp form2 = new CollaboratorSignUp();
            form2.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TwitterUI form3 = new TwitterUI();
            form3.Show();
        }

        private void View_Contributors_Click(object sender, RoutedEventArgs e)
        {
           viewContributors form4 = new viewContributors();
           form4.Show();
        }

    }
}
