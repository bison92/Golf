using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GolfBackEnd.Model;
using AbstractCrudRepository;
namespace GolfBackEnd.Repository
{
    public class ReservaRepository : AbstractRepository<long,Reserva, ReservaDTO, GolfDB>, IReservaRepository
    {
        public ReservaRepository(IGolfDBFactory dBFactory, IConversor<Reserva, ReservaDTO> conversor)
            : base(dBFactory, conversor)
        {

        }
        public override ReservaDTO Update(ReservaDTO dto)
        {
            return base.Update(dto, e => e.ReservaId == dto.ReservaId);
        }
    }
}
