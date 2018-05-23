using System;
using Microsoft.AspNetCore.Mvc;
using yearn.modules.rules;

namespace app.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        [Route("api/student")]    
        public IActionResult GetStudents()
        {
            var st = new StudentFacade();
            return Ok(st.get_student(1));
        }

        
    }
}