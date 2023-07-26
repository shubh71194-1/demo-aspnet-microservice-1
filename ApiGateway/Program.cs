using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace ApiGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Configuration.AddJsonFile("ocelot.json", optional:false, reloadOnChange:true);
            builder.Services.AddOcelot(builder.Configuration);

            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");
            app.MapControllers();
            app.UseOcelot();

            app.Run();
        }
    }
}