using AGL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.Repository
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPersons();
        IEnumerable<Gender> GetGenders();

    }
}
