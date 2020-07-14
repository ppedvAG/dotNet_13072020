using System.Net.Http;
using System.Windows;

namespace REST_GoogleBooks_Client
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

        private async void Suchen(object sender, RoutedEventArgs e)
        {
            var url = $"https://www.googleapis.com/books/v1/volumes?q={tb1.Text}";

            var http = new HttpClient();
            var json = await http.GetStringAsync(url);
            jsonTb.Text = json;
        }
    }
}
