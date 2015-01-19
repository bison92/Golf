using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AbstractCrudRepository;

namespace GolfBackEnd
{
    public class GolfDBFactory: IGolfDBFactory
    {

        public GolfDB GetInstace()
        {
            return new GolfDB(GolfDB.connection);
        }

        public GolfDB GetInstace(SqlConnection connection)
        {
            throw new NotImplementedException();
        }
    }
}
