using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public record Player
    {
        public Guid Id { get; init; }
        //public String? Name { get; set; } // String? = can be null
        public String Name { get; init; }
        public decimal Balance { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}