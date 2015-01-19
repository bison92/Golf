using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GolfBackEnd;

namespace GolfBackEndTest
{
    public class GolfDropCreateDB : GolfDB
    {
        public GolfDropCreateDB(SqlConnection connection)
            : base(connection)
        {

        }
        public GolfDropCreateDB(bool res)
            : base(res)
        {
            Database.SetInitializer<GolfDropCreateDB>(new GolfDBInitializer());
        }
    }
}
