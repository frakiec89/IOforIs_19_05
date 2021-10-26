using InOutTextFile.BL;
using Microsoft.Win32;
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

namespace MyTEstForm
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "dsdsds";

            if ( openFileDialog.ShowDialog()== true)
            {
               string s =   TextIO.ReadTextInTXT(openFileDialog.FileName);
                tbContent.Text = s;
            }
            else
            {
                MessageBox.Show("вы не  выбрали файл");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Сохрание  файла ";


            if (openFileDialog.ShowDialog() == true)
            {
                string s = TextIO.WriteTextToTXT(openFileDialog.FileName, 
                    tbContent.Text);
                MessageBox.Show(s);
            }
            else
            {
                MessageBox.Show("вы не  выбрали файл");
            }

        }
    }
}
