using System.Text;
using Crucero.Application.Profiles;
using Crucero.Application.Services.Implementations;
using Crucero.Application.Services.Interfaces;
using Crucero.Infraestructure.Repository.Implementations;
using Crucero.Infraestructure.Data;
using Crucero.Infraestructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Serilog.Events;
using Serilog;
using Crucero.Web.Middleware;
using Crucero.Infraestructure.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configurar D.I.
//Repository
builder.Services.AddTransient<IRepositoryHabitacion, RepositoryHabitacion>();
builder.Services.AddTransient<IRepositoryAplicadoPor, RepositoryAplicadoPor>();
builder.Services.AddTransient<IRepositoryBarco, RepositoryBarco>();
builder.Services.AddTransient<IRepositoryBarco_Habitacion, RepositoryBarco_Habitacion>();
builder.Services.AddTransient<IRepositoryComplemento, RepositoryComplemento>();
builder.Services.AddTransient<IRepositoryCrucero, RepositoryCrucero>();
builder.Services.AddTransient<IRepositoryDestino, RepositoryDestino>();
builder.Services.AddTransient<IRepositoryEstadoReserva, RepositoryEstadoReserva>();
builder.Services.AddTransient<IRepositoryFechasCrucero, RepositoryFechasCrucero>();
builder.Services.AddTransient<IRepositoryItinerario, RepositoryItinerario>();
builder.Services.AddTransient<IRepositoryMetodoPago, RepositoryMetodoPago>();
builder.Services.AddTransient<IRepositoryNotificacion, RepositoryNotificacion>();
builder.Services.AddTransient<IRepositoryOcupantes, RepositoryOcupantes>();
builder.Services.AddTransient<IRepositoryPago, RepositoryPago>();
builder.Services.AddTransient<IRepositoryPrecio_Habitacion, RepositoryPrecio_Habitacion>();
builder.Services.AddTransient<IRepositoryPuerto, RepositoryPuerto>();
builder.Services.AddTransient<IRepositoryReserva, RepositoryReserva>();
builder.Services.AddTransient<IRepositoryReserva_Complemento, RepositoryReserva_Complemento>();
builder.Services.AddTransient<IRepositoryReserva_Detalle, RepositoryReserva_Detalle>();
builder.Services.AddTransient<IRepositoryRol, RepositoryRol>();
builder.Services.AddTransient<IRepositoryUsuario, RepositoryUsuario>();
//Services
builder.Services.AddTransient<IServiceHabitacion, ServiceHabitacion>();
builder.Services.AddTransient<IServiceAplicadoPor, ServiceAplicadoPor>();
builder.Services.AddTransient<IServiceBarco, ServiceBarco>();
builder.Services.AddTransient<IServiceBarco_Habitacion, ServiceBarco_Habitacion>();
builder.Services.AddTransient<IServiceComplemento, ServiceComplemento>();
builder.Services.AddTransient<IServiceCrucero, ServiceCrucero>();
builder.Services.AddTransient<IServiceDestino, ServiceDestino>();
builder.Services.AddTransient<IServiceEstadoReserva, ServiceEstadoReserva>();
builder.Services.AddTransient<IServiceFechasCrucero, ServiceFechasCrucero>();
builder.Services.AddTransient<IServiceItinerario, ServiceItinerario>();
builder.Services.AddTransient<IServiceMetodoPago, ServiceMetodoPago>();
builder.Services.AddTransient<IServiceNotificacion, ServiceNotificacion>();
builder.Services.AddTransient<IServiceOcupantes, ServiceOcupantes>();
builder.Services.AddTransient<IServicePago, ServicePago>();
builder.Services.AddTransient<IServicePrecio_Habitacion, ServicePrecio_Habitacion>();
builder.Services.AddTransient<IServicePuerto, ServicePuerto>();
builder.Services.AddTransient<IServiceReserva, ServiceReserva>();
builder.Services.AddTransient<IServiceReserva_Complemento, ServiceReserva_Complemento>();
builder.Services.AddTransient<IServiceReserva_Detalle, ServiceReserva_Detalle>();
builder.Services.AddTransient<IServiceRol, ServiceRol>();
builder.Services.AddTransient<IServiceUsuario, ServiceUsuario>();
//Configurar Automapper
builder.Services.AddAutoMapper(config =>
{
config.AddProfile<HabitacionProfile>();
    config.AddProfile<HabitacionProfile>();
    config.AddProfile<AplicadoPorProfile>();
    config.AddProfile<Barco_HabitacionProfile>();
    config.AddProfile<BarcoProfile>();
    config.AddProfile<ComplementoProfile>();
    config.AddProfile<CruceroProfile>();
    config.AddProfile<DestinoProfile>();
    config.AddProfile<EstadoReservaProfile>();
    config.AddProfile<FechaCruceroProfile>();
    config.AddProfile<ItinerarioProfile>();
    config.AddProfile<MetodoPagoProfile>();
    config.AddProfile<NotificacionProfile>();
    config.AddProfile<OcupantesProfile>();
    config.AddProfile<PagoProfile>();
    config.AddProfile<Precio_HabitacionesProfile>();
    config.AddProfile<PuertoProfile>();
    config.AddProfile<Reserva_complementoProfile>();
    config.AddProfile<Reserva_DetalleProfile>();
    config.AddProfile<ReservaProfile>();
    config.AddProfile<RolProfile>();
    config.AddProfile<UsuarioProfile>();
});
// Configuar Conexión a la Base de Datos SQL
builder.Services.AddDbContext<WaddelsContext>(options =>
{
    // it read appsettings.json file
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerDataBase"));
    if (builder.Environment.IsDevelopment())
        options.EnableSensitiveDataLogging();
});

//Configuración Serilog
// Logger. P.E. Verbose = muestra SQl Statement
var logger = new LoggerConfiguration()
// Limitar la información de depuración
.MinimumLevel.Override("Microsoft", LogEventLevel.Error)
.Enrich.FromLogContext()
.WriteTo.Console(LogEventLevel.Information)
.WriteTo.Logger(l => l.Filter.ByIncludingOnly(e => e.Level ==
LogEventLevel.Information).WriteTo.File(@"Logs\Info-.log", shared: true, encoding:
Encoding.ASCII, rollingInterval: RollingInterval.Day))
 .WriteTo.Logger(l => l.Filter.ByIncludingOnly(e => e.Level ==
LogEventLevel.Debug).WriteTo.File(@"Logs\Debug-.log", shared: true, encoding:
System.Text.Encoding.ASCII, rollingInterval: RollingInterval.Day))
 .WriteTo.Logger(l => l.Filter.ByIncludingOnly(e => e.Level ==
LogEventLevel.Warning).WriteTo.File(@"Logs\Warning-.log", shared: true, encoding:
System.Text.Encoding.ASCII, rollingInterval: RollingInterval.Day))
 .WriteTo.Logger(l => l.Filter.ByIncludingOnly(e => e.Level ==
LogEventLevel.Error).WriteTo.File(@"Logs\Error-.log", shared: true, encoding: Encoding.ASCII,
rollingInterval: RollingInterval.Day))
 .WriteTo.Logger(l => l.Filter.ByIncludingOnly(e => e.Level ==
LogEventLevel.Fatal).WriteTo.File(@"Logs\Fatal-.log", shared: true, encoding: Encoding.ASCII,
rollingInterval: RollingInterval.Day))
 .CreateLogger();
builder.Host.UseSerilog(logger);
//***************************

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    // Error control Middleware
    app.UseMiddleware<ErrorHandlingMiddleware>();
}

app.UseSerilogRequestLogging();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseAntiforgery();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
