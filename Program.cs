using BlazorVetClinicPractise1.Components;
using BlazorVetClinicPractise1.DataLayer;
using BlazorVetClinicPractise1.UseCases.CreateAnimal;
using BlazorVetClinicPractise1.UseCases.CreateVaccination;
using BlazorVetClinicPractise1.UseCases.CreateVaccineRegistryEntry;
using BlazorVetClinicPractise1.UseCases.CreateVeterinarian;
using BlazorVetClinicPractise1.UseCases.GetAnimalPassports;
using BlazorVetClinicPractise1.UseCases.GetVaccinationsUseCase;
using BlazorVetClinicPractise1.UseCases.GetVaccines;
using BlazorVetClinicPractise1.UseCases.GetVeterinarians;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddMudServices();
builder.Services.AddDbContext<VetClinicDbContext>();

builder.Services.AddTransient<IGetVaccinations,  GetVaccinationsUseCase>();
builder.Services.AddTransient<IGetAnimalPassport, GetAnimalPassportsUseCase>();
builder.Services.AddTransient<IGetVeterinarians, GetVeterinariansUseCase>();
builder.Services.AddTransient<IGetVaccines, GetVaccinesUseCase>();
builder.Services.AddTransient<ICreateVaccination, CreateVaccinationUseCase>();
builder.Services.AddTransient<ICreateAnimal, CreateAnimalUseCase>();
builder.Services.AddTransient<ICreateVeterinarian, CreateVeterinarianUseCase>();
builder.Services.AddTransient<ICreateVaccineRegistryEntry, CreateVaccineRegistryEntryUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
