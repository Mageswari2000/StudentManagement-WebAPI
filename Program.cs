using Microsoft.EntityFrameworkCore;
using StudentManagement.DAL;
using StudentManagement.Data;
using StudentManagement.IDAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin",
        builder => builder
            .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());
});
builder.Services.AddScoped<IStudentDAL, StudentDAL>();
builder.Services.AddScoped<IDepartmentDAL, DepartmentDAL>();
builder.Services.AddScoped<IPaymentDAL, PaymentDAL>();
builder.Services.AddScoped<IStudent_SubjectDAL, Student_SubjectDAL>();




var app = builder.Build();
app.UseRouting();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseCors("AllowOrigin");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
