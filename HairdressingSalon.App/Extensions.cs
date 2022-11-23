using HairdressingSalon.BLL.Interfaces;
using HairdressingSalon.DAL.Autocomplete;
using HairdressingSalon.DAL.Interfaces;
using HairdressingSalon.DAL.Models;

namespace HairdressingSalon.App
{
    public static class Extensions
    {
        public static void FillTables(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                IRepositoryManager repositoryManager = context.RequestServices.GetService<IRepositoryManager>();
                IEnumerable<ServiceKind> serviceKinds = await repositoryManager.ServiceKindsRepository.Get(20, "ServiceKinds20");

                
                if (serviceKinds.Count() == 0)
                {
                    DbAutocompleter.GenerateRandomValues();

                    repositoryManager.ServiceKindsRepository.Create(DbAutocompleter.ServiceKinds);
                    repositoryManager.ClientsRepository.Create(DbAutocompleter.Clients);
                    repositoryManager.WorkersRepository.Create(DbAutocompleter.Workers);
                    repositoryManager.ServicesRepository.Create(DbAutocompleter.Services);
                    repositoryManager.OrdersRepository.Create(DbAutocompleter.Orders);
                    repositoryManager.FeedbacksRepository.Create(DbAutocompleter.Feedbacks);

                    await context.Response.WriteAsync("Mission complete!");
                }
                else
                {
                    await context.Response.WriteAsync("Data is already exists");
                }
            });
        }
    }
}
