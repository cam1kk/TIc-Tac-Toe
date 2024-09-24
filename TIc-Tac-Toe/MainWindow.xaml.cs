using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TIc_Tac_Toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string symb = "X";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.Content = symb;
            if (symb == "X")
            {
                symb = "O";
            }
            else
            {
                symb = "X";
            }
            clickedButton.FontSize = 20;
            clickedButton.FontWeight =  FontWeights.Bold;
            clickedButton.IsEnabled = false;
            IsWin();
        }
        private void IsWin()
        {
            if (btn1.Content == btn4.Content && btn4.Content == btn7.Content)
            {
                MessageBox.Show("123123");
            }
        }
    }
}