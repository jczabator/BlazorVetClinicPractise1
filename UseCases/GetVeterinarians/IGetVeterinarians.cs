using BlazorVetClinicPractise1.DataLayer;

namespace BlazorVetClinicPractise1.UseCases.GetVeterinarians
{
    public interface IGetVeterinarians
    {
        Task<IEnumerable<Veterinarian>> GetVeterinarians();
    }
}
