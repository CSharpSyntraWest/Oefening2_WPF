using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Oefening3_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Cursus
        {
            public string Naam { get; set; }
            public int PercentLesUrenGevolgd { get; set; }
        }
        public MainWindow()
        {
            InitializeComponent();
            List<Cursus> cursussen = new List<Cursus>();
            cursussen.Add(new Cursus() { Naam = "Databanken", PercentLesUrenGevolgd = 100 });
            cursussen.Add(new Cursus() { Naam = "Leren Programmeren", PercentLesUrenGevolgd = 100 });
            cursussen.Add(new Cursus() { Naam = "C# Programmeren 1", PercentLesUrenGevolgd = 50 });
            cursussen.Add(new Cursus() { Naam = "C# Programmeren 2", PercentLesUrenGevolgd = 0 });
            ListBoxCursussen.ItemsSource = cursussen;
        }

        private void ButtonToonGeselecteerde_Click(object sender, RoutedEventArgs e)
        {
            foreach (object o in ListBoxCursussen.SelectedItems)
            {
                Debug.WriteLine((o as Cursus).Naam);
            }
        }

        private void ButtonSelecteerLaatste_Click(object sender, RoutedEventArgs e)
        {
            ListBoxCursussen.SelectedIndex = ListBoxCursussen.Items.Count - 1;
        }

        private void ButtonSelecteerVolgende_Click(object sender, RoutedEventArgs e)
        {
            if ((ListBoxCursussen.SelectedIndex >= 0) && (ListBoxCursussen.SelectedIndex < (ListBoxCursussen.Items.Count - 1)))
            {
                ListBoxCursussen.SelectedIndex++;
            }
        }

        private void ButtonSelecteerEerste_Click(object sender, RoutedEventArgs e)
        {
            ListBoxCursussen.SelectedIndex = 0;
        }

        private void ButtonSelecteerAlles_Click(object sender, RoutedEventArgs e)
        {
            ListBoxCursussen.SelectAll();
            //foreach (object o in ListBoxCursussen.Items)
            //{
            //    ListBoxCursussen.SelectedItems.Add(o);
            //}
        }
    }
}
