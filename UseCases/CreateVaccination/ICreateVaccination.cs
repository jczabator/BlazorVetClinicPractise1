using BlazorVetClinicPractise1.DataLayer;

namespace BlazorVetClinicPractise1.UseCases.CreateVaccination
{
    public interface ICreateVaccination
    {
        Task CreateVaccination(Vaccination vaccination);
    }
}
