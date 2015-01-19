using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfBackEnd.Model
{
    public class Campo
    {
        public long CampoId { get; set; }
        public ICollection<Partido> Partidos { get; set; }
    }
}
