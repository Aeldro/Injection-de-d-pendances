
using Injection_de_dépendances.Services;

namespace Injection_de_dépendances
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Below, MonthlySalaryCalculator is injected as ISalaryCalculator
            builder.Services.AddScoped<ISalaryCalculator, MonthlySalaryCalculator>();
            builder.Services.AddScoped<ISalaryCalculator, QuarterlySalaryCalculator>();

            var app = builder.Build();
        }
    }
}
