using BlazorVetClinicPractise1.DataLayer;

namespace BlazorVetClinicPractise1.UseCases.CreateAnimal
{
    public interface ICreateAnimal
    {
        Task CreateAnimal(AnimalPassport passport);
    }
}
