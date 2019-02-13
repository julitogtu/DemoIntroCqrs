using Microsoft.AspNetCore.Builder;

namespace DemoIntroCqrs.Support
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder ConfigureSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Demo CQRS V1");
            });

            return app;
        }
    }
}