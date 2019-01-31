using System;
using CapEnum.Entities.Enum;

namespace CapEnum.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderEnum Status { get; set; }

        
        public override string ToString()
        {
            return $"Id: {Id}, Momento: {Moment}, Status: {Status}";
        }
    }
    
}
