using System.Web.UI;
using ExampleAngularJs.Models.Courses;
using ExampleAngularJs.Models.Students;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ExampleAngularJs.Models.Registrations
{
    public class RegistrationFactory
    {
        public Registration BuildRegistration()
        {
            var registration = new Registration
            {
                Courses = GetSerializedCourses(),
                Students = GetSerializedStudents(),
            };
            return registration;
        }

        public string GetSerializedCourses()
        {
            var courses = new[]
            {
                new Course {Code = "1A", Name = "Ensinando .Net", Instructor = "Geeglo"},
                new Course {Code = "2B", Name = "Ensinando Azure", Instructor = "Amozan"},
                new Course {Code = "3C", Name = "Ensinando Angular", Instructor = "Mocrisoft"},
            };

            JsonSerializerSettings settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };

            return JsonConvert.SerializeObject(courses, Formatting.None, settings);
        }

        public string GetSerializedStudents()
        {
            var students = new[]
            {
                new Student {Code = "1", Name = "Algum Nome", Email = "algumnome@email.com"},
                new Student {Code = "2", Name = "Outro Nome", Email = "outronome@email.com"},
                new Student {Code = "3", Name = "Mais Um Nome", Email = "maisumnome@email.com"},
            };

            JsonSerializerSettings settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };

            return JsonConvert.SerializeObject(students, Formatting.None, settings);
        }
    }
}