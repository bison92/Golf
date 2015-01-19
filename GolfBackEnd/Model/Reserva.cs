using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfBackEnd.Model
{
    public class Reserva
    {
        public long ReservaId { get; set; }
        public long PartidoId { get; set; }
        public Partido Partido { get; set; }

    }
}
