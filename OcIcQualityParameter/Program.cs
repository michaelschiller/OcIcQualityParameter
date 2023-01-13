var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOrchardCms();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseOrchardCore();

app.Run();
