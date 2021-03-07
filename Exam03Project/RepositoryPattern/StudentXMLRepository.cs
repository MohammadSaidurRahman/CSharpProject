using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Repository_Domain;
using _Repository_Domain;
using Repository_Sourc;
using Repository_Sourc;

namespace RepositoryPattern
{
    public class TraineeXMLRepository : XMLRepositoryBase<XMLSet<Trainee>, Trainee, int>,StudentRepository
    {
        public TraineeXMLRepository() : base("StudentInformation.xml")
        {

        }
    }
}
