using BlazorVetClinicPractise1.DataLayer;
using Microsoft.EntityFrameworkCore;

namespace BlazorVetClinicPractise1.UseCases.GetAnimalPassports
{
    public class GetAnimalPassportsUseCase : IGetAnimalPassport
    {
        private readonly VetClinicDbContext _context;

        public GetAnimalPassportsUseCase(VetClinicDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AnimalPassport>> GetAnimalPassports()
        {
            return await _context.AnimalPassports.ToListAsync();
        }
    }
}
