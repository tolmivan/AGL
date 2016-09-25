using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AGL.Repository;
using System.Collections;
using AGL.Model;
using System.Collections.Generic;

namespace AGL.Test.Repository
{
    [TestClass]
    public class RepositoryUnitTest
    {
        [TestMethod]
        public void TestJsonGetPersonsCountEqualsSix()
        {
            IPersonRepository repo = new PersonRepository();

            List<Person> persons = new List<Person>(repo.GetPersons());

            Assert.AreEqual(6, persons.Count);
        }

        [TestMethod]
        public void TestJsonGetPersonsFirstPersonIsBobIsMale23()
        {
            IPersonRepository repo = new PersonRepository();

            List<Person> persons = new List<Person>(repo.GetPersons());

            Assert.AreEqual("Bob", persons[0].Name);
            Assert.AreEqual(Gender.Male, persons[0].Gender);
            Assert.AreEqual(23, persons[0].Age);

        }
    }
}
