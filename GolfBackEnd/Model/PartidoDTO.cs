using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfBackEnd.Model
{
    public class PartidoDTO
    {
        public long PartidoId { get; set; }
        public long CampoId { get; set; }
        public CampoDTO Campo { get; set; }
    }
}
