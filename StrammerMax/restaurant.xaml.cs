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

namespace StrammerMax
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class Restaurant : Window
    {
        Koch besterKoch;
        Gericht leckerEssen;
        ListBox speisekarte;

        public Restaurant()
        {
            InitializeComponent();
            besterKoch = new Koch("Sebastian");
        }

        private void SpeisekarteErneuern(object sender, RoutedEventArgs e)
        {
            besterKoch.Name = "Peter";

            speisekarte = new ListBox();

            speisekarte.Width = 357;
            speisekarte.Height = 261;
            speisekarte.VerticalAlignment = VerticalAlignment.Top;
            speisekarte.HorizontalAlignment = HorizontalAlignment.Left;
            speisekarte.Margin = new Thickness(10, 37, 0, 0);


            this.Gästebereich.Children.Add(speisekarte);

            speisekarte.Items.Clear();
            speisekarte.Items.Add(besterKoch.Name + " kocht heute für Sie:");
            for (int i = 1; i < 7; i++)
            {
                leckerEssen = besterKoch.Kochen();                      // Brauchte nicht mit new instanziiert werden!!!

                speisekarte.Items.Add(i + ". Variante: " + leckerEssen.Fleischsorte + " mit " + leckerEssen.Soßensorte + " auf " + leckerEssen.Brotsorte);
            }
            speisekarte.Items.Add("");
        }
    }
}
