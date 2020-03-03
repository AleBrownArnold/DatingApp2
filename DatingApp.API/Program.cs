using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DatingApp.API
{
    public class Program
    {
        // al ejecutar dotnet run, se ejecuta el metodo Main
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        // al ejecutar el metodo main, se ejecuta el metodo siguiente, el cual configura los defaults del host. Por ejemplo configura los logs que aparecen en la terminal, también lee las configuraciones de los archivos que correspondan (appsettings.json, etc). También llama a la startup.cs 
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
