using BlazorVetClinicPractise1.DataLayer;

namespace BlazorVetClinicPractise1.UseCases.CreateVeterinarian
{
    public class CreateVeterinarianUseCase : ICreateVeterinarian
    {
        private readonly VetClinicDbContext _context;

        public CreateVeterinarianUseCase(VetClinicDbContext context)
        {
            _context = context;
        }

        public async Task CreateVeterinarian(Veterinarian veterinarian)
        {
            _context.Veterinarians.Add(veterinarian);
            _context.SaveChanges();
        }
    }
}
