using ClassLibrary.Models;
using System.Text.Json;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// SERVICES
builder.Services.AddRazorPages();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession(); // Add session service
//builder.Services.AddSingleton<Administration>();// add singleton
builder.Services.AddDistributedMemoryCache();

//builder.Services.AddSession(options =>
//{
//    options.IdleTimeout = TimeSpan.FromMinutes(30);
//    options.Cookie.HttpOnly = true;
//    options.Cookie.IsEssential = true;
//});
// SERVICES

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
//app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();


//var administration = app.Services.GetRequiredService<Administration>();

//var session = app.Services.GetRequiredService<IHttpContextAccessor>().HttpContext.Session;

//if (administration != null)
//{
//    session.Set("Administration", Encoding.UTF8.GetBytes(JsonSerializer.Serialize(administration)));
//}
app.Run();
