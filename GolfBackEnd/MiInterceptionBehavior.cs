using Microsoft.Practices.Unity.InterceptionExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Transactions;
using AbstractCrudRepository;

namespace GolfBackEnd
{
    public class MiInterceptionBehavior : IInterceptionBehavior
    {
        public MiInterceptionBehavior()
        {
        }

        public virtual IMethodReturn Invoke(IMethodInvocation input,
          GetNextInterceptionBehaviorDelegate getNext)
        {
            IMethodReturn result;
            if (GolfDB.connection == null)
            {
                using (var txScope = new TransactionScope())
                {
                    using (SqlConnection sqlConnection
                        = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GolfDB"].ToString()))
                    {
                        sqlConnection.Open();
                        GolfDB.connection = sqlConnection;
                        result = getNext()(input, getNext);

                        if (result.Exception == null)
                        {
                            txScope.Complete();
                        }
                        else
                        {
                            txScope.Dispose();
                        }
                    }
                }
                GolfDB.connection = null;
            }
            else
            {
                result = getNext()(input, getNext);
            }
            return result;
        }

        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return Type.EmptyTypes;
        }

        public bool WillExecute
        {
            get { return true; }
        }
    }
}
