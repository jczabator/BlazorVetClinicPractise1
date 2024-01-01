using BlazorVetClinicPractise1.DataLayer;

namespace BlazorVetClinicPractise1.UseCases.CreateVeterinarian
{
    public interface ICreateVeterinarian
    {
        Task CreateVeterinarian(Veterinarian veterinarian);
    }
}
