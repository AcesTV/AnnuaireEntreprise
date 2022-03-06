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

namespace AnnuaireEntreprise.Pages.SiteViews
{
    /// <summary>
    /// Logique d'interaction pour EditSite.xaml
    /// </summary>
    public partial class EditSite : Window
    {
        public EditSite(Site site)
        {
            InitializeComponent();
            VilleInput.Text = site.Ville;
            IdHidden.Text = site.Id.ToString();
            IdHidden.Visibility = Visibility.Hidden;
        }

        private void Button_Valider(object sender, RoutedEventArgs e)
        {
            Site site = new();
            site.Ville = VilleInput.Text;
            site.Id = int.Parse(IdHidden.Text);
            try
            {
                var result = site.Update();
                if (result == true)
                {
                    var win = new AdminPanel();
                    Close();
                    win.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Cancel(object sender, RoutedEventArgs e)
        {
            var win = new AdminPanel();
            Close();
            win.Show();
        }
    }
}
