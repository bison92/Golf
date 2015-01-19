using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GolfBackEnd;
using System.Data.Entity;
namespace GolfBackEndTest
{
    public class GolfDBInitializer: DropCreateDatabaseAlways<GolfDropCreateDB>
    {
        protected override void Seed(GolfDropCreateDB context)
        {
            base.Seed(context);
        }
    }
}
