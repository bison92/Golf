using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfBackEnd.Model
{
    public class CampoDTO
    {
        public long CampoId { get; set; }
        public ICollection<PartidoDTO> Partidos { get; set; }
    }
}
