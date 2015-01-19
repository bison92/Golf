using AbstractCrudRepository;
using GolfBackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GolfBackEnd
{
    public class ReservaConversor:IConversor<Reserva,ReservaDTO>
    {
        public Reserva DTO2Entity(ReservaDTO dto)
        {
            Reserva entity = new Reserva
            {
                ReservaId = dto.ReservaId,
                PartidoId = dto.PartidoId,
            };
            //@TODO: Implement Paritdo Object translation
            return entity;
        }

        public ReservaDTO Entity2DTO(Reserva entity)
        {
            ReservaDTO dto = new ReservaDTO
            {
                ReservaId = entity.ReservaId,
                PartidoId = entity.PartidoId,
            };
            //@TODO: Implement Paritdo Object translation
            return dto;
        }
    }
}
