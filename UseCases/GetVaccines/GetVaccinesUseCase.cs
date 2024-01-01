using BlazorVetClinicPractise1.DataLayer;
using Microsoft.EntityFrameworkCore;

namespace BlazorVetClinicPractise1.UseCases.GetVaccines
{
    public class GetVaccinesUseCase : IGetVaccines
    {
        private readonly VetClinicDbContext _context;

        public GetVaccinesUseCase(VetClinicDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<VaccineRegistry>> GetVaccines()
        {
            return await _context.VaccineRegistryEntries.AsNoTracking().ToListAsync();
        }
    }
}
