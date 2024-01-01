using BlazorVetClinicPractise1.DataLayer;

namespace BlazorVetClinicPractise1.UseCases.CreateVaccineRegistryEntry
{
    public interface ICreateVaccineRegistryEntry
    {
        Task CreateVaccineRegistryEntry(VaccineRegistry vaccineRegistry);
    }
}
