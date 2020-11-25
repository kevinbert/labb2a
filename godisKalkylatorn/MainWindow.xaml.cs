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

namespace godisKalkylatorn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> people;

        public MainWindow()
        {
            InitializeComponent();
            SetList();
            people = new List<Person>();
        }

        private void SetList()
        {
            
            TestData testData = new TestData();
            lstBoxPeople.ItemsSource = testData.People;
            

        }
        private void SendToCalculator()
        {
            

        }

        public void btnAdd_Click(object sender, RoutedEventArgs e)
        {


            Person person = new Person();
            person.Firstname = txtBoxFirstName.Text;
            person.LastName = txtBoxLastName.Text;
            person.Age = 8;


            
            people.Add(person);
            lstBoxPeople.ItemsSource = null;
            lstBoxPeople.ItemsSource = people;


        }
    }
}
