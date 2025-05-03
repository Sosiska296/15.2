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

namespace WpfApp7;
    public partial class MainWindow : Window
    {
        private List<SolidColorBrush> colors;
        private Random rnd;

        public MainWindow()
        {
            InitializeComponent();
            rnd = new Random();
            colors = new List<SolidColorBrush>
            {
                Brushes.Red,
                Brushes.Green,
                Brushes.Blue,
                Brushes.Yellow,
                Brushes.Orange
            };
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var buttons = new List<Button> { Button1, Button2, Button3, Button4, Button5 };
            SolidColorBrush previousColor = null;
            foreach (var button in buttons)
            {
                SolidColorBrush newColor;
                do
                {
                    newColor = colors[rnd.Next(colors.Count)];
                } while (newColor == previousColor);
                button.Background = newColor; 
                previousColor = newColor;
        }
        // как пожарить яичницу: Налить растительное масло в сковороду и поставить на огонь. Разбить яйца и вылить их на сковород. 
        // Посолить по вкусу. Жарить яичницу необходимо 2–3 минуты.
    }
}