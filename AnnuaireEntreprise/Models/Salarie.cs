#nullable disable
using AnnuaireEntreprise.Contexts;
using AnnuaireEntreprise.Methods;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AnnuaireEntreprise.Models
{
    public class Salarie : Entity<Salarie>
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nom salarie requis")]
        [MaxLength(50)]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Prenom salarie requis")]
        [MaxLength(50)]
        public string Prenom { get; set; }
        [Required(ErrorMessage = "Telephone fixe salarie requis")]
        [MaxLength(10)]
        public string TelFixe { get; set; }
        [Required(ErrorMessage = "Telephone portable salarie requis")]
        [MaxLength(10)]
        public string TelPortable { get; set; }
        [Required(ErrorMessage = "Email salarie requis")]
        [MaxLength(100)]
        public string Email { get; set; }
        public int ServicesId { get; set; }
        public int SiteId { get; set; }
        public virtual Service Services { get; set; }
        public virtual Site Site { get; set; }
        private DatabaseContext context = new DatabaseContext();

        public bool Create()
        {
            context.Database.EnsureCreated();
            context.Entry(this).State = EntityState.Modified;

            try
            {
                context.Salaries.Add(this);
                var result = context.SaveChanges();
                if (result == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        public bool Delete()
        {
            context.Database.EnsureCreated();
            try
            {
                context.Salaries.Remove(this);
                var result = context.SaveChanges();
                if (result == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Salarie> GetAll()
        {
            context.Database.EnsureCreated();
            try
            {
                IEnumerable<Salarie> Salaries = context.Salaries.Include(o=> o.Services).Include(o=> o.Site).ToList();
                return Salaries;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Salarie GetById(int id)
        {
            context.Database.EnsureCreated();
            try
            {
                var salarie = context.Salaries.Find(id);
                return salarie;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Update()
        {
            context.Database.EnsureCreated();
            try
            {
                context.Entry(this).State = EntityState.Modified;
                context.Salaries.Update(this);
                var result = context.SaveChanges();
                if (result == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch (Exception)
            {
                throw;
            }
        }
    }
}
