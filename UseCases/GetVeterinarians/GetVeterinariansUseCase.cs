using BlazorVetClinicPractise1.DataLayer;
using Microsoft.EntityFrameworkCore;

namespace BlazorVetClinicPractise1.UseCases.GetVeterinarians
{
    public class GetVeterinariansUseCase : IGetVeterinarians
    {
        private readonly VetClinicDbContext _context;

        public GetVeterinariansUseCase(VetClinicDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Veterinarian>> GetVeterinarians()
        {
            return await _context.Veterinarians.AsNoTracking().ToListAsync();
        }
    }
}
