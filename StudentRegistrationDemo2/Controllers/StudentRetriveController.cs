using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using StudentRegistrationDemo2.Models;

namespace StudentRegistrationDemo2.Controllers
{
    //GET api/studentretrive
    public class StudentRetriveController : ApiController
    {
        public List<Student> GetAllStudents()
        {
            return StudentRegistration.getInstance().getAllStudent();
        }
    }
}
