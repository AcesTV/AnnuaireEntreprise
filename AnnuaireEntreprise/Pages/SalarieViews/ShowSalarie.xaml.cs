using AnnuaireEntreprise.Models;
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

namespace AnnuaireEntreprise.Pages.SalarieViews
{
    /// <summary>
    /// Logique d'interaction pour ShowSalarie.xaml
    /// </summary>
    public partial class ShowSalarie : Window
    {
        public ShowSalarie(Salarie salarie)
        {
            InitializeComponent();
            DataContext = salarie;
            Nom.Text += salarie.Nom;
            Prenom.Text += salarie.Prenom;
            TelMobile.Text += salarie.TelPortable;
            TelFixe.Text += salarie.TelFixe;
            Email.Text += salarie.Email;
            Ville.Text += salarie.Site.Ville;
            Service.Text += salarie.Services.Nom;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
