using AutoMapperApi.Repository;
using AutoMapperApi.Services;
using AutoMapperApi.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentService _studentService;

        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_studentService.GetAllStudents());
        }

        [HttpPost]
        public IActionResult Create(CreateOrUpdateStudentVm vm)
        {
            return Ok(_studentService.CreateStudent(vm));
        }
    }
}
