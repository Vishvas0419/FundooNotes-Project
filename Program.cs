using BusinessLayer.Interfaces;
using BusinessLayer.Service;
using RepositoryLayer.Service;
using RepositoryLayer.Interfaces;

namespace Fundoo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            // Dependency Injection
            builder.Services.AddScoped<IUserBL, UserBL>();
            builder.Services.AddScoped<IUserRL, UserRL>();

            var app = builder.Build();

            // Configure HTTP request pipeline
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}