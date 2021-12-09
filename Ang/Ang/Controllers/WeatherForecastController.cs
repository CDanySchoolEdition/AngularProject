using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ang.Repository.Models;
using Ang.Repository;

namespace Ang.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly OopProjectDbContext _oopProjectDbContext;

        public WeatherForecastController(OopProjectDbContext oopProjectDbContext)
        {
            _oopProjectDbContext = oopProjectDbContext;
        }

        [Route("/writeStudent")]
        [HttpPost]
        public bool WriteStudent(Student student)
        {
            _oopProjectDbContext.Students.Add(student);
            _oopProjectDbContext.SaveChanges();
            return true;
        }

        [Route("/getStudents")]
        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            return _oopProjectDbContext.Students.ToArray();
        }
    }
}
