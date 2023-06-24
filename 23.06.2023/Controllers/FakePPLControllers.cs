using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _23._06._2023.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class FakePPLControllers : ControllerBase
    {
        private readonly ILogger<FakePPLControllers> _logger;

        public FakePPLControllers(ILogger<FakePPLControllers> logger)
        {
            _logger = logger;
        }

        private static readonly string[] Names = new string[]
        {
            "David","Davud","Alex","Ivan","Maxim"
        };
        private static readonly string[] Surnames = new string[] {
            "Gagnidze", "Azimov", "Negoden","Goden"
        };

        Random Random = new Random();


        //[HttpPost]
        //public IActionResult GetPersoneParams([FromBody] int png = 1, string? name = null, string? surname = null, int? age = null)
        //{
        //    Person person = new Person();

        //    person.Name = name;
        //    person.Surname = surname;
        //    person.Age = age;

        //    if (name == null)
        //    {
        //        person.Name = Names[Random.Next(Names.Length)];
        //    }
        //    if (surname == null)
        //    {
        //        person.Surname = Surnames[Random.Next(Surnames.Length)];
        //    }
        //    if (age == null)
        //    {
        //        person.Age = Random.Next(90);
        //    }
        //    return Ok(person);
        //}

        [HttpGet]
        public IActionResult GetPersone()
        {
            Person person = new Person();
                person.Name = Names[Random.Next(Names.Length)];
                person.Surname = Surnames[Random.Next(Surnames.Length)];
                person.Age = Random.Next(90);
            
            return Ok(person);
        }


        [HttpPost]
        public IActionResult GetPersoneParams([FromBody] Person pers)
        {
            Person person = new Person();

            person.Name = pers.Name;
            person.Surname = pers.Surname;
            person.Age = pers.Age;

            if (person.Name == null)
            {
                person.Name = Names[Random.Next(Names.Length)];
            }
            if (person.Surname == null)
            {
                person.Surname = Surnames[Random.Next(Surnames.Length)];
            }
            if (person.Age == null)
            {
                person.Age = Random.Next(90);
            }
            return Ok(person);
        }
    }
}
