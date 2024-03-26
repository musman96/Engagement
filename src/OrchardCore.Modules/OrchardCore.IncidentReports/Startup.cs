using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;

namespace OrchardCore.IncidentReports
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
           // services.add
        }

        public override void Configure(IApplicationBuilder builder, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
        {
            routes.MapAreaControllerRoute(
                name: "IncidentReports",
                areaName: "OrchardCore.IncidentReports",
                pattern: "IncidentReport/Index",
                defaults: new { controller = "IncidentReport", action = "Index" }
            );
        }
    }
}
