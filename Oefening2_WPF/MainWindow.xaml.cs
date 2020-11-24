
using System.Diagnostics;
using System.Windows;
using System.Windows.Media;


namespace Oefening2_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AantalKleuren.Text = "Aantal kleuren = " + typeof(Colors).GetProperties().Length;
            ComboBoxColors.ItemsSource = typeof(Colors).GetProperties();
            ListBoxColors.ItemsSource = typeof(Colors).GetProperties();
            Debug.WriteLine("Aantal elementen in Listbox=" + ListBoxColors.Items.Count);
        }
    }
}
