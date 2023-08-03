using JaxWorld.Data.Seeders;
using JaxWorld.Web.Extensions;
using JaxWorld.Web.Extensions.Authentication;
using JaxWorld.Web.Middleware;


var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddDatabase(builder.Configuration);
builder.Services.AddSwagger();
builder.Services.AddServices();
builder.Services.AddIdentityCore();
builder.Services.BuildIdentityServer();
builder.Services.AddAuthenticationConfig();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

DatabaseSeeder.SeedAsync(app.Services).GetAwaiter().GetResult();
app.UseIdentityServer();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ErrorHandler>();
app.UseHttpsRedirection();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseAuthorization();

app.MapControllers();

app.Run();
