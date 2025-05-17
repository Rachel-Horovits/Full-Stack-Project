using Dal.Api;
using Dal;
using Microsoft.Extensions.DependencyInjection;
using BL.Api;

namespace BL
{
    public class BlManager: IBLManager
    {
        public IBLClient BLClient { get; }
        public IBLDoctor BLDoctor { get; }
        public IBLAppointment BLAppointment { get; }
        public IBLAddress BLAddress { get; }
        public BlManager()
        {
            
            ServiceCollection services = new ServiceCollection();

            services.AddSingleton<IDal, DalMannager>();
            services.AddSingleton<IBLClient, Service.BLClientService>();
            services.AddSingleton<IBLDoctor, Service.BLDoctorService>();
            services.AddSingleton<IBLAppointment, Service.BLAppointmentService>();
            services.AddSingleton<IBLAddress, Service.BLAddressServiece>();
            ServiceProvider serviceProvider = services.BuildServiceProvider();

            BLClient = serviceProvider.GetService<IBLClient>();
            BLDoctor = serviceProvider.GetService<IBLDoctor>();
            BLAppointment = serviceProvider.GetService<IBLAppointment>();
            BLAddress = serviceProvider.GetService<IBLAddress>();
        }
    }
}
