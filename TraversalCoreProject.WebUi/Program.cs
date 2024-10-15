using Microsoft.Extensions.Logging;
using Serilog;
using TraversalCoreProject.BusinessLayer.Abstract;
using TraversalCoreProject.BusinessLayer.Concrete;
using TraversalCoreProject.DataAccessLayer.Abstract;
using TraversalCoreProject.DataAccessLayer.Concrete;
using TraversalCoreProject.DataAccessLayer.EntityFramework;
using TraversalCoreProject.EntityLayer.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddDbContext<TraversalContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<TraversalContext>();
builder.Services.AddScoped<IDestinationService, DestinationManager>();
builder.Services.AddScoped<IDestinationDal, EfDestinationDal>();

builder.Services.AddScoped<IFeatureBigImagesDal, EfFeatureBigImagesDal>();
builder.Services.AddScoped<IFeatureBigImagesService, FeatureBigImagesManager>();

builder.Services.AddScoped<IFeatureSmallImagesDal, EfFeatureSmallImagesDal>();
builder.Services.AddScoped<IFeatureSmallImagesService, FeatureSmallImageManager>();

builder.Services.AddScoped<ISubAboutDal, EfSubAboutDal>();
builder.Services.AddScoped<ISubAboutService, SubAboutManager>();

builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialService, TestimonialManager>();

builder.Services.AddScoped<ICommentDal, EfCommentDal>();
builder.Services.AddScoped<ICommentService, CommentManager>();

builder.Services.AddScoped<IReservationDal, EfReservationDal>();
builder.Services.AddScoped<IReservationService, ReservationManager>();

builder.Services.AddScoped<IGuideDal , EfGuideDal>();
builder.Services.AddScoped<IGuideService , GuideManager>();

builder.Services.AddScoped<IAppUserDal, EfAppUserDal>();
builder.Services.AddScoped<IAppUserService, AppUserManager>();

builder.Services.AddScoped<IExcelService , ExcelManager>();
builder.Services.AddScoped<IPdfService, PdfManager>();
builder.Services.AddControllersWithViews();


var logPath = Path.Combine(Directory.GetCurrentDirectory(), "LogFile");
if (!Directory.Exists(logPath))
{
    Directory.CreateDirectory(logPath); // Klasör yoksa oluþtur
}

builder.Services.AddLogging(log =>
{
    log.ClearProviders();
    log.SetMinimumLevel(LogLevel.Debug);   // Minimum log seviyesi Debug
    log.AddDebug();                        // Debug loglarý
    log.AddFile(Path.Combine(logPath, "log.txt"), LogLevel.Information); // Dosyaya Information loglarý
});


var app = builder.Build();

app.UseStatusCodePages(async x =>
{
    if (x.HttpContext.Response.StatusCode == 404)
    {
        x.HttpContext.Response.Redirect("/Error/NotFound404Page");
    }
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();
