using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorldCup.Models
{
    public class TimeModelContext : DbContext //Usado para criar banco de dados, nao funciona
    {
        public DbSet<Time> Times { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=Times.db");

        //List<Times> GetAllTimes(){
         //   return 
        //};
    }
    public class Time //Modelo de Time 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TimeId { get; set; }
        public string Nome { get; set; }
        public int Forca { get; set; }
    }
    
}