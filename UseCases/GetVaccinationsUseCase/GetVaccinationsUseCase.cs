using BlazorVetClinicPractise1.DataLayer;
using Microsoft.EntityFrameworkCore;

namespace BlazorVetClinicPractise1.UseCases.GetVaccinationsUseCase
{
    public class GetVaccinationsUseCase : IGetVaccinations
    {
        private readonly VetClinicDbContext _context;

        public GetVaccinationsUseCase(VetClinicDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Vaccination>> GetVaccinations()
        {
            return await _context.Vaccinations
                .AsNoTracking()
                .Include(v => v.AnimalPassport)
                .Include(v => v.Veterinarian)
                .Include(v => v.VaccineRegistryEntry)
                .ToListAsync();
        }
    }
}
