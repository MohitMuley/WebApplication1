using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]

        public List<Student> GetStudents() 
        {
            return new List<Student>{
                new Student
                {
                    id = 1,
                    name = "mohit",
                    email = "xyz@gmail.com",
                    address = "pune maharashtra"

                },
                new Student
                {
                    id = 2,
                    name = "xyz",
                    email = "mm@gmail.com",
                    address = "maharashtra"
                }

            }; 
            
        }
    }
}
