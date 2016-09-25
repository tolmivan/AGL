using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.Model
{
    public class Person
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }

        public List<Pet> Pets { get; set; }

    }

    public enum Gender {  Male, Female };
}
