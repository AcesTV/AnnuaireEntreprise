using AnnuaireEntreprise.Models;
using AnnuaireEntreprise.Pages;
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

namespace AnnuaireEntreprise
{
    public partial class MainWindow : Window
    {
        public static RoutedCommand cmd = new();
        public MainWindow()
        {
            InitializeComponent();
            var _service = new Service();
            var _site = new Site();
            serviceChoix.DataContext = _service;
            serviceChoix.ItemsSource = _service.GetAll();
            villeChoix.DataContext = _site;
            villeChoix.ItemsSource = _site.GetAll();
            cmd.InputGestures.Add(new KeyGesture(Key.F1, ModifierKeys.Shift));
            Salarie salarie = new();
            salariesList.DataContext = salarie;
            salariesList.ItemsSource = salarie.GetAll();
        }
        
        private void AdminPanel(object sender, ExecutedRoutedEventArgs e)
        {
            var win = new AdminCheck();

            Close();
            win.ShowDialog();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            var returnList = new List<Salarie>();
            var service = serviceChoix.SelectedItem as Service;
            var ville = villeChoix.SelectedItem as Site;
            var salarie = new Salarie();
            var list = salarie.GetAll();
            foreach (var item in list)
            {
                if(service != null && ville != null)
                {
                    if (item.ServicesId == service.Id && item.SiteId == ville.Id)
                    {
                        if ((item.Nom).ToUpper().Contains((searchInput.Text).ToUpper()) || (item.Prenom).ToUpper().Contains((searchInput.Text).ToUpper()))
                        {
                            returnList.Add(item);
                        }
                    } 
                } else
                {
                    if(service != null)
                    {
                        if (item.ServicesId == service.Id && ville == null)
                        {
                            if ((item.Nom).ToUpper().Contains((searchInput.Text).ToUpper()) || (item.Prenom).ToUpper().Contains((searchInput.Text).ToUpper()))
                            {
                                returnList.Add(item);
                            }
                        }
                    } else if(ville != null)
                    {
                        if (item.SiteId == ville.Id && service == null)
                        {
                            if ((item.Nom).ToUpper().Contains((searchInput.Text).ToUpper()) || (item.Prenom).ToUpper().Contains((searchInput.Text).ToUpper()))
                            {
                                returnList.Add(item);
                            }
                        }
                    } else if ((item.Nom).ToUpper().Contains((searchInput.Text).ToUpper()) || (item.Prenom).ToUpper().Contains((searchInput.Text).ToUpper()))
                    {
                        returnList.Add(item);
                    }
                }
                
            }
            salariesList.DataContext = salarie;
            salariesList.ItemsSource = returnList;
        }
        private void Row_DoubleClick(object sender, RoutedEventArgs e)
        {
            Salarie salarie = (Salarie)salariesList.SelectedItem;
            var win = new Pages.SalarieViews.ShowSalarie(salarie);
            win.ShowDialog();
        }

        private void Button_Click_Reset(object sender, RoutedEventArgs e)
        {
            serviceChoix.SelectedValue = 0;
            villeChoix.SelectedValue = 0;
            searchInput.Text = "";
        }
    }


}
