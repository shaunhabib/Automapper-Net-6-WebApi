using AutoMapperApi.Model;

namespace AutoMapperApi.Repository
{
    public class StudentRepo
    {
        public List<Student> GetStudents() => students;
        public Student GetById(int id) => students.Find(x => x.Id == id);
        public void Create(Student student) => students.Add(student);
        public void Update(Student student)
        {
            var exSt = students.Find(x => x.Id == student.Id);
            students.Remove(exSt);
            students.Add(exSt);
        }

        public void Delete(int id) => students.Remove(students.Find(x => x.Id == id));



        private List<Student> students = new List<Student>
        {
            new Student
            {
                Id = 1,
                Name = "shaun",
                Roll = 1,
                Section = "A",
                PhoneNumber = "0153658789",
                Email = "shaun@gmail.com",
                Nationality = "Bangladeshi",
                Gender = Enum.Gender.Male,
                Guardian = new Guardian
                {
                    Id = 1,
                    FName = "Habib",
                    MName = "Habiba",
                    FPhone = "0125689745",
                    MPhone = "254625454"
                },
                Addresses = new List<Address>
                {
                    new Address{ Id = 1, AddressLine1 = "Kaitakhali", AddressLine2 = "Nabiganj"},
                    new Address{ Id = 1, AddressLine1 = "Bandar", AddressLine2 = "Nabiganj"}
                }
            },
            new Student
            {
                Id = 2,
                Name = "shauni",
                Roll = 2,
                Section = "A",
                PhoneNumber = "0153658789",
                Email = "shauni@gmail.com",
                Nationality = "Bangladeshi",
                Gender = Enum.Gender.Male,
                Guardian = new Guardian
                {
                    Id = 2,
                    FName = "Habibi",
                    MName = "Habibia",
                    FPhone = "0125689745",
                    MPhone = "254625454"
                }
            },
            new Student
            {
                Id = 3,
                Name = "sohana",
                Roll = 5,
                Section = "B",
                PhoneNumber = "0153658789",
                Email = "sohana@gmail.com",
                Nationality = "Bangladeshi",
                Gender = Enum.Gender.Female,
                Guardian = new Guardian
                {
                    Id = 3,
                    FName = "Habib kahn",
                    MName = "Habiba akther",
                    FPhone = "0125689745",
                    MPhone = "254625454"
                },
                Addresses = new List<Address>
                {
                    new Address{ Id = 1, AddressLine1 = "Kaitakhali", AddressLine2 = "Nabiganj"}
                }
            },
            new Student
            {
                Id = 4,
                Name = "Arman",
                Roll = 10,
                Section = "C",
                PhoneNumber = "0153658789",
                Email = "Arman@gmail.com",
                Nationality = "Bangladeshi",
                Gender = Enum.Gender.Male,
                Guardian = new Guardian
                {
                    Id = 4,
                    FName = "Rahim",
                    MName = "Rahima",
                    FPhone = "0125689745",
                    MPhone = "254625454"
                },
                Addresses = new List<Address>
                {
                    new Address{ Id = 1, AddressLine1 = "Kaitakhali", AddressLine2 = "Nabiganj"},
                    new Address{ Id = 1, AddressLine1 = "Bandar", AddressLine2 = "Nabiganj"},
                    new Address{ Id = 1, AddressLine1 = "Narayanganj", AddressLine2 = "Dhaka"}
                }
            }
        };
    }
}
