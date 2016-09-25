using AGL.Dtos;
using AGL.Model;
using AGL.Repository;
using AGL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonRepository repo = new PersonRepository();

            IEnumerable<OwnerGenderCat> cats = dtoOwnerGenderCatService.GetDtoOwnerGenderCats(repo);

            foreach (var gender in repo.GetGenders())
            {
                System.Console.WriteLine(gender.ToString());

                var gendercats = from cat in cats
                           where cat.OwnerGender == gender
                           select cat;

                foreach (var cat in gendercats.OrderBy(x => x.CatName)) 
                {
                    System.Console.WriteLine(string.Format("\t* {0}", cat.CatName));
                }

            }


            System.Console.ReadLine();
        }
    }
}
