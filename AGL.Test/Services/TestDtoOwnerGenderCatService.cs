using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AGL.Repository;
using AGL.Model;
using System.Collections.Generic;
using System.Linq;
using AGL.Services;
using AGL.Dtos;

namespace AGL.Test.Services
{
    [TestClass]
    public class TestDtoOwnerGenderCatService
    {
        [TestMethod]
        public void TestMockDataTwoCatsUnderMale()
        {
            IPersonRepository repo = new MockRepo();

            IEnumerable<OwnerGenderCat> dto = dtoOwnerGenderCatService.GetDtoOwnerGenderCats(repo);

            var qry = from dt in dto
                      where dt.OwnerGender == Gender.Male
                      select dt;

            Assert.AreEqual(2, qry.ToList().Count);
            Assert.AreEqual("Cat2", qry.ToList()[1].CatName);
            
        }

    }

    class MockRepo : IPersonRepository
    {

        public IEnumerable<Person> GetPersons()
        {
            Person p1 = new Person { Name = "Person1", Age = 10, Gender = Gender.Male, Pets = new List<Pet> { new Pet { Name = "Cat1", Type = PetType.Cat } } };
            Person p2 = new Person { Name = "Person2", Age = 11, Gender = Gender.Female, Pets = new List<Pet> { new Pet { Name = "Dog1", Type = PetType.Dog } } };
            Person p3 = new Person { Name = "Person3", Age = 12, Gender = Gender.Male, Pets = new List<Pet> { new Pet { Name = "Cat2", Type = PetType.Cat } } };

            List<Person> people = new List<Person> { p1, p2, p3 };
            return people;
        }

        public IEnumerable<Gender> GetGenders()
        {
            return new List<Gender> { Gender.Male, Gender.Female };
        }
    }

}
