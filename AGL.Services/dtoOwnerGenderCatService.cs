using AGL.Dtos;
using AGL.Model;
using AGL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.Services
{
    public static class dtoOwnerGenderCatService
    {
        public static IEnumerable<OwnerGenderCat> GetDtoOwnerGenderCats(IPersonRepository repo)
        {
            IEnumerable<Person> people = repo.GetPersons();


            var qry = from p in people
                      where p.Pets != null
                      from c in p.Pets
                      where c.Type == PetType.Cat
                      select new OwnerGenderCat { OwnerGender = p.Gender, CatName = c.Name };

            return qry.ToList();

        }
    }
}
