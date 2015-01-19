using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfBackEnd.Model
{
    public class ReservaDTO
    {
        public long ReservaId { get; set; }
        public long PartidoId { get; set; }
        public PartidoDTO Partido { get; set; }
    }
}
