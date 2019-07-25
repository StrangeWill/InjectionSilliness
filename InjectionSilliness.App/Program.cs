namespace InjectionSilliness.App
{
    using System;
    using Microsoft.Extensions.DependencyInjection;

    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddScoped<IThing1, Implementation>()
                .AddScoped<IThing2, Implementation>()
                .AddScoped<InjectedItem>()
                .BuildServiceProvider();
            using (var serviceScope = serviceProvider.CreateScope())
            {
                var injectedItem = serviceScope.ServiceProvider.GetRequiredService<InjectedItem>();
                Console.WriteLine($"Thing1.Thing1(): {injectedItem.IThing1.Thing1()}");
                Console.WriteLine($"Thing2.Thing2(): {injectedItem.IThing2.Thing2()}");
                Console.WriteLine($"Thing1.Shared(): {injectedItem.IThing1.Shared()}");
                Console.WriteLine($"Thing2.Shared(): {injectedItem.IThing2.Shared()}");
            }
        }
    }
}
