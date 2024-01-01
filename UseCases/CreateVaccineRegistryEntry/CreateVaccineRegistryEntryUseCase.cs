using BlazorVetClinicPractise1.DataLayer;

namespace BlazorVetClinicPractise1.UseCases.CreateVaccineRegistryEntry
{
    public class CreateVaccineRegistryEntryUseCase : ICreateVaccineRegistryEntry
    {
        private readonly VetClinicDbContext _context;

        public CreateVaccineRegistryEntryUseCase(VetClinicDbContext context)
        {
            _context = context;
        }

        public async Task CreateVaccineRegistryEntry(VaccineRegistry vaccineRegistry)
        {
            _context.VaccineRegistryEntries.Add(vaccineRegistry);
            _context.SaveChanges();
        }
    }
}
