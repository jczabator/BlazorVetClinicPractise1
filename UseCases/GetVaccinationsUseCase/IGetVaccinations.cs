using BlazorVetClinicPractise1.DataLayer;

namespace BlazorVetClinicPractise1.UseCases.GetVaccinationsUseCase
{
    public interface IGetVaccinations
    {
        Task<IEnumerable<Vaccination>> GetVaccinations();
    }
}
