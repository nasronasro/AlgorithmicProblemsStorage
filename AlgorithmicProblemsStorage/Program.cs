using AlgorithmicProblemsStorage.Application.Services;
using AlgorithmicProblemsStorage.Application.Services.Interfaces;
using AlgorithmicProblemsStorage.Infrastructure.Data;
using AlgorithmicProblemsStorage.Infrastructure.Repositories;
using AlgorithmicProblemsStorage.Infrastructure.Repositories.Interfaces;
using AlgorithmicProblemsStorage.Presentation.Forms.AlgorithmForms;
using Microsoft.Extensions.DependencyInjection;

namespace AlgorithmicProblemsStorage
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            //DataLayer Injection
            services.AddScoped<ISqlConnectionFactory, SqlConnectionFactory>();

            //repositories injections
            services.AddScoped<IAlgorithmRepository, AlgorithmRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<IDifficultyRepository, DifficultyRepository>();
            services.AddScoped<IPlatformeRepository, PlatformeRepository>();

            //Services Injections
            services.AddScoped<IAlgorithmServices, AlgorithmServices>();
            services.AddScoped<IDifficultyServices, DifficultyServices>();
            services.AddScoped<IPlatformeServices, PlatformeServices>();

            //forms Injections
            services.AddTransient<MainForm>();
            services.AddTransient<AddAlgorithmForm>();
            using var sp = services.BuildServiceProvider();

            System.Windows.Forms.Application.Run(sp.GetRequiredService<MainForm>());
        }
    }
}