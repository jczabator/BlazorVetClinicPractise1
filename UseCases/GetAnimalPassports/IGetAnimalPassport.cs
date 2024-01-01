using BlazorVetClinicPractise1.DataLayer;

namespace BlazorVetClinicPractise1.UseCases.GetAnimalPassports
{
    public interface IGetAnimalPassport
    {
        Task<IEnumerable<AnimalPassport>> GetAnimalPassports();
    }
}
