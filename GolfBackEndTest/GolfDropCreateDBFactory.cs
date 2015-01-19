using AbstractCrudRepository;
using GolfBackEnd;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfBackEndTest
{
    public class GolfDropCreateDBFactory : IGolfDBFactory
    {
        public GolfDB GetInstace(SqlConnection connection)
        {
            return new GolfDropCreateDB(connection);
        }

        public GolfDB GetInstace()
        {
            return new GolfDB(false);
        }
    }
}
