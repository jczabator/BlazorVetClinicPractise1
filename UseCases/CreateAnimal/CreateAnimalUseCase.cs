using BlazorVetClinicPractise1.DataLayer;

namespace BlazorVetClinicPractise1.UseCases.CreateAnimal
{
    public class CreateAnimalUseCase : ICreateAnimal
    {
        private readonly VetClinicDbContext _context;

        public CreateAnimalUseCase(VetClinicDbContext vetClinicDbContext)
        {
            _context = vetClinicDbContext;
        }

        public async Task CreateAnimal(AnimalPassport passport)
        {
            _context.AnimalPassports.Add(passport);
            _context.SaveChanges();
        }
    }
}
