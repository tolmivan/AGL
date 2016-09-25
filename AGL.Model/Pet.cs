using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.Model
{
    public class Pet
    {
        public string Name { get; set; }
        public PetType Type { get; set; }
    }

    public enum PetType { Cat, Dog, Fish };

}
