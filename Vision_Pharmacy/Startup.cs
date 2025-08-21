using DevExpress.XtraRichEdit.Import.Html;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision_Pharmacy.Code;
using Vision_Pharmacy.Core;
using Vision_Pharmacy.Data;
using Vision_Pharmacy.Data.EFSqlServer;

namespace Vision_Pharmacy
{
    public class Startup
    {
        //private readonly IServiceCollection services;
        private readonly ServiceCollection services;
        private readonly ServiceProviderOptions serviceProvider;
        private readonly DependencyInjection dependency;
        public Startup()
        {
            serviceProvider = new ServiceProviderOptions();
            services = new ServiceCollection();
            ConfigureServices();
            dependency = new DependencyInjection();
            ConfigDictionary.keyValuePairs.Add("ConString", Properties.Settings.Default.SQLServerConString);
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices()
        {
            services.AddSingleton<IDataHelper<User>, UserEntity>();
            services.BuildServiceProvider(serviceProvider);
        }


    }
}
