using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace aspnetcoreapp
{
  public class Startup
  {
    public void Configure(IApplicationBuilder app)
    {
      app.Run(context =>
      {
        //test
        return context.Response.WriteAsync("Hello from ASP.NET Core eee!");
      });
    }
  }
}
