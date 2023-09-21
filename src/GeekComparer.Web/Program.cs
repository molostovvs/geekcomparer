using GeekComparer.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddHealthChecks();

builder.Services.AddDbContext<ApplicationDbContext>(
    opt => opt.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        //enabled due to low performance while loading smartphones
        //https://learn.microsoft.com/en-us/ef/core/querying/single-split-queries
        o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)
    )
);

/*
// configuration for https
// https://learn.microsoft.com/en-us/aspnet/core/security/enforcing-ssl?view=aspnetcore-7.0&tabs=visual-studio%2Clinux-ubuntu#options
if (!builder.Environment.IsDevelopment())
{
    builder.Services.AddHttpsRedirection(
        opt =>
        {
            opt.RedirectStatusCode = (int)HttpStatusCode.PermanentRedirect;
            opt.HttpsPort = 443;
        }
    );

    builder.Services.AddHsts(
        opt =>
        {
            opt.Preload = true;
            opt.IncludeSubDomains = true;
            opt.MaxAge = TimeSpan.FromMinutes(1);
        }
    );
}*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsProduction())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

// app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/"
);
app.MapHealthChecks("/healthz");

if (!app.Environment.IsProduction())
{
    using var context = app.Services.CreateScope()
       .ServiceProvider.GetRequiredService<ApplicationDbContext>();

    if (!context.Database.CanConnect())
    {
        context.Database.Migrate();
        context.Seed();
        context.SaveChanges();
    }
}

app.Run();