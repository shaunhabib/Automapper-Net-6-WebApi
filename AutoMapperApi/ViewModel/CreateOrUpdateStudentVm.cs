using AutoMapperApi.Enum;

namespace AutoMapperApi.ViewModel
{
    public class CreateOrUpdateStudentVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Roll { get; set; }
        public string Section { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Nationality { get; set; }
        public int Gender { get; set; }
        public CreateOrUpdateGuardianVm Guardian { get; set; }
        public List<AddressVm> Addresses { get; set; }
    }

    public class CreateOrUpdateGuardianVm
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string FPhone { get; set; }
        public string MPhone { get; set; }
    }
}
