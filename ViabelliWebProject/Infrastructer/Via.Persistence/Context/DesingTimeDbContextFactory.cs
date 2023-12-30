using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Via.Persistence.Context;

public class DesingTimeDbContextFactory : IDesignTimeDbContextFactory<ViaBaseContext>
{
    
    public ViaBaseContext CreateDbContext(string[] args)
    {
        ConfigurationManager configurationManager = new();
                  //"..\\..\\Presentation\\Via.MVC"   --> yazmak yeterlidir .net cl den migration işlemleri yapılcak sa
        configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/Via.WebApi"));

        configurationManager.AddJsonFile("appsettings.json");

        //Gercek sunucu
         var connection = configurationManager.GetConnectionString("postgresql_snucu");  
        
        //Test Sunucusu
        //var connection = configurationManager.GetConnectionString("sunucu_mssql");

        DbContextOptionsBuilder<ViaBaseContext> dbContextOptionsBuilder = new();
        
        //Gercek sunucu 
         dbContextOptionsBuilder.UseNpgsql(connection);
        
        //Test sunucusus
       //dbContextOptionsBuilder.UseSqlServer(connection);
        
        return new(dbContextOptionsBuilder.Options);
    }
}
