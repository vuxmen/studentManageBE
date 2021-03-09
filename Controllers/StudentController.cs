using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace student_manager_api.Controllers
{
    public record RequestResult<T>(T? Data, string Message = "", bool isSuccess = true);

    public record RequestResult<T, MetaType>(T? Data, MetaType Meta, string Message = "", bool isSuccess = true);

    public record PagedMeta(int TotalItem);

    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentController : ControllerBase
    {
        private static List<Student> students = new(MockData.GenerateData());

        public record AddStudentVM(DateTime CreatedDate, DateTime AdmissionDate, string Name, Genders Gender, string PhoneNumber, IFormFile? ImageFile, DateTime Birthday);

        private static object lockObj = new();

        [HttpGet]
        public RequestResult<IEnumerable<Student>, PagedMeta> GetStudents(string? search, int page, int pageSize)
        {
            search = string.IsNullOrEmpty(search) ? "" : search;

            var filteredResult = students.Where(s => s.PhoneNumber.Contains(search) || s.Name.Contains(search)).OrderBy(s => s.CreatedDate);

            return new RequestResult<IEnumerable<Student>, PagedMeta>(filteredResult.Skip((page - 1) * pageSize).Take(pageSize), new PagedMeta(filteredResult.Count()));
        }

        [HttpPost]
        public async Task<RequestResult<Student>> AddStudent([FromForm] AddStudentVM viewModel)
        {
            var studentId = Guid.NewGuid().ToString();

            var fileName = studentId;

            if (viewModel.ImageFile != null)
            {
                await saveAvatarAsync(viewModel.ImageFile, studentId);
            }
            else
            {
                fileName = "default.png";
            }

            Student newStudent = new Student(studentId, viewModel.CreatedDate, viewModel.AdmissionDate, viewModel.Name, viewModel.Gender, "", viewModel.PhoneNumber, viewModel.Birthday) with { Id = studentId, Img = fileName, CreatedDate = DateTime.UtcNow };

            // clone and add new
            students = students.Select(t => t).ToList();
            students.Add(newStudent);

            return new RequestResult<Student>(newStudent);
        }

        // [HttpPost]
        // public async Task<RequestResult<Student>> ModifyStudent(StudentVM viewModel)
        // {
        //     if (viewModel.Id == string.Empty)
        //     {
        //         return new RequestResult<Student>(null, "Student Id should not be empty", false);
        //     }

        //     if (viewModel.image != null)
        //     {
        //         var fileName = await saveAvatarAsync(viewModel.image);
        //         viewModel = viewModel with { Img = fileName };
        //     }

        //     students = students.Select(s => s.Id == viewModel.Id ? viewModel : s).ToList();
        //     return new RequestResult<Student>(viewModel, "Update success");
        // }

        async Task saveAvatarAsync(IFormFile file, string studentId)
        {
            var fileExtension = file.FileName.Split(".").Last();
            var fullPath = $"./uploadImg/{studentId}.{fileExtension}";
            System.IO.File.Delete(fullPath);
            using (var fileStream = System.IO.File.Create(fullPath))
            {
                await file.CopyToAsync(fileStream);
            }
        }

    }

}