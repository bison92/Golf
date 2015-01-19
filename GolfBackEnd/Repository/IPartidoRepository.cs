using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GolfBackEnd.Model;
using AbstractCrudRepository;

namespace GolfBackEnd.Repository
{
    public interface IPartidoRepository : ICrud<long, PartidoDTO>
    {
    }
}
