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
    public class Service : Entity<Service>
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nom service requis")]
        [MaxLength(50)]
        public string Nom { get; set; }
        public virtual ICollection<Salarie> Salaries { get; set; }
        private DatabaseContext context = new DatabaseContext();

        public bool Create()
        {
            context.Database.EnsureCreated();
            Service service = new Service();
            service.Nom = Nom;
            try
            {
                context.Services.Add(service);
                var result = context.SaveChanges();

                if (result != 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
       
        public bool Delete()
        {
            context.Database.EnsureCreated();
            if (isSalarieDansService() == false)
            {

                try
                {
                    context.Services.Remove(this);
                    var result = context.SaveChanges();
                    if (result == 1)
                    {
                        return true;
                    }
                    else { return false; }

                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                Console.WriteLine("Impossible de supprimer : il y a un salarié dans le service");
                return false;
            }
        }

        public IEnumerable<Service> GetAll()
        {
            context.Database.EnsureCreated();
            try
            {
                IEnumerable<Service> Services = context.Services.AsNoTracking().ToList();

                return Services;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Service GetById(int id)
        {
            context.Database.EnsureCreated();
            try
            {
               var service =  context.Services.Find(id);
               return service;
              
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
                 context.Services.Update(this);
                var result = context.SaveChanges();
                var returnresult =   (result == 1) ?  true :  false;
                return returnresult;
            }catch (Exception)
            {
                throw;
            }
        }
        public bool isSalarieDansService()
        {
            var salarie = new Salarie();
            var sl = salarie.GetAll();
            var test = sl.FirstOrDefault(predicate: salarie => salarie.ServicesId == this.Id);
            if (test != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
