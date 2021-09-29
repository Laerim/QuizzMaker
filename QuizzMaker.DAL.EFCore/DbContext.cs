using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizzMaker.BO;
using System.Configuration;

namespace QuizzMaker.DAL.EFCore
{
    public class QuizzContext : DbContext
    {
        public DbSet<Questionnaire> Questionnaires {get;set;}
        public DbSet<Question> Questions { get; set; }
        public DbSet<Reponse> Reponses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source="+ConfigurationManager.AppSettings.Get("BDD"));

       
        
        
    }
    
   
}
