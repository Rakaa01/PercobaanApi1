using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PercobaanApi1.Models;
using System;

namespace PercobaanApi1.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("api/person/")]
        public ActionResult<Person> ListPerson()
        {
            PersonContext context = new PersonContext();
            List<Person> persons = context.ListPerson();
            return Ok(ListPerson);
        }
        [HttpGet("Api/person/{id_person}")]
        public ActionResult<Person>GetpersonById(int id_person)
        {
            PersonContext context = new PersonContext();
            List<Person> persons = context.ListPerson();
            Person person = persons.Find(p =>p.id_person == id_person);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }
    }
}

