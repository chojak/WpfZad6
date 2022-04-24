using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfZad6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Collection<Person> People = new ObservableCollection<Person>();
        public Collection<string> Cities = new Collection<string>();
        
        public MainWindow()
        {
            InitializeComponent();

            Cities.Add("Białystok");
            Cities.Add("Warszawa");
            Cities.Add("Gdańsk");
            Cities.Add("Łódź");
            Cities.Add("Wrocław");

            People.Add(new Person { Name = "Andrzej", Surname = "Andrzejowski", Email = "Andrzej@and.pl", Payment = 20.37M, City = "Białystok", AccessLevel = 1, Details = true });
            People.Add(new Person { Name = "Bartek", Surname = "Bartkowski", Email = "Bartek@brt.pl", Payment = 19.37M, City = "Warszawa", AccessLevel = 2, Details = true });
            People.Add(new Person { Name = "Cezary", Surname = "Cezarowy", Email = "Cezary@cez.pl", Payment = 218.37M, City = "Gdańsk", AccessLevel = 3, Details = true });
            People.Add(new Person { Name = "Dominik", Surname = "Dominikowski", Email = "Dominik@dom.pl", Payment = 18.37M, City = "Łódź", AccessLevel = 4, Details = true });
            People.Add(new Person { Name = "Eryk", Surname = "Erykowski", Email = "Eryk@erk.pl", Payment = 200.37M, City = "Wrocław", AccessLevel = 5, Details = true });

            ComboBox.ItemsSource = Cities;
            Listbox.ItemsSource = People;
        }

        private void GroupBoxCheck_Changed(object sender, RoutedEventArgs e)
        {
            DetailsGrid.IsEnabled = (bool)GroupBoxCheck.IsChecked;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (Listbox.SelectedIndex >= 0)
                People.RemoveAt(Listbox.SelectedIndex);

            System.Diagnostics.Debug.WriteLine(Listbox.SelectedIndex);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            People.Add(new Person());
            Listbox.SelectedIndex = People.Count - 1;
            NameTextBox.Text = "Imię";
            NameTextBox.SelectAll();
            NameTextBox.Focus();
        }
    }
}
