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

namespace labb2a
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Ravenclaw ravenclaw = new Ravenclaw();
            Gryffindor gryffindor = new Gryffindor();
            Hufflepuff hufflepuff = new Hufflepuff();
            Slytherin slytherin = new Slytherin();
            MessageBox.Show(slytherin.Password);
            slytherin.SetPassword("bbbbbbbb");
            MessageBox.Show(slytherin.Password);

            MessageBox.Show(hufflepuff.Password); // kollar lösenordet
            hufflepuff.SetPassword("ennn ensam trollkarl");
            MessageBox.Show(hufflepuff.Password);// kollar så det har ändrats
            MessageBox.Show(hufflepuff.HasCorrectPasswordFormat("en ensam trollkarl").ToString());
            Wizard wizard = new Wizard();
            MessageBox.Show(gryffindor.Members[0].ToString());
            

        }
    }
}
