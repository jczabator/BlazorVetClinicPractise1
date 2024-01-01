namespace BlazorVetClinicPractise1.DataLayer
{
    public class Vaccination
    {
        public int Id { get; set; }
        public int AnimalPassportId { get; set; }
        public int VeterinarianId { get; set; }
        public int VaccineRegistryEntryId { get; set; }
        public DateTime VaccinationDate { get; set; }
        public AnimalPassport AnimalPassport { get; set; }
        public VaccineRegistry VaccineRegistryEntry { get; set; }
        public Veterinarian Veterinarian { get; set; }
    }
}
