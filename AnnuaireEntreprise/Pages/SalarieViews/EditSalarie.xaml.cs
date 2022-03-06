using AnnuaireEntreprise.Models;
using System;
using System.Windows;

namespace AnnuaireEntreprise.Pages.SalarieViews
{
    /// <summary>
    /// Logique d'interaction pour EditSalarie.xaml
    /// </summary>
    public partial class EditSalarie : Window
    {
        public EditSalarie(Salarie salarie)
        {
            InitializeComponent();
            Site site = new();
            Service service = new();
            siteChoice.DataContext = site;
            siteChoice.ItemsSource = site.GetAll();
            serviceChoice.DataContext = service;
            serviceChoice.ItemsSource = service.GetAll();
            Inom.Text = salarie.Nom;
            Iprenom.Text = salarie.Prenom;
            ItelFixe.Text = salarie.TelFixe.ToString();
            ItelPort.Text = salarie.TelPortable.ToString();
            Iemail.Text = salarie.Email;
            siteChoice.SelectedValue = salarie.Site.Id;
            serviceChoice.SelectedValue = salarie.Services.Id;
            idHidden.Text = salarie.Id.ToString();
            idHidden.Visibility = Visibility.Hidden;
            salarie.Id = -1;
        }

        private void btn_Valider_Click(object sender, RoutedEventArgs e)
        {
            Salarie salarie = new();

            salarie.Id = int.Parse(idHidden.Text);
            salarie.Nom = Inom.Text;
            salarie.Prenom = Iprenom.Text;
            salarie.Email = Iemail.Text;
            salarie.TelPortable = ItelPort.Text;
            salarie.TelFixe = ItelFixe.Text;
            salarie.Services = (Service)serviceChoice.SelectedItem;
            salarie.Site = (Site)siteChoice.SelectedItem;
            salarie.ServicesId = salarie.Services.Id;
            salarie.SiteId = salarie.Site.Id;
            try
            {
                var result = salarie.Update();
                if(result == true)
                {
                    var win = new AdminPanel();
                    Close();
                    win.Show();
                }
            }catch (Exception ex)
            {
                throw;    
            }
        }

        private void btn_Annuler_Click(object sender, RoutedEventArgs e)
        {
            var win = new AdminPanel();
            Close();
            win.Show();
        }
    }
}
