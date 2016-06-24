﻿using System;
using Microsoft.AspNetCore.Hosting;
namespace aspnetcoreapp
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()

        .UseStartup<Startup>()
        .UseUrls("http://localhost:5033")
        .Build();

      host.Run();
    }
  }
}
