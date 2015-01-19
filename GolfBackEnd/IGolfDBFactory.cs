using AbstractCrudRepository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfBackEnd
{
    public interface IGolfDBFactory:IDBFactory<GolfDB>
    {
        GolfDB GetInstace(SqlConnection connection);
    }
}
