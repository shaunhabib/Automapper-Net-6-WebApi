using AutoMapperApi.Enum;

namespace AutoMapperApi.ViewModel
{
    public class StudentVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Roll { get; set; }
        public string Section { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Nationality { get; set; }
        public string xyz { get; set; }
        public VmSelectList Gender { get; set; }
        public GuardianVm Guardian { get; set; }
        public List<AddressVm> Addresses { get; set; }
    }

    public class VmSelectList
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class GuardianVm
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string FPhone { get; set; }
        public string MPhone { get; set; }
    }

    public class AddressVm
    {
        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
    }
}
