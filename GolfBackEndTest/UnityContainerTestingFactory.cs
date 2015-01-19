using AbstractCrudRepository;
using GolfBackEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfBackEndTest
{
    public class UnityContainerTestingFactory : UnityContainerFactory
    {
        public override IGolfDBFactory CreateDBFactory()
        {
            return new GolfDropCreateDBFactory();
        }
    }
}
