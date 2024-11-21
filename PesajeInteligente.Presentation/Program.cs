using Microsoft.Extensions.DependencyInjection;
using PesajeInteligente.Application.Interfaces;
using PesajeInteligente.Application.Services;
using PesajeInteligente.Infrastructure.Interfaces;
using PesajeInteligente.Infrastructure.Repositories;

namespace PesajeInteligentes
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceProvider = new ServiceCollection()
               .AddSingleton<ICompanyRepository, CompanyRepository>() 
               .AddSingleton<ICompanyService, CompanyService>()       
               .BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(new FormCompanyList());
        }
    }
}