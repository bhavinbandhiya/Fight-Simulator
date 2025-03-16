using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApi.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(
                new Skill {ID = 1, Name = "Fireball", Damage = 30},
                new Skill {ID = 2, Name = "Blizzard", Damage = 50},
                new Skill {ID = 3, Name = "Earthquake", Damage = 100}
            );
        }

        public DbSet<Character> Characters => Set<Character>();

        public DbSet<User> User => Set<User>();
        
        public DbSet<Weapon> Weapons => Set<Weapon>();

        public DbSet<Skill> Skills => Set<Skill>();

    }
}