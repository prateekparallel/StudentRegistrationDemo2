using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using StudentRegistrationDemo2.Models;

namespace StudentRegistrationDemo2.Controllers
{
    public class StudentDeleteController : ApiController
    {
        [Route("student/remove/{regdNum}")]

        public String DeleteStudentRecord(String regdNum)
        {
            Console.WriteLine("In deleteStudentRecord");
            return StudentRegistration.getInstance().Remove(regdNum);
        }
    }
}
