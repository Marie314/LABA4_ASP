using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairdressingSalon.DAL.DTO
{
    public class OrderCreated
    {
        public DateTime DateTime { get; set; }
        public int ClientId { get; set; }
        public int WorkerId { get; set; }
    }
}
