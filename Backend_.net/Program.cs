
using Microsoft.EntityFrameworkCore;
using Vehicle_Configurator.DbRepos;
using Vehicle_Configurator.Repository;
using Microsoft.EntityFrameworkCore;


namespace Vehicle_Configurator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);


            builder.Services.AddScoped<IMfgRepository, MfgRepository>();
            builder.Services.AddScoped<ISegmentRepository, SegmentRepository>();
            builder.Services.AddScoped<IModelRepository, ModelRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            builder.Services.AddScoped<IAlternatecomponentmasterRepository, AlternatecomponentRepository>();
            builder.Services.AddScoped<IVehicleDetailRepository, VehicleDetailRepository>();
            builder.Services.AddDbContext<ScottDbContext>(options =>
            options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("MyAllowSpecificOrigins",
                                  builder =>
                                  {
                                      builder.WithOrigins("*").AllowAnyHeader().AllowAnyMethod();
                                  });
            });

            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseCors("MyAllowSpecificOrigins");

            app.MapControllers();

            var url = builder.Configuration["Kestrel:Endpoints:Http:Url"];
            app.Run(url);
        }
    }
}