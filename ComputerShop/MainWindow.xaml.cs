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

namespace ComputerShop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
  
        }
        Videocards card = new Videocards("RTX 2080 Super", 28000, 212459128, "NVidia");
        Videocards card2 = new Videocards("RTX 3080 Super", 38000, 211159128, "NVidia");
        Processors proc = new Processors("i5-8300h", 10000, 1231424, "8th");
        private void ProceedButton_Click(object sender, RoutedEventArgs e)
        {
            User user = new User(NameTextBox.Text, (Convert.ToInt32(MoneyTextBox.Text)));
            user.Cart.Add(card2);
            MessageBox.Show(user.Cart.Products[0].ToString());
        }
    }
}
