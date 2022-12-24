using MainApp.Areas.Identity;
using MainApp.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionStringName = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionStringName, ServerVersion.AutoDetect(connectionStringName)));

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();



using (var scope = app.Services.CreateScope())
{
    var dbContext =scope.ServiceProvider.GetService<ApplicationDbContext>();
    var usermanager=scope.ServiceProvider.GetService<UserManager<IdentityUser>>();
    if (!dbContext.Roles.Any())
    {
        dbContext.Roles.Add(new IdentityRole("Admin") { NormalizedName="ADMIN" });
        dbContext.Roles.Add(new IdentityRole("Petugas") { NormalizedName = "PETUGAS" });
        dbContext.Roles.Add(new IdentityRole("Client") { NormalizedName = "CLIENT"});
        dbContext.SaveChanges();

        //var user = new IdentityUser() { Email = "", UserName = "", };
        //var resutl = usermanager.CreateAsync(user,"1234").Result;
        //if (resutl.Succeeded)
        //{
        //    usermanager.AddToRoleAsync(user, "Petugas");
        //   //Create Petugas

        //    //user.Id
        //}

    }

    if(!dbContext.Users.Any())
    {
        var user = new IdentityUser { Email = "admin@gmail.com", UserName = "admin@gmail.com", EmailConfirmed = true };
        var createResult = await usermanager.CreateAsync(user, "@Admin123");

        if(createResult.Succeeded)
        {
           await usermanager.AddToRoleAsync(user, "Admin");
        }
    }

}



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
