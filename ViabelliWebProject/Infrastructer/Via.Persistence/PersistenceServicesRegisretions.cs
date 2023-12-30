using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Via.Application.Services.Repositories;
using Via.Application.Services.Repositories.Cards;
using Via.Domain.Entities.CardGame;
using Via.Persistence.Context;
using Via.Persistence.Repositories;
using Via.Persistence.Repositories.Cards;

namespace Via.Persistence;

public static class PersistenceServicesRegisretions
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        //Veritabanı bağlantıları

        //services.AddDbContext<ViaBaseContext>(cof => cof.UseInMemoryDatabase("ViaInmemoryDatabase"));

        //Buradaki pool u kullanımının mantıklı ve performans yaratması ıcın sanıyee 2_000 ila 5_000 arasında istek alıyor olması gerek . Buradakı pool yapısı max 1024 adet context nesensı uretılemsıne ızın verır.
        // services.AddDbContextPool<ViaBaseContext>(cof => cof.UseSqlServer(configuration.GetConnectionString("mssqlSadıkDocker_Win")));
        
        //Postgre ıcın olan gercek sunucumuz
        services.AddDbContext<ViaBaseContext>(cof => cof.UseNpgsql(configuration.GetConnectionString("postgresql_snucu")));

        //Test sunucucusu
      //  services.AddDbContext<ViaBaseContext>(cof => cof.UseSqlServer(configuration.GetConnectionString("sunucu_mssql"))); 


        //RepositroyIoc Kaydı
        services.AddScoped<IDenemeRepository, DenemeRepositroy>();
        services.AddScoped<ICardRepository,CardRepository>();
        services.AddScoped<IEquipmentCardsRepository,EquipmentCardsRepository>();
        services.AddScoped<IMoneyCardsRepository,MoneyCardsRepository>();
        services.AddScoped<IMonsterCardsRepository,MonsterCardsRepository>();
        services.AddScoped<IPotionCardsRepository,PotionCardsRepository>();
        


        return services;
    }
}
