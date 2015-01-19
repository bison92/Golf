using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GolfBackEnd.Model;

namespace GolfBackEnd
{
    public class GolfDB: DbContext
    {
        public GolfDB(SqlConnection connection)
            : base(connection, false)
        {

        }
        public GolfDB(bool res)
            :base("GolfDB")
        {

        }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Partido> Partidos { get; set; }
        public DbSet<Campo> Campos { get; set; }
    

    [ThreadStatic]
    public static SqlConnection connection = null;
    }
}
