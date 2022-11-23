using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairdressingSalon.DAL.DTO
{
    public class ServiceCreated
    {
        public int Code { get; set; }
        public decimal Price { get; set; }
        public int ServiceKindId { get; set; }
        public int OrderId { get; set; }
    }
}
