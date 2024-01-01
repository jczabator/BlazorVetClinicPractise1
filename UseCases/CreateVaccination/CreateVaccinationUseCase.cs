using BlazorVetClinicPractise1.DataLayer;

namespace BlazorVetClinicPractise1.UseCases.CreateVaccination
{
    public class CreateVaccinationUseCase : ICreateVaccination
    {
        private readonly VetClinicDbContext _context;

        public CreateVaccinationUseCase(VetClinicDbContext context)
        {
            _context = context;
        }

        public async Task CreateVaccination(Vaccination vaccination)
        {
            _context.Vaccinations.Add(vaccination);
            _context.SaveChanges();
        }
    }
}
