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

namespace AnnuaireEntreprise.Models
{
    public class Site : Entity<Site>
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ville site requis")]
        [MaxLength(50)]
        public string Ville { get; set; }
        private DatabaseContext context = new DatabaseContext(); 
        public virtual ICollection<Salarie> Salaries { get; set; }

        public bool Create()
        {
            context.Database.EnsureCreated();
            Site site = new();
            site.Ville = Ville;
            try
            {
                context.Add(site);
                var result = context.SaveChanges();
                if (result != 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }catch (Exception)
            {
                throw;
            }

        }

        public bool Delete()
        {
            context.Database.EnsureCreated();
           if(isSalarieDansVille() == false) { 
            try
                {
                    context.Sites.Remove(this);
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
            else
            {
                Console.WriteLine("Impossible de supprimer : il y a un salarié dans la ville");
                return false;
            }
        }

        public IEnumerable<Site> GetAll()
        {
            context.Database.EnsureCreated();
                try
                {
                IEnumerable<Site> Sites = context.Sites.AsNoTracking().ToList();
                    return Sites;
                }
                catch (Exception) 
                { 
                    throw;
                }
        }

        public Site GetById(int id)
        {
            context.Database.EnsureCreated();
            try
            {
                var site = context.Sites.Find(id);
                return site;
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
                context.Sites.Update(this);
                var result =  context.SaveChanges();
                var returnresult = (result == 1) ? true : false;
                return returnresult;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool isSalarieDansVille()
        {
            var salarie = new Salarie();
            var sl = salarie.GetAll();
            var test = sl.FirstOrDefault(predicate: salarie => salarie.SiteId == this.Id);
            if (test != null){
                return true;
            }
            else
            {
                return false;
            }    
        }
    }
}
