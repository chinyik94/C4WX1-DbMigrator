using C4WX1_DbMigrator.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Npgsql;

Console.WriteLine("C4WX1 DB Schema Migrator App!");
var targetConnectionString = string.Empty;

while (true)
{
    Console.WriteLine("Enter a valid Postgresql Connection String to start migration: ");
    targetConnectionString = Console.ReadLine();
    if (IsValidConnectionString(targetConnectionString))
    {
        break;
    }
}

var builder = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddDbContext<THCC_C4WDEVContext>(options =>
            options.UseNpgsql(targetConnectionString, o => o.UseNodaTime()));
    });

var host = builder.Build();

using (var scope = host.Services.CreateScope())
{
    var target = scope.ServiceProvider.GetRequiredService<THCC_C4WDEVContext>();
    var transaction = await target.Database.BeginTransactionAsync();
    Console.WriteLine("Applying migrations...");
    try
    {
        var connected = await target.Database.CanConnectAsync();
        if (!connected)
        {
            Console.WriteLine("Unable to connect to target database.");
            return;
        }

        await target.Database.MigrateAsync();

        await transaction.CommitAsync();
        Console.WriteLine("Database migration completed.");
    }
    catch (Exception ex)
    {
        await transaction.RollbackAsync();
        Console.WriteLine($"An error occurred: {ex}");
    }
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();

static bool IsValidConnectionString(string? connectionString)
{
    try
    {
        if (string.IsNullOrWhiteSpace(connectionString))
        {
            return false;
        }

        NpgsqlConnectionStringBuilder connStringBuilder = new(connectionString);
        return true;
    }
    catch (Exception)
    {
        return false;
    }
}