using AutoMapper;
using AutoMapperApi.Model;
using AutoMapperApi.Repository;
using AutoMapperApi.ViewModel;

namespace AutoMapperApi.Services
{
    public class StudentService
    {
        private readonly StudentRepo _studentRepo;
        private readonly IMapper _mapper;

        public StudentService(StudentRepo studentRepo, IMapper mapper)
        {
            _studentRepo = studentRepo;
            _mapper = mapper;
        }

        public List<StudentVm> GetAllStudents()
        {
            var students = _studentRepo.GetStudents();
            var rs = _mapper.Map<List<StudentVm>>(students);
            return rs;
        }

        public string CreateStudent(CreateOrUpdateStudentVm vm)
        {
            var student = _mapper.Map<Student>(vm);
            _studentRepo.Create(student);
            return "Success";
        }
    }
}
