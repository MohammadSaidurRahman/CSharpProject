using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    public static class RepositoryFactory
    { public static TRepository Create<TRepository>(ContextTypes ctype) where TRepository : class 
        { 
            if 
                (typeof(TRepository) == typeof(StudentRepository)) 
            { 
                return new TraineeXMLRepository() as TRepository;
            }
            return null; 
        } 
    }
}
