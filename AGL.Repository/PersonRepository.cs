using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGL.Model;
using AGL.Repository.Json;


namespace AGL.Repository
{
    public class PersonRepository : IPersonRepository
    {

        public IEnumerable<Person> GetPersons()
        {
            return JsonConsumer.GetPeopleFromJson();
        }

        public IEnumerable<Gender> GetGenders()
        {
            return new List<Gender> { Gender.Male, Gender.Female };
        }
    }
}
