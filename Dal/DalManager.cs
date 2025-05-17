using Dal.Api;
using Dal.models;
using Microsoft.Extensions.DependencyInjection;

namespace Dal
{
    public class DalMannager : IDal
    {
        public Iclient client { get; }
        public IDoctor doctor { get; }
        public IAppointment appointment { get; }
        public IAddress address { get; }

        public DalMannager()
        {

            ServiceCollection service = new ServiceCollection();
            service.AddSingleton<DatabaseManager>();
            service.AddSingleton<Iclient, Services.ClientService>();
            service.AddSingleton<IDoctor, Services.DoctorService>();
            service.AddSingleton<IAddress, Services.AddressService>();  
            service.AddSingleton<IAppointment, Services.AppointmentService>();
            ServiceProvider serviceProvider = service.BuildServiceProvider();
            client = serviceProvider.GetService<Iclient>();
            doctor = serviceProvider.GetService<IDoctor>();
            appointment = serviceProvider.GetService<IAppointment>();
            address = serviceProvider.GetService<IAddress>();
        }
    }
}
