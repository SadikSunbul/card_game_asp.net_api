using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Via.Domain.Entities;
using Via.Domain.Entities.CardGame;

namespace Via.Persistence.Context;

public class ViaBaseContext:DbContext
{
    
    public ViaBaseContext(DbContextOptions opt) : base(opt)
    {
      
    }

    #region DbSet<> Properties
    public DbSet<Deneme> Denemes { get; set; }
    public DbSet<Card> Cards { get; set; }
    public DbSet<EquipmentCards> EquipmentCards { get; set; }
    public DbSet<MoneyCards> MoneyCards { get; set; }
    public DbSet<MonsterCards> MonsterCards { get; set; }
    public DbSet<PotionCards> PotionCards { get; set; }
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.Entity<Card>().UseTpcMappingStrategy();
        base.OnModelCreating(modelBuilder);
    }
}
