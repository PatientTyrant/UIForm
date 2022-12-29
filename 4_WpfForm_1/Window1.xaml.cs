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
using System.Windows.Shapes;

namespace _4_WpfForm_1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, RoutedEventArgs e)
        {
            // sender parametresi event'i tetiklenen kontrolü temsil eder...
            Button btn = (Button) sender;

            txtNum.Text = txtNum.Text + btn.Content;

            //MessageBox.Show("Selam");

        }
    }
}
