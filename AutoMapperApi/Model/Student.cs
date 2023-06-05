using AutoMapperApi.Enum;

namespace AutoMapperApi.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Roll { get; set; }
        public string Section { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Nationality { get; set; }
        public Gender Gender { get; set; }
        public Guardian Guardian { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
