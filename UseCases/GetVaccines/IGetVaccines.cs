using BlazorVetClinicPractise1.DataLayer;

namespace BlazorVetClinicPractise1.UseCases.GetVaccines
{
    public interface IGetVaccines
    {
        Task<IEnumerable<VaccineRegistry>> GetVaccines();
    }
}
