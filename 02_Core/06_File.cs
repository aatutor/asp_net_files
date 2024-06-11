// https://metanit.com/sharp/aspnet6/2.6.php

var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.Run(async (context) => await context.Response.SendFileAsync("img.jpg"));

app.Run();

/// Copy to Output Directory: Copy if newer | Copy always