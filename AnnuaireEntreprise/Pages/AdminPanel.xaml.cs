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

namespace AnnuaireEntreprise.Pages
{
    /// <summary>
    /// Logique d'interaction pour AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public AdminPanel()
        {
            InitializeComponent();
            Site site = new();
            Service services = new();
            Salarie salaries = new();
            sitesList.DataContext = site;
            sitesList.ItemsSource = site.GetAll();
            servicesList.DataContext = services;
            servicesList.ItemsSource = services.GetAll();
            salarieList.DataContext = salaries;
            salarieList.ItemsSource = salaries.GetAll();

        }

        private void Btn_new_site(object sender, RoutedEventArgs e)
        {
            var win = new SiteViews.AddSite();
            Close();
            win.Show(); 
        }

        private void Btn_edit_site(object sender, RoutedEventArgs e)
        {
            Site site = (Site)sitesList.SelectedItem;

            if(site != null)
            {
                var win = new SiteViews.EditSite(site);
                this.Close();
                win.Show();
            } else
            {
                MessageBox.Show("Veuillez selectionner une ville");
            }
            
        }

        private void Btn_del_site(object sender, RoutedEventArgs e)
        {
            Site site = (Site)sitesList.SelectedItem;

            if(site != null)
            {
                try
                {
                  var result = site.Delete();
                    if(result == true)
                    {
                        var win = new AdminPanel();
                        this.Close();
                        win.Show();
                    }
                    else
                    {

                        MessageBox.Show("Vous devez d'abord supprimer les salariés dans cette ville");
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                MessageBox.Show("Veuillez selectionner une ville");
            }
            
        }

        private void Btn_new_service(object sender, RoutedEventArgs e)
        {
            var win = new ServiceViews.AddService();
            Close();
            win.Show();

        }

        private void Btn_edit_service(object sender, RoutedEventArgs e)
        {
            Service service = (Service)servicesList.SelectedItem;

            if(service != null)
            {
                var win = new ServiceViews.EditService(service);
                Close();
                win.Show();
            } else
            {
                MessageBox.Show("Veuillez selectionner un service");
            }
            

        }

        private void Btn_del_service(object sender, RoutedEventArgs e)
        {
            Service service = (Service)servicesList.SelectedItem;

            if(service != null)
            {
                try
                {
                    var result = service.Delete();
                    if(result == true)
                    {
                        var win = new AdminPanel();
                        this.Close();
                        win.Show();

                    }
                    else
                    {

                        MessageBox.Show("Vous devez d'abord supprimer les salariés dans ce service");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                MessageBox.Show("Veuillez selectionner un service");
            }

            
        }

        private void Btn_new_salarie(object sender, RoutedEventArgs e)
        {
            var win = new SalarieViews.AddSalarie();
            Close();
            win.Show();
        }

        private void Btn_edit_salarie(object sender, RoutedEventArgs e)
        {
            Salarie salarie = (Salarie)salarieList.SelectedItem;

            if(salarie != null)
            {
                var win = new SalarieViews.EditSalarie(salarie);
                Close();
                win.Show();
            } else
            {
                MessageBox.Show("Veuillez selectionner un salarié");
            }
            
        }

        private void Btn_del_salarie(object sender, RoutedEventArgs e)
        {
            Salarie salarie = (Salarie)salarieList.SelectedItem;

            if(salarie != null)
            {
                try
                {
                    var result = salarie.Delete();
                    if (result == true)
                    {
                        var win = new AdminPanel();
                        this.Close();
                        win.Show();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                MessageBox.Show("Veuillez selectionner un salarié");
            }
            
        }
        private void Row_DoubleClick(object sender, RoutedEventArgs e)
        {
            Salarie salarie = (Salarie)salarieList.SelectedItem;
            var win = new SalarieViews.ShowSalarie(salarie);
            win.ShowDialog();
        }

      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var win = new MainWindow();
            Close();
            win.Show();
        }
    }
}
