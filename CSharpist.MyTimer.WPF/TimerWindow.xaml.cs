using System.Threading.Tasks;
using System.Windows;
using Timer = CSharpist.MyTimer.Library.Timer;

namespace CSharpist.MyTimer.WPF
{
    public partial class TimerWindow : Window
    {
        private Timer timer = new Timer();

        public TimerWindow() => InitializeComponent();

        private async void StartButton_Click(object sender, RoutedEventArgs e)
        {
            StartButton.IsEnabled = false;
            while (true)
            {
                string result = await Task.Run(() => timer.Displaying());

                TimerText.Text = result;
            }
        }
    }
}
