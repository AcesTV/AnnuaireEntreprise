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

namespace AnnuaireEntreprise.Pages
{
    public partial class AdminCheck : Window
    {
        private string password = "admin";
        public static RoutedCommand enter = new();

        public AdminCheck()
        {
            InitializeComponent();
            enter.InputGestures.Add(new KeyGesture(Key.Enter));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(passwordAdmin.Password == password)
            {
                var win = new AdminPanel();
                Close();
                win.Show();
            }
            else
            {
                passwordAdmin.Clear();
                MessageBox.Show("Le mot de passe saisi est incorrect");

            }
        }
        private void Button_Cancel(object sender, RoutedEventArgs e)
        {
            var win = new MainWindow();
            Close();
            win.Show();
        }
    }
}
