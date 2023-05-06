using System.Threading.Tasks;
using System.Windows;
using Timer = CSharpist.MyTimer.Library.Timer;

namespace CSharpist.MyTimer.WPF
{
    public partial class TimerWindow : Window
    {
        private Timer timer = new Timer();

        public TimerWindow() => InitializeComponent();

        private async void StartStopButton_Click(object sender, RoutedEventArgs e)
        {
            while (true)
            {
                string result = await Task.Run(() => timer.Displaying());

                TimerText.Text = result;
            }
        }
    }
}
