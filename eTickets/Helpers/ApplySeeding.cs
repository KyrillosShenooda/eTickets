using eTickets.DAL.Context;
using eTickets.DAL.SeedData;

namespace eTickets.Pl.Helpers
{
    public class ApplySeeding
    {
        public static async Task ApplySeedingAsync(WebApplication app)
        {
            using(var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var loggerFactory = services.GetRequiredService<ILoggerFactory>();

                try
                {
                    var context = services.GetRequiredService<eTicketsDbContext>();
                    await SeedStoreData.SeedAsync(context, loggerFactory);
                }
                catch(Exception ex)
                {
                    var logger = loggerFactory.CreateLogger<eTicketsDbContext>();
                    logger.LogError(ex.Message);
                }
            }
        }
    }
}
